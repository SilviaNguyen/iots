using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace TrafficLightSystem
{
    public partial class TrafficLightControl : Form
    {
        private SerialPort serialPort;
        private int currentState = 0; 
        private int timeCounter = 0;
        private int timeXanh1 = 25;
        private int timeXanh2 = 33;
        private int timeVang = 3;
        private bool isRunning = false;
        private bool isConnected = false;

        public TrafficLightControl()
        {
            InitializeComponent();
            InitializeSerial();
            LoadComPorts();
            UpdateConnectionStatus();
            UpdateControlStates();
        }

        private void InitializeSerial()
        {
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.Handshake = Handshake.None;
            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void LoadComPorts()
        {
            cmbPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbPort.Items.Add(port);
            }
            if (cmbPort.Items.Count > 0)
                cmbPort.SelectedIndex = 0;
        }

        private void UpdateConnectionStatus()
        {
            if (isConnected)
            {
                lblConnection.Text = $"Trạng thái: Đã kết nối ({cmbPort.Text})";
                lblConnection.ForeColor = Color.Green;
            }
            else
            {
                lblConnection.Text = "Trạng thái: Chưa kết nối";
                lblConnection.ForeColor = Color.Red;
            }
            UpdateControlStates();
        }

        private void UpdateControlStates()
        {
            btnConnect.Enabled = !isConnected && cmbPort.Items.Count > 0;
            btnDisconnect.Enabled = isConnected;
            btnRefreshPort.Enabled = !isConnected;
            cmbPort.Enabled = !isConnected;
            
            // Các nút điều khiển chỉ hoạt động khi đã kết nối
            btnStart.Enabled = isConnected && !isRunning;
            btnStop.Enabled = isConnected && isRunning;
            btnSwapTime.Enabled = isConnected;
            btnSendTime.Enabled = isConnected;
            
            // Cài đặt thời gian
            nudXanh1.Enabled = !isRunning;
            nudXanh2.Enabled = !isRunning;
            nudVang.Enabled = !isRunning;
        }

        private void AddLog(string message)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(AddLog), message);
                return;
            }

            string timeStamp = DateTime.Now.ToString("HH:mm:ss");
            txtLog.AppendText($"[{timeStamp}] {message}\r\n");
            txtLog.ScrollToCaret();
            
            // Giới hạn số dòng log (tối đa 1000 dòng)
            if (txtLog.Lines.Length > 1000)
            {
                string[] lines = txtLog.Lines;
                txtLog.Clear();
                for (int i = 100; i < lines.Length; i++)
                {
                    txtLog.AppendText(lines[i] + "\r\n");
                }
            }
        }

        private void BtnRefreshPort_Click(object sender, EventArgs e)
        {
            LoadComPorts();
            AddLog("Đã làm mới danh sách cổng COM");
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPort.SelectedItem != null)
                {
                    serialPort.PortName = cmbPort.SelectedItem.ToString();
                    if (!serialPort.IsOpen)
                    {
                        serialPort.Open();
                        Thread.Sleep(2000); // Đợi Arduino khởi động
                        
                        isConnected = true;
                        UpdateConnectionStatus();
                        AddLog($"Kết nối thành công với {cmbPort.Text}");
                        
                        // Gửi thời gian hiện tại đến Arduino
                        SendTimeToArduino();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn cổng COM!", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddLog($"Lỗi kết nối: {ex.Message}");
                isConnected = false;
                UpdateConnectionStatus();
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    if (isRunning)
                    {
                        serialPort.WriteLine("STOP");
                        Thread.Sleep(100);
                    }
                    
                    serialPort.Close();
                    isConnected = false;
                    isRunning = false;
                    UpdateConnectionStatus();
                    TurnOffAllLights();
                    lblStatus.Text = "Trạng thái: Đã ngắt kết nối";
                    AddLog("Đã ngắt kết nối");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ngắt kết nối: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddLog($"Lỗi ngắt kết nối: {ex.Message}");
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Vui lòng kết nối với Arduino trước!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Cập nhật thời gian từ giao diện
                timeXanh1 = (int)nudXanh1.Value;
                timeXanh2 = (int)nudXanh2.Value;
                timeVang = (int)nudVang.Value;

                // Gửi thời gian trước
                SendTimeToArduino();
                Thread.Sleep(200);
        
                // Bắt đầu chế độ tự động
                serialPort.WriteLine("A");
        
                isRunning = true;
                UpdateControlStates();
        
                lblStatus.Text = "Trạng thái: Đang chạy (Arduino điều khiển)";
                AddLog("Hệ thống bắt đầu hoạt động - Chế độ tự động");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddLog($"Lỗi bắt đầu: {ex.Message}");
                isRunning = false;
                UpdateControlStates();
            }
        }

        private void SendTimeToArduino()
        {
            if (serialPort.IsOpen)
            {
                string timeData = $"T,{(int)nudXanh1.Value},{(int)nudXanh2.Value},{(int)nudVang.Value}";
                serialPort.WriteLine(timeData);
                AddLog($"Gửi thời gian: X1={nudXanh1.Value}s, X2={nudXanh2.Value}s, V={nudVang.Value}s");
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine("STOP");
                }
                
                isRunning = false;
                UpdateControlStates();
                TurnOffAllLights();
                lblStatus.Text = "Trạng thái: Dừng";
                lblTime.Text = "Thời gian: 0s";
                AddLog("Hệ thống đã dừng");
            }
            catch (Exception ex)
            {
                AddLog($"Lỗi dừng: {ex.Message}");
            }
        }

        private void BtnSwapTime_Click(object sender, EventArgs e)
        {
            try
            {
                if (isConnected && serialPort.IsOpen)
                {
                    serialPort.WriteLine("S");
                    AddLog("Đã gửi lệnh đảo thời gian đến Arduino");
                }
                
                // Đảo thời gian trên giao diện
                int temp = (int)nudXanh1.Value;
                nudXanh1.Value = nudXanh2.Value;
                nudXanh2.Value = temp;
                
                timeXanh1 = (int)nudXanh1.Value;
                timeXanh2 = (int)nudXanh2.Value;
                
                AddLog($"Thời gian đã đảo: Xanh1={timeXanh1}s, Xanh2={timeXanh2}s");
            }
            catch (Exception ex)
            {
                AddLog($"Lỗi đảo thời gian: {ex.Message}");
            }
        }

        private void BtnSendTime_Click(object sender, EventArgs e)
        {
            if (isConnected && serialPort.IsOpen)
            {
                SendTimeToArduino();
                AddLog("Đã gửi thời gian mới đến Arduino");
            }
            else
            {
                MessageBox.Show("Chưa kết nối với Arduino!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
            AddLog("Log đã được xóa");
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadExisting();
                string[] lines = data.Split(new char[] { '\r', '\n' }, 
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        if (this.InvokeRequired)
                        {
                            this.BeginInvoke(new Action<string>(ProcessArduinoData), line.Trim());
                        }
                        else
                        {
                            ProcessArduinoData(line.Trim());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AddLog($"Lỗi nhận dữ liệu: {ex.Message}");
            }
        }

        private void ProcessArduinoData(string data)
        {
            AddLog($"Arduino: {data}");
            
            if (data.StartsWith("STATUS,"))
            {
                try
                {
                    string[] parts = data.Split(',');
                    if (parts.Length >= 7)
                    {
                        int state = int.Parse(parts[1]);
                        int timeCount = int.Parse(parts[2]);
                        int xanh1 = int.Parse(parts[3]);
                        int xanh2 = int.Parse(parts[4]);
                        int vang = int.Parse(parts[5]);
                        bool running = parts[6] == "1";

                        UpdateUIFromArduino(state, timeCount, xanh1, xanh2, vang, running);
                    }
                }
                catch (Exception ex)
                {
                    AddLog($"Lỗi xử lý STATUS: {ex.Message}");
                }
            }
            else if (data.Contains("SWAPPED"))
            {
                // Cập nhật giao diện khi Arduino thông báo đã đảo thời gian
                int temp = (int)nudXanh1.Value;
                nudXanh1.Value = nudXanh2.Value;
                nudXanh2.Value = temp;
            }
        }

        private void UpdateUIFromArduino(int state, int timeCount, int xanh1, int xanh2, int vang, bool running)
        {
            // Cập nhật thời gian nếu khác
            if (xanh1 != nudXanh1.Value) nudXanh1.Value = xanh1;
            if (xanh2 != nudXanh2.Value) nudXanh2.Value = xanh2;
            if (vang != nudVang.Value) nudVang.Value = vang;

            timeXanh1 = xanh1;
            timeXanh2 = xanh2;
            timeVang = vang;
            isRunning = running;
            
            lblTime.Text = $"Thời gian: {timeCount}s";
            currentState = state;
            timeCounter = timeCount;

            // Cập nhật trạng thái đèn và label
            switch (state)
            {
                case 0:
                    SetLights(Color.Green, Color.Gray, Color.Gray, Color.Gray, Color.Gray, Color.Red);
                    lblStatus.Text = "Trạng thái: H1 Xanh - H2 Đỏ";
                    break;
                case 1:
                    SetLights(Color.Gray, Color.Yellow, Color.Gray, Color.Gray, Color.Gray, Color.Red);
                    lblStatus.Text = "Trạng thái: H1 Vàng - H2 Đỏ";
                    break;
                case 2:
                    SetLights(Color.Gray, Color.Gray, Color.Red, Color.Green, Color.Gray, Color.Gray);
                    lblStatus.Text = "Trạng thái: H1 Đỏ - H2 Xanh";
                    break;
                case 3:
                    SetLights(Color.Gray, Color.Gray, Color.Red, Color.Gray, Color.Yellow, Color.Gray);
                    lblStatus.Text = "Trạng thái: H1 Đỏ - H2 Vàng";
                    break;
            }
            
            UpdateControlStates();
        }

        private void SetLights(Color xanh1, Color vang1, Color do1, Color xanh2, Color vang2, Color do2)
        {
            btnXanh1.BackColor = xanh1;
            btnVang1.BackColor = vang1;
            btnDo1.BackColor = do1;
            btnXanh2.BackColor = xanh2;
            btnVang2.BackColor = vang2;
            btnDo2.BackColor = do2;
        }

        private void TurnOffAllLights()
        {
            SetLights(Color.Gray, Color.Gray, Color.Gray, Color.Gray, Color.Gray, Color.Gray);
        }

        private void TrafficLightControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    if (isRunning)
                    {
                        serialPort.WriteLine("STOP");
                        Thread.Sleep(100);
                    }
                    serialPort.Close();
                }
            }
            catch
            {
                // Ignore errors during closing
            }
        }

        // Event handlers cho NumericUpDown để cập nhật thời gian
        private void nudXanh1_ValueChanged(object sender, EventArgs e)
        {
            timeXanh1 = (int)nudXanh1.Value;
        }

        private void nudXanh2_ValueChanged(object sender, EventArgs e)
        {
            timeXanh2 = (int)nudXanh2.Value;
        }

        private void nudVang_ValueChanged(object sender, EventArgs e)
        {
            timeVang = (int)nudVang.Value;
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}