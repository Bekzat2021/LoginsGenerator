using System;
using System.IO;

namespace Aydin
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateLogins(1000);
        }

        ///<summary>
        ///Записывает в файл текста 
        ///</summary>
        ///<param name="text">
        ///Текст для записи
        ///</param>
        ///<param name="writePath">
        ///не обязательный параметр пути
        ///</param>
        public static void WriteToFile(string text, string writePath = @"D:\file.txt")
        {
            using(StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }

        ///<summary>
        ///Дает необходимое количество логинов которые получает из метода 
        ///прибавляет порядковый номер и записывает в файл
        ///</summary>
        ///<param name="times">
        ///Количество логинов для генерации
        /// </param>
        public static void GenerateLogins(int times)
        {
            string loginWithNumber = null;
            for (int i = 0; i < times; i++)
            {
                loginWithNumber = GenerateLogin() + i.ToString();
                WriteToFile(loginWithNumber);
                Console.WriteLine(loginWithNumber);
            }
        }

        ///<summary>
        ///Генерирует логин из англиских букв алфавита длинной 8 букв
        ///</summary>
        ///<returns>
        ///Логин
        /// </returns>
        public static string GenerateLogin()
        {
            string letters = "qwertyuioplkjhgfdsazxcvbnm";
            Random random = new Random();
            string login = null;

            for (int i = 0; i < 8; i++)
            {
                login += letters[random.Next(letters.Length - 1)];
            }

            return login;
        }
    }
}
