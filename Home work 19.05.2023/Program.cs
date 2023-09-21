using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_19._05._2023
{
    class CaesarCipher
    {
        static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        
        public static string Encryption(string text)
        {
            var res = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
                for (int j = 0; j < alphabet.Length; j++)
                    if (text[i] == alphabet[j])
                        res.Append(alphabet[(j + 3) % alphabet.Length]);

            return res.ToString();
        }
        public static string Decryption(string crypt)
        {
            var res = new StringBuilder();
            for (int i = 0; i < crypt.Length; i++)
                for (int j = 0; j < alphabet.Length; j++)
                    if (crypt[i] == alphabet[j])
                        res.Append(alphabet[(j - 3 + alphabet.Length) % alphabet.Length]);

            return res.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //string text = "grEeNPaRROt";
            Console.WriteLine("Введите слово, которое хотите зашифровать: ");
            string text2 = Console.ReadLine();
            string crypt = CaesarCipher.Encryption(text2);
            Console.WriteLine($"Зашифрованное сообщение: {crypt}\n");
            string decrypt = CaesarCipher.Decryption(crypt);
            Console.WriteLine($"Расшифрованное сообщение: {decrypt}\n");
        }
    }
}