namespace TrafficLightSystem
{
    partial class TrafficLightControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHuong1 = new System.Windows.Forms.Panel();
            this.lblHuong1 = new System.Windows.Forms.Label();
            this.btnXanh1 = new System.Windows.Forms.Button();
            this.btnVang1 = new System.Windows.Forms.Button();
            this.btnDo1 = new System.Windows.Forms.Button();
            this.pnlHuong2 = new System.Windows.Forms.Panel();
            this.lblHuong2 = new System.Windows.Forms.Label();
            this.btnXanh2 = new System.Windows.Forms.Button();
            this.btnVang2 = new System.Windows.Forms.Button();
            this.btnDo2 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSwapTime = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblCaiDat = new System.Windows.Forms.Label();
            this.lblXanh1 = new System.Windows.Forms.Label();
            this.nudXanh1 = new System.Windows.Forms.NumericUpDown();
            this.lblXanh2 = new System.Windows.Forms.Label();
            this.nudXanh2 = new System.Windows.Forms.NumericUpDown();
            this.lblVangTime = new System.Windows.Forms.Label();
            this.nudVang = new System.Windows.Forms.NumericUpDown();
            this.lblPort = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.btnRefreshPort = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnSendTime = new System.Windows.Forms.Button();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlHuong1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXanh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXanh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVang)).BeginInit();
            this.pnlHuong2.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHuong1
            // 
            this.pnlHuong1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHuong1.Controls.Add(this.lblHuong1);
            this.pnlHuong1.Controls.Add(this.btnXanh1);
            this.pnlHuong1.Controls.Add(this.btnVang1);
            this.pnlHuong1.Controls.Add(this.btnDo1);
            this.pnlHuong1.Location = new System.Drawing.Point(30, 30);
            this.pnlHuong1.Name = "pnlHuong1";
            this.pnlHuong1.Size = new System.Drawing.Size(200, 130);
            this.pnlHuong1.TabIndex = 0;
            // 
            // lblHuong1
            // 
            this.lblHuong1.AutoSize = true;
            this.lblHuong1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuong1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHuong1.Location = new System.Drawing.Point(60, 10);
            this.lblHuong1.Name = "lblHuong1";
            this.lblHuong1.Size = new System.Drawing.Size(80, 19);
            this.lblHuong1.TabIndex = 0;
            this.lblHuong1.Text = "HƯỚNG 1";
            // 
            // btnXanh1
            // 
            this.btnXanh1.BackColor = System.Drawing.Color.Gray;
            this.btnXanh1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnXanh1.Location = new System.Drawing.Point(15, 40);
            this.btnXanh1.Name = "btnXanh1";
            this.btnXanh1.Size = new System.Drawing.Size(50, 60);
            this.btnXanh1.TabIndex = 1;
            this.btnXanh1.Text = "XANH";
            this.btnXanh1.UseVisualStyleBackColor = false;
            // 
            // btnVang1
            // 
            this.btnVang1.BackColor = System.Drawing.Color.Gray;
            this.btnVang1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnVang1.Location = new System.Drawing.Point(75, 40);
            this.btnVang1.Name = "btnVang1";
            this.btnVang1.Size = new System.Drawing.Size(50, 60);
            this.btnVang1.TabIndex = 2;
            this.btnVang1.Text = "VÀNG";
            this.btnVang1.UseVisualStyleBackColor = false;
            // 
            // btnDo1
            // 
            this.btnDo1.BackColor = System.Drawing.Color.Gray;
            this.btnDo1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnDo1.Location = new System.Drawing.Point(135, 40);
            this.btnDo1.Name = "btnDo1";
            this.btnDo1.Size = new System.Drawing.Size(50, 60);
            this.btnDo1.TabIndex = 3;
            this.btnDo1.Text = "ĐỎ";
            this.btnDo1.UseVisualStyleBackColor = false;
            // 
            // pnlHuong2
            // 
            this.pnlHuong2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHuong2.Controls.Add(this.lblHuong2);
            this.pnlHuong2.Controls.Add(this.btnXanh2);
            this.pnlHuong2.Controls.Add(this.btnVang2);
            this.pnlHuong2.Controls.Add(this.btnDo2);
            this.pnlHuong2.Location = new System.Drawing.Point(280, 30);
            this.pnlHuong2.Name = "pnlHuong2";
            this.pnlHuong2.Size = new System.Drawing.Size(200, 130);
            this.pnlHuong2.TabIndex = 1;
            // 
            // lblHuong2
            // 
            this.lblHuong2.AutoSize = true;
            this.lblHuong2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuong2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHuong2.Location = new System.Drawing.Point(60, 10);
            this.lblHuong2.Name = "lblHuong2";
            this.lblHuong2.Size = new System.Drawing.Size(80, 19);
            this.lblHuong2.TabIndex = 0;
            this.lblHuong2.Text = "HƯỚNG 2";
            // 
            // btnXanh2
            // 
            this.btnXanh2.BackColor = System.Drawing.Color.Gray;
            this.btnXanh2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnXanh2.Location = new System.Drawing.Point(15, 40);
            this.btnXanh2.Name = "btnXanh2";
            this.btnXanh2.Size = new System.Drawing.Size(50, 60);
            this.btnXanh2.TabIndex = 1;
            this.btnXanh2.Text = "XANH";
            this.btnXanh2.UseVisualStyleBackColor = false;
            // 
            // btnVang2
            // 
            this.btnVang2.BackColor = System.Drawing.Color.Gray;
            this.btnVang2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnVang2.Location = new System.Drawing.Point(75, 40);
            this.btnVang2.Name = "btnVang2";
            this.btnVang2.Size = new System.Drawing.Size(50, 60);
            this.btnVang2.TabIndex = 2;
            this.btnVang2.Text = "VÀNG";
            this.btnVang2.UseVisualStyleBackColor = false;
            // 
            // btnDo2
            // 
            this.btnDo2.BackColor = System.Drawing.Color.Gray;
            this.btnDo2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnDo2.Location = new System.Drawing.Point(135, 40);
            this.btnDo2.Name = "btnDo2";
            this.btnDo2.Size = new System.Drawing.Size(50, 60);
            this.btnDo2.TabIndex = 3;
            this.btnDo2.Text = "ĐỎ";
            this.btnDo2.UseVisualStyleBackColor = false;
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.btnStart);
            this.groupBoxControl.Controls.Add(this.btnStop);
            this.groupBoxControl.Controls.Add(this.btnSwapTime);
            this.groupBoxControl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxControl.Location = new System.Drawing.Point(30, 180);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(450, 70);
            this.groupBoxControl.TabIndex = 2;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "ĐIỀU KHIỂN";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(20, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "BẮT ĐẦU";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightCoral;
            this.btnStop.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnStop.Location = new System.Drawing.Point(140, 25);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 35);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "DỪNG";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnSwapTime
            // 
            this.btnSwapTime.BackColor = System.Drawing.Color.LightBlue;
            this.btnSwapTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSwapTime.Location = new System.Drawing.Point(260, 25);
            this.btnSwapTime.Name = "btnSwapTime";
            this.btnSwapTime.Size = new System.Drawing.Size(120, 35);
            this.btnSwapTime.TabIndex = 2;
            this.btnSwapTime.Text = "ĐẢO THỜI GIAN";
            this.btnSwapTime.UseVisualStyleBackColor = false;
            this.btnSwapTime.Click += new System.EventHandler(this.BtnSwapTime_Click);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.lblCaiDat);
            this.groupBoxSettings.Controls.Add(this.lblXanh1);
            this.groupBoxSettings.Controls.Add(this.nudXanh1);
            this.groupBoxSettings.Controls.Add(this.lblXanh2);
            this.groupBoxSettings.Controls.Add(this.nudXanh2);
            this.groupBoxSettings.Controls.Add(this.lblVangTime);
            this.groupBoxSettings.Controls.Add(this.nudVang);
            this.groupBoxSettings.Controls.Add(this.btnSendTime);
            this.groupBoxSettings.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxSettings.Location = new System.Drawing.Point(30, 270);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(450, 100);
            this.groupBoxSettings.TabIndex = 3;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "CÀI ĐẶT THỜI GIAN";
            // 
            // lblXanh1
            // 
            this.lblXanh1.AutoSize = true;
            this.lblXanh1.Font = new System.Drawing.Font("Arial", 9F);
            this.lblXanh1.Location = new System.Drawing.Point(20, 35);
            this.lblXanh1.Name = "lblXanh1";
            this.lblXanh1.Size = new System.Drawing.Size(65, 15);
            this.lblXanh1.TabIndex = 0;
            this.lblXanh1.Text = "Xanh 1 (s):";
            // 
            // nudXanh1
            // 
            this.nudXanh1.Font = new System.Drawing.Font("Arial", 9F);
            this.nudXanh1.Location = new System.Drawing.Point(90, 32);
            this.nudXanh1.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            this.nudXanh1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudXanh1.Name = "nudXanh1";
            this.nudXanh1.Size = new System.Drawing.Size(60, 21);
            this.nudXanh1.TabIndex = 1;
            this.nudXanh1.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // lblXanh2
            // 
            this.lblXanh2.AutoSize = true;
            this.lblXanh2.Font = new System.Drawing.Font("Arial", 9F);
            this.lblXanh2.Location = new System.Drawing.Point(170, 35);
            this.lblXanh2.Name = "lblXanh2";
            this.lblXanh2.Size = new System.Drawing.Size(65, 15);
            this.lblXanh2.TabIndex = 2;
            this.lblXanh2.Text = "Xanh 2 (s):";
            // 
            // nudXanh2
            // 
            this.nudXanh2.Font = new System.Drawing.Font("Arial", 9F);
            this.nudXanh2.Location = new System.Drawing.Point(240, 32);
            this.nudXanh2.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            this.nudXanh2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudXanh2.Name = "nudXanh2";
            this.nudXanh2.Size = new System.Drawing.Size(60, 21);
            this.nudXanh2.TabIndex = 3;
            this.nudXanh2.Value = new decimal(new int[] { 33, 0, 0, 0 });
            // 
            // lblVangTime
            // 
            this.lblVangTime.AutoSize = true;
            this.lblVangTime.Font = new System.Drawing.Font("Arial", 9F);
            this.lblVangTime.Location = new System.Drawing.Point(320, 35);
            this.lblVangTime.Name = "lblVangTime";
            this.lblVangTime.Size = new System.Drawing.Size(59, 15);
            this.lblVangTime.TabIndex = 4;
            this.lblVangTime.Text = "Vàng (s):";
            // 
            // nudVang
            // 
            this.nudVang.Font = new System.Drawing.Font("Arial", 9F);
            this.nudVang.Location = new System.Drawing.Point(380, 32);
            this.nudVang.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.nudVang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudVang.Name = "nudVang";
            this.nudVang.Size = new System.Drawing.Size(50, 21);
            this.nudVang.TabIndex = 5;
            this.nudVang.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnSendTime
            // 
            this.btnSendTime.BackColor = System.Drawing.Color.LightYellow;
            this.btnSendTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSendTime.Location = new System.Drawing.Point(165, 65);
            this.btnSendTime.Name = "btnSendTime";
            this.btnSendTime.Size = new System.Drawing.Size(120, 25);
            this.btnSendTime.TabIndex = 6;
            this.btnSendTime.Text = "GỬI THỜI GIAN";
            this.btnSendTime.UseVisualStyleBackColor = false;
            this.btnSendTime.Click += new System.EventHandler(this.BtnSendTime_Click);
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.lblPort);
            this.groupBoxConnection.Controls.Add(this.cmbPort);
            this.groupBoxConnection.Controls.Add(this.btnRefreshPort);
            this.groupBoxConnection.Controls.Add(this.btnConnect);
            this.groupBoxConnection.Controls.Add(this.btnDisconnect);
            this.groupBoxConnection.Controls.Add(this.lblConnection);
            this.groupBoxConnection.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxConnection.Location = new System.Drawing.Point(30, 390);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(450, 80);
            this.groupBoxConnection.TabIndex = 4;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "KẾT NỐI";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Arial", 9F);
            this.lblPort.Location = new System.Drawing.Point(20, 30);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(71, 15);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Cổng COM:";
            // 
            // cmbPort
            // 
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(95, 27);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(80, 23);
            this.cmbPort.TabIndex = 1;
            // 
            // btnRefreshPort
            // 
            this.btnRefreshPort.Font = new System.Drawing.Font("Arial", 8F);
            this.btnRefreshPort.Location = new System.Drawing.Point(185, 27);
            this.btnRefreshPort.Name = "btnRefreshPort";
            this.btnRefreshPort.Size = new System.Drawing.Size(60, 23);
            this.btnRefreshPort.TabIndex = 2;
            this.btnRefreshPort.Text = "Làm mới";
            this.btnRefreshPort.UseVisualStyleBackColor = true;
            this.btnRefreshPort.Click += new System.EventHandler(this.BtnRefreshPort_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.LightGreen;
            this.btnConnect.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnConnect.Location = new System.Drawing.Point(260, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(80, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "KẾT NỐI";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.LightCoral;
            this.btnDisconnect.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnDisconnect.Location = new System.Drawing.Point(350, 27);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(80, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "NGẮT KẾT NỐI";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Arial", 9F);
            this.lblConnection.ForeColor = System.Drawing.Color.Red;
            this.lblConnection.Location = new System.Drawing.Point(20, 55);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(129, 15);
            this.lblConnection.TabIndex = 5;
            this.lblConnection.Text = "Trạng thái: Chưa kết nối";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(500, 50);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(115, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Trạng thái: Dừng";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTime.Location = new System.Drawing.Point(500, 75);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 16);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Thời gian: 0s";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblLog.Location = new System.Drawing.Point(500, 120);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(35, 16);
            this.lblLog.TabIndex = 7;
            this.lblLog.Text = "LOG";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 8F);
            this.txtLog.ForeColor = System.Drawing.Color.Lime;
            this.txtLog.Location = new System.Drawing.Point(500, 140);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(280, 280);
            this.txtLog.TabIndex = 8;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Font = new System.Drawing.Font("Arial", 8F);
            this.btnClearLog.Location = new System.Drawing.Point(705, 435);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 9;
            this.btnClearLog.Text = "Xóa Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.BtnClearLog_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // TrafficLightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBoxConnection);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBoxControl);
            this.Controls.Add(this.pnlHuong2);
            this.Controls.Add(this.pnlHuong1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TrafficLightControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều Khiển Đèn Giao Thông - Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrafficLightControl_FormClosing);
            this.pnlHuong1.ResumeLayout(false);
            this.pnlHuong1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXanh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXanh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVang)).EndInit();
            this.pnlHuong2.ResumeLayout(false);
            this.pnlHuong2.PerformLayout();
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHuong1;
        private System.Windows.Forms.Label lblHuong1;
        private System.Windows.Forms.Button btnXanh1;
        private System.Windows.Forms.Button btnVang1;
        private System.Windows.Forms.Button btnDo1;
        private System.Windows.Forms.Panel pnlHuong2;
        private System.Windows.Forms.Label lblHuong2;
        private System.Windows.Forms.Button btnXanh2;
        private System.Windows.Forms.Button btnVang2;
        private System.Windows.Forms.Button btnDo2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSwapTime;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblCaiDat;
        private System.Windows.Forms.Label lblXanh1;
        private System.Windows.Forms.NumericUpDown nudXanh1;
        private System.Windows.Forms.Label lblXanh2;
        private System.Windows.Forms.NumericUpDown nudXanh2;
        private System.Windows.Forms.Label lblVangTime;
        private System.Windows.Forms.NumericUpDown nudVang;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button btnRefreshPort;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnSendTime;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Timer timer1;
    }
}