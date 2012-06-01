using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime;
using System.Runtime.InteropServices;
using WindowsFormsApplication1.Properties;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

            try
            {
                wow = Registry.LocalMachine;

                if (Environment.Is64BitOperatingSystem)
                {
                    wow = wow.OpenSubKey(@"SOFTWARE\Wow6432Node\Blizzard Entertainment\World of Warcraft");
                }
                else
                {
                    wow = wow.OpenSubKey(@"SOFTWARE\Blizzard Entertainment\World of Warcraft");
                }

                if (wow != null)
                {

                    string path = String.Format(@"{0}Data\esES\realmlist.wtf", wow.GetValue("InstallPath").ToString());

                    StreamWriter writer = new StreamWriter(path);

                    writer.WriteLine(Settings.Default.realmlist);
                    writer.Flush();

                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: no se encuentra la carpeta del WOW", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://reinoslokos.no-ip.org");
            }
            catch { }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
			webBrowser2.Visible = false;
			if (Settings.Default.noticias)
            	{
					webBrowser2.Visible = true;
				}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://melchor629.github.com/Parche-RL");
            }
            catch { }
        }

        private void statusLabel_Click_1(object sender, EventArgs e)
        {
           
        }
        
        private RegistryKey wow = null;
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool status = false;
            try
            {
                TcpClient client = new TcpClient();

                client.Connect(Settings.Default.server, Settings.Default.port);

                status = true;
            }
            catch (Exception ex)
            {
                status = false;
            }
            status1.Invoke((MethodInvoker)delegate
            {
                if (status)
                {
                    label2.Text = Settings.Default.nombre1;
                    status1.ForeColor = Color.Green;
                    status1.Text = "Online";
                }
                else
                {
                    label2.Text = Settings.Default.nombre1;
                    status1.ForeColor = Color.Red;
                    status1.Text = "Offline";
                }
            });
            if (Settings.Default.port2_enabled)
            {
                bool statusII = false;
                try
                {
                    TcpClient client = new TcpClient();

                    client.Connect(Settings.Default.server, Settings.Default.port2);

                    statusII = true;
                }
                catch (Exception ex)
                {
                    statusII = false;
                }
                status2.Invoke((MethodInvoker)delegate
                {
                    if (statusII)
                    {
                        label3.Text = Settings.Default.nombre2;
                        status2.ForeColor = Color.Green;
                        status2.Text = "Online";
                    }
                    else
                    {
                        label3.Text = Settings.Default.nombre2;
                        status2.ForeColor = Color.Red;
                        status2.Text = "Offline";
                    }
                });
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void barradesp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
