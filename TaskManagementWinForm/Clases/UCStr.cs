using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using NLog;

namespace TaskManagementWinForm.Clases
{
    public static class UCStr
    {

        /// <summary>
        /// генератор пароля
        /// </summary>
        /// <param name="length">Длина пароля (по умолчанию 12)</param>
        /// <returns></returns>
        public static string GenerateRandomPassword(int length = 12)
        {
            var stringChars = "";
            while (stringChars == "" || stringChars.Split(new char[] { ';', ':', '&', '.', ',' }, StringSplitOptions.RemoveEmptyEntries).Length > 1)
                stringChars = Membership.GeneratePassword(length, 1);
            return stringChars;
        }

        /// <summary>
        /// Сохраняем ошибки в лог-файл
        /// </summary>
        /// <param name="logger">Екземпляр Logger</param>
        /// <param name="ex">Exception</param>
        /// <param name="text">текст для описание ошибки</param>
        public static void SaveLog(Logger logger, Exception ex, string text)
        {
            if (!String.IsNullOrWhiteSpace(text)) logger.Error($"{text}");

            while (ex.InnerException != null)
            {
                logger.Error($"{ex.Message}, {ex.StackTrace}");
                ex = ex.InnerException;
            }
        }

        /// <summary>
        /// Сохраняем ошибки в лог-файл
        /// </summary>
        /// <param name="logger">Екземпляр Logger</param>
        /// <param name="ex">Exception</param>
        /// <param name="text">текст для описание ошибки</param>
        public static void SaveLog(Exception ex, string text = "")
        {
            SaveLog(LogManager.GetLogger("Error"), ex, text);
        }

        /// <summary>
        /// ФИО в правильном формате
        /// </summary>
        /// <param name="_name">ФИО</param>
        /// <returns></returns>
        public static string NormalizeFIO(string _name)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(_name)) return "";
                string result = "";
                string[] subnames = _name.Split(' ');
                int i = 1;
                foreach (var str in subnames)
                {
                    result += i != subnames.Length ? GetNormalName(str) + " " : GetNormalName(str);
                    i++;
                }
                return result.Trim();
            }
            catch (Exception)
            {
                return _name;
            }
        }

        public static string GetNormalName(string str)
        {
            if (String.IsNullOrWhiteSpace(str)) return "";
            StringBuilder strok = new StringBuilder(str.Trim().ToLower());
            strok[0] = strok[0].ToString().ToUpper()[0];
            return strok.ToString();
        }
        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an RijndaelManaged object
            // with the specified key and IV.
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }

        public static string StringUnLock(string s)
        {
            RijndaelManaged cipher = new RijndaelManaged
            {
                Key = new byte[] { 228, 227, 156, 209, 248, 203, 27, 7, 129, 102, 10, 25, 200, 47, 119, 88, 46, 244, 8, 0, 148, 79, 53, 95, 155, 192, 95, 65, 168, 95, 224, 222 },
                IV = new byte[] { 35, 5, 51, 64, 201, 108, 74, 98, 83, 237, 195, 154, 17, 94, 147, 163 }
            };

            try
            {
                return DecryptStringFromBytes(Convert.FromBase64String(s), cipher.Key, cipher.IV);
            }
            catch { }

            return "";
        }
        public static string StringLock(string s)
        {
            RijndaelManaged cipher = new RijndaelManaged
            {
                Key = new byte[] { 228, 227, 156, 209, 248, 203, 27, 7, 129, 102, 10, 25, 200, 47, 119, 88, 46, 244, 8, 0, 148, 79, 53, 95, 155, 192, 95, 65, 168, 95, 224, 222 },
                IV = new byte[] { 35, 5, 51, 64, 201, 108, 74, 98, 83, 237, 195, 154, 17, 94, 147, 163 }
            };

            return Convert.ToBase64String(EncryptStringToBytes(s, cipher.Key, cipher.IV));
        }

        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            // Create an RijndaelManaged object
            // with the specified key and IV.
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            // Return the encrypted bytes from the memory stream.
            return encrypted;

        }
    }
}
