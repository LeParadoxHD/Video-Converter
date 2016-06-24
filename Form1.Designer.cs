namespace LeParadoxHD_Converter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getVideo = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.comenzarButton = new System.Windows.Forms.Button();
            this.quality = new System.Windows.Forms.Label();
            this.calidad = new System.Windows.Forms.ComboBox();
            this.CPUCores = new System.Windows.Forms.Label();
            this.cores = new System.Windows.Forms.ComboBox();
            this.mismoNombre = new System.Windows.Forms.CheckBox();
            this.customName = new System.Windows.Forms.TextBox();
            this.linkYouTube = new System.Windows.Forms.LinkLabel();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.resolucion = new System.Windows.Forms.Label();
            this.resolution = new System.Windows.Forms.ComboBox();
            this.fotos = new System.Windows.Forms.Label();
            this.frameRate = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getVideo
            // 
            this.getVideo.AllowDrop = true;
            this.getVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getVideo.Location = new System.Drawing.Point(0, 0);
            this.getVideo.MaximumSize = new System.Drawing.Size(498, 121);
            this.getVideo.MinimumSize = new System.Drawing.Size(498, 121);
            this.getVideo.Name = "getVideo";
            this.getVideo.Size = new System.Drawing.Size(498, 121);
            this.getVideo.TabIndex = 0;
            this.getVideo.Text = "Arrastre o haga clic para seleccionar vídeo.";
            this.getVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.getVideo.Click += new System.EventHandler(this.getVideo_Click);
            this.getVideo.DragDrop += new System.Windows.Forms.DragEventHandler(this.getVideo_DragDrop);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 121);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(498, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(49, 17);
            this.status.Text = "Iniciado";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comenzarButton
            // 
            this.comenzarButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.comenzarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comenzarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comenzarButton.Location = new System.Drawing.Point(23, 14);
            this.comenzarButton.Name = "comenzarButton";
            this.comenzarButton.Size = new System.Drawing.Size(119, 31);
            this.comenzarButton.TabIndex = 2;
            this.comenzarButton.Text = "Procesar";
            this.comenzarButton.UseVisualStyleBackColor = false;
            this.comenzarButton.Visible = false;
            this.comenzarButton.Click += new System.EventHandler(this.comenzarButton_Click);
            // 
            // quality
            // 
            this.quality.AutoSize = true;
            this.quality.Location = new System.Drawing.Point(12, 65);
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(45, 13);
            this.quality.TabIndex = 3;
            this.quality.Text = "Calidad:";
            this.quality.Visible = false;
            // 
            // calidad
            // 
            this.calidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calidad.FormattingEnabled = true;
            this.calidad.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta",
            "Ultra",
            "Sin pérdida"});
            this.calidad.Location = new System.Drawing.Point(58, 62);
            this.calidad.Name = "calidad";
            this.calidad.Size = new System.Drawing.Size(84, 21);
            this.calidad.TabIndex = 4;
            this.calidad.Visible = false;
            // 
            // CPUCores
            // 
            this.CPUCores.AutoSize = true;
            this.CPUCores.Location = new System.Drawing.Point(148, 65);
            this.CPUCores.Name = "CPUCores";
            this.CPUCores.Size = new System.Drawing.Size(120, 13);
            this.CPUCores.TabIndex = 5;
            this.CPUCores.Text = "Núcleos de procesador:";
            this.CPUCores.Visible = false;
            // 
            // cores
            // 
            this.cores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cores.FormattingEnabled = true;
            this.cores.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8"});
            this.cores.Location = new System.Drawing.Point(274, 62);
            this.cores.Name = "cores";
            this.cores.Size = new System.Drawing.Size(39, 21);
            this.cores.TabIndex = 6;
            this.cores.Visible = false;
            // 
            // mismoNombre
            // 
            this.mismoNombre.AutoSize = true;
            this.mismoNombre.Checked = true;
            this.mismoNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mismoNombre.Location = new System.Drawing.Point(148, 22);
            this.mismoNombre.Name = "mismoNombre";
            this.mismoNombre.Size = new System.Drawing.Size(94, 17);
            this.mismoNombre.TabIndex = 7;
            this.mismoNombre.Text = "Mismo nombre";
            this.mismoNombre.UseVisualStyleBackColor = true;
            this.mismoNombre.Visible = false;
            this.mismoNombre.CheckStateChanged += new System.EventHandler(this.mismoNombre_CheckStateChanged);
            // 
            // customName
            // 
            this.customName.Location = new System.Drawing.Point(249, 20);
            this.customName.Name = "customName";
            this.customName.Size = new System.Drawing.Size(237, 20);
            this.customName.TabIndex = 8;
            this.customName.Visible = false;
            // 
            // linkYouTube
            // 
            this.linkYouTube.AutoSize = true;
            this.linkYouTube.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkYouTube.Location = new System.Drawing.Point(338, 125);
            this.linkYouTube.Name = "linkYouTube";
            this.linkYouTube.Size = new System.Drawing.Size(139, 13);
            this.linkYouTube.TabIndex = 10;
            this.linkYouTube.TabStop = true;
            this.linkYouTube.Text = "Visita mi canal de YouTube!";
            this.linkYouTube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkYouTube_LinkClicked);
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(175, 125);
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(157, 15);
            this.progreso.TabIndex = 11;
            this.progreso.Visible = false;
            // 
            // resolucion
            // 
            this.resolucion.AutoSize = true;
            this.resolucion.Location = new System.Drawing.Point(12, 95);
            this.resolucion.Name = "resolucion";
            this.resolucion.Size = new System.Drawing.Size(63, 13);
            this.resolucion.TabIndex = 12;
            this.resolucion.Text = "Resolución:";
            this.resolucion.Visible = false;
            // 
            // resolution
            // 
            this.resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolution.FormattingEnabled = true;
            this.resolution.Items.AddRange(new object[] {
            "Igual",
            "256 x 144",
            "640 x 360",
            "852 x 480",
            "1024 x 576",
            "1280 x 720",
            "1600 x 900",
            "1920 x 1080",
            "2560 x 1440",
            "3840 x 2160"});
            this.resolution.Location = new System.Drawing.Point(81, 92);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(96, 21);
            this.resolution.TabIndex = 13;
            this.resolution.Visible = false;
            // 
            // fotos
            // 
            this.fotos.Location = new System.Drawing.Point(319, 65);
            this.fotos.Name = "fotos";
            this.fotos.Size = new System.Drawing.Size(112, 13);
            this.fotos.TabIndex = 12;
            this.fotos.Text = "Fotogramas/segundo:";
            this.fotos.Visible = false;
            // 
            // frameRate
            // 
            this.frameRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frameRate.FormattingEnabled = true;
            this.frameRate.Items.AddRange(new object[] {
            "Igual",
            "5",
            "10",
            "12",
            "15",
            "23",
            "24",
            "29",
            "30",
            "50",
            "59",
            "60",
            "70",
            "75",
            "90",
            "120"});
            this.frameRate.Location = new System.Drawing.Point(437, 62);
            this.frameRate.Name = "frameRate";
            this.frameRate.Size = new System.Drawing.Size(47, 21);
            this.frameRate.TabIndex = 13;
            this.frameRate.Visible = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 143);
            this.Controls.Add(this.frameRate);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.fotos);
            this.Controls.Add(this.resolucion);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.linkYouTube);
            this.Controls.Add(this.customName);
            this.Controls.Add(this.mismoNombre);
            this.Controls.Add(this.cores);
            this.Controls.Add(this.CPUCores);
            this.Controls.Add(this.calidad);
            this.Controls.Add(this.quality);
            this.Controls.Add(this.comenzarButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.getVideo);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LeParadoxHD Video Compressing";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label getVideo;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Button comenzarButton;
        private System.Windows.Forms.Label quality;
        private System.Windows.Forms.ComboBox calidad;
        private System.Windows.Forms.Label CPUCores;
        private System.Windows.Forms.ComboBox cores;
        private System.Windows.Forms.CheckBox mismoNombre;
        private System.Windows.Forms.TextBox customName;
        private System.Windows.Forms.LinkLabel linkYouTube;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.Label resolucion;
        private System.Windows.Forms.ComboBox resolution;
        private System.Windows.Forms.Label fotos;
        private System.Windows.Forms.ComboBox frameRate;
    }
}

