//MARCO
double x1, x2, y1, y2;
double d1, d2, d;

Console.WriteLine("Escreva x2");
x2= int.Parse(Console.ReadLine());
Console.WriteLine("Escreva x1");
x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva y2");
y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva y1");
y1 = int.Parse(Console.ReadLine());

d1 = Math.Pow(x2 - x1, 2);
d2 = Math.Pow(y2 - y1, 2);
d = Math.Sqrt(d1 + d2);

Console.WriteLine(d);
