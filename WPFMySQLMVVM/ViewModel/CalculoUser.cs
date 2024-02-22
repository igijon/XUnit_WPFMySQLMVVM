using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMySQLMVVM.ViewModel
{
    public class CalculoUser
    {
        public static String GetBirthYear(String edad)
        {
            try
            {
                int posBirthYear = DateTime.Today.Year - Int32.Parse(edad);
                return (posBirthYear).ToString() + " - " + (posBirthYear + 1).ToString();
            }catch(FormatException e)
            { return "";  }
        }
    }
}
