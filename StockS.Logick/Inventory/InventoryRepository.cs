using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using QuestPDF.Helpers;



namespace StockS.Logic.Inventory
{
    public class InventoryRepository
    {
        string patha = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db.db");
        public string CreatepdfFile(string title)
        {
            string FilePath = title + ".pdf";
            string msg = "";
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header()
                        .Text(title)
                        .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(20);

                            x.Item().Text("jel ovo stvarno tolko jebeno");
                            x.Item().Image(Placeholders.Image(200, 100));
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page ");
                            x.CurrentPageNumber();
                        });
                });
            })
.GeneratePdf(FilePath);
            return FilePath + "is generated." ;
        }
    }
}
