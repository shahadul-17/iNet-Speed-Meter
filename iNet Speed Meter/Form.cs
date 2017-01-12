using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Threading;

namespace iNet_Speed_Meter
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int networkInterfaceIndex = -1;
        private double _uploadSpeed = 0.0, _downloadSpeed = 0.0, bytesSent = 0.0, bytesReceived = 0.0;
        private static readonly double KB = 1024.0, MB = KB * 1024.0, GB = MB * 1024.0, TB = GB * 1024.0;
        private string uploadSpeed = "0.0 Bytes/s", downloadSpeed = "0.0 Bytes/s";

        private IPv4InterfaceStatistics iPv4InterfaceStatistics;
        private NetworkInterface[] networkInterfaces;

        public Form()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            for (int i = 0; i < networkInterfaces.Length; i++)
            {
                if ((networkInterfaces[i].NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    networkInterfaces[i].NetworkInterfaceType == NetworkInterfaceType.Ethernet) &&
                    networkInterfaces[i].OperationalStatus == OperationalStatus.Up)
                {
                    networkInterfaceIndex = i;
                    textBoxConnectionType.Text = networkInterfaces[networkInterfaceIndex].NetworkInterfaceType.ToString();

                    break;
                }
            }

            if (networkInterfaceIndex != -1)
            {
                backgroundWorker.RunWorkerAsync();
                timer.Start();
            }
        }

        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            if (sender.Equals(backgroundWorker))
            {
                while (true)
                {
                    iPv4InterfaceStatistics = networkInterfaces[networkInterfaceIndex].GetIPv4Statistics();

                    _uploadSpeed = iPv4InterfaceStatistics.BytesSent - bytesSent;
                    _downloadSpeed = iPv4InterfaceStatistics.BytesReceived - bytesReceived;

                    uploadSpeed = Format(_uploadSpeed);
                    downloadSpeed = Format(_downloadSpeed);

                    bytesSent = iPv4InterfaceStatistics.BytesSent;
                    bytesReceived = iPv4InterfaceStatistics.BytesReceived;

                    Thread.Sleep(1000);
                }
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (sender.Equals(timer))
            {
                textBoxUpload.Text = uploadSpeed;
                textBoxDownload.Text = downloadSpeed;
            }
        }

        private string Format(double speed)
        {
            if (speed == 0.0)
            {
                return "0.0 Bytes/s";
            }

            string unit = "Bytes/s";

            if (speed > TB)
            {
                speed /= TB;
                unit = "TB/s";
            }
            else if (speed > GB)
            {
                speed /= GB;
                unit = "GB/s";
            }
            else if (speed > MB)
            {
                speed /= MB;
                unit = "MB/s";
            }
            else if (speed > KB)
            {
                speed /= KB;
                unit = "KB/s";
            }

            return string.Format("{0:.##}", speed) + " " + unit;
        }
    }
}