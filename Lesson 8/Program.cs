using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\yxakr\Desktop\Test\Karl.txt";
            using (StreamReader sr = new StreamReader(path))
                            
            {
                Console.WriteLine(sr.ReadToEnd());
                int count = File.ReadAllLines(path).Length;// находим количество строк в файле
                Console.WriteLine(count++);// выводим количество строк в файле

                int wordcount=0;               
                string[,] textMass = sr.Split();
                while (sr.EndOfStream != true) ;
                {
                    wordcount =sr.ReadLine();
                    wordcount++;
                }               
                
                Console.WriteLine(wordcount);


            }
            

            Console.ReadKey();
        }
    }
}
