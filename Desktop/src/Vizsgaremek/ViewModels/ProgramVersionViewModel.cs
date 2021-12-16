using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Models;

namespace Vizsgaremek.ViewModels
{
    // ViewModel réteg
    // A megjelenítendő adatokat kell megadni itt
    class ProgramVersionViewModel
    {
        private ProgramInfo programInfo;
        public string Version
        {
            get
            {
                return programInfo.Version;
            }
        }

        public ProgramVersionViewModel()
        {
            programInfo = new ProgramInfo();
        }
    }
}
