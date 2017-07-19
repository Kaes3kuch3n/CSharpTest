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
    public partial class formMain : Form
    {
        #region "Variablen"

        #region "Strings"
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
        #endregion

        #region "Integers"
        int iGender;
        int iCC1;
        int iCC2;
        int iCC3;
        int iCC4;
        int iAC1;
        int iAC2;
        int iAC3;
        int iAC4;
        #endregion

        #region "Sonstiges"
        Image imgContact = Telefonbuch.Properties.Resources.contact;
        DateTime dtBirthday;
        #endregion

        #endregion

        public formMain()
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

        //Button "Vorschau"
        private void btnPreview_Click(object sender, EventArgs e)
        {
            saveVars();

            formPreview fPre = new formPreview();
            fPre.Text += prepareShowAsPreview(sName, sFirstName, sNickName, sTitle, sShowAsType);

            fPre.lblEmailPH1.Text = prepareMailPreview(sEmail1, sEmailType1);
            fPre.lblEmailPH2.Text = prepareMailPreview(sEmail2, sEmailType2);
            
            fPre.lblNumberPH1.Text = prepareNumbersPreview(sNumberType1, iCC1, iAC1, sNr1);
            fPre.lblNumberPH2.Text = prepareNumbersPreview(sNumberType2, iCC2, iAC2, sNr2);
            fPre.lblNumberPH3.Text = prepareNumbersPreview(sNumberType3, iCC3, iAC3, sNr3);
            fPre.lblNumberPH4.Text = prepareNumbersPreview(sNumberType4, iCC4, iAC4, sNr4);

            fPre.lblGenderPH.Text = prepareGenderPreview(iGender);

            fPre.lblNamePH.Text = sName;
            fPre.lblFirstNamePH.Text = sFirstName;
            fPre.lblNickNamePH.Text = sNickName;
            fPre.lblTitlePH.Text = sTitle;
            fPre.lblStreetPH.Text = sStreet;
            fPre.lblHouseNumberPH.Text = sHouseNumber;
            fPre.lblZipCodePH.Text = sZipCode;
            fPre.lblCityPH.Text = sCity;
            fPre.lblCountryPH.Text = sCountry;
            fPre.lblWorkNamePH.Text = sWorkName;
            fPre.lblStreetPH2.Text = sStreet2;
            fPre.lblHouseNumberPH2.Text = sHouseNumber2;
            fPre.lblZipCodePH2.Text = sZipCode2;
            fPre.lblCityPH2.Text = sCity2;
            fPre.lblCountryPH2.Text = sCountry2;
            fPre.lblNotesPH.Text = sNotes;

            fPre.lblBirthdayPH.Text = dtBirthday.ToString("dddd, dd.mm.yyyy");
            fPre.pictureBoxContact.Image = imgContact;

            fPre.Show();
        }

        //Check mail string for '@' and '.' chars
        string mailStringCheck(string mailAddress)
        {
            if (mailAddress != "")
            {
                if (!mailAddress.Contains("@") || !mailAddress.Contains("."))
                {
                    MessageBox.Show("Eine der eingegebenen eMail-Adressen ist ungültig!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return mailAddress;
        }

        //Save form content to vars
        void saveVars()
        {
            sName = txtName.Text;
            sFirstName = txtFirstName.Text;
            sNickName = txtNickname.Text;
            sTitle = txtTitle.Text;
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
            sEmail1 = mailStringCheck(txtEmail1.Text);
            sEmail2 = mailStringCheck(txtEmail2.Text);
            sNotes = txtNotes.Text;

            sNr1 = txtNumber1.Text;
            sNr2 = txtNumber2.Text;
            sNr3 = txtNumber3.Text;
            sNr4 = txtNumber4.Text;

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

            iCC1 = int.Parse(txtCC1.Text);
            iCC2 = int.Parse(txtCC2.Text);
            iCC3 = int.Parse(txtCC3.Text);
            iCC4 = int.Parse(txtCC4.Text);

            try
            {
                if (txtAC1.Text != "") iAC1 = int.Parse(txtAC1.Text);
                if (txtAC2.Text != "") iAC2 = int.Parse(txtAC2.Text);
                if (txtAC3.Text != "") iAC3 = int.Parse(txtAC3.Text);
                if (txtAC4.Text != "") iAC4 = int.Parse(txtAC4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte geben Sie nur Ziffern als Telefonnummern ein!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dtBirthday = datePickerBirthday.Value;
        }

        //Preview title
        string prepareShowAsPreview(string name, string firstName, string nickName, string title, string showAsType)
        {
            switch (showAsType)
            {
                case "NV":
                    return name + ", " + firstName;
                case "VN":
                    return firstName + " " + name;
                case "NVS":
                    return name + ", " + firstName + " (\"" + nickName + "\")";
                case "TVN":
                    return title + " " + firstName + " " + name;
                default:
                    return name + ", " + firstName;
            }
        }

        //Preview mail
        string prepareMailPreview(string email, string emailType)
        {
            if (email == "")
            {
                return "-----";
            }
            else
            {
                return email + " (" + emailType + ")";
            }
        }

        //Preview numbers
        string prepareNumbersPreview(string numberType, int cc, int ac, string number)
        {
            if (ac == 0 && number == "")
            {
                return "-----";
            }
            else
            {
                return "+" + cc + " " + ac + "/" + number + " (" + numberType + ")";
            }
        }

        //Preview gender
        string prepareGenderPreview(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Weiblich";
                case 1:
                    return "Männlich";
                case 2:
                    return "Anderes";
                default:
                    return "-----";
            }
        }
    }
}
