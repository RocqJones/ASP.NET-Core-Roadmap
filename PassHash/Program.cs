using System;
using System.Security.Cryptography;

namespace PassHash
{
    class Program
    {
        static public string EncryptText(string strInputText)
        {
            byte[] data = Array.ConvertAll<char, byte>(strInputText.ToCharArray(), delegate (char ch) { return (byte)ch; });
            SHA256 shaM = new SHA256Managed();
            byte[] result = shaM.ComputeHash(data);
            return Convert.ToBase64String(result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(EncryptText("admin@domain.compass@102"));
        }
    }
}
