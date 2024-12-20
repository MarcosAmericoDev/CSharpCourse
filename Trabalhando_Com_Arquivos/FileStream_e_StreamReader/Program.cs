﻿namespace FileStream_e_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while(!sr.EndOfStream) 
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occorred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
