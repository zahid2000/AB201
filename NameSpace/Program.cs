

using CustomValidator;

namespace NS
{
    public class Program
    {
        static void Main(string[] args)
        {
            // MsWord.Word word = Microsoft.Interop.Word.Word();
            // //MyNs.Car car = new MyNs.Car();
            // // car.
            //MyNs.Car car = new MyNs.Car();
            // car.Brand = "BMW";
            // Console.WriteLine(car.Brand);
            //Car car1 =new Car();
            // car1.Engine = 2;
            // Console.WriteLine(car1.Engine);
            //MyNs.Car car = new MyNs.Car();

            MyValidator validator = new MyValidator();
        }
        //class Car
        //{
        //    public string Color { get; set; }
        //}



    }

    //class Car
    //{
    //    public string Name { get; set; }
    //}


}
namespace MyNs
{
    class Car
    {
        public string Brand { get; set; }
       
    }
   
}
