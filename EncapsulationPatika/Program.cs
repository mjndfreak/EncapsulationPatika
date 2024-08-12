using EncapsulationPatika;
// Car1 object
Cars car1 = new Cars();
car1.Brand = "Toyota";
car1.Model = "Corolla";
car1.Color = "Gray";
car1.DoorCount = 4;

Console.WriteLine("\n");
//Car2 object
Cars car2 = new Cars();
car2.Brand = "Porsche";
car2.Model =  "911 Turbo S";
car2.Color = "Antrasit";
car2.DoorCount = 3;
// To see that the value is set to -1
Console.WriteLine("Car 2 Door Count: " + car2.DoorCount);