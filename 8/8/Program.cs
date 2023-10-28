// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Text;
using System.Threading;
class Shape
{
    public virtual void Show() { }
    public virtual double Area() { return 0; }
    public virtual void Save() { }
    public virtual void Load() { }

    public virtual void Input() { } 
}

class Triangle : Shape 
{
    private double side1;
    private double side2;
    public Triangle() 
    { 
        side1 = 3;
        side2 = 4;
    }
    public Triangle(double sd1, double sd2)
    {
        side1 = sd1;
        side2 = sd2;
    }
    public double Side1
    {
        get
        {
            return side1;
        }
        set
        {
            side1 = value;
        }
    }
    public double Side2
    {
        get
        {
            return side2;
        }
        set
        {
            side2 = value;
        }
    }
    public override void Show() 
    {
        Console.WriteLine("\tTriangle \n side1 = {0} \n side2 = {1}", side1, side2);        
    }
    public override double Area() 
    {
        return (side1 * side2 / 2.0); 
    }
    public override void Save() 
    {
        StreamWriter sw = new StreamWriter("Figures.log", true, Encoding.Default);
        sw.WriteLine(Convert.ToString(1));

        string str = Convert.ToString(side1);
        sw.WriteLine(str);
        str = Convert.ToString(side2);
        sw.WriteLine(str);

        sw.Close();
    }
    public override void Load()
    {
        StreamReader sr = new StreamReader("tmp.log", Encoding.Default);
      
        side1 = Convert.ToDouble(sr.ReadLine());
        side2 = Convert.ToDouble(sr.ReadLine());

        sr.Close();
    }
    public override void Input() 
    {
        Console.WriteLine("Input the length of side 1: ");
        Side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input the length of side 2: ");
        Side2 = Convert.ToDouble(Console.ReadLine());
    }
}

class Rectangle : Shape
{
    private double x1;
    private double y1;
    private double x2;
    private double y2;
    public Rectangle()
    {
        x1 = 1;
        y1 = 1;
        x2 = 5;
        y2 = 5;
    }
    public Rectangle(double _x1, double _y1, double _x2, double _y2)
    {
        x1 = _x1;
        y1 = _y1;
        x2 = _x2;
        y2 = _y2;
    }
    # region properties
    public double X1
    {
        get
        {
            return x1;
        }
        set
        {
            x1 = value;
        }
    }
    public double Y1
    {
        get
        {
            return y1;
        }
        set
        {
            y1 = value;
        }
    }
    public double X2
    {
        get
        {
            return x2;
        }
        set
        {
            x2 = value;
        }
    }
    public double Y2
    {
        get
        {
            return y2;
        }
        set
        {
            y2 = value;
        }
    }
    #endregion properties
    public override void Show()
    {
        Console.WriteLine("\tRectangle \n Coordinates:\n Lower bottom ({0}, {1})\n" +
            " Top right    ({2}, {3})", x1, y1, x2, y2);
    }
    public override double Area()
    {
        return (Math.Sqrt( (y1 - y2) * (y1 - y2)) * Math.Sqrt((x1 - x2) * (x1 - x2) ));
    }
    public override void Save()
    {
        StreamWriter sw = new StreamWriter("Figures.log", true, Encoding.Default);
        sw.WriteLine(Convert.ToString(2));

        string str = Convert.ToString(x1);
        sw.WriteLine(str);
        str = Convert.ToString(y1);
        sw.WriteLine(str);
        str = Convert.ToString(x2);
        sw.WriteLine(str);
        str = Convert.ToString(y2);
        sw.WriteLine(str);

        sw.Close();
    }
    public override void Load()
    {
        StreamReader sr = new StreamReader("tmp.log", Encoding.Default);

        x1 = Convert.ToDouble(sr.ReadLine());
        y1 = Convert.ToDouble(sr.ReadLine());
        x2 = Convert.ToDouble(sr.ReadLine());
        y2 = Convert.ToDouble(sr.ReadLine());

        sr.Close();
    }
    public override void Input()
    {
        Console.WriteLine("Input x1: ");
        X1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input y1: ");
        Y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input x2: ");
        X2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input y2: ");
        Y2 = Convert.ToDouble(Console.ReadLine());
    }
}

class Circle : Shape 
{
    private double x;
    private double y;
    private double radius;

