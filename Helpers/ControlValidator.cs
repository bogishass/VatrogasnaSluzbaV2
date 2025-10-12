using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VatrogasnaSluzba.Helpers
{
    public static class ControlValidator
    {
        public static bool IsValid(TextBox tb, string msg)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                MessageBox.Show(msg);
                tb.Focus();
                return false;
            }
            return true;
        }

        public static bool IsValid(ComboBox cb, string msg)
        {
            if (cb.SelectedItem == null)
            {
                MessageBox.Show(msg);
                cb.Focus();
                return false;
            }
            return true;
        }

        public static bool IsValidInt(TextBox tb, string msg)
        {
            if (string.IsNullOrWhiteSpace(tb.Text) || !int.TryParse(tb.Text, out _))
            {
                MessageBox.Show(msg);
                tb.Focus();
                return false;
            }
            return true;
        }

        public static bool IsValidMatBr(TextBox tb, string msg)
        {
            if (!IsValid(tb, msg)) return false;

            if (!Regex.IsMatch(tb.Text, @"^\d{13}$")) // 13 karaktera i samo cifre
            {
                MessageBox.Show(msg);
                return false;
            }

            return true;
        }
    }
}
