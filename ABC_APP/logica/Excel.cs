using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_APP.Vista;
using ClosedXML.Excel;

namespace ABC_APP.logica
{
    public class Excel
    {

        private FormAviso formAviso;
        private FormError formError;

        public void ExportToExcelWithFormatting(DataGridView dataGridView1)
        {
            try
            {

                string fileName;

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog1.Title = "To Excel";
                saveFileDialog1.FileName = "Archivo " + DateTime.Now.ToString("yyyyMMdd");

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog1.FileName;
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Results");
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].Name;
                        //worksheet.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.FromColor(dataGridView1.ColumnHeadersDefaultCellStyle.BackColor);
                        //worksheet.Cell(1, i + 1).Style.Font.FontColor = XLColor.FromColor(dataGridView1.RowsDefaultCellStyle.ForeColor);
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            worksheet.Cell(i + 2, j + 2).SetDataType(XLDataType.Number);
                            worksheet.Cell(i + 2, j + 2).Style.NumberFormat.Format = "0.00";


                            if (worksheet.Cell(i + 2, j + 1).Value.ToString().Length > 0)
                            {
                                XLAlignmentHorizontalValues align;

                                switch (dataGridView1.Rows[i].Cells[j].Style.Alignment)
                                {
                                    case DataGridViewContentAlignment.BottomRight:
                                        align = XLAlignmentHorizontalValues.Right;
                                        break;
                                    case DataGridViewContentAlignment.MiddleRight:
                                        align = XLAlignmentHorizontalValues.Right;
                                        break;
                                    case DataGridViewContentAlignment.TopRight:
                                        align = XLAlignmentHorizontalValues.Right;
                                        break;

                                    case DataGridViewContentAlignment.BottomCenter:
                                        align = XLAlignmentHorizontalValues.Center;
                                        break;
                                    case DataGridViewContentAlignment.MiddleCenter:
                                        align = XLAlignmentHorizontalValues.Center;
                                        break;
                                    case DataGridViewContentAlignment.TopCenter:
                                        align = XLAlignmentHorizontalValues.Center;
                                        break;

                                    default:
                                        align = XLAlignmentHorizontalValues.Left;
                                        break;
                                }

                                worksheet.Cell(i + 2, j + 1).Style.Alignment.Horizontal = align;

                                XLColor xlColor = XLColor.FromColor(dataGridView1.Rows[i].Cells[j].Style.SelectionBackColor);
                                worksheet.Cell(i + 2, j + 1).AddConditionalFormat().WhenLessThan(1).Fill.SetBackgroundColor(xlColor);

                                worksheet.Cell(i + 2, j + 1).Style.Font.FontName = dataGridView1.Font.Name;
                                worksheet.Cell(i + 2, j + 1).Style.Font.FontSize = dataGridView1.Font.Size;

                                //worksheet.Cell(i + 2, j + 1).Style.Fill.BackgroundColor = XLColor.FromColor(dataGridView1.BackgroundColor);
                                //worksheet.Cell(i + 2, j + 1).Style.Font.FontColor = XLColor.FromColor(dataGridView1.RowsDefaultCellStyle.ForeColor);

                            }

                        }
                    }
                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(fileName);
                    using (formAviso = new FormAviso("Archivo Guardo en la ruta: " + fileName))
                    {
                        formAviso.ShowDialog();
                    }
                }
            }
            catch (Exception e)
            {
                using (formError = new FormError(e.ToString()))
                {
                    formError.ShowDialog();
                }
                       
            }


        }
    }
}
