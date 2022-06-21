using System;
using System.IO;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Program shows all the folders and files in the current folder.");
            Console.Write("Enter the way to the folder: ");

            string address = Console.ReadLine();

            Console.WriteLine(address);
            FilesCatalog(address, "");
            Console.ReadKey();
        }

        static void FilesCatalog(string address, string space)
        {
            try
            {
                string[] files = Directory.GetFiles(address);
                string[] dirs = Directory.GetDirectories(address);

                int addressLen = address.Length;

                foreach (string file in files)
                {
                    Console.WriteLine(space + "L " + file.Substring(addressLen));
                }

                foreach (string dir in dirs)
                {
                    string dirName = dir.Substring(addressLen);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(space + "\n  + " + dirName);
                    Console.ResetColor();

                    string newAddress;

                    if (address[addressLen - 1] == '/' || address[addressLen - 1] == '\\')
                    {
                        newAddress = address + dirName + "/";
                    }
                    else
                    {
                        newAddress = address + "/" + dirName + "/";
                    }

                    FilesCatalog(newAddress, space + "  ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
