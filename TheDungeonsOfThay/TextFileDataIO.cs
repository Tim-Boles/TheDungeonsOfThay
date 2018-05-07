using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextForRPGTest
{
    public class TextFileDataIO
    {
        public void WriteToFile(string path, string[] text)
        {
            if (File.Exists(path))
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
                {
                    foreach(string line in text)
                    {
                        file.WriteLine(line);
                    }

                    file.Close();
                }

                //Console.WriteLine("Looks like it worked cap");
            }
            else
            {
                Console.WriteLine("Sorry cap, it didn't work");
            }
        }

        public void ReadFromFile(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

                //Console.WriteLine("Looks like it worked cap");
            }
            else
            {
                Console.WriteLine("Sorry cap, it didn't work");
            }
        }

        public void ClearTextFile(string path)
        {
            if (File.Exists(path))
            {
                File.WriteAllText(path, String.Empty);

                //Console.WriteLine("Looks like it worked cap");
            }
            else
            {
                Console.WriteLine("Sorry cap, it didn't work");
            }
        }
    }
}
