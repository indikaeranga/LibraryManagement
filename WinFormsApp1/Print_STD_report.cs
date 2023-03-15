using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iTextSharp.text.pdf.draw;
using Image = iText.Layout.Element.Image;
using LineSeparator = iText.Layout.Element.LineSeparator;
using System.Data.SqlClient;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Font;

namespace WinFormsApp1
{
    public partial class Print_STD_report : Form
    {
        ConString cn = new ConString();
        public Print_STD_report(string teacher, string stdid,string name)
        {
            InitializeComponent();
            lblteacher.Text = teacher;
            lblstd.Text = stdid;
            lblstdname.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = lblpath.Text;
                string std = lblstd.Text;
                // Must have write permissions to the path folder "" + fpath + "\\output.xls"
                PdfWriter writer = new PdfWriter("" + path + "/" + std + "_Report.pdf");
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                //var doc = new Document(pdf, PageSize.Default, false);
                Paragraph header = new Paragraph("VISAKHA VIDYALAYA COLOMBO")  // header 
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFontSize(20);

                Paragraph subheader = new Paragraph("Library Report")   // dub header
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFontSize(15);

                // Add paragraph1
                Paragraph Empty_space = new Paragraph("");

                // Line separator
                LineSeparator ls = new LineSeparator(new SolidLine(1F));          // line

                //first Paragraph
                Paragraph Paragraph1 = new Paragraph("This report include the history of student books that receive, return, missing and replace (MR)");

                Paragraph Paragraph2 = new Paragraph("> Student ID  :  " + lblstd.Text);
                Paragraph Paragraph3 = new Paragraph("> Student Name  :  " + lblstdname.Text);
                Paragraph Paragraph4 = new Paragraph("> Report Genarated by  :  " + lblteacher.Text + "           > Signature  :  _______________");

                // Add image
                Image img = new Image(ImageDataFactory
                   .Create("D:/C_Sharp/LibraryManagement/Icons/visaka.JPG"))
                   .SetTextAlignment(TextAlignment.CENTER)
                   .ScaleAbsolute(400, 200)
                   .SetMarginTop(5);


                document.Add(header);
                document.Add(subheader);
                document.Add(ls);
                //document.Add(img);   //this works
                document.Add(Empty_space);
                document.Add(Empty_space);
                document.Add(Paragraph1);
                document.Add(Paragraph2);
                document.Add(Paragraph3);

                document.Add(Empty_space);
                document.Add(Empty_space);
                //-------------
                // Table
                Table table = new Table(4);

                Cell cell12 = new Cell(1, 1)
                   .SetBackgroundColor(ColorConstants.GRAY)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Book ID"));
                Cell cell13 = new Cell(1, 1)
                   .SetBackgroundColor(ColorConstants.GRAY)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Book Name"));
                Cell cell14 = new Cell(1, 1)
                   .SetBackgroundColor(ColorConstants.GRAY)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Issued"));
                Cell cell15 = new Cell(1, 1)
                   .SetBackgroundColor(ColorConstants.GRAY)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Return Status"));

                table.AddCell(cell12.SetWidth(70));
                table.AddCell(cell13.SetWidth(230));
                table.AddCell(cell14.SetWidth(120));
                table.AddCell(cell15.SetWidth(100));

                // set body
                SqlConnection con = new SqlConnection(cn.connectionstring());
                con.Open();
                string sql = "select ib.Issue_ID,ib.Book_ID,b.Name,ib.Issue_Date,ib.Return_status from Issue_Book  ib " +
                                 " join Book_Inventory bi on ib.Book_ID = bi.Book_ID  " +
                                 " join Book b on b.ISBN = bi.ISBN " +
                                 " where ib.student_id = '" + std + "'";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    table.AddCell(reader[1].ToString());
                    table.AddCell(reader[2].ToString());
                    table.AddCell(reader[3].ToString().Substring(0,10)); //Date without midnight time
                    table.AddCell(reader[4].ToString());   
                }

                document.Add(table);
                document.Add(Empty_space);
                document.Add(Empty_space);
                document.Add(Paragraph4);
                document.Add(Empty_space);
                document.Add(ls);
                document.Add(Empty_space);
                document.Close();
                con.Close();
                MessageBox.Show("Success ! Please check the selected path for report.");
            }
            catch (Exception ex) {
                MessageBox.Show("Error !");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sSelectedPath = fbd.SelectedPath;

                lblpath.Text = sSelectedPath.ToString();

            }
        }
    }
}
