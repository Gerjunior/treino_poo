using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Entities
{
    class Client
    {
        #region Properties
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        #endregion

        #region Constructors
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        #endregion

        public override string ToString()
        {
            return Name + ", (" + BirthDate.ToString("dd//MM/yyyy") + ") - " + Email;
        }
    }
}
