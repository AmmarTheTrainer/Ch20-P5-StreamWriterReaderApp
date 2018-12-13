using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch20_P5_StreamWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Fun with StreamWriter / StreamReader *****\n");
            // Get a StreamWriter and write string data.
            //using (StreamWriter writer = File.CreateText("reminders.txt"))
            //{
            //    writer.WriteLine("Don't forget Mother's Day this year...");
            //    writer.WriteLine("Don't forget Father's Day this year...");
            //    writer.WriteLine("Don't forget these numbers:");
            //    for (int i = 0; i < 10; i++)
            //        writer.Write(i + " ");
            //    // Insert a new line.
            //    writer.Write(writer.NewLine);
            //    writer.WriteLine("This is another line for testing:");
            //}
            //Console.WriteLine("Created file and wrote some thoughts...");

            //// Now read data from file.
            //Console.WriteLine("Here are your thoughts:\n");
            //using (StreamReader sr = File.OpenText("reminders.txt"))
            //{

            //    int num = sr.Read();
            //    Console.WriteLine(num);

            //    //int no = sr.Peek();
            //    string s = sr.ReadToEnd();
            //    //Console.WriteLine(s);
            //    var v = sr.CurrentEncoding;
            //   // sr.DiscardBufferedData() ;

            //    Console.WriteLine(v);

            //    char[] chList = new char[100];
            //    sr.ReadBlock(chList , 0, 50);

            //    for (int i = 0; i < chList.Length; i++)
            //    {
            //        Console.Write(chList[i]);
            //    }

            //    string input = null;
            //    //while ((input = sr.ReadLine()) != null)
            //    //{
            //    //    Console.WriteLine(input);
            //    //}
            //}

            Console.WriteLine("***** Fun with StreamWriter / StreamReader *****\n");
            // Get a StreamWriter and write string data.
            using (StreamWriter writer = new StreamWriter("reminders.txt"))
            {

            }
            // Now read data from file.
            using (StreamReader sr = new StreamReader("reminders.txt"))
            {

            }

            Console.ReadLine();
        }
    }
}
