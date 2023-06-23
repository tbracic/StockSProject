using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Previewer;
using StockS.Logic.Items;
namespace StockS.Logic.Inventory
{
    public class WriteOffListpdf
    {
        public void generateListPdf(string documentPath)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(50);
                    page.Header().Height(100).Background(Colors.Grey.Lighten1);
                    page.Content().Background(Colors.Grey.Lighten3);
                    page.Footer().Height(50).Background(Colors.Grey.Lighten1);

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                    page.Footer().AlignCenter().Text(x =>
                    {
                        x.CurrentPageNumber();
                        x.Span(" / ");
                        x.TotalPages();
                    });
                });

            }).GeneratePdf(documentPath + ".pdf");
        }
        void ComposeHeader(IContainer container)
        {
            var titleStyle = TextStyle.Default.FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item().Text("Lista artikla").Style(titleStyle);

                    column.Item().Text(text =>
                    {
                        text.Span("Datum izrade: ").SemiBold();
                        text.Span(DateTime.Now.ToShortDateString());
                    });

                });

                row.ConstantItem(100).Height(50).Placeholder();
            });
        }
        void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Column(column =>
            {
                column.Spacing(5);

                column.Item().Element(ComposeTable);
            });
        }

        void ComposeTable(IContainer container)
        {
            container.Table(table =>
            {
                // step 1
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(25);
                    columns.RelativeColumn(3);

                    columns.RelativeColumn();
                });

                // step 2
                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("#");
                    header.Cell().Element(CellStyle).Text("Product");

                    header.Cell().Element(CellStyle).AlignRight().Text("Quantity");


                    static IContainer CellStyle(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });
                ItemRepositroy repositroy = new ItemRepositroy();
                List<string> imena = repositroy.GetAllItemNames();
                int i = 1;
                // step 3
                foreach (string item in imena)
                {
                    table.Cell().Element(CellStyle).Text(i);
                    table.Cell().Element(CellStyle).Text(item);
                    table.Cell().Element(CellStyle).AlignRight().Text("_______");
                    i++;

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                    }
                }
            });

        }
    }
}
