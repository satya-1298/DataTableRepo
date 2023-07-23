using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable_Demo
{
    public class Tables_Data
    {
        public void Table()
        {

            DataTable dataTable = new DataTable("Test");
            dataTable.Columns.Add("ProductID", typeof(int));
            dataTable.Columns.Add("UserID");
            dataTable.Columns.Add("Rating");
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("IsLike");

            dataTable.Rows.Add("1", "1", "6", "Nice", "true");
            dataTable.Rows.Add("2", "2", "4", "Average", "false");
            //Printing all the data in table
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


        }
    }
}
