using System;
// крутая программа
namespace zadanie2
{
    static class libl2
    {
        public static string stroka(string s)
        {
            string x= "-1";
            string y = "-2";
         
          
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'f')
                {
                    x += s[i];
                    
                }
                 y += s[i];
               
            }
            return s;
            
        }
        public static string Tr(string s)
        {
            // Изменим заглавные буквы
            s = s.Replace("А", "A");
            s = s.Replace("Б", "B");
            s = s.Replace("В", "V");
            s = s.Replace("Г", "G");
            s = s.Replace("Д", "D");
            s = s.Replace("Е", "E");
            s = s.Replace("Ё", "YO");
            s = s.Replace("Ж", "J");
            s = s.Replace("З", "Z");
            s = s.Replace("И", "I");
            s = s.Replace("Й", "J");
            s = s.Replace("К", "K");
            s = s.Replace("Л", "L");
            s = s.Replace("М", "M");
            s = s.Replace("Н", "N");
            s = s.Replace("О", "O");
            s = s.Replace("П", "P");
            s = s.Replace("Р", "R");
            s = s.Replace("С", "S");
            s = s.Replace("Т", "T");
            s = s.Replace("У", "U");
            s = s.Replace("Ф", "F");
            s = s.Replace("Х", "H");
            s = s.Replace("Ц", "C");
            s = s.Replace("Ч", "CH");
            s = s.Replace("Ш", "SH");
            s = s.Replace("Щ", "SCH");
            s = s.Replace("Ъ", "");
            s = s.Replace("Ы", "I");
            s = s.Replace("Ь", "");
            s = s.Replace("Э", "E");
            s = s.Replace("Ю", "Y");
            s = s.Replace("Я", "YA");
            //Теперь строчные
            s = s.Replace("а", "a");
            s = s.Replace("б", "b");
            s = s.Replace("в", "v");
            s = s.Replace("г", "g");
            s = s.Replace("д", "d");
            s = s.Replace("е", "e");
            s = s.Replace("ё", "yo");
            s = s.Replace("ж", "j");
            s = s.Replace("з", "z");
            s = s.Replace("и", "i");
            s = s.Replace("й", "j");
            s = s.Replace("к", "k");
            s = s.Replace("л", "l");
            s = s.Replace("м", "m");
            s = s.Replace("н", "n");
            s = s.Replace("о", "o");
            s = s.Replace("п", "p");
            s = s.Replace("р", "r");
            s = s.Replace("с", "s");
            s = s.Replace("т", "t");
            s = s.Replace("у", "u");
            s = s.Replace("ф", "f");
            s = s.Replace("х", "h");
            s = s.Replace("ц", "c");
            s = s.Replace("ч", "ch");
            s = s.Replace("ш", "sh");
            s = s.Replace("щ", "sch");
            s = s.Replace("ъ", "");
            s = s.Replace("ы", "i");
            s = s.Replace("ь", "");
            s = s.Replace("э", "e");
            s = s.Replace("ю", "yu");
            s = s.Replace("я", "ya");
            return s;
        }
        public static string stroka2(string s)
        {
            string res = s[0].ToString();
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == 'h')
                {
                      res += "H";
                }
            }
               
            return res;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
