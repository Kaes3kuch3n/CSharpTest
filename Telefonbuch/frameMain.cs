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
        string sNumberType1 = "";
        string sNumberType2 = "";
        string sNumberType3 = "";
        string sNumberType4 = "";
        string sEmailType1 = "";
        string sEmailType2 = "";
        string sShowAsType = "NV";

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
                    sShowAsType = "NV";
                    lblExample.Text = "Beispiel: " + txtName.Text + ", " + txtFirstName.Text;
                    break;
                case 1:
                    sShowAsType = "VN";
                    lblExample.Text = "Beispiel: " + txtFirstName.Text + " " + txtName.Text;
                    break;
                case 2:
                    sShowAsType = "NVS";
                    lblExample.Text = "Beispiel: " + txtName.Text + ", " + txtFirstName.Text + " (\"" + txtNickname.Text + "\")";
                    break;
                case 3:
                    sShowAsType = "TVN";
                    lblExample.Text = "Beispiel: " + txtTitle.Text + " " + txtFirstName.Text + " " + txtName.Text;
                    break;
                default:
                    sShowAsType = "NV";
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

        //ComboBoxes "Label" Auswahl geändert
        private void cBoxesChanged(object sender, EventArgs e)
        {
            ComboBox cBox = (ComboBox)sender;

            switch (cBox.Name)
            {
                case "cbNumber1":
                    if (cBox.SelectedIndex == -1)
                    {
                        sNumberType1 = "";
                    }
                    else
                    {
                        sNumberType1 = cBox.SelectedItem.ToString();
                    }
                    break;
                case "cbNumber2":
                    if (cBox.SelectedIndex == -1)
                    {
                        sNumberType2 = "";
                    }
                    else
                    {
                        sNumberType2 = cBox.SelectedItem.ToString();
                    }
                    break;
                case "cbNumber3":
                    if (cBox.SelectedIndex == -1)
                    {
                        sNumberType3 = "";
                    }
                    else
                    {
                        sNumberType3 = cBox.SelectedItem.ToString();
                    }
                    break;
                case "cbNumber4":
                    if (cBox.SelectedIndex == -1)
                    {
                        sNumberType4 = "";
                    }
                    else
                    {
                        sNumberType4 = cBox.SelectedItem.ToString();
                    }
                    break;
                case "cbEmail1":
                    if (cBox.SelectedIndex == -1)
                    {
                        sEmailType1 = "";
                    }
                    else
                    {
                        sEmailType1 = cBox.SelectedItem.ToString();
                    }
                    break;
                case "cbEmail2":
                    if (cBox.SelectedIndex == -1)
                    {
                        sEmailType2 = "";
                    }
                    else
                    {
                        sEmailType2 = cBox.SelectedItem.ToString();
                    }
                    break;
            }
        }

        //Button "Delete"
        private void btnDeleteClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "btnDelNumber1":
                    cbNumber1.SelectedIndex = -1;
                    txtCC1.Text = "49";
                    txtAC1.Text = "";
                    txtNumber1.Text = "";
                    break;
                case "btnDelNumber2":
                    cbNumber2.SelectedIndex = -1;
                    txtCC2.Text = "49";
                    txtAC2.Text = "";
                    txtNumber2.Text = "";
                    break;
                case "btnDelNumber3":
                    cbNumber3.SelectedIndex = -1;
                    txtCC3.Text = "49";
                    txtAC3.Text = "";
                    txtNumber3.Text = "";
                    break;
                case "btnDelNumber4":
                    cbNumber4.SelectedIndex = -1;
                    txtCC4.Text = "49";
                    txtAC4.Text = "";
                    txtNumber4.Text = "";
                    break;
                case "btnDelEmail1":
                    cbEmail1.SelectedIndex = -1;
                    txtEmail1.Text = "";
                    break;
                case "btnDelEmail2":
                    cbEmail2.SelectedIndex = -1;
                    txtEmail2.Text = "";
                    break;
            }
        }
    }
}
