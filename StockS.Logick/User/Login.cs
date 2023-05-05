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
        public object SLogIn(string username,string pass)
        {
            string msg = "";
            
            if (string.IsNullOrEmpty(msg)) {
                userRepository = new UserRepository();
                msg = userRepository.CheckIfDatabaseExist();
                if (string.IsNullOrEmpty(msg)) { return userRepository.GetUserLogin(username, pass); }
                else return msg;
                }
            else { return msg; }
            
        }
    
    }
}
