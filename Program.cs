Console.WriteLine("1.Vehicle Program");
Vehicle myVehicle = new Vehicle("Vehicle", 60);
Console.WriteLine("Vehicle Details:");
myVehicle.DisplayInfo();
Car myCar = new Car("Toyota", 180);
Console.WriteLine("\nCar Details:");
myCar.DisplayInfo();
Bike myBike = new Bike("Yamaha", 120);
Console.WriteLine("\nBike Details:");
myBike.DisplayInfo();
Console.WriteLine("---------------------------------");

Console.WriteLine("2.Vehicle Program");
Vehicles myVehicles = new Vehicles("Vehicle", 60);
Console.WriteLine("Vehicle Details:");
myVehicle.DisplayInfo();
Cars myCars = new Cars("Toyota", 180, 4);
Console.WriteLine("\nCar Details:");
myCar.DisplayInfo();
Bikes myBikes = new Bikes("Yamaha", 120, true);
Console.WriteLine("\nBike Details:");
myBike.DisplayInfo();
Console.WriteLine("---------------------------------");

Console.WriteLine("3.Employee Program");
Employee emp = new Employee("Srija", 50000);
Console.WriteLine("\nEmployee Details:");
emp.DisplayInfo();
Manager mgr = new Manager("Sri", 80000, 10000);
Console.WriteLine("\nManager Details:");
mgr.DisplayInfo();
Console.WriteLine("---------------------------------");

Console.WriteLine("4.Animal Program");
Dog myDog = new Dog("Puppy");
myDog.DisplayInfo();
myDog.MakeSound();
Console.WriteLine();
Cat myCat = new Cat("kitty");
myCat.DisplayInfo();
myCat.MakeSound();
Console.WriteLine("---------------------------------");

Console.WriteLine("5.MovableMachine program");
Robot myrobot = new Robot();
myrobot.Start();
myrobot.Move();
Console.WriteLine("---------------------------------");

Console.WriteLine("6.Banking System");
SavingsAccount mySavings = new SavingsAccount(5000, 5);
Console.WriteLine("Savings Account Details:");
mySavings.CalculateInterest();
Console.WriteLine("---------------------------------");

Console.WriteLine("7.Duck program");
Duck myDuck = new Duck();
myDuck.Fly();  
myDuck.Swim();
Console.WriteLine("---------------------------------");

Console.WriteLine("8.Type Casting Demonstration");
Console.WriteLine("Type Casting Demonstration");
Student studentObj = new Student("Alice", 101);
Person personObj = studentObj;
Console.WriteLine("Upcasting Done!");
personObj.ShowDetails();  
Student downcastedStudent = (Student)personObj;
Console.WriteLine("Downcasting Done!");
downcastedStudent.ShowStudentDetails();
Console.WriteLine("---------------------------------");

Console.WriteLine("9.Product Discount System");
ElectronicProduct laptop = new ElectronicProduct("Laptop", 1200);
ClothingProduct tshirt = new ClothingProduct("T-Shirt", 50);
laptop.DisplayProductInfo();
tshirt.DisplayProductInfo();
Console.WriteLine("---------------------------------");

Console.WriteLine("10.Security System Demo");
SecuritySystem system = new SecuritySystem();
system.AuthenticateUser();



