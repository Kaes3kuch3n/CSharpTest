using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefonbuch
{
    public partial class frameMain : Form
    {
        Image imgContact;

        public frameMain()
        {
            InitializeComponent();
        }

        //Button "Neuer Kontakt"
        private void btnNew_Click(object sender, EventArgs e)
        {
            tabControlContactInfos.Visible = true;
            btnPreview.Visible = true;
            btnSave.Visible = true;
        }

        //ComboBox "Anzeigen als" Auswahl geändert
        private void cbShowAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbShowAs.SelectedIndex)
            {
                //Name, Vorname
                //Vorname Name
                //Name, Vorname(Spitzname)
                //Titel Vorname Name
                case 0:
                    lblExample.Text = "Beispiel: " + txtName.Text + ", " + txtFirstName.Text;
                    break;
                case 1:
                    lblExample.Text = "Beispiel: " + txtFirstName.Text + " " + txtName.Text;
                    break;
                case 2:
                    lblExample.Text = "Beispiel: " + txtName.Text + ", " + txtFirstName.Text + " (\"" + txtNickname.Text + "\")";
                    break;
                case 3:
                    lblExample.Text = "Beispiel: " + txtTitle.Text + " " + txtFirstName.Text + " " + txtName.Text;
                    break;
                default:
                    lblExample.Text = "Beispiel: ";
                    break;
            }
        }

        //Kontaktbild setzen
        private void btnOpenPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Kontaktbild auswählen...";
            of.Multiselect = false;
            of.Filter = "Alle Bilder|*.bmp;*.gif;*.jpg;*.jpeg;*.jpe;*.jfif;*.png;*.tif;*.tiff|BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg;*.jpe;*.jfif|PNG|*.png|TIF|*.tif;*.tiff";
            of.FilterIndex = 0;
            DialogResult dr = of.ShowDialog();
            
            if (dr == DialogResult.OK)
            {
                imgContact = Image.FromFile(of.FileName);
                pictureBoxContact.Image = imgContact;
            }
        }
    }
}
