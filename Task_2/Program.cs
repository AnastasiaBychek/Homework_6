Console.WriteLine("Enter k1");
 int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b1");
 int b1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Enter k2");
 int k2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Enter b2");
 int b2 = Convert.ToInt32(Console.ReadLine());

 void Method (int k1, int b1, int k2, int b2)
 {
    double x = (b2 - b1)/(k2-k1);
    double y = k1*((b2 - b1)/(k2-k1))+b1;
    Console.WriteLine($"{x}, {y}");
 }

Method(k1,b1, k2, b2);