using ProfitLossCalculator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitLossCalculator.Helper
{
    class Helper
    {
       public static bool Required(Control cont)
        {
            TextBox txt = (TextBox)cont;

            if (txt.Text == string.Empty)
            {
                MessageBox.Show(txt.Name.Replace("txt","") + " is required.");
                return false;
            }
            else
            {
                return true;
            }

        }

       public static bool NonNegativeInteger(Control cont)
       {
           TextBox txt = (TextBox)cont;
           int value;

           if (!int.TryParse(txt.Text, out value))
           {
               MessageBox.Show(txt.Name.Replace("txt", "") + " value must be integer.");
               return false;
           }
           else
           {
               if (value <= 0) {
                   MessageBox.Show(txt.Name.Replace("txt", "") + " value must be greater than 0.");
                   return false;
               }

               return true;
           }
       }

       public static bool NonNegativeDecimal(Control cont)
       {
           TextBox txt = (TextBox)cont;
           decimal value;

           if (!decimal.TryParse(txt.Text, out value))
           {
               MessageBox.Show(txt.Name.Replace("txt", "") + " value must be decimal.");
               return false;
           }
           else
           {
               if (value <= 0)
               {
                   MessageBox.Show(txt.Name.Replace("txt", "") + " value must be greater than 0.");
                   return false;
               }

               return true;
           }
       }

       public static bool ValidDate(Control cont)
       {
           TextBox txt = (TextBox)cont;
           DateTime value;

           if (!DateTime.TryParse(txt.Text, out value))
           {
               MessageBox.Show(txt.Name.Replace("txt", "") + " value must be valid date. DateTime Format is dd/MM/yyyy");
               return false;
           }
           else
           {
               return true;
           }
       }
    }
}
