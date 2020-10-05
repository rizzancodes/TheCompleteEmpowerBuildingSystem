using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Software_New
{
    class classDirectory
    {

        public static string getrootPath()
        {
            string getPath = System.IO.Directory.GetCurrentDirectory();

            string rootDirectory = (getPath);


            bool directoryExists = Directory.Exists(rootDirectory);

            if(directoryExists)
            {
                return rootDirectory;
            }
            else
            {
                throw new Exception("Error 1: Path doesn't exist. Contact the relevant person!");
            }



        }




       
      
    }
}
