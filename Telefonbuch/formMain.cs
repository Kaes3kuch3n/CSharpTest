using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Telefonbuch
{
    public partial class formMain : Form
    {
        #region "Constants"
        private const string sKEY = "DD)Fbsly9!K§s;*D";
        private const string sIV = "'8iV1N_yu,V5D4WU";
        #endregion

        #region "Strings"
        string sPath;

        string sNumberType1 = "";
        string sNumberType2 = "";
        string sNumberType3 = "";
        string sNumberType4 = "";
        string sEmailType1 = "";
        string sEmailType2 = "";
        string sShowAsType = "NV";
        string sName = "";
        string sFirstName = "";
        string sNickName = "";
        string sTitle = "";
        string sStreet = "";
        string sStreet2 = "";
        string sHouseNumber = "";
        string sHouseNumber2 = "";
        string sZipCode = "";
        string sZipCode2 = "";
        string sCity = "";
        string sCity2 = "";
        string sCountry = "";
        string sCountry2 = "";
        string sWorkName = "";
        string sEmail1 = "";
        string sEmail2 = "";
        string sNotes = "";
        string sNr1 = "";
        string sNr2 = "";
        string sNr3 = "";
        string sNr4 = "";
        string sCC1 = "";
        string sCC2 = "";
        string sCC3 = "";
        string sCC4 = "";
        string sAC1 = "";
        string sAC2 = "";
        string sAC3 = "";
        string sAC4 = "";
        string sBirthday = "";
        #endregion

        #region "Integers"
        int iGender;
        #endregion

        #region "Sonstiges"
        Image imgContact = Telefonbuch.Properties.Resources.contact;
        Preview p;
        #endregion

        public formMain()
        {
            InitializeComponent();
        }

        #region "GUI-Functions"

        //Button "Neuer Kontakt"
        private void btnNew_Click(object sender, EventArgs e)
        {
            tabControlContactInfos.Visible = true;
            btnPreview.Visible = true;
            btnNew.Visible = false;
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

        //Button "Vorschau"
        private void btnPreview_Click(object sender, EventArgs e)
        {
            saveVars();

            p = new Preview(sName, sFirstName, sShowAsType, iGender);
            p.SetGeneralVars(sNickName, sTitle, sBirthday, imgContact);
            p.SetPhoneNumberVars(sCC1, sCC2, sCC3, sCC4, sAC1, sAC2, sAC3, sAC4, sNr1, sNr2, sNr3, sNr4, sNumberType1, sNumberType2, sNumberType3, sNumberType4);
            p.SetAddressVars(sStreet, sHouseNumber, sZipCode, sCity, sCountry);
            p.SetWorkAddressVars(sWorkName, sStreet2, sHouseNumber2, sZipCode2, sCity2, sCountry2);
            p.SetOtherVars(sEmail1, sEmail2, sEmailType1, sEmailType2, sNotes);

            if (p.ShowPreview())
            {
                btnSave.Visible = true;
                btnEdit.Visible = true;
                btnOpen.Visible = false;
                btnPreview.Visible = false;
                tabControlContactInfos.Enabled = false;
            }

        }

        //Button "Bearbeiten"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnSave.Visible = false;
            btnOpen.Visible = true;
            btnPreview.Visible = true;
            tabControlContactInfos.Enabled = true;
        }

        //Button "Öffnen"
        private void btnOpen_Click(object sender, EventArgs e)
        {
            formOpen openForm = new formOpen();

            openForm.CancelOpenForm += OpenCanceled;
            openForm.AcceptOpenForm += OpenAccepted;

            openForm.Show();
        }
        
        //Button "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
            sPath = Directory.GetCurrentDirectory() + "\\contacts\\";
            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }

            Contact c = new Contact(p);
            if (c.SaveContact(sPath, sKEY, sIV))
            {
                MessageBox.Show("Der Kontakt wurde gespeichert!", "Gespeichert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.btnNew.Visible = true;
                this.btnOpen.Visible = true;
                this.btnPreview.Visible = false;
                this.btnEdit.Visible = false;
                this.btnSave.Visible = false;
                this.tabControlContactInfos.Enabled = true;
                this.tabControlContactInfos.Visible = false;
                
                ClearAllContent();
            }
        }

        #endregion

        //Open contact
        private void OpenAccepted(string file)
        {
            throw new NotImplementedException();
        }

        //Cancel open contact
        private void OpenCanceled()
        {
            throw new NotImplementedException();
        }

        //Save form content to vars
        void saveVars()
        {
            sName = txtName.Text;
            sFirstName = txtFirstName.Text;
            sNickName = txtNickname.Text;
            sTitle = txtTitle.Text;
            sBirthday = txtBirthday.Text;
            imgContact = pictureBoxContact.Image;
            sStreet = txtStreet.Text;
            sHouseNumber = txtHouseNumber.Text;
            sZipCode = txtZipCode.Text;
            sCity = txtCity.Text;
            sCountry = txtCountry.Text;
            sWorkName = txtWorkName.Text;
            sStreet2 = txtStreet2.Text;
            sHouseNumber2 = txtHouseNumber2.Text;
            sZipCode2 = txtZipCode2.Text;
            sCity2 = txtCity2.Text;
            sCountry2 = txtCountry2.Text;
            sEmail1 = txtEmail1.Text;
            sEmail2 = txtEmail2.Text;
            sNotes = txtNotes.Text;

            sNr1 = txtNumber1.Text;
            sNr2 = txtNumber2.Text;
            sNr3 = txtNumber3.Text;
            sNr4 = txtNumber4.Text;
            sCC1 = txtCC1.Text;
            sCC2 = txtCC2.Text;
            sCC3 = txtCC3.Text;
            sCC4 = txtCC4.Text;
            sAC1 = txtAC1.Text;
            sAC2 = txtAC2.Text;
            sAC3 = txtAC3.Text;
            sAC4 = txtAC4.Text;


            if (rbFemale.Checked)
            {
                iGender = 0;
            }
            else if (rbMale.Checked)
            {
                iGender = 1;
            }
            else
            {
                iGender = 2;
            }
        }
        
        void ClearAllContent()
        {
            cbNumber1.SelectedIndex = -1;
            txtCC1.Text = "49";
            txtAC1.Text = "";
            txtNumber1.Text = "";
            cbNumber2.SelectedIndex = -1;
            txtCC2.Text = "49";
            txtAC2.Text = "";
            txtNumber2.Text = "";
            cbNumber3.SelectedIndex = -1;
            txtCC3.Text = "49";
            txtAC3.Text = "";
            txtNumber3.Text = "";
            cbNumber4.SelectedIndex = -1;
            txtCC4.Text = "49";
            txtAC4.Text = "";
            txtNumber4.Text = "";
            cbEmail1.SelectedIndex = -1;
            txtEmail1.Text = "";
            cbEmail2.SelectedIndex = -1;
            txtEmail2.Text = "";
            pictureBoxContact.Image = Properties.Resources.contact;
            imgContact = Properties.Resources.contact;
            cbShowAs.SelectedIndex = -1;
            rbFemale.Checked = true;
            txtNotes.Text = "";
            txtName.Text = "";
            txtFirstName.Text = "";
            txtNickname.Text = "";
            txtTitle.Text = "";
            txtBirthday.Text = "";
            txtStreet.Text = "";
            txtHouseNumber.Text = "";
            txtZipCode.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtWorkName.Text = "";
            txtStreet2.Text = "";
            txtHouseNumber2.Text = "";
            txtZipCode2.Text = "";
            txtCity2.Text = "";
            txtCountry2.Text = "";
        }
    }
}
