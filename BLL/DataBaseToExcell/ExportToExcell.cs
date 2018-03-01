using RealEstateAgency2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DataBaseToExcell
{
    public class ExportToExcell
    {
       // private MyContext _context;

       // List<tblRooms> list;
       //  dt;

       // public ExportToExcell(MyContext context)
       // {
       //     _context = context;


       //     list = (from qq in _context.tblRooms select qq).ToList();

        

       // }


       //public  void WriteExcel()
       // {

       //     DataTable dt = ToDataTable<tblRooms>(list);
       //     string fileName = "outputBooks.xlsx";
       //     using (XLWorkbook wb = new XLWorkbook())
       //     {
       //         //for (int i = 0; i < 10; i++)
       //         //{
       //         //    object[] listCols =
       //         //    {
       //         //            i+1,
       //         //            "Step",
       //         //            null,
       //         //            Guid.NewGuid().ToString()
       //         //        };
       //         //    dt.Rows.Add(listCols);
       //         }
       //         wb.Worksheets.Add(dt, "users-images");
       //         wb.SaveAs(fileName);

       //     }


       // }


       // private  DataTable ToDataTable<T>(List<T> items)
       // {
       //     DataTable dataTable = new DataTable(typeof(T).Name);

       //     //Get all the properties
       //     PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
       //     foreach (PropertyInfo prop in Props)
       //     {
       //         //Setting column names as Property names
       //         dataTable.Columns.Add(prop.Name);
       //     }
       //     foreach (T item in items)
       //     {
       //         var values = new object[Props.Length];
       //         for (int i = 0; i < Props.Length; i++)
       //         {
       //             //inserting property values to datatable rows
       //             values[i] = Props[i].GetValue(item, null);
       //         }
       //         dataTable.Rows.Add(values);
       //     }
       //     //put a breakpoint here and check datatable
       //     return dataTable;
       // }





    }
}
