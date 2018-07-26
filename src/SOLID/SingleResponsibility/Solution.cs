using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Solution
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
                new ExceptionHandler().Handle(ex);
                throw;
            }
        }
    }

    class ExceptionHandler
    {
        string path = "";
        public void Handle(Exception ex)
        {
            System.IO.File.WriteAllText(path, ex.ToString());
        }
    }
}
