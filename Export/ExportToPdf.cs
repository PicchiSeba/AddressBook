using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Export
{
    public class ExportToPdf : IExportToPdf
    {
        private int columns;
        private string destination = "C:\\Users\\" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "\\Documents\\";
        private string filename = "";
        private Table table;

        public ExportToPdf(List<String> columns, string elementsName)
        {
            this.columns = columns.Count;
            filename = elementsName + "_list.pdf";

            PdfWriter writer = new PdfWriter(destination + "\\" + filename);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document document = new Document(pdfDoc);

            Table table = new Table(columns.Count).UseAllAvailableWidth();
            foreach(String singleColumn in columns)
            {
                Cell cellTemp = new Cell();
                cellTemp.Add(new Paragraph(singleColumn));
                cellTemp.SetBorder(new SolidBorder(3));
                table.AddCell(cellTemp);
            }
            this.table = table;
        }

        public void AddRowElements(List<String> elems)
        {
            if(elems.Count <= columns)
            {
                foreach(String singleElem in elems)
                {
                    table.AddCell(singleElem);
                }
            }
        }
    }
}
