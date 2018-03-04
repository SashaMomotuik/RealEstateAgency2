using BLL.Model;
using ClosedXML.Excel;
using Microsoft.Win32;
using RealEstateAgency2;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BLL.DataBaseToExcell
{
    public static class ExportToExcell
    {
 

        public static  void WriteExcel(List<RoomShowViewModel> listrooms)
        {

            /* RoomCity = r.NumberHouse.Street.District.City.Name,
                     RoomDistrict = r.NumberHouse.Street.District.Name,
                     RoomStreet = r.NumberHouse.Street.Name,
                     RoomNumberHouse = r.NumberHouse.Number,
                     NumberRoom = r.NumberRoom,
                     CountRoom = r.CountRooms,
                     Floor = r.Floor,
                     Square = r.Square,
                     Price = r.Price,
                     Reserved = r.Reserved,
                     Sales = r.Sales,*/

            using (DataTable dt = new DataTable())
            {
                dt.Columns.Add(new DataColumn("#",
                   Type.GetType("System.Int32")));
                dt.Columns.Add(new DataColumn("City",
                    Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("District",
                    Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("Street",
                    Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("NumberHouse",
                    Type.GetType("System.Int32")));
                dt.Columns.Add(new DataColumn("NumberRoom",
                   Type.GetType("System.Int32")));
                dt.Columns.Add(new DataColumn("CountRooms",
                   Type.GetType("System.Int32")));
                dt.Columns.Add(new DataColumn("Floor",
                   Type.GetType("System.Int32")));
                dt.Columns.Add(new DataColumn("Square",
                   Type.GetType("System.Decimal")));
                dt.Columns.Add(new DataColumn("Price",
                Type.GetType("System.Decimal")));
                dt.Columns.Add(new DataColumn("Reserved",
                Type.GetType("System.Boolean")));
                dt.Columns.Add(new DataColumn("Sales",
                Type.GetType("System.Boolean")));



                string fileName = "outputRooms.xlsx";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    int i = 1;
                    foreach (var item in listrooms)
                    {

                        object[] listCols =
                        {
                            i,
                            item.RoomCity,
                            item.RoomDistrict,
                            item.RoomStreet,
                            item.RoomNumberHouse,
                            item.NumberRoom,
                            item.CountRoom,
                            item.Floor,
                            item.Square,
                            item.Price,
                            item.Reserved,
                            item.Sales
                        };



                         dt.Rows.Add(listCols);

                        i++;
                    }



                    wb.Worksheets.Add(dt, "Rooms");
                    wb.SaveAs(fileName);

                }




                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Excell File";

               // saveFileDialog1.CheckFileExists = true;

                saveFileDialog1.CheckPathExists = true;

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excell files (*.xlsx)|.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;



                if (saveFileDialog1.ShowDialog() == true)

                {
                    string oldpath = Environment.CurrentDirectory + "\\" + fileName;
                  string newpath = saveFileDialog1.FileName;
                    if (System.IO.File.Exists(newpath))
                        System.IO.File.Delete(newpath);

                    System.IO.File.Move(oldpath, newpath);
                    MessageBox.Show($"File \"{Path.GetFileName(newpath)}\" successfully create!", "DataBase to Excell",MessageBoxButton.OK);

                }

            }

        }



    }
}
