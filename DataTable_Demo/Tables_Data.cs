using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DataTable_Demo
{
    public class Tables_Data
    {
        DataTable dataTable = new DataTable("Employee");
        public void Table()
        {

            dataTable.Columns.Add("ProductID", typeof(int));
            dataTable.Columns.Add("UserID");
            dataTable.Columns.Add("Rating");
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("IsLike");

            dataTable.Rows.Add("1", "1", "6", "Nice", "true");
            dataTable.Rows.Add("2", "2", "4", "Average", "false");
            //Printing all the data in table
        }
        public void Display()
        { 
            Console.WriteLine("------------------------------------");
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("ProductID ={0} , UserID = {1} , Rating = {2} , Review = {3} ,IsLike = {4} ", row["ProductID"], row["UserID"], row["Rating"], row["Review"], row["IsLike"]);
            }

            //Display certain Column
            Console.WriteLine("-------------------------------------");
            foreach (DataRow rows in dataTable.Rows)
            {
                Console.WriteLine("ProductID = {0} ", rows["ProductID"]);
            }
            //Only row values without column
            Console.WriteLine("-------------------------------------");
            foreach (DataRow item in dataTable.Rows) //Takes each TableRow from table
            {
                foreach (var value in item.ItemArray) //Take each values from the rows
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("No .of Rows "+dataTable.Rows.Count);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("No .of Columns " + dataTable.Columns.Count);
           // dataTable=

        }
        public void Converting_Table_List()
        {
            // Table(); 
            Console.WriteLine("Converting table to link");
            Console.WriteLine("-------------------------------------");
            List<Employee> list= new List<Employee>();  
            for(int val=0;val<dataTable.Rows.Count;val++) 
            {
                Employee employee=new Employee();
                employee.ProductID = Convert.ToInt32(dataTable.Rows[val]["ProductID"]);
                employee.UserID = Convert.ToInt32(dataTable.Rows[val]["UserID"]);
                employee.Rating= Convert.ToInt32(dataTable.Rows[val]["Rating"]);
                employee.Review = dataTable.Rows[val]["Review"].ToString();
                employee.IsLike = Convert.ToBoolean(dataTable.Rows[val]["IsLike"]);
                list.Add(employee);
            }
            foreach(var result in list) 
            {
                Console.WriteLine(result.ProductID + " " + result.UserID + " " + result.Rating + " " +result.Review+" "+result.IsLike);
            }
            Console.WriteLine("-------------------------------------");
            // var res = list.Where(x => x.ProductID<2&&x.Rating<2);
            var res =list.OrderBy(x => x.IsLike=true);
            foreach(var result in res) 
            {
                Console.WriteLine(result.ProductID+" "+result.UserID+" "+result.Rating+" "+result.IsLike);
            }

           
        }

       
    }
}
