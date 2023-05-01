
#region Thread
//Thread th1 = new Thread(Loop1);
//Thread th2 = new Thread(Loop2);
//Thread th3 = new Thread(Loop3);
//th1.Start();
//th3.Start();
//th2.Start();
//th1.Join();
//th2.Join();
//th3.Join();
//Console.WriteLine("Malak");

//Loop1();
//Loop2(); 
#endregion
#region Race condition,Deadlock
//int count = 0;
//object lockObj = new object();
//object lockObj1 = new object();
//Thread th1 = new Thread(Increase);
//Thread th2 = new Thread(Decrease);
//th1.Start();
//th2.Start();
//th1.Join();
//th2.Join();
//Console.WriteLine(count); 
#endregion
#region Thread

using System.Diagnostics;

void Loop1()
{
    for (int i = 0; i < 100; i++)
    {

        Thread.Sleep(1000);
        Console.WriteLine($"Loop1 -> {i}");
    }
}

void Loop2()
{
    for (int i = 100; i < 200; i++)
    {
        Thread.Sleep(2000);
        Console.WriteLine($"Loop2 -> {i}");
    }
}
void Loop3()
{
    for (int i = 200; i < 300; i++)
    {

        Thread.Sleep(3000);
        Console.WriteLine($"Loop3 -> {i}");
    }
}
#endregion
#region Race Condition,Deadlock

//void Increase()
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        lock(lockObj){
//            lock (lockObj1)
//            {
//                count++;
//            }
//        }        
//    }
//}
//void Decrease()
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        lock (lockObj1)
//        {
//            lock(lockObj){
//                count--;            }
//        }
//    }
//}


#endregion

//Console.WriteLine(await Sum());

//async Task<int> Sum()
//{
//    int result = 0;
//   await Task.Run(async () =>
//    {
//        for (int i = 0; i < 100; i++)
//        {
//            await Task.Delay(10);
//            result += i;
//        }

        
//    });
   

//    return result;
//}





//string[] urls = new string[]
//{
//    "https://docs.microsoft.com",
//    "https://docs.microsoft.com/aspnet/core",
//    "https://docs.microsoft.com/azure/devops",
//    "https://docs.microsoft.com/dotnet",
//    "https://docs.microsoft.com/dynamics365",
//    "https://docs.microsoft.com/education",
//    "https://docs.microsoft.com/enterprise-mobility-security",
//    "https://docs.microsoft.com/gaming",
//    "https://docs.microsoft.com/graph",
//    "https://docs.microsoft.com/microsoft-365",
//    "https://docs.microsoft.com/office",
//    "https://docs.microsoft.com/powershell"
//};


////GetHttpContent(urls);
//async void GetHttpContent(string[] urls)
//{
//    HttpClient httpClient = new HttpClient();
//    Stopwatch sw = new Stopwatch();
//    sw.Start();
//    foreach (var url in urls)
//    {
//        var result =  httpClient.GetStringAsync(url).Result;
//        Console.WriteLine(result.Length);       
//    }
//    sw.Stop();
//    Console.WriteLine($"{sw.ElapsedMilliseconds} ms");
//}


//await GetHttpContentAsync(urls);
//async Task GetHttpContentAsync(string[] urls)
//{
//    HttpClient httpClient = new HttpClient();
//    List<Task<string>> tasks=new List<Task<string>>();
//    Stopwatch sw = new Stopwatch();
//    foreach (var url in urls)
//    {
//        Task<string> result = httpClient.GetStringAsync(url);
//       tasks.Add(result);
//    }
//    sw.Start();
//    string[] arr=  await Task.WhenAll(tasks);
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item.Length);
//    }
//    sw.Stop();

//    Console.WriteLine($"{sw.ElapsedMilliseconds} ms");
   
//}

//get();
//Console.ReadLine();
//async void get()
//{
//await    GetHttpContentAsync(urls);
//}