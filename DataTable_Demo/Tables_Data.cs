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
           
        }
    }
}
