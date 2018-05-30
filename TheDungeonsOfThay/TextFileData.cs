using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextForRPGTest
{
    public class TextFileData
    {
        private string _name;
        private string _path;
        private string _truePath;

        public string Name
        {
            get
            {
                if(_name is null)
                {
                    return "This Text File Has no name";
                }
                else
                {
                    return _name;
                }

            }
            set
            {
                _name = value;
            }
        }

        public string Path
        {
            get
            {
                if(_path is null)
                {
                    return "This Text File does not exist";
                }
                else
                {
                    return _path;
                }
            }
            set
            {
                _path = value;
            }
        }

        public string TruePath
        {
            get { return _truePath; }
            set { _truePath = value; }
        }

        public void CreateFile()
        {
            string path = @"" + Path + "\\" + Name + ".txt";
            TruePath = path;
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            var myFile = File.Create(path);
            myFile.Close();
        }
    }
}
