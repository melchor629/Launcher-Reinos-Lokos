namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button2 = new System.Windows.Forms.Button();
            this.status1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.status2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cerrar = new System.Windows.Forms.Label();
            this.barradesp = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.titulo0 = new System.Windows.Forms.Label();
            this.mensaje0 = new System.Windows.Forms.Label();
            this.autor0 = new System.Windows.Forms.Label();
            this.linkLabel0 = new System.Windows.Forms.LinkLabel();
            this.titulo1 = new System.Windows.Forms.Label();
            this.titulo2 = new System.Windows.Forms.Label();
            this.titulo3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comica BD", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dark Nights";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Programa para controlar cosas de Reinos Lokos";
            this.notifyIcon1.BalloonTipTitle = "Programa para controlar cosas de Reinos Lokos";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RL";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Web de Dark Nights";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1, 281);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(284, 269);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("http://dark-night.no-ip.org/panel/login/?dash", System.UriKind.Absolute);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Parche RL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // status1
            // 
            this.status1.AutoSize = true;
            this.status1.BackColor = System.Drawing.Color.Transparent;
            this.status1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status1.ForeColor = System.Drawing.Color.Red;
            this.status1.Location = new System.Drawing.Point(330, 143);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(0, 33);
            this.status1.TabIndex = 7;
            this.status1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status1.Click += new System.EventHandler(this.statusLabel_Click_1);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(159, 110);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(247, 33);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Estado de los servidores";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click_1);
            // 
            // status2
            // 
            this.status2.AutoSize = true;
            this.status2.BackColor = System.Drawing.Color.Transparent;
            this.status2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status2.ForeColor = System.Drawing.Color.Red;
            this.status2.Location = new System.Drawing.Point(330, 185);
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(0, 33);
            this.status2.TabIndex = 9;
            this.status2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 30);
            this.label3.TabIndex = 11;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(800, 1);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(37, 31);
            this.cerrar.TabIndex = 12;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // barradesp
            // 
            this.barradesp.BackColor = System.Drawing.Color.Transparent;
            this.barradesp.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.barradesp.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barradesp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.barradesp.Location = new System.Drawing.Point(1, 1);
            this.barradesp.Name = "barradesp";
            this.barradesp.Size = new System.Drawing.Size(926, 33);
            this.barradesp.TabIndex = 13;
            this.barradesp.Text = "    Launcher - Dark Nights";
            this.barradesp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barradesp_MouseDown);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Image = global::WindowsFormsApplication1.Properties.Resources.play___copia;
            this.play.Location = new System.Drawing.Point(303, 468);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(243, 179);
            this.play.TabIndex = 14;
            this.play.Click += new System.EventHandler(this.play_Click);
            this.play.MouseLeave += new System.EventHandler(this.play_MouseLeave);
            this.play.MouseHover += new System.EventHandler(this.play_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.wow_icon;
            this.pictureBox2.Location = new System.Drawing.Point(7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // titulo0
            // 
            this.titulo0.AutoSize = true;
            this.titulo0.BackColor = System.Drawing.Color.Transparent;
            this.titulo0.Font = new System.Drawing.Font("Decibel", 14.25F, System.Drawing.FontStyle.Bold);
            this.titulo0.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.titulo0.Location = new System.Drawing.Point(465, 282);
            this.titulo0.MaximumSize = new System.Drawing.Size(380, 0);
            this.titulo0.Name = "titulo0";
            this.titulo0.Size = new System.Drawing.Size(102, 21);
            this.titulo0.TabIndex = 16;
            this.titulo0.Text = "Cargando...";
            // 
            // mensaje0
            // 
            this.mensaje0.AutoSize = true;
            this.mensaje0.BackColor = System.Drawing.Color.Transparent;
            this.mensaje0.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mensaje0.Location = new System.Drawing.Point(465, 329);
            this.mensaje0.MaximumSize = new System.Drawing.Size(370, 0);
            this.mensaje0.Name = "mensaje0";
            this.mensaje0.Size = new System.Drawing.Size(67, 13);
            this.mensaje0.TabIndex = 17;
            this.mensaje0.Text = "Cargando...";
            // 
            // autor0
            // 
            this.autor0.AutoSize = true;
            this.autor0.BackColor = System.Drawing.Color.Transparent;
            this.autor0.Font = new System.Drawing.Font("Comica BD", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor0.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.autor0.Location = new System.Drawing.Point(755, 268);
            this.autor0.Name = "autor0";
            this.autor0.Size = new System.Drawing.Size(60, 15);
            this.autor0.TabIndex = 18;
            this.autor0.Text = "Cargando..";
            // 
            // linkLabel0
            // 
            this.linkLabel0.ActiveLinkColor = System.Drawing.Color.Aquamarine;
            this.linkLabel0.AutoSize = true;
            this.linkLabel0.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel0.Font = new System.Drawing.Font("Doppio One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel0.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel0.Location = new System.Drawing.Point(465, 268);
            this.linkLabel0.Name = "linkLabel0";
            this.linkLabel0.Size = new System.Drawing.Size(55, 14);
            this.linkLabel0.TabIndex = 19;
            this.linkLabel0.TabStop = true;
            this.linkLabel0.Text = "linkLabel1";
            this.linkLabel0.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel0_LinkClicked);
            // 
            // titulo1
            // 
            this.titulo1.AutoSize = true;
            this.titulo1.BackColor = System.Drawing.Color.Transparent;
            this.titulo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titulo1.Font = new System.Drawing.Font("Decibel", 14.25F, System.Drawing.FontStyle.Bold);
            this.titulo1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.titulo1.Location = new System.Drawing.Point(465, 389);
            this.titulo1.MaximumSize = new System.Drawing.Size(380, 0);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(102, 21);
            this.titulo1.TabIndex = 20;
            this.titulo1.Text = "Cargando...";
            this.titulo1.Click += new System.EventHandler(this.titulo1_Click);
            // 
            // titulo2
            // 
            this.titulo2.AutoSize = true;
            this.titulo2.BackColor = System.Drawing.Color.Transparent;
            this.titulo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titulo2.Font = new System.Drawing.Font("Decibel", 14.25F, System.Drawing.FontStyle.Bold);
            this.titulo2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.titulo2.Location = new System.Drawing.Point(465, 410);
            this.titulo2.MaximumSize = new System.Drawing.Size(380, 0);
            this.titulo2.Name = "titulo2";
            this.titulo2.Size = new System.Drawing.Size(102, 21);
            this.titulo2.TabIndex = 21;
            this.titulo2.Text = "Cargando...";
            this.titulo2.Click += new System.EventHandler(this.titulo2_Click);
            // 
            // titulo3
            // 
            this.titulo3.AutoSize = true;
            this.titulo3.BackColor = System.Drawing.Color.Transparent;
            this.titulo3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titulo3.Font = new System.Drawing.Font("Decibel", 14.25F, System.Drawing.FontStyle.Bold);
            this.titulo3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.titulo3.Location = new System.Drawing.Point(465, 431);
            this.titulo3.MaximumSize = new System.Drawing.Size(380, 0);
            this.titulo3.Name = "titulo3";
            this.titulo3.Size = new System.Drawing.Size(102, 21);
            this.titulo3.TabIndex = 22;
            this.titulo3.Text = "Cargando...";
            this.titulo3.Click += new System.EventHandler(this.titulo3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(840, 630);
            this.Controls.Add(this.titulo3);
            this.Controls.Add(this.titulo2);
            this.Controls.Add(this.titulo1);
            this.Controls.Add(this.linkLabel0);
            this.Controls.Add(this.autor0);
            this.Controls.Add(this.mensaje0);
            this.Controls.Add(this.titulo0);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.play);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status2);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.status1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barradesp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reinos Lokos";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label status1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label status2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label cerrar;
        private System.Windows.Forms.Label barradesp;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label play;
        private System.Windows.Forms.Label titulo0;
        private System.Windows.Forms.Label mensaje0;
        private System.Windows.Forms.Label autor0;
        private System.Windows.Forms.LinkLabel linkLabel0;
        private System.Windows.Forms.Label titulo1;
        private System.Windows.Forms.Label titulo2;
        private System.Windows.Forms.Label titulo3;
    }
}

