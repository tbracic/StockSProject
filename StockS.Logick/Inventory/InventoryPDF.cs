using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Previewer;
using StockS.Logic.User;
using StockS.Logic.Items;
using SkiaSharp;
using OfficeOpenXml.Table.PivotTable;

namespace StockS.Logic.Inventory
{
    public class InventoryPDF
    {
        Inventory inventory1;
        List<QuantityHistory> items;
        UserRepository repo = new UserRepository();
        float total = 0;
        public void generateInventoryPDF(string documentPath, Inventory inventory, List<QuantityHistory> inventoryItems)
        {
            inventory1 = inventory;
            items = inventoryItems;
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
                    column.Item().Text("Inventura robe").Style(titleStyle);
                    column.Item().Text( text => {
                        text.Span("Broj: ").SemiBold();
                        text.Span(inventory1.IdInventory.ToString());
                    });
                    column.Item().Text(text =>
                    {
                        text.Span("Datum izrade: ").SemiBold();
                        text.Span(inventory1.date);
                    });
                    column.Item().Text(text =>
                    {
                        text.Span("Odgovorna osoba: ").SemiBold();
                        text.Span(repo.GetUserOIB(inventory1.User).Name + " " + repo.GetUserOIB(inventory1.User).Surname);
                    });

                });

                
            });
        }
        void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Column(column =>
            {
                column.Spacing(5);

                column.Item().Element(ComposeTable);

                column.Item().Text("Potpis: ______________________________________");
            });
        }

        void ComposeTable(IContainer container)
        {
            container.Table(table =>
            {
                // step 1
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();

                });

                // step 2
                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).AlignLeft().Text("Red. broj");
                    header.Cell().Element(CellStyle).AlignCenter().Text("Naziv robe");
                    header.Cell().Element(CellStyle).AlignCenter().Text("Jed. mjere");

                    header.Cell().Element(CellStyle).AlignCenter().Text("Kolicina");

                    header.Cell().Element(CellStyle).AlignCenter().Text("Cijena");

                    header.Cell().Element(CellStyle).AlignRight().Text("Vrijednost");



                    static IContainer CellStyle(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });
                ItemRepositroy repository = new ItemRepositroy();
                int i = 1;
                foreach (QuantityHistory item in items)
                {
                    Item item1 = repository.GetItem(item.IdItem);
                    
                    table.Cell().Element(CellStyle).AlignCenter().Text(item1.IdItem);
                    table.Cell().Element(CellStyle).AlignCenter().Text(item1.Name);
                    table.Cell().Element(CellStyle).AlignCenter().Text(item1.Unit);
                    table.Cell().Element(CellStyle).AlignCenter().Text(item1.Quantity);
                    table.Cell().Element(CellStyle).AlignCenter().Text(item1.Price);
                    table.Cell().Element(CellStyle).AlignCenter().Text(item1.Price * item1.Quantity);
                    total += item1.Price * item1.Quantity;
                    i++;

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                    }
                }
                table.Footer(footer =>
                {
                    footer.Cell().Element(CellStyle).Text("");
                    footer.Cell().Element(CellStyle).Text("");
                    footer.Cell().Element(CellStyle).Text("");
                    footer.Cell().Element(CellStyle).Text("");
                    footer.Cell().Element(CellStyle).AlignCenter().Text("Ukupno: ");
                    footer.Cell().Element(CellStyle).AlignCenter().Text(total);
                    static IContainer CellStyle(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderTop(2).BorderBottom(2).BorderColor(Colors.Black);
                    }
                });
            });

        }

    }
}
