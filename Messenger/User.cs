using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
   public class User
    {
       
        private String firstName;
        private String email;
        private String password;

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public User() { }


        public User(String firstName, String email, String password)
        {
            this.firstName = firstName;
            this.email = email;
            this.password = password;
        }
   

    }
}
