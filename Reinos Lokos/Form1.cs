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
        /* Cambia el realmlist */
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
        /* Abre la web */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://dark-night.no-ip.org");
            }
            catch { }
        }
        /* Icono de notificación que minimiza la ventana */
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        /* 2º Botón que te lleva a algun sitio */
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://melchor629.github.com/Parche-RL");
            }
            catch { }
        }
        /* NADA */
        private void statusLabel_Click_1(object sender, EventArgs e)
        {
           
        }
        /* NI IDEA */
        private RegistryKey wow = null;
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        /* Comprueba si está abierto los reinos */
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

            /* NOTICIAS */
            var URLString = "http://dark-night.no-ip.org/Scripts/news.php";
            string xmlStr;
            using (var wc = new WebClient())
            {
                xmlStr = wc.DownloadString(URLString);
            }
            var xDoc = new XmlDocument();
            xDoc.LoadXml(xmlStr);
            //MessageBox.Show(xmlStr); // Muestra todo el XML

            XmlNodeList personas = xDoc.GetElementsByTagName("noticias");

            XmlNodeList lista = ((XmlElement)personas[0]).GetElementsByTagName("noticia");

            foreach (XmlElement nodo in lista)
            {

                int i = 0;
                XmlNodeList titulo =
                nodo.GetElementsByTagName("titulo");

                XmlNodeList autor = nodo.GetElementsByTagName("autor");

                XmlNodeList contenido = nodo.GetElementsByTagName("contenido");

                XmlNodeList link = nodo.GetElementsByTagName("link");

                /** Cambiando cosas :D */
                titulo0.Invoke((MethodInvoker)delegate
                {
                    this.titulo0.Text = titulo[0].InnerText;
                });
                autor0.Invoke((MethodInvoker)delegate
                {
                    this.autor0.Text = autor[0].InnerText;
                });
                mensaje0.Invoke((MethodInvoker)delegate
                {
                    this.mensaje0.Text = contenido[0].InnerText;
                });
                linkLabel0.Invoke((MethodInvoker)delegate
                {
                    this.linkLabel0.Text = link[0].InnerText;
                });

                i++;
            }
            /* Mas cambios */
            titulo1.Invoke((MethodInvoker)delegate
            {
                this.titulo1.Text = otrostitulos(1);
            });

            titulo2.Invoke((MethodInvoker)delegate
            {
                this.titulo2.Text = otrostitulos(2);
            });

            titulo3.Invoke((MethodInvoker)delegate
            {
                this.titulo3.Text = otrostitulos(3);
            });

        }

        /* Obtiene los titulos de los antiguos posts */
        static String otrostitulos(int id)
        {
            var URLString = "http://dark-night.no-ip.org/Scripts/news.php?id=" + id + "";
            string xmlStr;
            using (var wc = new WebClient())
            {
                xmlStr = wc.DownloadString(URLString);
            }
            var xDoc = new XmlDocument();
            xDoc.LoadXml(xmlStr);
            XmlNodeList titulo = xDoc.GetElementsByTagName("titulo");

            string erreturn = titulo[0].InnerText;
            return erreturn;
        }

        /* Obtiene el link de los antiguos posts */
        static String otroslinks(int id)
        {
            var URLString = "http://dark-night.no-ip.org/Scripts/news.php?link=" + id + "";
            string xmlStr;
            using (var wc = new WebClient())
            {
                xmlStr = wc.DownloadString(URLString);
            }
            var xDoc = new XmlDocument();
            xDoc.LoadXml(xmlStr);
            XmlNodeList titulo = xDoc.GetElementsByTagName("titulo");

            string erreturn = titulo[0].InnerText;
            return erreturn;
        }

        /* Cerrar ventana */
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
        /* Botón para jugar */
        private void play_MouseHover(object sender, EventArgs e)
        {
            play.Image = Properties.Resources.play_hover___copia;
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            play.Image = Properties.Resources.play___copia;
        }
        private void play_Click(object sender, EventArgs e)
        {
            string wowpath = String.Format(@"{0}/Wow.exe", wow.GetValue("InstallPath").ToString());
            System.Diagnostics.Process.Start(wowpath);
        }

        /* Links */
        private void linkLabel0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(otroslinks(1));
        }

        private void titulo1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(otroslinks(1));
        }

        private void titulo2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(otroslinks(2));
        }

        private void titulo3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(otroslinks(3));
        }

    }
}
