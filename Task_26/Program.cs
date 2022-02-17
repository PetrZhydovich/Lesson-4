// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Возведём число А в натуральную степень В");
Console.Write("А = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

double result = Math.Pow(a, b);
Console.WriteLine($"{a} в степень {b} = {result}");