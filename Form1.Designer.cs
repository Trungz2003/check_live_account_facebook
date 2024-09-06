namespace Tool_check_status_uid
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            label3 = new Label();
            lbCountUidRemain = new Label();
            label7 = new Label();
            lbQuantityUidDie = new Label();
            label9 = new Label();
            lbQuantityUidLive = new Label();
            groupBox3 = new GroupBox();
            btnStop = new Button();
            label10 = new Label();
            nudThreading = new NumericUpDown();
            btnStart = new Button();
            groupBox2 = new GroupBox();
            btnOpenFileUid = new Button();
            lbQuantityUid = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOpenFolderSave = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudThreading).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(807, 343);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Màn hình chính";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(lbCountUidRemain);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(lbQuantityUidDie);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(lbQuantityUidLive);
            groupBox4.Location = new Point(32, 247);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(742, 81);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kết quả ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(15, 35);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 26;
            label3.Text = "Số uid còn lại: ";
            // 
            // lbCountUidRemain
            // 
            lbCountUidRemain.AutoSize = true;
            lbCountUidRemain.BackColor = Color.FromArgb(192, 255, 192);
            lbCountUidRemain.Font = new Font("Segoe UI", 10.2F);
            lbCountUidRemain.Location = new Point(141, 35);
            lbCountUidRemain.Name = "lbCountUidRemain";
            lbCountUidRemain.Size = new Size(37, 23);
            lbCountUidRemain.TabIndex = 27;
            lbCountUidRemain.Text = "000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(260, 35);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 22;
            label7.Text = "Số uid live: ";
            // 
            // lbQuantityUidDie
            // 
            lbQuantityUidDie.AutoSize = true;
            lbQuantityUidDie.BackColor = Color.FromArgb(192, 255, 192);
            lbQuantityUidDie.Font = new Font("Segoe UI", 10.2F);
            lbQuantityUidDie.Location = new Point(594, 35);
            lbQuantityUidDie.Name = "lbQuantityUidDie";
            lbQuantityUidDie.Size = new Size(37, 23);
            lbQuantityUidDie.TabIndex = 23;
            lbQuantityUidDie.Text = "000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(493, 35);
            label9.Name = "label9";
            label9.Size = new Size(95, 23);
            label9.TabIndex = 24;
            label9.Text = "Số uid die: ";
            // 
            // lbQuantityUidLive
            // 
            lbQuantityUidLive.AutoSize = true;
            lbQuantityUidLive.BackColor = Color.FromArgb(192, 255, 192);
            lbQuantityUidLive.Font = new Font("Segoe UI", 10.2F);
            lbQuantityUidLive.Location = new Point(363, 35);
            lbQuantityUidLive.Name = "lbQuantityUidLive";
            lbQuantityUidLive.Size = new Size(37, 23);
            lbQuantityUidLive.TabIndex = 25;
            lbQuantityUidLive.Text = "000";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnStop);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(nudThreading);
            groupBox3.Controls.Add(btnStart);
            groupBox3.Location = new Point(447, 49);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(327, 166);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bước 2: Thao tác cài đặt";
            // 
            // btnStop
            // 
            btnStop.AutoSize = true;
            btnStop.BackColor = Color.Red;
            btnStop.Location = new Point(194, 116);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(118, 38);
            btnStop.TabIndex = 29;
            btnStop.Text = "Tạm dừng";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(64, 53);
            label10.Name = "label10";
            label10.Size = new Size(118, 23);
            label10.TabIndex = 26;
            label10.Text = "Số luồng chạy";
            // 
            // nudThreading
            // 
            nudThreading.Location = new Point(194, 51);
            nudThreading.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudThreading.Name = "nudThreading";
            nudThreading.Size = new Size(82, 30);
            nudThreading.TabIndex = 27;
            nudThreading.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnStart
            // 
            btnStart.AutoSize = true;
            btnStart.BackColor = Color.Lime;
            btnStart.Location = new Point(21, 117);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(116, 37);
            btnStart.TabIndex = 28;
            btnStart.Text = "Bắt đầu";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOpenFileUid);
            groupBox2.Controls.Add(lbQuantityUid);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(32, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 166);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bước 1: Nạp file uid";
            // 
            // btnOpenFileUid
            // 
            btnOpenFileUid.AutoSize = true;
            btnOpenFileUid.BackColor = Color.FromArgb(128, 255, 255);
            btnOpenFileUid.Location = new Point(15, 29);
            btnOpenFileUid.Name = "btnOpenFileUid";
            btnOpenFileUid.Size = new Size(306, 71);
            btnOpenFileUid.TabIndex = 17;
            btnOpenFileUid.Text = "Mở file tài khoản";
            btnOpenFileUid.UseVisualStyleBackColor = false;
            btnOpenFileUid.Click += btnOpenFileUid_Click;
            // 
            // lbQuantityUid
            // 
            lbQuantityUid.AutoSize = true;
            lbQuantityUid.BackColor = Color.FromArgb(192, 255, 192);
            lbQuantityUid.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQuantityUid.Location = new Point(175, 119);
            lbQuantityUid.Name = "lbQuantityUid";
            lbQuantityUid.Size = new Size(37, 23);
            lbQuantityUid.TabIndex = 19;
            lbQuantityUid.Text = "000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 119);
            label2.Name = "label2";
            label2.Size = new Size(163, 23);
            label2.TabIndex = 18;
            label2.Text = "Số lượng tài khoản: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 21);
            label1.Name = "label1";
            label1.Size = new Size(528, 38);
            label1.TabIndex = 17;
            label1.Text = "Kiểm tra trạng thái tài khoản facebook";
            // 
            // btnOpenFolderSave
            // 
            btnOpenFolderSave.AutoSize = true;
            btnOpenFolderSave.BackColor = Color.Yellow;
            btnOpenFolderSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenFolderSave.Location = new Point(254, 448);
            btnOpenFolderSave.Name = "btnOpenFolderSave";
            btnOpenFolderSave.Size = new Size(283, 38);
            btnOpenFolderSave.TabIndex = 29;
            btnOpenFolderSave.Text = "Mở thư mục lưu trữ dữ liệu";
            btnOpenFolderSave.UseVisualStyleBackColor = false;
            btnOpenFolderSave.Click += btnOpenFolderSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(812, 513);
            Controls.Add(btnOpenFolderSave);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudThreading).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnStop;
        private Button btnStart;
        private NumericUpDown nudThreading;
        private Label label10;
        private Label lbQuantityUidLive;
        private Label label9;
        private Label lbQuantityUidDie;
        private Label label7;
        private Label lbQuantityUid;
        private Label label2;
        private Button btnOpenFileUid;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label1;
        private Label label3;
        private Label lbCountUidRemain;
        private Button btnOpenFolderSave;
    }
}
