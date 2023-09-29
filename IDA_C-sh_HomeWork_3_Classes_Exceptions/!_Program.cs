// HomeWork template 1.3 // date: 29.09.2023

using IDA_C_sh_HomeWork;
using Service;
using System;
using System.Linq.Expressions;
using System.Net;
using System.Text;

/// QUESTIONS ///
/// 
/// 1. Почему возникает ошибка: System.StackOverflowException: 'Exception_WasThrown'
///    public byte ip_adress_octet_1 { get { return ip_adress_octet_1; } set { ip_adress_octet_1 = value; } }
///    
/// /// /// ///
/// 
/// 2. Модификатор доступа в структурах по умолчанию - private
/// IP_ADRESS ip_adr = new(192, 168, 11, 16);
/// byte b1 = ip_adr._octet_1;



// HomeWork 03 : [Classes, Exceptions] --------------------------------

namespace IDA_C_sh_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu.MainMenu mainMenu = new MainMenu.MainMenu();
            do
            {
                Console.Clear();
                mainMenu.Show_menu();
                if (mainMenu.User_Choice_Handle() == 0) break;
                Console.ReadKey();
            } while (true);
        }

        public static void Task_1(string work_name)
        {
            Console.Write(work_name + "\n");
            Console.Write("\nEnter a square edge length -> ");
            int edge_length = ServiceFunction.Get_Int(3, 50, "try in range [3..50]");
            //Console.Write("\nEnter a symbol or ASCII code to draw -> ");
            Console.Write("\nEnter a symbol to draw -> ");
            char symbol = Convert.ToChar(Console.Read());

            Square_Draw();

            //void Square_Draw(int edge_length, char symbol)
            void Square_Draw()
            {
                Console.Write("\n\n");
                Drow_horizontal_line(edge_length, symbol);
                Draw_square_side_edges(edge_length, symbol);
                Drow_horizontal_line(edge_length, symbol);
            }
            void Draw_square_side_edges(int edge_length, char symbol)
            {
                for (int i = 1; i < edge_length - 1; i++)
                {
                    Console.Write(symbol);
                    for (int ii = 1; ii < edge_length - 1; ii++) { Console.Write(' '); }
                    Console.WriteLine(symbol);
                }
            }
            void Drow_horizontal_line(int length, char symbol)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(symbol);
                }
                Console.Write('\n');
            }        
        }

        public static void Task_2(string work_name)
        {
            Console.Write(work_name + "\n");
            Console.Write("\nEnter a number -> ");
            string user_number = Convert.ToString(ServiceFunction.Get_Int());            
            Console.WriteLine("\nis palindrome -> " + is_palindrome(user_number));     
        }
        static bool is_palindrome(string user_number)
        {
            for (int i = 0; i < user_number.Length / 2; i++)
            {
                if (user_number[i] != user_number[user_number.Length - 1 - i]) return false;
            }
            return true;
        }
        public static void Task_3(string work_name)       
         /* Задание */
        {
            Console.Write(work_name + "\n");

            int[] random_array = new int[10];
            for (int i = 0; i < random_array.Length; i++) { random_array[i] = Convert.ToInt32(ServiceFunction.Get_Random(100)); }
            Console.WriteLine("\noriginal array:");
            Array.Sort(random_array);
            foreach (var item in random_array)  { Console.Write((item + " | ").PadLeft(5)); }
            Console.Write("\b\b \n");

            Console.WriteLine("\n\nEnter a filter_array:");
            Console.Write("Length -> ");
            int[] filtr_array = new int[ServiceFunction.Get_Int(1,10, "try in range [1..10]")];
            for (int i = 0; i < filtr_array.Length;i++) 
            {
                Console.Write("\nfiltr_array[" + i + "] -> ");
                filtr_array[i] = ServiceFunction.Get_Int(); 
            }
                  
            Console.WriteLine("\noriginal array after filtration:");
            foreach (var item in Array_Filtration(random_array, filtr_array)) { Console.Write((item + " | ").PadLeft(5)); }
            Console.Write("\b\b \n");

        }
        static int[] Array_Filtration(int[] orginal_array, int[] filtr_array)
        {
            return Array.FindAll(orginal_array, Is_Not_from_filtr_array).ToArray();
           
            bool Is_Not_from_filtr_array(int n)
            {
                foreach (var item in filtr_array)
                    if (item == n) return false;
                return true;
            }
        }
     
        public static void Task_4(string work_name)
        /* Задание */
        {
            Console.Write(work_name + "\n");      

            Web_site new_web_Site = new Web_site();
            new_web_Site.name = "C# guru coding site";
            new_web_Site.web_path = "http://mysuperCsharpsite.guru";
            new_web_Site.comment = "This is the newest guru C# site. No articles yet...";
            //new_web_Site.ip_adress_octet_1 = 190; // ??? System.StackOverflowException: 'Exception_WasThrown'
            new_web_Site.ip_adress = new( 192, 168, 11, 16 );

            Console.WriteLine(new_web_Site.ShowInfo());
        }
        public static void Task_5(string work_name)
        /* Задание */

        {
            Console.Write(work_name + "\n");

            Journal new_journal = new Journal();
            new_journal.Name = "C# Guru Journal";
            new_journal.Date_foundation = new(2020, 1, 1);
            new_journal.Comment = "This is the coolest C# Guru Journal. No articles yet...";
            new_journal.Phone_number = "+7(900)111-55-66";
            new_journal.Email = "comebacksoon@csharpjournal.guru";

            Console.WriteLine(new_journal.ShowInfo());

        }
        public static void Task_6(string work_name)
        /* Задание */        
        {
            Console.Write(work_name + "\n");

            Shop new_shop = new Shop();
            new_shop.Name = "C# code shop";

            new_shop.Get_POST_ADRESS_as_object()._zip = "620000";
            new_shop.Get_POST_ADRESS_as_object()._country = "Russia";
            new_shop.Get_POST_ADRESS_as_object()._city = "Ekaterinburg";
            new_shop.Get_POST_ADRESS_as_object()._street = "Lenina";
            new_shop.Get_POST_ADRESS_as_object()._house = "8";

            new_shop.Comment = "This is the rightest C# Guru-code shop. No code-lots to buy yet...";
            new_shop.Phone_number = "+7(343)370-20-50";
            new_shop.Email = "welcometeam@csharpcode.shop";

            Console.WriteLine(new_shop.ShowInfo());

        }


    }// class Program
}// namespace