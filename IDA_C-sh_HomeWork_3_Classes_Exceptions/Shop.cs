using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_HomeWork
{
    internal class Shop
    {
        string _name;
        POST_ADRESS _post_adress;
        string _comment;
        string _phone_number;
        string _email;
        public struct POST_ADRESS
        {
            public string? _country;
            public string? _city;
            public string? _street;
            public string? _house;
            public string _room;
            public string _zip;
            public string ShowInfo()
            {              
                    return _zip+" "+_country + ", " + _city + ", " + _street + ", " + _house + ", " + _room; 
            }
        }
        public string Name { get { return _name; } set { _name = value; } }
        public POST_ADRESS Post_adress { get { return _post_adress; } set { _post_adress = value; } }
        public ref POST_ADRESS Get_POST_ADRESS_as_object() { return ref _post_adress; }
        public string Comment { get { return _comment; } set { _comment = value; } }
        public string Phone_number { get { return _phone_number; } set { _phone_number = value; } }
        public string Email { get { return _email; } set { _email = value; } }
   


        public string ShowInfo()
        {
            return "\n*** Info" +
                "\n_name        : " + _name +
                "\n_post_adress : " + _post_adress.ShowInfo() +
                "\n_comment     : " + _comment +
                "\n_phone_number: " + _phone_number +
                "\n_email       : " + _email;
        }

    }
}
