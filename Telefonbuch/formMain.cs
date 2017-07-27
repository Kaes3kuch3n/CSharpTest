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
        private const string sSUBPATH = "\\contacts\\";
        internal const string FILETYPE = ".card";
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
            sPath = Directory.GetCurrentDirectory() + sSUBPATH;
            OpenContact();
        }
        
        //Button "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
            sPath = Directory.GetCurrentDirectory() + sSUBPATH;
            SaveContact();
        }

        //Custom open dir path
        private void btnOpenCustom_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Kontakt-Ordner öffnen...";
            folderBrowser.ShowNewFolderButton = false;

            DialogResult dr = folderBrowser.ShowDialog();

            if (dr == DialogResult.OK)
            {
                sPath = folderBrowser.SelectedPath;
                OpenContact();
            }
        }

        //Custom save dir path
        private void btnSaveCustom_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Kontakt speichern unter...";
            folderBrowser.ShowNewFolderButton = true;

            DialogResult dr = folderBrowser.ShowDialog();

            if (dr == DialogResult.OK)
            {
                sPath = folderBrowser.SelectedPath;
                SaveContact();
            }
        }

        #endregion

        //Open contact
        private void OpenAccepted(string file)
        {
            tabControlContactInfos.Visible = true;
            tabControlContactInfos.Enabled = true;
            btnPreview.Visible = true;
            btnOpen.Visible = true;
            btnSave.Visible = false;
            btnEdit.Visible = false;
            btnNew.Visible = false;

            Contact c = new Contact();
            c = Contact.OpenContact(file, sKEY, sIV);

            switch (c.iGender)
            {
                case 0:
                    rbFemale.Checked = true;
                    break;
                case 1:
                    rbMale.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }

            pictureBoxContact.Image = Contact.StringToImage(c.sContactImage);
            txtName.Text = c.sName;
            txtFirstName.Text = c.sFirstName;
            txtNickname.Text = c.sNickName;
            txtTitle.Text = c.sTitle;
            txtBirthday.Text = c.dtBirthday.ToShortDateString();

            txtStreet.Text = c.sStreet;
            txtHouseNumber.Text = c.sHouseNr;
            txtZipCode.Text = c.sZipCode;
            txtCity.Text = c.sCity;
            txtCountry.Text = c.sCountry;
            txtWorkName.Text = c.sWorkName;
            txtStreet2.Text = c.sStreet2;
            txtHouseNumber2.Text = c.sHouseNr2;
            txtZipCode2.Text = c.sZipCode2;
            txtCity2.Text = c.sCity2;
            txtCountry2.Text = c.sCountry2;

            txtCC1.Text = c.sCC1;
            txtCC2.Text = c.sCC2;
            txtCC3.Text = c.sCC3;
            txtCC4.Text = c.sCC4;
            txtAC1.Text = c.iAC1.ToString();
            txtAC2.Text = c.iAC2.ToString();
            txtAC3.Text = c.iAC3.ToString();
            txtAC4.Text = c.iAC4.ToString();
            txtNumber1.Text = c.sNr1;
            txtNumber2.Text = c.sNr2;
            txtNumber3.Text = c.sNr3;
            txtNumber4.Text = c.sNr4;
            cbNumber1.SelectedIndex = SetSelectionNumbers(c.sNumberType1);
            cbNumber2.SelectedIndex = SetSelectionNumbers(c.sNumberType2);
            cbNumber3.SelectedIndex = SetSelectionNumbers(c.sNumberType3);
            cbNumber4.SelectedIndex = SetSelectionNumbers(c.sNumberType4);

            txtEmail1.Text = c.sMail1;
            txtEmail2.Text = c.sMail2;
            cbEmail1.SelectedIndex = SetSelectionMail(c.sMailType1);
            cbEmail2.SelectedIndex = SetSelectionMail(c.sMailType2);
            txtNotes.Text = c.sNotes;
        }
        private int SetSelectionNumbers(string sSel)
        {
            switch (sSel)
            {
                case "Privat":
                    return 0;
                case "Mobil":
                    return 1;
                case "Arbeit":
                    return 2;
                case "Andere":
                    return 3;
                default:
                    return -1;
            }
        }
        private int SetSelectionMail(string sSel)
        {
            switch (sSel)
            {
                case "Privat":
                    return 0;
                case "Arbeit":
                    return 1;
                case "Andere":
                    return 2;
                default:
                    return -1;
            }
        }
        private int SetSelectionShowAs(string sSel)
        {
            switch (sSel)
            {
                case "NV":
                    return 0;
                case "VN":
                    return 1;
                case "NVS":
                    return 2;
                case "TVN":
                    return 3;
                default:
                    return -1;
            }
        }

        //Cancel open contact
        private void OpenCanceled()
        {
            btnNew.Visible = true;
            btnEdit.Visible = false;
            btnOpen.Visible = true;
            btnPreview.Visible = false;
            btnSave.Visible = false;
            tabControlContactInfos.Enabled = true;
            tabControlContactInfos.Visible = false;

            ClearAllContent();
        }

        //Save
        private void SaveContact()
        {
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

        //Open
        private void OpenContact()
        {
            string[] sFiles = Directory.GetFiles(sPath, "*" + FILETYPE);

            formOpen openForm = new formOpen();

            openForm.CancelOpenForm += OpenCanceled;
            openForm.AcceptOpenForm += OpenAccepted;

            int imageIndex = 0;

            foreach (string file in sFiles)
            {
                Contact c = new Contact();
                c = Contact.OpenContact(file, sKEY, sIV);
                ListViewItem lvItem = new ListViewItem();

                FileInfo fileInfo = new FileInfo(file);
                string sShow = (fileInfo.Name).Replace(FILETYPE, "");

                string sGender;
                switch (c.iGender)
                {
                    case 0:
                        sGender = "Weiblich";
                        break;
                    case 1:
                        sGender = "Männlich";
                        break;
                    case 2:
                        sGender = "Anderes";
                        break;
                    default:
                        sGender = "-----";
                        break;
                }

                openForm.imageList.Images.Add(Contact.StringToImage(c.sContactImage));

                lvItem.Text = sShow;
                lvItem.ToolTipText = "Name:\t\t" + c.sName + "\nVorname:\t" + c.sFirstName + "\nSpitzname:\t" + c.sNickName + "\nTitel:\t" + c.sTitle + "\nGeschlecht:\t" + sGender;
                lvItem.ImageIndex = imageIndex;
                imageIndex++;
                lvItem.SubItems.Add(file);

                openForm.lvContacts.Items.Add(lvItem);
            }

            openForm.Show();
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
