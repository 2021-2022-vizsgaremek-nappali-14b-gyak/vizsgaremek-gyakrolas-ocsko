using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vizsgaremek.Models
{
    public class ProgramInfo
    {
        private string version;
        private string authors;

        public string Version
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                var assemblyVerzio = assembly.GetName().Version;
                return assemblyVerzio.ToString();
            }
        }
        public string Authors
        {
            get
            {
                return "";
            }
        }

        public ProgramInfo()
        {

        }
    }

    
}
