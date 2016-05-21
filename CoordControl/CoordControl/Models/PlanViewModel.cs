using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordControl.Models
{
    class PlanViewModel
    {
        public void SaveDoc(string fileName, string fileContent)
        {
            File.WriteAllText(fileName, fileContent);
        }
    }
}
