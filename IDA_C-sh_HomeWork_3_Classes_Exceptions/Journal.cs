using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_HomeWork
{
    internal class Journal
    {
        string _name;
        DateTime _date_foundation;
        string _comment;
        string _phone_number;
        string _email;
        public string Name { get { return _name; } set { _name = value; } }
        public DateTime Date_foundation { get { return _date_foundation; } set { _date_foundation = value; } }
        public string Comment { get { return _comment; } set { _comment = value; } }    
        public string Phone_number  { get { return _phone_number; } set{ _phone_number = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string ShowInfo()
        {
            return "\n*** Info" +
                "\n_name     : " + _name +
                "\n_year_foundation: " + _date_foundation.Year +
                "\n_comment : " + _comment +
                "\n_phone_number : " + _phone_number +
                "\n_email: " + _email;
        }

    }
}
