namespace Telefonbuch
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblVornname = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNummer = new System.Windows.Forms.TextBox();
            this.lblNummer = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.txtEintraege = new System.Windows.Forms.RichTextBox();
            this.cbAlles = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblVornname
            // 
            this.lblVornname.AutoSize = true;
            this.lblVornname.Location = new System.Drawing.Point(12, 15);
            this.lblVornname.Name = "lblVornname";
            this.lblVornname.Size = new System.Drawing.Size(52, 13);
            this.lblVornname.TabIndex = 0;
            this.lblVornname.Text = "Vorname:";
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(101, 12);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(185, 20);
            this.txtVorname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtNummer
            // 
            this.txtNummer.Location = new System.Drawing.Point(101, 64);
            this.txtNummer.Name = "txtNummer";
            this.txtNummer.Size = new System.Drawing.Size(185, 20);
            this.txtNummer.TabIndex = 5;
            // 
            // lblNummer
            // 
            this.lblNummer.AutoSize = true;
            this.lblNummer.Location = new System.Drawing.Point(12, 67);
            this.lblNummer.Name = "lblNummer";
            this.lblNummer.Size = new System.Drawing.Size(83, 13);
            this.lblNummer.TabIndex = 4;
            this.lblNummer.Text = "Telefonnummer:";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(72, 99);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichern.TabIndex = 6;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLoeschen.Location = new System.Drawing.Point(153, 99);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btnLoeschen.TabIndex = 7;
            this.btnLoeschen.Text = "Löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // txtEintraege
            // 
            this.txtEintraege.Location = new System.Drawing.Point(310, 12);
            this.txtEintraege.Name = "txtEintraege";
            this.txtEintraege.ReadOnly = true;
            this.txtEintraege.Size = new System.Drawing.Size(264, 336);
            this.txtEintraege.TabIndex = 8;
            this.txtEintraege.Text = "";
            // 
            // cbAlles
            // 
            this.cbAlles.AutoSize = true;
            this.cbAlles.Location = new System.Drawing.Point(153, 128);
            this.cbAlles.Name = "cbAlles";
            this.cbAlles.Size = new System.Drawing.Size(54, 17);
            this.cbAlles.TabIndex = 15;
            this.cbAlles.Text = "Alles?";
            this.cbAlles.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.cbAlles);
            this.Controls.Add(this.txtEintraege);
            this.Controls.Add(this.btnLoeschen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.txtNummer);
            this.Controls.Add(this.lblNummer);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.lblVornname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefonbuch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVornname;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNummer;
        private System.Windows.Forms.Label lblNummer;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.RichTextBox txtEintraege;
        private System.Windows.Forms.CheckBox cbAlles;
    }
}

