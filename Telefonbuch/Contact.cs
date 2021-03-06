﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefonbuch
{
    [Serializable()]
    public class Contact
    {
        private string sSaveName;

        #region "General Vars"

        internal string sName;
        internal string sFirstName;
        internal string sShowAs;
        internal int iGender;
        internal string sNickName;
        internal string sTitle;
        internal DateTime dtBirthday;
        internal string sContactImage;

        #endregion

        #region "Phone Number Vars"
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
        internal int iAC1;
        internal int iAC2;
        internal int iAC3;
        internal int iAC4;

        #endregion

        #region "Address Vars"

        internal string sStreet;
        internal string sHouseNr;
        internal string sZipCode;
        internal string sCity;
        internal string sCountry;

        #endregion

        #region "Work Address Vars"

        internal string sWorkName;
        internal string sStreet2;
        internal string sHouseNr2;
        internal string sZipCode2;
        internal string sCity2;
        internal string sCountry2;

        #endregion

        #region "Other Vars"

        internal string sMailType1;
        internal string sMailType2;
        internal string sMail1;
        internal string sMail2;
        internal string sNotes;

        #endregion

        /// <summary>
        /// Konstruktor zum Erstellen eines leeren Contact-Objekts.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Konstruktor der Klasse Contact. Erstellt ein neues Objekt Contact aus einem Preview-Objekt.
        /// </summary>
        /// <param name="p">Preview-Objekt, aus dem der Kontakt erstellt werden soll</param>
        public Contact(Preview p)
        {
            this.sSaveName = p.sSaveName;
            this.sName = p.sName;
            this.sFirstName = p.sFirstName;
            this.sShowAs = p.sShowAs;
            this.iGender = p.iGender;
            this.sNickName = p.sNickName;
            this.sTitle = p.sTitle;
            this.dtBirthday = p.dtBirthday;
            this.sCC1 = p.sCC1;
            this.sCC2 = p.sCC2;
            this.sCC3 = p.sCC3;
            this.sCC4 = p.sCC4;
            this.iAC1 = p.iAC1;
            this.iAC2 = p.iAC2;
            this.iAC3 = p.iAC3;
            this.iAC4 = p.iAC4;
            this.sNr1 = p.sNr1;
            this.sNr2 = p.sNr2;
            this.sNr3 = p.sNr3;
            this.sNr4 = p.sNr4;
            this.sNumberType1 = p.sNumberType1;
            this.sNumberType2 = p.sNumberType2;
            this.sNumberType3 = p.sNumberType3;
            this.sNumberType4 = p.sNumberType4;
            this.sStreet = p.sStreet;
            this.sHouseNr = p.sHouseNr;
            this.sZipCode = p.sZipCode;
            this.sCity = p.sCity;
            this.sCountry = p.sCountry;
            this.sWorkName = p.sWorkName;
            this.sStreet2 = p.sStreet2;
            this.sHouseNr2 = p.sHouseNr2;
            this.sZipCode2 = p.sZipCode2;
            this.sCity2 = p.sCity2;
            this.sCountry2 = p.sCountry2;
            this.sMail1 = p.sMail1;
            this.sMail2 = p.sMail2;
            this.sMailType1 = p.sMailType1;
            this.sMailType2 = p.sMailType2;
            this.sNotes = p.sNotes;
            this.sContactImage = ImageToString(p.imgContactImage, p.imgContactImage.RawFormat);
        }

        /// <summary>
        /// Speichert den Kontakt unter dem angegebenen Pfad
        /// </summary>
        /// <param name="path">Speicherort des Kontakts</param>
        /// <returns>Gibt true zurück, wenn der Speichervorgang erfolgreich war</returns>
        public bool SaveContact(string path, string key, string iv)
        {
            string fullPath = path + ReplaceBadChars(sSaveName);

            if (!File.Exists(fullPath))
            {
                FileStream stream = null;
                CryptoStream cryptoStream = null;
                BinaryFormatter formatter = null;

                try
                {
                    stream = new FileStream(fullPath, FileMode.Create);
                    cryptoStream = new CryptoStream(stream, CryptByKey(key, iv).CreateEncryptor(), CryptoStreamMode.Write);
                    formatter = new BinaryFormatter();

                    formatter.Serialize(cryptoStream, this);

                    stream.Flush();
                    cryptoStream.Flush();
                    cryptoStream.Close();
                    stream.Close();

                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Der Kontakt konnte nicht gespeichert werden!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                string fileName = sSaveName.Remove(sSaveName.Length - 5, 5);
                MessageBox.Show("Es existiert bereits ein Kontakt, der als \"" + fileName + "\" gespeichert wurde. Bitte ändern Sie den Namen oder die Eigenschaft \"Anzeigen als\"!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Lädt einen Kontakt aus einer Datei.
        /// </summary>
        /// <param name="file">Datei, aus der der Kontakt geladen werden soll.</param>
        /// <returns></returns>
        public static Contact OpenContact(string file, string key, string iv)
        {
            FileStream stream = null;
            CryptoStream cryptoStream = null;
            BinaryFormatter formatter = null;

            try
            {
                stream = new FileStream(file, FileMode.Open);
                cryptoStream = new CryptoStream(stream, StaticCryptByKey(key, iv).CreateDecryptor(), CryptoStreamMode.Read);
                formatter = new BinaryFormatter();

                return (Contact)formatter.Deserialize(cryptoStream);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Der Kontakt konnte nicht geöffnet werden!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                stream.Flush();
                cryptoStream.Flush();
                cryptoStream.Close();
                stream.Close();
            }
        }

        /// <summary>
        /// Ersetzt unter Windows verbotene Zeichen im Dateinamen.
        /// </summary>
        /// <param name="text">Zu überarbeitender Dateiname</param>
        /// <returns>Gesäuberter Dateiname</returns>
        private string ReplaceBadChars(string text)
        {
            text.Replace("\\", "$");
            text.Replace("/", "$");
            text.Replace(":", "$");
            text.Replace("*", "$");
            text.Replace("?", "$");
            text.Replace("\"", "$");
            text.Replace("<", "$");
            text.Replace(">", "$");
            text.Replace("|", "$");
            return text;
        }

        /// <summary>
        /// Wandelt ein Image-Objekt in einen String um.
        /// </summary>
        /// <param name="img">Umzuwandelndes Bild</param>
        /// <param name="imgFormat">RawFormat des umzuwandelnden Bildes</param>
        /// <returns>Image als String</returns>
        private string ImageToString(Image img, ImageFormat imgFormat)
        {
            string sImg;

            MemoryStream stream = new MemoryStream();
            img.Save(stream, imgFormat);
            sImg = Convert.ToBase64String(stream.ToArray());
            stream.Close();

            return sImg;
        }

        /// <summary>
        /// Wandelt einen String in ein Image-Objekt um.
        /// </summary>
        /// <param name="sImage">Umzuwandelnder String</param>
        /// <returns></returns>
        public static Image StringToImage(string sImage)
        {
            MemoryStream stream = new MemoryStream(Convert.FromBase64String(sImage));
            Image img = Image.FromStream(stream);
            stream.Close();

            return img;
        }

        #region "Crypto-Functions"

        private Rijndael CryptByKey(string key, string iv)
        {
            Rijndael rj = Rijndael.Create();
            rj.Key = ASCIIEncoding.ASCII.GetBytes(PaddKey(key));
            rj.IV = ASCIIEncoding.ASCII.GetBytes(PaddKey(iv));
            rj.Padding = PaddingMode.Zeros;
            return rj;
        }

        private string PaddKey(string key)
        {
            if (key.Length % 2 == 0)
            {
                return key.PadLeft(16, (char)(key.Length + 64));
            }
            else
            {
                return key.PadRight(16, (char)(90 - key.Length));
            }
        }

        private static Rijndael StaticCryptByKey(string key, string iv)
        {
            Rijndael rj = Rijndael.Create();
            rj.Key = ASCIIEncoding.ASCII.GetBytes(StaticPaddKey(key));
            rj.IV = ASCIIEncoding.ASCII.GetBytes(StaticPaddKey(iv));
            rj.Padding = PaddingMode.Zeros;
            return rj;
        }

        private static string StaticPaddKey(string key)
        {
            if (key.Length % 2 == 0)
            {
                return key.PadLeft(16, (char)(key.Length + 64));
            }
            else
            {
                return key.PadRight(16, (char)(90 - key.Length));
            }
        }

        #endregion
    }
}
