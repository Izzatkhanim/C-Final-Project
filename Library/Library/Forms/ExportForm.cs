using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data;
using Library.Models;
using ClosedXML.Excel;

namespace Library.Forms
{
    public partial class ExportForm : Form
    {
        private readonly LibraryDbContext _context;

        public ExportForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillReport();
        }

        //Sifarishleri dgv-e chixartmaq uchun fill metodu
        private void FillReport()
        {
            var ShowReport = _context.Orders
                                           .Include("Book")
                                           .Include("Client")
                                           .Where(r => r.IsDone != false)
                                           .ToList();

            foreach (var item in ShowReport)
            {
                DgvReportOrders.Rows.Add(item.Id,
                                         item.Client.Name,
                                         item.Client.Lastname,
                                         item.Client.Email,
                                         item.Client.Phone,
                                         item.Book.Title,
                                         item.Count,
                                         item.Date.ToString("dd.MM.yyyy"),
                                         item.ReturnDate,
                                         item.Deadline.ToString("dd.MM.yyyy"),
                                         item.ReturnPrice);
            }
        }

        //Ay intervali sechib o arada olan sifarishleri axtarib dgv-e chixartmaq
        private void BtnReportSearch_Click(object sender, EventArgs e)
        {
            var FromDate = DtpReportFrom.Value.Date;
            var ToDate = DtpReportTo.Value.Date;
            DgvReportOrders.Rows.Clear();
            var ShowReport = _context.Orders
                                            .Include("Book")
                                            .Include("Client")
                                            .ToList();

            foreach (var item in ShowReport)
            {
                if (item.IsDone == true && FromDate <= item.ReturnDate && item.ReturnDate <= ToDate)
                {
                    DgvReportOrders.Rows.Add(item.Id,
                                  item.Client.Name,
                                  item.Client.Lastname,
                                  item.Client.Email,
                                  item.Client.Phone,
                                  item.Book.Title,
                                  item.Count,
                                  item.Date.ToString("dd.MM.yyyy"),
                                  item.ReturnDate,
                                  item.Deadline.ToString("dd.MM.yyyy"),
                                  item.ReturnPrice);
                }
            }
        }

        //Excel-e export etmek
        private void BtnExcelExport_Click(object sender, EventArgs e)
        {

            if (DgvReportOrders.Rows.Count > 0)
            {

                try
                {
                    var workbook = new XLWorkbook();
                    var workSheet = workbook.Worksheets.Add("Bills");
                    for (int i = 1; i < DgvReportOrders.Columns.Count; i++)
                    {
                        workSheet.Cell(1, i).SetValue(DgvReportOrders.Columns[i].HeaderText);
                        workSheet.Column(i).Width = 15;
                    }
                    for (int i = 1; i < DgvReportOrders.Columns.Count - 1; i++)
                    {
                        for (int j = 1; j < DgvReportOrders.Columns.Count; j++)
                        {
                            workSheet.Cell(i + 2, j).SetValue(DgvReportOrders.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                    workbook.SaveAs(@"C:\Users\nrzayeva\Desktop\Bills.xlsx");
                    MessageBox.Show("Excell file was created");
                }
                catch (System.IO.IOException)
                {

                    MessageBox.Show("This file is open at the moment, please try again after closing the file.");
                    return;
                }
            }
        }
    }
}
