using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace QuanLyPhucLong
{
    class ConvertMoney
    {
        public ConvertMoney()
        {}

        public string _ConvertMoney(string money)
        {
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(money, NumberStyles.AllowThousands);
            return String.Format(culture, "{0:N0}", value);
        }

        public string _ConvertMoney(int money)
        {
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(money.ToString(), NumberStyles.AllowThousands);
            return String.Format(culture, "{0:N0}", value);
        }

        public int _ConvertInt(string text)
        {
            string StrNew = "";
            foreach (char item in text)
            {
                var regex = new Regex(@"[^0-9]");
                if (!regex.IsMatch(item.ToString()))
                {
                    StrNew += item.ToString();
                }
            }
            return Int32.Parse(StrNew);
        }
    }
}
