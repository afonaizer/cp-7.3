using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string st = "";
            //int L = st.Length;
            //string s = "";
            //for(int i=0; i<5;i++)
            //{
            //    Console.WriteLine($"введ {i + 1} ");
            //    string st1 = Console.ReadLine();
            //    if (st1.Length>L)
            //    {
            //        L = st1.Length;
            //        s = st1;
            //    }              
            //}
            //Console.WriteLine($"самое длинное слово {s} имеет{L}");


            //задан2
            //Console.Write("Введите слово: ");
            //string word = Console.ReadLine();
            //int count = 0;
            //foreach (char e in word)
            //{
            //    if (e == 'е')
            //    { count++; }
            //    if (e == 'Е')
            //    { count++; }
            //}
            //string custom = word.Replace("е","") ;
            //string custom_night = custom.Replace("Е","");
            //Console.WriteLine($"Количество удаленных символов е в слове = {count}, итоговое слово {custom_night}");

            //задан3
            //Console.Write("Введите слово: ");
            //string word = Console.ReadLine();
            //int count = 0;
            //foreach (char a in word)
            //{
            //    if (a == 'а')
            //    { count++; }
            //    if (a == 'А')
            //    { count++; }
            //}
            //Console.WriteLine($"Количество символов а в слове = {count}");

            //задан4

            //Console.WriteLine("Введте предложение: ");
            //string sentence = Console.ReadLine();
            //string[] sent = sentence.Split(' ');
            //int i = sent[0].Length;
            //Console.WriteLine($"Длина первого слова {i}");

            //задан5 
            //Console.WriteLine("Введте 5 слов: ");
            //string sentence = Console.ReadLine();
            //string[] sent = sentence.Split(' ');
            //int i = sent.Length;
            //Console.WriteLine($"Длина последнего слова {sent[i-1].Length}");

            //задан6
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            string word1 = word.Replace('а','о') ;
            string word2 = word1.Replace('А','О');
            Console.WriteLine(word2);

            Console.ReadKey();

        }
    }
}
