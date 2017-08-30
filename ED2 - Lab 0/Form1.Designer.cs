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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RHYTHMN));
            this.menú = new System.Windows.Forms.MenuStrip();
            this.biblioteclaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todaLaMúsicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasDeReproducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menú.SuspendLayout();
            this.SuspendLayout();
            // 
            // menú
            // 
            this.menú.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biblioteclaToolStripMenuItem});
            this.menú.Location = new System.Drawing.Point(0, 0);
            this.menú.Name = "menú";
            this.menú.Size = new System.Drawing.Size(728, 24);
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
            // 
            // listasDeReproducciónToolStripMenuItem
            // 
            this.listasDeReproducciónToolStripMenuItem.Name = "listasDeReproducciónToolStripMenuItem";
            this.listasDeReproducciónToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listasDeReproducciónToolStripMenuItem.Text = "Listas de Reproducción";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RHYTHMN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(728, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menú);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menú;
            this.Name = "RHYTHMN";
            this.Text = "RHYTHMN";
            this.menú.ResumeLayout(false);
            this.menú.PerformLayout();
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
    }
}

