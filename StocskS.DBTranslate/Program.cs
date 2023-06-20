using StockS.Logic;
using StockS.Logic.Items;
using System.Data.SQLite;

string path = "asd";
AppDatabase instanceOut = new AppDatabase();
AppDatabase instanceIN = new AppDatabase(path);

string sql1 = "SELECT [arsif], [arnaziv], [arcijena] , [arjmj]  FROM [artikli] WHERE [arneaktivan] = 0";
instanceIN.Open();
SQLiteDataReader reader = instanceIN.GetData(sql1);
List<Item> items = new List<Item>();
while (reader.Read())
{
    int id = int.Parse(reader.GetString(0));
    string name = reader.GetString(1);
    float price = reader.GetFloat(2);
    string mj = reader.GetString(3);
    int mjera;
    if (mj == "kom" || mj == "KOM") mjera = 0;
    else if(mj == "") mjera = 0;
    else mjera = 1;
    Item item = new Item(id, name, price, 0, (Units)mjera,0);
    items.Add(item);
}
reader.Close();
instanceIN.Close();
instanceOut.Open();
foreach(Item item1 in items)
{
    string sql2 = $"INSERT INTO [Item] VALUES('{item1.IdItem}','{item1.Name}','{item1.Price}','{item1.Quantity}','{item1.Unit}','{item1.Company}');";
    instanceOut.InsertData(sql2);
}
instanceOut.Close();