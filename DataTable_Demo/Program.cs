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
           
            while (true)
            {
                Console.WriteLine("1-Data Table");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option) 
                {
                    case 1:
                        Tables_Data tables_Data = new Tables_Data();
                        tables_Data.Table();
                        break;
                }
            }
           
        }
       
    }
}
