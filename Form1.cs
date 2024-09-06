using RestSharp;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace Tool_check_status_uid
{
    public partial class Form1 : Form
    {
        static string currentDate = null;
        private string folderPath = "";
        static string strRandom = "";
        public Form1()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            // Tạo tên tệp dựa trên ngày hiện tại cho UID Live và UID Die
            string folderName = $"{currentDate}";
            folderPath = Path.Combine(Application.StartupPath, folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        // Bước 1: nhập file vào 1 mảng
        string[] arrUid;

        private void btnOpenFileUid_Click(object sender, EventArgs e)
        {
            // Xóa tất cả dữ liệu cũ đã sử dụng lần chạy trước
            lstUidDies.Clear();
            lstUidLives.Clear();
            countUidLive = 0;
            countUidDie = 0;
            lbQuantityUid.Text = "0";
            Random random = new Random();
            currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            strRandom = random.Next(100, 1000).ToString();
            // Khởi tạo đối tượng OpenFileDialog
            OpenFileDialog openFile = new OpenFileDialog();
            // Chọn tệp với định dạng file txt hoặc tất cả định dạng
            openFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.Title = "Mở tệp chứa danh sách uid";

            // Nếu hộp thoại được mở
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // lấy đường dẫn tới file
                string filePath = openFile.FileName;
                try
                {
                    // đọc tất cả các dòng
                    arrUid = File.ReadAllLines(filePath);
                    if (arrUid == null || arrUid.Length == 0)
                    {
                        MessageBox.Show("Vui lòng thêm file uid để chạy dứng dụng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // lọc bỏ các dòng không có dữ liệu
                        arrUid = arrUid.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

                        arrUid = arrUid.Distinct().ToArray();

                        for (int i = 0; i < arrUid.Count(); i++)
                        {
                            Mutil_UID.Enqueue(arrUid[i]);
                        }

                        arrUid = new string[] { };
                        MessageBox.Show("Thêm file thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sảy ra lỗi khi đọc têp:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            lbQuantityUid.Text = Mutil_UID.Count().ToString();

        }

        // Bước 2: thao tác trên cài đặt
        // Tạo ConcurrentBag để lưu trữ Uid đã xử lý
        Queue<string> Mutil_UID = new Queue<string>();
        //Tạo một danh sách để chứa uid live
        private ConcurrentBag<string> lstUidLives = new ConcurrentBag<string>();
        private ConcurrentBag<string> lstUidDies = new ConcurrentBag<string>();

        // Tạo biến đếm số lượng uid live
        private int countUidLive = 0;
        // Tạo biến đếm số lượng uid die
        private int countUidDie = 0;
        // Tạo biên bool để stop
        private bool isStop = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            isStop = false;
            btnStop.Enabled = true;
            int maxThread = Convert.ToInt32(nudThreading.Value);
            new Task(() =>
            {
                CheckUid(maxThread);
            }).Start();

            btnStart.Enabled = false;

        }

        private void CheckUid(int maxThread)
        {
            for (int i = 0; i < maxThread; i++)
            {
                Thread thread = new Thread(() =>
                {

                    MutilCheck(strRandom);

                });
                thread.IsBackground = true;
                thread.Start();

            }

            while (true)
            {
                if (Mutil_UID.Count() == 0)
                {
                    MessageBox.Show("Kiểm tra thành công! chờ lưu file!");
                    Invoke(new Action(() =>
                    {
                        btnStart.Enabled = true;
                        btnStop.Enabled = false;
                    }));
                    break;
                }
            }


        }

        private void MutilCheck(string strRandom)
        {
            while (Mutil_UID.Count > 0)
            {
                string uid = Mutil_UID.Dequeue();
                if (isStop)
                {
                    return;
                }
                try
                {

                    Api_Check(uid, strRandom);

                    // cho phép cập nhật mà không cần chờ đợi luồng
                    Invoke(new Action(() =>
                    {
                        lbQuantityUidLive.Text = countUidLive.ToString();
                        lbQuantityUidDie.Text = countUidDie.ToString();
                        lbCountUidRemain.Text = Mutil_UID.Count().ToString();
                    }));
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
            if (Mutil_UID.Count() == 0)
            {
                return;
            }

        }

        private void Api_Check(string uid, string strRandom)
        {

            var options = new RestClientOptions("https://graph2.facebook.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest($"/v3.3/{uid}/picture?redirect=0", Method.Get);
            RestResponse response = client.Execute(request);

            string html = response.Content;
            string error = "";

            try
            {
                if (!String.IsNullOrEmpty(html))
                {
                    if (html.Contains("height") && html.Contains("width"))
                    {
                        SaveUid(uid, "UidLive_", lstUidLives, strRandom);
                        countUidLive++;
                    }
                    else
                    {
                        SaveUid(uid, "UidDIE_", lstUidDies, strRandom);
                        countUidDie++;
                    }
                }
                
            }catch (Exception ex)
            {
                error = ex.ToString();
            }
        }

        private void SaveUid(string uid, string name, ConcurrentBag<string> lst, string strRandom)
        {
            // Thêm uid live vào danh sách
            lst.Add(uid);            
            // Tạo tên tệp dựa trên ngày hiện tại cho UID Live và UID Die
            string fileName = $"{name}{currentDate}_{strRandom}.txt";
            string filePath = Path.Combine(folderPath, fileName);

            Invoke(new Action(() =>
            {
                StreamWriter savelive = new StreamWriter(filePath, true);
                savelive.WriteLine(uid);
                savelive.Close();
            }));

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isStop = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnOpenFolderSave_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Application.StartupPath);
            // Kiểm tra nếu thư mục tồn tại, sau đó mở nó
            if (Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("Thư mục không tồn tại.");
            }
        }

    }
}
