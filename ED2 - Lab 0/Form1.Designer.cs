namespace ED2___Lab_0
{
    partial class RHYTHMN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RHYTHMN));
            this.menú = new System.Windows.Forms.MenuStrip();
            this.biblioteclaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todaLaMúsicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasDeReproducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Álbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevaCanción = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.ReproducirLista = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.anterior = new System.Windows.Forms.PictureBox();
            this.siguiente = new System.Windows.Forms.PictureBox();
            this.playPausa = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLista = new System.Windows.Forms.Panel();
            this.exit1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarLista = new System.Windows.Forms.Button();
            this.txtNombreLista = new System.Windows.Forms.TextBox();
            this.panelCanción = new System.Windows.Forms.Panel();
            this.btnAgregarCanción = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCanción = new System.Windows.Forms.TextBox();
            this.exit2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Detener = new System.Windows.Forms.Button();
            this.menú.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLista.SuspendLayout();
            this.panelCanción.SuspendLayout();
            this.SuspendLayout();
            // 
            // menú
            // 
            this.menú.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biblioteclaToolStripMenuItem});
            this.menú.Location = new System.Drawing.Point(0, 0);
            this.menú.Name = "menú";
            this.menú.Size = new System.Drawing.Size(818, 24);
            this.menú.TabIndex = 0;
            this.menú.Text = "menuStrip1";
            this.menú.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menú_ItemClicked);
            // 
            // biblioteclaToolStripMenuItem
            // 
            this.biblioteclaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todaLaMúsicaToolStripMenuItem,
            this.listasDeReproducciónToolStripMenuItem});
            this.biblioteclaToolStripMenuItem.Name = "biblioteclaToolStripMenuItem";
            this.biblioteclaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.biblioteclaToolStripMenuItem.Text = "Biblioteca ";
            // 
            // todaLaMúsicaToolStripMenuItem
            // 
            this.todaLaMúsicaToolStripMenuItem.Name = "todaLaMúsicaToolStripMenuItem";
            this.todaLaMúsicaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.todaLaMúsicaToolStripMenuItem.Text = "Toda la música";
            this.todaLaMúsicaToolStripMenuItem.Click += new System.EventHandler(this.todaLaMúsicaToolStripMenuItem_Click);
            // 
            // listasDeReproducciónToolStripMenuItem
            // 
            this.listasDeReproducciónToolStripMenuItem.Name = "listasDeReproducciónToolStripMenuItem";
            this.listasDeReproducciónToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listasDeReproducciónToolStripMenuItem.Text = "Listas de Reproducción";
            this.listasDeReproducciónToolStripMenuItem.Click += new System.EventHandler(this.listasDeReproducciónToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(425, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "+ Crear una nueva Lista de Reproducción";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Título,
            this.Artista,
            this.Álbum,
            this.Duración});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 219);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(762, 199);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Título
            // 
            this.Título.HeaderText = "Título";
            this.Título.Name = "Título";
            this.Título.Width = 60;
            // 
            // Artista
            // 
            this.Artista.HeaderText = "Artista";
            this.Artista.Name = "Artista";
            this.Artista.Width = 61;
            // 
            // Álbum
            // 
            this.Álbum.HeaderText = "Álbum";
            this.Álbum.Name = "Álbum";
            this.Álbum.Width = 61;
            // 
            // Duración
            // 
            this.Duración.HeaderText = "Duración (Segundos)";
            this.Duración.Name = "Duración";
            this.Duración.Width = 121;
            // 
            // btnNuevaCanción
            // 
            this.btnNuevaCanción.BackColor = System.Drawing.Color.Blue;
            this.btnNuevaCanción.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevaCanción.Location = new System.Drawing.Point(28, 160);
            this.btnNuevaCanción.Name = "btnNuevaCanción";
            this.btnNuevaCanción.Size = new System.Drawing.Size(199, 28);
            this.btnNuevaCanción.TabIndex = 6;
            this.btnNuevaCanción.Text = "+ Agregar canción a la lista";
            this.btnNuevaCanción.UseVisualStyleBackColor = false;
            this.btnNuevaCanción.Visible = false;
            this.btnNuevaCanción.Click += new System.EventHandler(this.btnNuevaCanción_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(25, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Elige una Lista de Reproducción";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(25, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ordenar lista por:";
            this.label4.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nombre (ascendente)",
            "Nombre (descendente)",
            "Duración (ascendente)",
            "Duración (descendente)"});
            this.comboBox2.Location = new System.Drawing.Point(28, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(226, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 106);
            this.label5.TabIndex = 11;
            this.label5.Text = "RHYTHMN";
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(521, 450);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(114, 67);
            this.Reproductor.TabIndex = 12;
            this.Reproductor.Visible = false;
            // 
            // ReproducirLista
            // 
            this.ReproducirLista.BackColor = System.Drawing.Color.DarkGreen;
            this.ReproducirLista.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReproducirLista.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReproducirLista.Location = new System.Drawing.Point(21, 441);
            this.ReproducirLista.Name = "ReproducirLista";
            this.ReproducirLista.Size = new System.Drawing.Size(165, 76);
            this.ReproducirLista.TabIndex = 13;
            this.ReproducirLista.Text = "REPRODUCIR LISTA";
            this.ReproducirLista.UseVisualStyleBackColor = false;
            this.ReproducirLista.Visible = false;
            this.ReproducirLista.Click += new System.EventHandler(this.ReproducirLista_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(240, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 22);
            this.label6.TabIndex = 17;
            // 
            // anterior
            // 
            this.anterior.Image = global::ED2___Lab_0.Properties.Resources.anterior;
            this.anterior.Location = new System.Drawing.Point(244, 452);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(55, 56);
            this.anterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anterior.TabIndex = 16;
            this.anterior.TabStop = false;
            this.anterior.Visible = false;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // siguiente
            // 
            this.siguiente.Image = global::ED2___Lab_0.Properties.Resources.siguiente;
            this.siguiente.Location = new System.Drawing.Point(385, 452);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(55, 56);
            this.siguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siguiente.TabIndex = 15;
            this.siguiente.TabStop = false;
            this.siguiente.Visible = false;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // playPausa
            // 
            this.playPausa.Image = global::ED2___Lab_0.Properties.Resources.pausa__1_;
            this.playPausa.Location = new System.Drawing.Point(313, 452);
            this.playPausa.Name = "playPausa";
            this.playPausa.Size = new System.Drawing.Size(55, 56);
            this.playPausa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playPausa.TabIndex = 14;
            this.playPausa.TabStop = false;
            this.playPausa.Visible = false;
            this.playPausa.Click += new System.EventHandler(this.playPausa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ED2___Lab_0.Properties.Resources._35_Music_Player_icon_icons_com_61459;
            this.pictureBox1.Location = new System.Drawing.Point(70, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panelLista
            // 
            this.panelLista.BackgroundImage = global::ED2___Lab_0.Properties.Resources.the_walkmen_band_members_instruments_record_4493_1920x1080;
            this.panelLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLista.Controls.Add(this.exit1);
            this.panelLista.Controls.Add(this.label1);
            this.panelLista.Controls.Add(this.btnAgregarLista);
            this.panelLista.Controls.Add(this.txtNombreLista);
            this.panelLista.Location = new System.Drawing.Point(436, 76);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(279, 121);
            this.panelLista.TabIndex = 3;
            this.panelLista.Visible = false;
            // 
            // exit1
            // 
            this.exit1.BackColor = System.Drawing.Color.Red;
            this.exit1.Location = new System.Drawing.Point(253, 0);
            this.exit1.Name = "exit1";
            this.exit1.Size = new System.Drawing.Size(26, 23);
            this.exit1.TabIndex = 3;
            this.exit1.Text = "X";
            this.exit1.UseVisualStyleBackColor = false;
            this.exit1.Click += new System.EventHandler(this.exit1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escribe el nombre de tu nueva lista";
            // 
            // btnAgregarLista
            // 
            this.btnAgregarLista.BackColor = System.Drawing.Color.Lime;
            this.btnAgregarLista.Location = new System.Drawing.Point(107, 87);
            this.btnAgregarLista.Name = "btnAgregarLista";
            this.btnAgregarLista.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarLista.TabIndex = 1;
            this.btnAgregarLista.Text = "Crear";
            this.btnAgregarLista.UseVisualStyleBackColor = false;
            this.btnAgregarLista.Click += new System.EventHandler(this.btnAgregarLista_Click);
            // 
            // txtNombreLista
            // 
            this.txtNombreLista.Location = new System.Drawing.Point(38, 41);
            this.txtNombreLista.Name = "txtNombreLista";
            this.txtNombreLista.Size = new System.Drawing.Size(200, 20);
            this.txtNombreLista.TabIndex = 0;
            // 
            // panelCanción
            // 
            this.panelCanción.BackgroundImage = global::ED2___Lab_0.Properties.Resources.the_walkmen_band_members_instruments_record_4493_1920x1080;
            this.panelCanción.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCanción.Controls.Add(this.btnAgregarCanción);
            this.panelCanción.Controls.Add(this.label2);
            this.panelCanción.Controls.Add(this.txtNombreCanción);
            this.panelCanción.Controls.Add(this.exit2);
            this.panelCanción.Location = new System.Drawing.Point(435, 76);
            this.panelCanción.Name = "panelCanción";
            this.panelCanción.Size = new System.Drawing.Size(277, 121);
            this.panelCanción.TabIndex = 4;
            this.panelCanción.Visible = false;
            // 
            // btnAgregarCanción
            // 
            this.btnAgregarCanción.BackColor = System.Drawing.Color.Lime;
            this.btnAgregarCanción.Location = new System.Drawing.Point(102, 87);
            this.btnAgregarCanción.Name = "btnAgregarCanción";
            this.btnAgregarCanción.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCanción.TabIndex = 7;
            this.btnAgregarCanción.Text = "Agregar";
            this.btnAgregarCanción.UseVisualStyleBackColor = false;
            this.btnAgregarCanción.Click += new System.EventHandler(this.btnAgregarCanción_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Escribe el título de la canción que deseas agregar";
            // 
            // txtNombreCanción
            // 
            this.txtNombreCanción.Location = new System.Drawing.Point(37, 41);
            this.txtNombreCanción.Name = "txtNombreCanción";
            this.txtNombreCanción.Size = new System.Drawing.Size(200, 20);
            this.txtNombreCanción.TabIndex = 5;
            // 
            // exit2
            // 
            this.exit2.BackColor = System.Drawing.Color.Red;
            this.exit2.Location = new System.Drawing.Point(253, 0);
            this.exit2.Name = "exit2";
            this.exit2.Size = new System.Drawing.Size(26, 23);
            this.exit2.TabIndex = 4;
            this.exit2.Text = "X";
            this.exit2.UseVisualStyleBackColor = false;
            this.exit2.Click += new System.EventHandler(this.exit2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(70, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "haga doble click en una canción para reproducir";
            // 
            // Detener
            // 
            this.Detener.BackColor = System.Drawing.Color.DarkRed;
            this.Detener.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detener.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Detener.Location = new System.Drawing.Point(492, 441);
            this.Detener.Name = "Detener";
            this.Detener.Size = new System.Drawing.Size(165, 76);
            this.Detener.TabIndex = 19;
            this.Detener.Text = "DETENER MÚSICA";
            this.Detener.UseVisualStyleBackColor = false;
            this.Detener.Visible = false;
            this.Detener.Click += new System.EventHandler(this.Detener_Click);
            // 
            // RHYTHMN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(818, 576);
            this.Controls.Add(this.Detener);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.playPausa);
            this.Controls.Add(this.ReproducirLista);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNuevaCanción);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelCanción);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menú);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menú;
            this.Name = "RHYTHMN";
            this.Text = "RHYTHMN";
            this.Load += new System.EventHandler(this.RHYTHMN_Load);
            this.menú.ResumeLayout(false);
            this.menú.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            this.panelCanción.ResumeLayout(false);
            this.panelCanción.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menú;
        private System.Windows.Forms.ToolStripMenuItem biblioteclaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todaLaMúsicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasDeReproducciónToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarLista;
        private System.Windows.Forms.TextBox txtNombreLista;
        private System.Windows.Forms.Panel panelCanción;
        private System.Windows.Forms.Button exit1;
        private System.Windows.Forms.Button exit2;
        private System.Windows.Forms.Button btnAgregarCanción;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCanción;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Álbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duración;
        private System.Windows.Forms.Button btnNuevaCanción;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.Button ReproducirLista;
        private System.Windows.Forms.PictureBox playPausa;
        private System.Windows.Forms.PictureBox siguiente;
        private System.Windows.Forms.PictureBox anterior;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Detener;
    }
}