    public Circle()
    {
        x = 0;
        y = 0;
        radius = 1;
    }
    public Circle(double _x, double _y, double _radius)
    {
        x = _x;
        y = _y;
        radius = _radius;
    }
    #region properties
    public double X
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }
    public double Y
    {
        get
        {
            return y;
        }
        set
        {
            y = value;
        }
    }
    public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            radius = value;
        }
    }
    #endregion properties    
    public override void Show()
    {
        Console.WriteLine("\tCircle \n Center oordinates: ({0}, {1})\n" +
            " Radus: {2}", x, y, radius); 
    }
    public override double Area()
    {
        return (Math.PI * radius * radius);
    }
    public override void Save()
    {
        StreamWriter sw = new StreamWriter("Figures.log", true, Encoding.Default);
        sw.WriteLine(Convert.ToString(3));

        string str = Convert.ToString(x);
        sw.WriteLine(str);
        str = Convert.ToString(y);
        sw.WriteLine(str);
        str = Convert.ToString(radius);
        sw.WriteLine(str);

        sw.Close();
    }
    public override void Load()
    {
        StreamReader sr = new StreamReader("tmp.log", Encoding.Default);

        x = Convert.ToDouble(sr.ReadLine());
        y = Convert.ToDouble(sr.ReadLine());
        radius = Convert.ToDouble(sr.ReadLine());

        sr.Close();
    }
    public override void Input()
    {
        Console.WriteLine("Input x: ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input y: ");
        Y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input radius: ");
        Radius = Convert.ToDouble(Console.ReadLine());
    }
}

