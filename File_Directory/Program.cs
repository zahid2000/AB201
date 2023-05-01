#region File,Directory

//string path = @"C:/Users/lenovo/Desktop/AB201/test";
//string pathFile = @"C:/Users/lenovo/Desktop/AB201/index.html";

//Console.WriteLine(Directory.Exists(path));
//if (!Directory.Exists(path))
//{
//    Directory.CreateDirectory(path);
//}
//Directory.CreateDirectory(path);
//Directory.Delete(path,true);



//Console.WriteLine(File.Exists(pathFile));
//if (!File.Exists(pathFile))
//{
//    File.Create(pathFile);
//}
//else
//{
//    Console.WriteLine("Var");
//}
//File.Create(pathFile);
//File.Delete(pathFile);


//string[] files = Directory.GetFiles(path);
//foreach (string file in files)
//{
//    Console.WriteLine(file);
//}

//string[] directories = Directory.GetDirectories(path);
//foreach(string directory in directories)
//{
//    Console.WriteLine(directory);
//}

//Console.WriteLine(Directory.GetCurrentDirectory());
//FileInfo file = new FileInfo(pathFile);
//Console.WriteLine(file.FullName); 
//DirectoryInfo directory = new DirectoryInfo(path);
//directory.Create();

#endregion

#region Stream
//string path = @"C:/Users/lenovo/Desktop/AB201";
//string pathFile = @"C:/Users/lenovo/Desktop/AB201/test.txt";
//if (!File.Exists(pathFile))
//{
//    File.Create(pathFile);
//    Console.WriteLine("Yaradildi");
//}
//string text = "";
//using (StreamReader sr = new StreamReader(pathFile))
//{
//    text = sr.ReadToEnd();
//}

//using (StreamWriter sw = new StreamWriter(pathFile))
//{
//    sw.WriteLine(text);
//    sw.WriteLine("AB2021");
//    sw.WriteLine("Hamiya salamlar2");
//}





#endregion

#region Serializer
using File_Directory.Models;
using Newtonsoft.Json;
using System.Xml.Serialization;
using Xml2CSharp;
#region Json
string jsonPath = @"C:\Users\lenovo\Desktop\Code_Academy\Aztu\AB201\File_Directory\Data\jsonData.json";
//Product iphone14 = new Product { Id = 1, Name = "Iphone 14", Price = 1700.00008787655m };
//Product samsung = new Product { Id = 2, Name = "Samsung S23 ultra ", Price = 2300};
//OrderItem orderItem = new OrderItem { Id = 1, Product = iphone14, Count = 18 };
//orderItem.TotalPrice = iphone14.Price*orderItem.Count;
//OrderItem orderItem1 = new OrderItem { Id = 2, Product = samsung, Count = 18 };
//orderItem1.TotalPrice = samsung.Price * orderItem1.Count;
//Order order = new Order() { Id = 1, Items = new List<OrderItem>{ orderItem, orderItem1 }, TotalPrice = orderItem1.TotalPrice + orderItem.TotalPrice };

//Console.WriteLine(JsonConvert.SerializeObject(order));
//using (StreamWriter sw = new StreamWriter(jsonPath))
//{
//    sw.WriteLine(JsonConvert.SerializeObject(order));
//}
//Order order=new Order();
//using (StreamReader sr=new StreamReader(jsonPath))
//{
//    string data = await sr.ReadToEndAsync();
//    //order = JsonConvert.DeserializeObject<Order>(data);
//}
//Console.WriteLine(order.Items[0].Product.Name);
//Console.WriteLine(order.Items[0].Product.Price); 
#endregion
#region Xml
string xmlPath = @"C:\Users\lenovo\Desktop\Code_Academy\Aztu\AB201\File_Directory\Data\xmlData.xml";

XmlSerializer serializer = new XmlSerializer(typeof(ValCurs));
ValCurs valCurs=new ValCurs();
using (StreamReader sr = new StreamReader(xmlPath))
{
    valCurs = (ValCurs)serializer.Deserialize(sr);
}
//Console.WriteLine(valCurs.ValType[1].Valute[0].Name);
//Console.WriteLine(valCurs.ValType[1].Valute[0].Nominal);
//Console.WriteLine(valCurs.ValType[1].Valute[0].Value);
foreach (var type in valCurs.ValType)
{
	foreach (var valuta in type.Valute)
	{
        Console.WriteLine(valuta.Name);
        Console.WriteLine(valuta.Value);
    }
}

//Product iphone14 = new Product { Id = 1, Name = "Iphone 14", Price = 1700.00008787655m };
//Product samsung = new Product { Id = 2, Name = "Samsung S23 ultra ", Price = 2300 };
//OrderItem orderItem = new OrderItem { Id = 1, Product = iphone14, Count = 18 };
//orderItem.TotalPrice = iphone14.Price * orderItem.Count;
//OrderItem orderItem1 = new OrderItem { Id = 2, Product = samsung, Count = 18 };
//orderItem1.TotalPrice = samsung.Price * orderItem1.Count;
//Order order = new Order() { Id = 1, Items = new List<OrderItem> { orderItem, orderItem1 }, TotalPrice = orderItem1.TotalPrice + orderItem.TotalPrice };

//XmlSerializer serializer = new XmlSerializer(typeof(Order));
//using (StreamWriter sw=new StreamWriter(xmlPath))
//{
//    serializer.Serialize(sw,order);
//}
#endregion
#endregion
