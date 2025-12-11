// See https://aka.ms/new-console-template for more information

internal class Program
{
private static void Main(string[] args)
{   bool check=false;
    while (!check)
    {
    Console.WriteLine("Quyidagilardan qaysi shaklning yuzasi va perimetri kerak:");
    Console.WriteLine("1:Uchburchak");
    Console.WriteLine("2:Doira");
    Console.WriteLine("3:To'rtburchak");
    Console.WriteLine("0:Dasturdan chiqish");
    string tanlov=Console.ReadLine();

    switch (tanlov)
            {case "1":
                        Triangle triangle1 = new Triangle();
                        Console.Write("a = "); triangle1.a = double.Parse(Console.ReadLine());
                        Console.Write("b = "); triangle1.b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Uchinchi tomonga {Math.Abs(triangle1.a-triangle1.b)} dan {triangle1.a+triangle1.b} gacha kirita olasiz");
                        Console.Write("c = "); triangle1.c = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Yuzasi = {triangle1.Yuzasi()  }Perimetri = {triangle1.Perimetri()}");
                        break;

                    case "2":
                        Circle circle = new Circle();
                        Console.Write("radius = ");
                        circle.r = double.Parse(Console.ReadLine());

                        Console.WriteLine($"Yuzasi = {circle.Yuzasi()  } Perimetri = {circle.Perimetri()}");
                        Console.WriteLine($"");
                        break;

                    case "3":
                        Rectangle rectangle = new Rectangle();
                        Console.Write("a = "); rectangle.a = double.Parse(Console.ReadLine());
                        Console.Write("b = "); rectangle.b = double.Parse(Console.ReadLine());

                        Console.WriteLine($"Yuzasi = {rectangle.Yuzasi()}");
                        Console.WriteLine($"Perimetri = {rectangle.Perimetri()}");
                        break;

                    case "0":
                        check = true;
                        Console.WriteLine("Dasturdan chiqildi.");
                        break;

                    default:
                        Console.WriteLine("Noto'g'ri tanlov!");
                        break;
                
            }
    }
}

public class Triangle
{
    public double a{get;set;}   // uchburchakning tomonlari
    public double b{get;set;}
    public double c{get;set;}
   
    
    public double Yuzasi()    // yuzasini chiqaruvcji metod
    {
        double p=(a+b+c)/2;
      return Math.Sqrt(p*(p-a)*(p-b)*(p-c));  
    }
    public double Perimetri()  // perimetrini chiqaruvchi metod
    {
        return a+b+c;
    }
    
}
public class Circle
{
    public double r{get;set;}
    public double Yuzasi()
    {
        return Math.PI*Math.Pow(r,2);
    }
    public double Perimetri()
    {
        return 2*Math.PI*r;
    }

}
public class Rectangle
{
    public double a{get;set;} //fields
    public double b{get;set;} //fields
    public double Yuzasi()
    {
        return a*b;
    }
    public double Perimetri()
    {
        return 2*(a+b);
    }

}
public class Square
    {
        public double a{get;set;}
        public double Yuzasi()
        {
            return Math.Pow(a,2);
        }
        public double Perimetri()
        {
            return 4*a;
        }
    }
}
