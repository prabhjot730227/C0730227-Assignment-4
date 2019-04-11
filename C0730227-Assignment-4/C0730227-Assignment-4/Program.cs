﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace C0730227_Assignment_4
{
    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();
        }

        public void Run()
        {
            this.ReadTextFiles();
        }
        public void ReadTextFiles()
        {
            //Read file using StreamReader. Reads file line by line
            using (StreamReader file = new StreamReader("U:/Users/730227/C0730227-Assignment-4/Beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {

                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines. ");
            }
        }
        public int FindNumberOfBlankSpace(string line)
        {

            int countletters = 0;
            int countSpaces = 0;
            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    countletters++;
                }
                if (char.IsWhiteSpace(c))
                {
                    countSpaces++;
                }
            }
            return countSpaces;
        }


    }
}
