namespace VenteChandails
{
    partial class VenteChandailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenteChandailsForm));
            this.venteChandailsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clientsGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.venteGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPrixDisplayLabel = new System.Windows.Forms.Label();
            this.prixDisplayLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.prixTotalLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.tailleLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.venteChandailsMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.clientsGroupBox.SuspendLayout();
            this.venteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // venteChandailsMenuStrip
            // 
            this.venteChandailsMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.venteChandailsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem});
            this.venteChandailsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.venteChandailsMenuStrip.Name = "venteChandailsMenuStrip";
            this.venteChandailsMenuStrip.Size = new System.Drawing.Size(460, 28);
            this.venteChandailsMenuStrip.TabIndex = 0;
            this.venteChandailsMenuStrip.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.transactionToolStripMenuItem.Text = "&Transaction";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // clientsGroupBox
            // 
            this.clientsGroupBox.Controls.Add(this.dateTextBox);
            this.clientsGroupBox.Controls.Add(this.nomTextBox);
            this.clientsGroupBox.Controls.Add(this.dateLabel);
            this.clientsGroupBox.Controls.Add(this.nomLabel);
            this.clientsGroupBox.ForeColor = System.Drawing.Color.White;
            this.clientsGroupBox.Location = new System.Drawing.Point(23, 270);
            this.clientsGroupBox.Name = "clientsGroupBox";
            this.clientsGroupBox.Size = new System.Drawing.Size(406, 100);
            this.clientsGroupBox.TabIndex = 2;
            this.clientsGroupBox.TabStop = false;
            this.clientsGroupBox.Text = "Information du client";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(103, 65);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(261, 22);
            this.dateTextBox.TabIndex = 3;
            // 
            // nomTextBox
            // 
            this.nomTextBox.BackColor = System.Drawing.Color.White;
            this.nomTextBox.Location = new System.Drawing.Point(103, 34);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(261, 22);
            this.nomTextBox.TabIndex = 2;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(32, 65);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 17);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date:";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.ForeColor = System.Drawing.Color.White;
            this.nomLabel.Location = new System.Drawing.Point(32, 34);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(41, 17);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom:";
            // 
            // venteGroupBox
            // 
            this.venteGroupBox.Controls.Add(this.totalPrixDisplayLabel);
            this.venteGroupBox.Controls.Add(this.prixDisplayLabel);
            this.venteGroupBox.Controls.Add(this.comboBox2);
            this.venteGroupBox.Controls.Add(this.comboBox1);
            this.venteGroupBox.Controls.Add(this.prixTotalLabel);
            this.venteGroupBox.Controls.Add(this.priceLabel);
            this.venteGroupBox.Controls.Add(this.tailleLabel);
            this.venteGroupBox.Controls.Add(this.teamLabel);
            this.venteGroupBox.ForeColor = System.Drawing.Color.White;
            this.venteGroupBox.Location = new System.Drawing.Point(23, 402);
            this.venteGroupBox.Name = "venteGroupBox";
            this.venteGroupBox.Size = new System.Drawing.Size(406, 201);
            this.venteGroupBox.TabIndex = 3;
            this.venteGroupBox.TabStop = false;
            this.venteGroupBox.Text = "Vente";
            // 
            // totalPrixDisplayLabel
            // 
            this.totalPrixDisplayLabel.BackColor = System.Drawing.Color.White;
            this.totalPrixDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPrixDisplayLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.totalPrixDisplayLabel.Location = new System.Drawing.Point(115, 156);
            this.totalPrixDisplayLabel.Name = "totalPrixDisplayLabel";
            this.totalPrixDisplayLabel.Size = new System.Drawing.Size(169, 23);
            this.totalPrixDisplayLabel.TabIndex = 7;
            // 
            // prixDisplayLabel
            // 
            this.prixDisplayLabel.AutoEllipsis = true;
            this.prixDisplayLabel.BackColor = System.Drawing.Color.White;
            this.prixDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prixDisplayLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prixDisplayLabel.Location = new System.Drawing.Point(115, 118);
            this.prixDisplayLabel.Name = "prixDisplayLabel";
            this.prixDisplayLabel.Size = new System.Drawing.Size(169, 23);
            this.prixDisplayLabel.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(115, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(249, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // prixTotalLabel
            // 
            this.prixTotalLabel.AutoSize = true;
            this.prixTotalLabel.Location = new System.Drawing.Point(32, 156);
            this.prixTotalLabel.Name = "prixTotalLabel";
            this.prixTotalLabel.Size = new System.Drawing.Size(44, 17);
            this.prixTotalLabel.TabIndex = 3;
            this.prixTotalLabel.Text = "Total:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(32, 120);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 17);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Prix:";
            // 
            // tailleLabel
            // 
            this.tailleLabel.AutoSize = true;
            this.tailleLabel.Location = new System.Drawing.Point(28, 84);
            this.tailleLabel.Name = "tailleLabel";
            this.tailleLabel.Size = new System.Drawing.Size(46, 17);
            this.tailleLabel.TabIndex = 1;
            this.tailleLabel.Text = "Taille:";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(28, 48);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(56, 17);
            this.teamLabel.TabIndex = 0;
            this.teamLabel.Text = "Équipe:";
            // 
            // VenteChandailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(460, 615);
            this.Controls.Add(this.venteGroupBox);
            this.Controls.Add(this.clientsGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.venteChandailsMenuStrip);
            this.MainMenuStrip = this.venteChandailsMenuStrip;
            this.Name = "VenteChandailsForm";
            this.Text = "Vente de chandails";
            this.venteChandailsMenuStrip.ResumeLayout(false);
            this.venteChandailsMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.clientsGroupBox.ResumeLayout(false);
            this.clientsGroupBox.PerformLayout();
            this.venteGroupBox.ResumeLayout(false);
            this.venteGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip venteChandailsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox clientsGroupBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.GroupBox venteGroupBox;
        private System.Windows.Forms.Label tailleLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Label prixTotalLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label totalPrixDisplayLabel;
        private System.Windows.Forms.Label prixDisplayLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

