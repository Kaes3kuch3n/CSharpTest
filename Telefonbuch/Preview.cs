using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefonbuch
{
    class Preview
    {
        #region "Constructor-Variables"

        private string sName;
        private string sFirstName;
        private string sShowAs;
        private int iGender;

        #endregion

        #region "General"

        private string sNickName;
        private string sTitle;
        private DateTime dtBirthday;
        private Image imgContactImage;

        #endregion

        #region "Phone Numbers"

        private string sNumberType1;
        private string sNumberType2;
        private string sNumberType3;
        private string sNumberType4;
        private string sNr1;
        private string sNr2;
        private string sNr3;
        private string sNr4;
        private string sCC1;
        private string sCC2;
        private string sCC3;
        private string sCC4;
        private string sAC1;
        private string sAC2;
        private string sAC3;
        private string sAC4;
        private int iAC1;
        private int iAC2;
        private int iAC3;
        private int iAC4;

        #endregion

        #region "Address"

        private string sStreet;
        private string sHouseNr;
        private string sZipCode;
        private string sCity;
        private string sCountry;

        #endregion

        #region "Work Address"

        private string sWorkName;
        private string sStreet2;
        private string sHouseNr2;
        private string sZipCode2;
        private string sCity2;
        private string sCountry2;

        #endregion

        #region "Other"

        private string sMailType1;
        private string sMailType2;
        private string sMail1;
        private string sMail2;
        private string sNotes;

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

        /// <summary>
        /// Setzt die Variablen des Tabs "Allgemein".
        /// </summary>
        /// <param name="nickName">Spitzname des Kontaktes</param>
        /// <param name="title">Titel des Kontaktes</param>
        /// <param name="birthday">Geburtstag des Kontaktes</param>
        /// <param name="contactImage">Foto des Kontaktes</param>
        public void SetGeneralVars(string nickName, string title, DateTime birthday, Image contactImage)
        {
            this.sNickName = nickName;
            this.sTitle = title;
            this.dtBirthday = birthday;
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

        /// <summary>
        /// Blendet das Preview-Fenster ein. Zuvor wird eine Überprüfung auf Vollständigkeit und Formfehler durchgeführt.
        /// </summary>
        public void ShowPreview()
        {
            if (CheckIfOkay())
            {
                formPreview preview = new formPreview();
                preview.lblNamePH.Text = sName;
                preview.lblFirstNamePH.Text = sFirstName;
                preview.Show();
            }
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
    }
}
