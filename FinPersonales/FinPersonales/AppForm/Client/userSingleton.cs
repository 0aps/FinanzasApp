using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;

namespace FinPersonales
{
    public class userSingleton
    {
        private static userSingleton _instance;
        private userSingleton(){}
        public String _userName {get; set;}
        public Guid _Id { get; set; }

        public void setUserName(String username)
        {
            _userName = username;
            MembershipUser user = Membership.GetUser(username);
            Guid userId = (Guid)((user.ProviderUserKey));
            _Id = userId;
        }

        public static userSingleton getIntance()
        {
           if(_instance == null)
           {
               _instance = new userSingleton();
           }

           return _instance;
        }


    }
}
