
using Microsoft.VisualBasic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace StockS.Logic
{
    public class InputCheck
    {
        public string CheckItem(string name, float price, int quantity )
        {
            string msg = "";
            if (string.IsNullOrEmpty(name)) { msg = "Name cannot be empty";}
            else if (price <=0) { msg = "Price must be positive value"; }
            else if (quantity<0) { msg = "Quantitiy must be higher than 0."; }
            return msg;
        }
        public string CheckLogin(string oib, string password)
        {

            if (string.IsNullOrEmpty(oib)) { return "OIB field cannot be empty!"; }
            else if (string.IsNullOrEmpty(password)) { return "Password field cannot be empty!"; }
            else {
                string msg = "";
                msg = CheckOIB(long.Parse(oib)); 
                if (!string.IsNullOrEmpty(msg)) return msg; 
                msg = CheckPass(password);
                if(!string.IsNullOrEmpty(msg)) return msg;
                return msg;
            }
        }
        public string CheckComp(string oiba, string adress, string telephone, string email)
        {
            string msg = "";
            long oib = long.Parse(oiba);
            msg = CheckOIB(oib);
            if (string.IsNullOrEmpty(msg))
            {
                msg = CheckAdress(adress);
                if(string.IsNullOrEmpty(msg))
                {
                    msg = CheckPhone(telephone);
                    if(string.IsNullOrEmpty(msg))
                    {
                        msg = CheckEmail(email);
                        if (string.IsNullOrEmpty(msg)) return msg;
                        else return msg;
                    }
                    else return msg;
                }
                else return msg;
            }
            else return msg;
        }

        private string CheckEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Match match= Regex.Match(email, pattern);
            if (match.Success) { return ""; }
            else return "Email is in wrong form";
        }

        private string CheckPhone(string telephone)
        {
            throw new NotImplementedException();
        }

        private string CheckAdress(string adress)
        {
            string pattern = @"\s+[a-zA-Z\s]+\d+,\s+\d{5}\s+[a-zA-Z\s]+$";
            Match match = Regex.Match(adress, pattern);
            if (match.Success) { return ""; }
            else return "Adress is in wrong form";
            throw new NotImplementedException();
        }

        private string CheckPass(string pass)
        { 
            if (pass.Length<8) return "Password is to short.";
            else return "";
        }
        private string CheckOIB(long oib)
        {
            if (oib <= 9999999999) return "Oib je prekratak!";
            else if (oib >= 100000000000) return "OIB je Predug";
            else return "";
        }
    }
}
