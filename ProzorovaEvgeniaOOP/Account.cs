using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProzorovaEvgeniaOOP
{
    public class Account
    {
        private int id;
        private string name;
        private string password;
        public int Id => id;
        public string Name => name;
        public string Password => password;
        public Account(int id, string name, string password) 
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }
    }
}
