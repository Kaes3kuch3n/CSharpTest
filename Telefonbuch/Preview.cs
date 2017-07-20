using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefonbuch
{
    public class Preview
    {
        internal string sSaveName;

        #region "Constructor-Variables"

        internal string sName;
        internal string sFirstName;
        internal string sShowAs;
        internal int iGender;

        #endregion

        #region "General"

        internal string sNickName;
        internal string sTitle;
        private string sBirthday;
        internal DateTime dtBirthday;
        internal Image imgContactImage;

        #endregion

        #region "Phone Numbers"

        internal string sNumberType1;
        internal string sNumberType2;
        internal string sNumberType3;
        internal string sNumberType4;
        internal string sNr1;
        internal string sNr2;
        internal string sNr3;
        internal string sNr4;
        internal string sCC1;
        internal string sCC2;
        internal string sCC3;
        internal string sCC4;
        private string sAC1;
        private string sAC2;
        private string sAC3;
        private string sAC4;
        internal int iAC1;
        internal int iAC2;
        internal int iAC3;
        internal int iAC4;

        #endregion

        #region "Address"

        internal string sStreet;
        internal string sHouseNr;
        internal string sZipCode;
        internal string sCity;
        internal string sCountry;

        #endregion

        #region "Work Address"

        internal string sWorkName;
        internal string sStreet2;
        internal string sHouseNr2;
        internal string sZipCode2;
        internal string sCity2;
        internal string sCountry2;

        #endregion

        #region "Other"

        internal string sMailType1;
        internal string sMailType2;
        internal string sMail1;
        internal string sMail2;
        internal string sNotes;

        #endregion


        /// <summary>
        /// Konstruktor der Klasse Preview.
        /// </summary>
        /// <param name="name">Nachname des Kontaktes</param>
        /// <param name="firstName">Vorname des Kontaktes</param>
        /// <param name="showAs">Anzeigeart des Kontaktes: NV, VN, NVS oder TVN</param>
        /// <param name="gender">Geschlecht des Kontaktes</param>
        public Preview(string name, string firstName, string showAs, int gender)
        {
            this.sName = name;
            this.sFirstName = firstName;
            this.sShowAs = showAs;
            this.iGender = gender;
        }

        #region "Set Vars"

        /// <summary>
        /// Setzt die Variablen des Tabs "Allgemein".
        /// </summary>
        /// <param name="nickName">Spitzname des Kontaktes</param>
        /// <param name="title">Titel des Kontaktes</param>
        /// <param name="birthday">Geburtstag des Kontaktes</param>
        /// <param name="contactImage">Foto des Kontaktes</param>
        public void SetGeneralVars(string nickName, string title, string birthday, Image contactImage)
        {
            this.sNickName = nickName;
            this.sTitle = title;
            this.sBirthday = birthday;
            this.imgContactImage = contactImage;
        }

        /// <summary>
        /// Setzt die Variablen des Tabs "Telefonnummern"
        /// </summary>
        /// <param name="cc1">Länderkennung #1</param>
        /// <param name="cc2">Länderkennung #2</param>
        /// <param name="cc3">Länderkennung #3</param>
        /// <param name="cc4">Länderkennung #4</param>
        /// <param name="ac1">Vorwahl #1</param>
        /// <param name="ac2">Vorwahl #2</param>
        /// <param name="ac3">Vorwahl #3</param>
        /// <param name="ac4">Vorwahl #4</param>
        /// <param name="nr1">Telefonnummer #1</param>
        /// <param name="nr2">Telefonnummer #2</param>
        /// <param name="nr3">Telefonnummer #3</param>
        /// <param name="nr4">Telefonnummer #4</param>
        /// <param name="numberType1">Art der Nummer #1</param>
        /// <param name="numberType2">Art der Nummer #2</param>
        /// <param name="numberType3">Art der Nummer #3</param>
        /// <param name="numberType4">Art der Nummer #4</param>
        public void SetPhoneNumberVars(string cc1, string cc2, string cc3, string cc4, string ac1, string ac2, string ac3, string ac4, string nr1, string nr2, string nr3, string nr4, 
                                        string numberType1, string numberType2, string numberType3, string numberType4)
        {
            this.sCC1 = cc1;
            this.sCC2 = cc2;
            this.sCC3 = cc3;
            this.sCC4 = cc4;
            this.sAC1 = ac1;
            this.sAC2 = ac2;
            this.sAC3 = ac3;
            this.sAC4 = ac4;
            this.sNr1 = nr1;
            this.sNr2 = nr2;
            this.sNr3 = nr3;
            this.sNr4 = nr4;
            this.sNumberType1 = numberType1;
            this.sNumberType2 = numberType2;
            this.sNumberType3 = numberType3;
            this.sNumberType4 = numberType4;
        }

        /// <summary>
        /// Setzt die Variablen des Tabs "Adresse" für die Privat-Adresse
        /// </summary>
        /// <param name="street">Straßenname</param>
        /// <param name="houseNr">Hausnummer</param>
        /// <param name="zipCode">Postleitzahl</param>
        /// <param name="city">Stadtname</param>
        /// <param name="country">Ländername</param>
        public void SetAddressVars(string street, string houseNr, string zipCode, string city, string country)
        {
            this.sStreet = street;
            this.sHouseNr = houseNr;
            this.sZipCode = zipCode;
            this.sCity = city;
            this.sCountry = country;
        }

        /// <summary>
        /// Setzt die Variablen des Tabs "Adresse" für die Arbeits-Adresse
        /// </summary>
        /// <param name="workName">Name der Firma</param>
        /// <param name="street">Straßenname</param>
        /// <param name="houseNr">Hausnummer</param>
        /// <param name="zipCode">Postleitzahl</param>
        /// <param name="city">Stadtname</param>
        /// <param name="country">Ländername</param>
        public void SetWorkAddressVars(string workName, string street, string houseNr, string zipCode, string city, string country)
        {
            this.sWorkName = workName;
            this.sStreet2 = street;
            this.sHouseNr2 = houseNr;
            this.sZipCode2 = zipCode;
            this.sCity2 = city;
            this.sCountry2 = country;
        }

        /// <summary>
        /// Setzt die Variablen des Tabs "Sonstiges"
        /// </summary>
        /// <param name="mail1">eMail-Adresse #1</param>
        /// <param name="mail2">eMail-Adresse #2</param>
        /// <param name="mailType1">eMail-Art #1</param>
        /// <param name="mailType2">eMail-Art #2</param>
        /// <param name="notes">Notizen</param>
        public void SetOtherVars(string mail1, string mail2, string mailType1, string mailType2, string notes)
        {
            this.sMail1 = mail1;
            this.sMail2 = mail2;
            this.sMailType1 = mailType1;
            this.sMailType2 = mailType2;
            this.sNotes = notes;
        }

        #endregion

        /// <summary>
        /// Blendet das Preview-Fenster ein. Zuvor wird eine Überprüfung auf Vollständigkeit und Formfehler durchgeführt.
        /// </summary>
        public bool ShowPreview()
        {
            if (CheckIfOkay())
            {
                formPreview fPre = new formPreview();
                fPre.Text += prepareShowAsPreview(sName, sFirstName, sNickName, sTitle, sShowAs);

                fPre.lblEmailPH1.Text = prepareMailPreview(sMail1, sMailType1);
                fPre.lblEmailPH2.Text = prepareMailPreview(sMail2, sMailType2);

                fPre.lblNumberPH1.Text = prepareNumbersPreview(sNumberType1, sCC1, iAC1, sNr1);
                fPre.lblNumberPH2.Text = prepareNumbersPreview(sNumberType2, sCC2, iAC2, sNr2);
                fPre.lblNumberPH3.Text = prepareNumbersPreview(sNumberType3, sCC3, iAC3, sNr3);
                fPre.lblNumberPH4.Text = prepareNumbersPreview(sNumberType4, sCC4, iAC4, sNr4);

                fPre.lblGenderPH.Text = prepareGenderPreview(iGender);

                fPre.lblNamePH.Text = sName;
                fPre.lblFirstNamePH.Text = sFirstName;
                fPre.lblNickNamePH.Text = sNickName;
                fPre.lblTitlePH.Text = sTitle;
                fPre.lblStreetPH.Text = sStreet;
                fPre.lblHouseNumberPH.Text = sHouseNr;
                fPre.lblZipCodePH.Text = sZipCode;
                fPre.lblCityPH.Text = sCity;
                fPre.lblCountryPH.Text = sCountry;
                fPre.lblWorkNamePH.Text = sWorkName;
                fPre.lblStreetPH2.Text = sStreet2;
                fPre.lblHouseNumberPH2.Text = sHouseNr2;
                fPre.lblZipCodePH2.Text = sZipCode2;
                fPre.lblCityPH2.Text = sCity2;
                fPre.lblCountryPH2.Text = sCountry2;
                fPre.lblNotesPH.Text = sNotes;

                if (sBirthday != "  ,  ,") fPre.lblBirthdayPH.Text = dtBirthday.ToString("dddd, dd.MM.yyyy");
                
                fPre.pictureBoxContact.Image = imgContactImage;

                fPre.Show();

                return true;
            }
            else return false;
        }

        private bool CheckIfOkay()
        {
            if (CheckEssential())
            {
                if (CheckOthers())
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        private bool CheckEssential()
        {
            bool isOkay = true;
            string sMessage = "";

            if (sName == "" && sFirstName == "")
            {
                isOkay = false;
                sMessage += "Es wurde kein Name eingegeben";
            }

            #region "Check Country Codes"
            try
            {
                if (sCC1 != "") int.Parse(this.sCC1);
            }
            catch (FormatException)
            {
                isOkay = false;
                sMessage += "Die Länderkennung von #1 ist ungültig!\n";
            }

            try
            {
                if (sCC2 != "") int.Parse(this.sCC2);
            }
            catch (FormatException)
            {
                isOkay = false;
                sMessage += "Die Länderkennung von #2 ist ungültig!\n";
            }

            try
            {
                if (sCC3 != "") int.Parse(this.sCC3);
            }
            catch (FormatException)
            {
                isOkay = false;
                sMessage += "Die Länderkennung von #3 ist ungültig!\n";
            }

            try
            {
                if (sCC4 != "") int.Parse(this.sCC4);
            }
            catch (FormatException)
            {
                isOkay = false;
                sMessage += "Die Länderkennung von #4 ist ungültig!\n";
            }
            #endregion

            #region "Check and convert Area Codes"
            try
            {
                if (sAC1 != "") this.iAC1 = int.Parse(this.sAC1);
            }
            catch (FormatException)
            {
                isOkay = false;
                sMessage += "Die Vorwahl von #1 ist ungültig!\n";
            }

            try
            {
                if (sAC2 != "") this.iAC2 = int.Parse(this.sAC2);
            }
            catch (FormatException)
            {
                isOkay = false;
                sMessage += "Die Vorwahl von #2 ist ungültig!\n";
            }

            try
            {
                if (sAC3 != "") this.iAC3 = int.Parse(this.sAC3);
            }
            catch (FormatException)
            {
                isOkay = false;
                sMessage += "Die Vorwahl von #3 ist ungültig!\n";
            }

            try
            {
                if (sAC4 != "") this.iAC4 = int.Parse(this.sAC4);
            }
            catch (FormatException)
            {
                isOkay = false;
                sMessage += "Die Vorwahl von #4 ist ungültig!\n";
            }
            #endregion

            #region "Check Phone Numbers"
            try
            {
                if (sNr1 != "") int.Parse(this.sNr1);
            }
            catch (FormatException)
            {
                isOkay = false;
                sMessage += "Die Rufnummer von #1 ist ungültig!\n";
            }

            try
            {
                if (sNr2 != "") int.Parse(this.sNr2);
            }
            catch (FormatException)
            {
                isOkay = false;
                sMessage += "Die Rufnummer von #2 ist ungültig!\n";
            }

            try
            {
                if (sNr3 != "") int.Parse(this.sNr3);
            }
            catch (FormatException)
            {
                isOkay = false;
                sMessage += "Die Rufnummer von #3 ist ungültig!\n";
            }

            try
            {
                if (sNr4 != "") int.Parse(this.sNr4);
            }
            catch (FormatException)
            {
                isOkay = false;
                sMessage += "Die Rufnummer von #4 ist ungültig!\n";
            }
            #endregion

            if (!isOkay)
            {
                MessageBox.Show("Vorschau konnte nicht erstellt werden:\n\n" + sMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isOkay;
        }

        private bool CheckOthers()
        {
            bool isOkay = true;
            string sMessage = "";

            if (sBirthday != "  ,  ,")
            {
                try
                {
                    dtBirthday = DateTime.Parse(sBirthday);
                }
                catch (FormatException)
                {
                    isOkay = false;
                    sMessage += "Das angegebene Geburtsdatum ist ungültig!\n";
                }
            }

            if (sMail1 != "" && (!sMail1.Contains("@") || !sMail1.Contains(".")))
            {
                isOkay = false;
                sMessage += "Die 1. Mail-Adresse ist ungültig, da sie kein '@'-Zeichen/kein '.'-Zeichen enthält!\n";
            }
            if (sMail2 != "" && (!sMail2.Contains("@") || !sMail2.Contains(".")))
            {
                isOkay = false;
                sMessage += "Die 2. Mail-Adresse ist ungültig, da sie kein '@'-Zeichen/kein '.'-Zeichen enthält!\n";
            }

            if (!isOkay)
            {
                DialogResult dr = MessageBox.Show("Nicht alle Felder wurden ordnungsgemäß ausgefüllt:\n\n" + sMessage + "\nMöchten Sie trotzdem fortfahren?", "Warnung!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    return true;
                }
            }
            return isOkay;
        }

        #region "Preview preparation"

        //Preview title
        private string prepareShowAsPreview(string name, string firstName, string nickName, string title, string showAsType)
        {
            switch (showAsType)
            {
                case "NV":
                    sSaveName = name + ", " + firstName + ".card";
                    return name + ", " + firstName;
                case "VN":
                    sSaveName = firstName + " " + name + ".card";
                    return firstName + " " + name;
                case "NVS":
                    sSaveName = name + ", " + firstName + " (" + nickName + ").card";
                    return name + ", " + firstName + " (" + nickName + ")";
                case "TVN":
                    sSaveName = title + " " + firstName + " " + name + ".card";
                    return title + " " + firstName + " " + name;
                default:
                    sSaveName = name + ", " + firstName + ".card";
                    return name + ", " + firstName;
            }
        }

        //Preview mail
        private string prepareMailPreview(string email, string emailType)
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
        private string prepareNumbersPreview(string numberType, string cc, int ac, string number)
        {
            if (ac == 0 && number == "")
            {
                return "-----";
            }
            else
            {
                return cc + " " + ac + "/" + number + " (" + numberType + ")";
            }
        }

        //Preview gender
        private string prepareGenderPreview(int gender)
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

        #endregion
    }
}
