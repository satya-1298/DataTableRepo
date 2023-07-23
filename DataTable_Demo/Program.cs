using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataTable table = new DataTable("Table_Data");
            Tables_Data tables_Data = new Tables_Data();
            while (true)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("1-Data Table");
                Console.WriteLine("2-Display ");
                Console.WriteLine("3-Table to List");
                Console.WriteLine("Choose the above option");
                Console.WriteLine("-------------------------------------");
                int option =Convert.ToInt32(Console.ReadLine());
                switch(option) 
                {
                    case 1:
                        tables_Data.Table();
                        break;
                    case 2:
                        tables_Data.Display(); 
                        break;
                    case 3:
                        tables_Data.Converting_Table_List();
                        break;
                }
            }
           
        }
       
    }
}
