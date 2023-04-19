using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockS.Logic.User
{
    public class Login
    {
        UserRepository userRepository;
        InputCheck check;
        public object SLogIn(string oib0,string pass)
        {
            string msg = "";
            check = new InputCheck();
            msg = check.CheckLogin(oib0, pass);
            if (string.IsNullOrEmpty(msg)) {
                long oib = long.Parse(oib0);
                userRepository = new UserRepository();
                msg = userRepository.CheckIfDatabaseExist();
                if (string.IsNullOrEmpty(msg)) { return userRepository.GetUserLogin(oib, pass); }
                else return msg;
                }
            else { return msg; }
            
        }
    
    }
}
