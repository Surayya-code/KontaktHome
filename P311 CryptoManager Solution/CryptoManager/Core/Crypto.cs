using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CryptoManager.Core
{
    /// <summary>
    /// http://www.vcskicks.com/code-snippet/encryption.php
    /// Email config
    /// fromMail: fullstackstaff@mail.ru
    /// smtpHost: smtp.mail.ru
    /// smtpLogin: fullstackstaff
    /// smtpPassword: !d@v#l0pmentgroup20!9
    /// smtpPort: 25
    /// </summary>
    static class Crypto
    {
        readonly static char[] allowedChars;
        readonly static Random r;
        static Crypto()
        {
            r = new Random();
            allowedChars = "1q2w3e4r5t6y7u8p9asdfghkzxcvbnmMNBVCXZKHGFDSAPUYTREWQ".ToCharArray();
        }
        public static byte[] Encrypt(byte[] input, string password)
        {
            try
            {
                using (TripleDESCryptoServiceProvider service = new TripleDESCryptoServiceProvider())
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    var key = md5.ComputeHash(Encoding.ASCII.GetBytes($"p311{password}20!9"));
                    var iv = md5.ComputeHash(Encoding.ASCII.GetBytes($"p311{string.Join("", password.Reverse())}20!9"));

                    return Transform(input, service.CreateEncryptor(key, iv));
                }
            }
            catch (Exception)
            {
                return new byte[0];
            }
        }

        public static byte[] Decrypt(byte[] input, string password)
        {
            try
            {
                using (TripleDESCryptoServiceProvider service = new TripleDESCryptoServiceProvider())
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    var key = md5.ComputeHash(Encoding.ASCII.GetBytes($"p311{password}20!9"));
                    var iv = md5.ComputeHash(Encoding.ASCII.GetBytes($"p311{string.Join("", password.Reverse())}20!9"));

                    return Transform(input, service.CreateDecryptor(key, iv));
                }                    
            }
            catch (Exception)
            {
                return new byte[0];
            }
        }

        public static string Encrypt(this string text, string password)
        {
            var input = Encoding.UTF8.GetBytes(text);
            var output = Encrypt(input, password);
            return Convert.ToBase64String(output);
        }

        public static string Decrypt(this string text, string password)
        {
            var input = Convert.FromBase64String(text);
            var output = Decrypt(input, password);
            return Encoding.UTF8.GetString(output);
        }

        public static string Encrypt(this string text)
        {
            return Encrypt(text, "!d@v#l0pmentgroup20!9");
        }

        public static string Decrypt(this string text)
        {
            return Decrypt(text, "!d@v#l0pmentgroup20!9");
        }

        private static byte[] Transform(byte[] input, ICryptoTransform CryptoTransform)
        {
            using (MemoryStream memStream = new MemoryStream())
            using (CryptoStream cryptStream = new CryptoStream(memStream, CryptoTransform, CryptoStreamMode.Write))
            {
                cryptStream.Write(input, 0, input.Length);
                cryptStream.FlushFinalBlock();

                memStream.Position = 0;
                byte[] result = new byte[Convert.ToInt32(memStream.Length)];
                memStream.Read(result, 0, Convert.ToInt32(result.Length));

                return result;
            }            
        }

        public static string GetRandomString(byte len = 7)
        {
            len = len < 5 ? (byte)5 : len;
            return string.Join("", Enumerable.Range(1, len)
                .Select(l => allowedChars[r.Next(0, allowedChars.Length)]));
        }
    }
}