class Shapes 
{
    private Shape[] p;
    public Shapes()
    {
        p = new Shape[0];
    }
    public void Add(Shape s)
    {
        Shape[] tmp = new Shape[p.Length + 1];
        for (int i = 0; i < p.Length; i++) 
        {
            tmp[i] = p[i];
        }
        tmp[tmp.Length - 1] = s;
        p = tmp; 
    }
    public void Delete(int index)
    {
        if (index < 0 || index >= p.Length)
            Console.WriteLine("Wrong index!");
        else
        {
            Shape[] tmp = new Shape[p.Length - 1];
            int k = 0;
            for (int i = 0; i < p.Length - 1; i++)
            {
                if (i == index)
                    k++;
                tmp[i] = p[i + k];
            }
            p = tmp;
            Console.WriteLine("Deleted!");
        }
    }
    public void Print() 
    {
        for (int i = 0; i < p.Length; i++) 
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("Figure number {0}", i + 1);
            p[i].Show();
        }
    }
    public void Areas()
    {
        for (int i = 0; i < p.Length; i++)
        {
            double d = p[i].Area();
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("Area of figure number {0} = {1}", i + 1, d);
        }
    }
    public void Print_by_type() 
    {
        Console.WriteLine("1 - Triangles\n2 - Rectangles\n3 - Circles");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.D1)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    Triangle t = p[i] as Triangle;
                    if (t != null) 
                    {
                        Console.WriteLine("\n-----------------------------");
                        Console.WriteLine("Figure number {0}", i + 1);
                        p[i].Show();
                    }    
                }
                break;
            }
            else if (key.Key == ConsoleKey.D2)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    Rectangle r = p[i] as Rectangle;
                    if (r != null)
                    {
                        Console.WriteLine("\n-----------------------------");
                        Console.WriteLine("Figure number {0}", i + 1);
                        p[i].Show();
                    }
                }
                break;
            }
            else if (key.Key == ConsoleKey.D3)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    Circle c = p[i] as Circle;
                    if (c != null)
                    {
                        Console.WriteLine("\n-----------------------------");
                        Console.WriteLine("Figure number {0}", i + 1);
                        p[i].Show();
                    }
                }
                break;
            }
            else
            {
                Console.WriteLine("Wrong key! Try again");
            }
        }
            
    }
    public void Areas_by_type()
    {
        Console.WriteLine("1 - Areas of triangles\n2 - Areas of rectangles\n3 - Areas of circles");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Areas of all triangles:\n");
                for (int i = 0; i < p.Length; i++)
                {
                    Triangle t = p[i] as Triangle;
                    if (t != null)
                    {
                        Console.WriteLine("\n-----------------------------");
                        Console.WriteLine("Figure number {0}", i + 1);
                        Console.WriteLine(" Area[{0}] = {1}", i + 1, p[i].Area());
                    }
                }
                break;
            }
            else if (key.Key == ConsoleKey.D2)
            {
                Console.WriteLine("Areas of all rectangles:\n");
                for (int i = 0; i < p.Length; i++)
                {
                    Rectangle r = p[i] as Rectangle;
                    if (r != null)
                    {
                        Console.WriteLine("\n-----------------------------");
                        Console.WriteLine("Figure number {0}", i + 1);
                        Console.WriteLine(" Area[{0}] = {1}", i + 1, p[i].Area());
                    }
                }
                break;
            }
            else if (key.Key == ConsoleKey.D3)
            {
                Console.WriteLine("Areas of all circles:\n");
                for (int i = 0; i < p.Length; i++)
                {
                    Circle c = p[i] as Circle;
                    if (c != null)
                    {
                        Console.WriteLine("\n-----------------------------");
                        Console.WriteLine("Figure number {0}", i + 1);
                        Console.WriteLine(" Area[{0}] = {1}", i + 1, p[i].Area());
                    }
                }
                break;
            }
            else
            {
                Console.WriteLine("Wrong key! Try again");
            }
        }

    }
    public void Save()
    {
        StreamWriter sw = new StreamWriter("Figures.log", false, Encoding.Default);
        sw.WriteLine(p.Length);
        sw.Close();

        Console.WriteLine();
        for (int i = 0; i < p.Length; i++)
        {
            p[i].Save();
        }
        sw.Close();    
    }
    public void Load() 
    {
        int type;
        StreamReader sr = new StreamReader("Figures.log", Encoding.Default);
        int count = Convert.ToInt32(sr.ReadLine());

        for (int i = 0; i < count; i++)
        {
            type = Convert.ToInt32(sr.ReadLine());

            if (type == 1) 
            {
                string s1 = sr.ReadLine();
                string s2 = sr.ReadLine();
                StreamWriter tmp = new StreamWriter("tmp.log", false, Encoding.Default);
                tmp.WriteLine(s1);
                tmp.WriteLine(s2);
                tmp.Close();

                Triangle t = new Triangle();
                t.Load();
                Add(t);
            }
            else if (type == 2)
            {
                string x1 = sr.ReadLine();
                string y1 = sr.ReadLine();
                string x2 = sr.ReadLine();
                string y2 = sr.ReadLine();
                StreamWriter tmp = new StreamWriter("tmp.log", false, Encoding.Default);
                tmp.WriteLine(x1);
                tmp.WriteLine(y1);
                tmp.WriteLine(x2);
                tmp.WriteLine(y2);
                tmp.Close();

                Rectangle r = new Rectangle();
                r.Load();
                Add(r);
            }
            else if (type == 3)
            {
                string x = sr.ReadLine();
                string y = sr.ReadLine();
                string radius = sr.ReadLine();

                StreamWriter tmp = new StreamWriter("tmp.log", false, Encoding.Default);
                tmp.WriteLine(x);
                tmp.WriteLine(y);
                tmp.WriteLine(radius);
                tmp.Close();

                Circle c = new Circle();
                c.Load();
                Add(c);
            }
        }
        sr.Close();
    }
}
class Test 
{
    public static void Main()
    {
        try
        {
            Shapes sh = new Shapes();
            bool flag = true;
            while (flag == true)
            {
                Console.Clear();
                Console.WriteLine("1 - add new figure");
                Console.WriteLine("2 - delete the figure");
                Console.WriteLine("3 - print all figures");
                Console.WriteLine("4 - choose which figures to print");
                Console.WriteLine("5 - print all areas");
                Console.WriteLine("6 - choose which areas to print");
                Console.WriteLine("7 - load figures from the file");
                Console.WriteLine("0 - exit");
                Console.WriteLine("\n\nThe program will save all figures when you close it");

                ConsoleKeyInfo key1 = Console.ReadKey(true);

                if (key1.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("Which figure do you want to add?");
                    Console.WriteLine("1 - triangle");
                    Console.WriteLine("2 - rectangle");
                    Console.WriteLine("3 - circle");
                    ConsoleKeyInfo key2 = Console.ReadKey(true);
                    if (key2.Key == ConsoleKey.D1)
                    {
                        Triangle tr = new Triangle();
                        tr.Input();
                        sh.Add(tr);
                        Console.WriteLine("New Triangle was added. Press any key to continue");
                        Console.ReadKey();
                    }
                    else if (key2.Key == ConsoleKey.D2)
                    {
                        Rectangle rc = new Rectangle();
                        rc.Input();
                        sh.Add(rc);
                        Console.WriteLine("New Rectangle was added. Press any key to continue");
                        Console.ReadKey();
                    }
                    else if (key2.Key == ConsoleKey.D3)
                    {
                        Circle cl = new Circle();
                        cl.Input();
                        sh.Add(cl);
                        Console.WriteLine("New Circle was added. Press any key to continue");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice. Press any key to continue");
                        Console.ReadKey();
                    }
                }
                else if (key1.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the number of the figure that you want to delete:");
                    int ind = Convert.ToInt32(Console.ReadLine());
                    sh.Delete(ind - 1);
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();

                }
                else if (key1.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    Console.WriteLine("All figures:");
                    sh.Print();
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();
                }
                else if (key1.Key == ConsoleKey.D4)
                {
                    Console.Clear();
                    sh.Print_by_type();
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();
                }
                else if (key1.Key == ConsoleKey.D5)
                {
                    Console.Clear();
                    sh.Areas();
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();
                }
                else if (key1.Key == ConsoleKey.D6)
                {
                    Console.Clear();
                    sh.Areas_by_type();
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();
                }
                else if (key1.Key == ConsoleKey.D7)
                {
                    Console.Clear();
                    sh.Load();
                    Console.WriteLine("New figures were loaded from file Figures.txt!");
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();
                }
                else if (key1.Key == ConsoleKey.D0)
                {
                    flag = false;
                }
            }
            sh.Save();
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("\nPress any key to finish");
        Console.ReadKey();

    }
}