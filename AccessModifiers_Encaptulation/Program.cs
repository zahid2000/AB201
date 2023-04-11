using AccessModifiers_Encaptulation.Models;


#region Public,internal(class,interface)-- class and all class's members
//Vehicle vehicle = new Vehicle();
//vehicle.Run();
//vehicle.Brand = "BMW";
//vehicle.Price = 100;
//Console.WriteLine(vehicle.Brand);
#endregion

#region Protected,Private --All class's members
//Vehicle vehicle=new Vehicle();
//vehicle._engine = 1.6;
//var prop = vehicle.GetType().GetField("_engine", System.Reflection.BindingFlags.NonPublic
//    | System.Reflection.BindingFlags.Instance);
//prop.SetValue(vehicle, 1.6);
//var _engine=prop.GetValue(vehicle);
//Console.WriteLine(_engine);
#endregion


#region Encaptulation
Car car=new Car();
//car.SetSpeed(300);

//double speed=car.GetSpeed();
//Console.WriteLine(speed);
car.Speed = -20;
//car.ProductYear = 1995;
Console.WriteLine(car.ProductYear);

#endregion