using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Problem
{
    class Machine
    {
        public void Start()
        {
            try
            {
                //Do Something
            }
            catch (Exception ex)
            {
                string path = "";
                System.IO.File.WriteAllText(path, ex.ToString());
            }
        }
    }
}
