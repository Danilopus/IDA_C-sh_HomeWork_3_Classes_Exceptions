using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_HomeWork
{
    internal class Web_site
    {
        string _name;
        string _web_path;
        string _comment;
        IP_ADRESS _ip_adress;
        // Хотел оставить эту структуру внутри класса, но тогда приходится имет сеттеры/геттеры типа byte на каждый октет
        /*struct IP_ADRESS
        {
            byte _octet_1; // старший
            byte _octet_2;
            byte _octet_3;
            byte _octet_4;
        }*/
        public string name  { get { return _name; } set { _name = value;} }
        public string web_path  { get { return _web_path; } set { _web_path = value;} }
        public string comment   { get { return _comment; } set {  _comment = value;} }
        //public byte ip_adress_octet_1 { get { return ip_adress_octet_1; } set { ip_adress_octet_1 = value; } }
        public IP_ADRESS ip_adress    { get {return  _ip_adress; } set { _ip_adress = value;} }
        public string ShowInfo()
        {
            return "\n*** Info" +
                "\n_name     : " + _name +  
                "\n_web_path : " + _web_path +
                "\n_comment  : "+ _comment +
                "\n_ip_adress: " + _ip_adress.Show();
        }

    }
    struct IP_ADRESS
    {
        public byte _octet_1; // старший
        byte _octet_2;
        byte _octet_3;
        byte _octet_4;
        public IP_ADRESS(byte octet_1, byte octet_2, byte octet_3, byte octet_4 )
        {
            _octet_1 = octet_1;
            _octet_2 = octet_2;
            _octet_3 = octet_3;
            _octet_4 = octet_4;
        }
        public string Show()
        {
            return _octet_1 + "." + _octet_2 + "." + _octet_3 + "." + _octet_4;
        }
    }
}
