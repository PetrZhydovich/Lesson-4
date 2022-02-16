// Возведите число А в натуральную степень B используя цикл
double GetRandomNumber()
{
    double number = new Random().Next(-20, 20);
    return number;   
}
double a = GetRandomNumber();
double b = GetRandomNumber();
Console.WriteLine($"Сгенерироавнное число: {a} \n Сгенерированная степени числаL: {b}");
