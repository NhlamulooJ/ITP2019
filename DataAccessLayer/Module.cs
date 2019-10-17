using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Module
    {
        public int ModuleCode { get; set; }
        public string ModuleDesc { get; set; }
        public string Status { get; set; }


        //Inserting
        public Module(string moduleDesc,string status)
        {
            Status = status;
            ModuleDesc = moduleDesc;
        }
        //Updating
        public Module(int moduleCode, string moduleDesc)
        {
            ModuleCode = moduleCode;
            ModuleDesc = moduleDesc;
        }
        //Removing
        public Module(int moduleCode)
        {
            ModuleCode = moduleCode;
        }

    }
}
