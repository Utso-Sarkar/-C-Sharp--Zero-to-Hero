১. C# program for: “Hello World” প্রিন্ট করার জন্য
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
২. C# program for: Array ব্যব্হার করর 10 টি সংখ্যা থেরক ব্ড়
সংখ্যা থব্র করার
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, max data[10] ={ 12,14,15,25,12,14,18,56,23,65,41,52,51};
            max = data[0];
            for (i = 1; i <= 9; i = i + 1)
                if (max < data[i])
                    max = data[i];
            Console.WriteLine(max);
        }
    }
}
৩. C# program for: প্ররকাপ্রস িভ ফাংশন্ ব্যব্হার করর Factorial থব্র করার
namespace program
{
    class factorial
    {
        public int fact(int num)
        {
            int f;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                f = fact(num - 1) * num;
                return f;
            }
        }
        class Program
        {
            public static void main(string[] args)
            {
                int result;
                factorial s = new factorial();
                result = s.fact(5);
                Console.writeline(result);
            }
        }
    }
৪. C# program for: Inheritance /Single Inheritance ব্যব্হার
করর থিাগ্রাম
namespace program
    {
        class AAAA
        {
            int a = 10;
        }
        class BBBB : public AAAA
 {
 public void sum()
        {
            int b, c;
            b = 15;
            c = a + b;
            Console.WriteLine(c);
        }
    }
    class Program
    {
        public static void main(string[] args)
        {
            BBBB s = new BBBB();
            s.sum();
        }
    }
৫. C# program for: Multiple Inheritance ব্যব্হার করর থিাগ্রাম
namespace program
    {
        class AAAA
        {
            int a = 10;
        }
        class BBBB
        {
            int b = 15;
        }
        class DDDD : public AAAA ,public BBBB
 {
 public void sum()
        {
            int c;
            c = a + b;
            Console.WriteLine(c);
        }
    }
    class Program
    {
        public static void main(string[] args)
        {
            DDDD s = new DDDD();
            s.sum();
        }
    }
6. C# program for: Multilevel Inheritance ব্যব্হার করর থিাগ্রাম
namespace program
    {
        class AAAA
        {
            int a = 10;
        }
        class BBBB : public AAAA
 { int b = 15;
    }
    class DDDD : public BBBB
 { public void sum()
    {
        int c;
        c = a + b;
        Console.WriteLine(c);
    }
}
class Program
{
    public static void main(string[] args)
    {
        DDDD s = new DDDD();
        s.sum();
    }
}
7.C# program for: Method Overloading / ফাংশন্
Overloading ব্যব্হার করর থিাগ্রাম
namespace program
{
    class student
    {
        public void sum(int a, int b)
        {
            int c;
            c = a + b;
            Console.WriteLine(c);
        }
        public void sum(int a, int b, int c)
        {
            int d;
            d = a + b + c;
            Console.WriteLine(d);
        }
    }
    class Program
    {
        public static void main(string[] args)
        {
            student s = new student();
            s.sum(5, 6);
            s.sum(5, 6, 15);
        }
    }
}
8.C# program for: Interface ব্যব্হার করর থিাগ্রাম
namespace program
{
    interface teacher
    {
        void display();
    }
    class student : teacher
    {
        public void display()
        {
            int a = 12, b = 7, c;
            c = a + b;
            Console.WriteLine(c);
            Console.WriteLine("this is interface");
        }
    }
    class Program
    {
        public static void main(string[] args)
        {
            student s = new student();
            s.student();
        }
    }
}
9.C# program for: Constructor ব্যব্হার করর থিাগ্রাম
namespace program
{
    class student
    {
        public void student()
        {
            int a = 10, b = 15, c;
            c = a + b;
            Console.WriteLine(c);
            Console.WriteLine("this is costuctor function");
        }
    }
    class Program
    {
        public static void main(string[] args)
        {
            student s = new student();
        }
    }
}
10.C# program for: Switch ব্যব্হার করর থিাগ্রাম
namespace program
{
    class Program
    {
        public static void main(string[] args)
        {
            int mark;
            mark = convert.ToInt(Console.Writeline());
            switch (console.ToInt(mark / 10))
            {
                case 0,1,2,3:
console.Writeline(“F”);
                    break;
                case 4:
                    console.Writeline(“C”);
                    break;
                case 5:
                    console.Writeline(“B”);
                    break;
                case 6:
                    console.Writeline(“B +”);
                    break;
                case 7:
                    console.Writeline(“A”);
                    break;
                case 8,9:
console.Writeline(“A +”);
                    break;
                defult:
                    console.writeline(“invalid”);
                    break;
            }
        }
    }
}
11.C# program for: Destructor ব্যব্হার করর থিাগ্রাম
namespace program
{
    class student
    {
        student()
        {
            int a = 10, b = 15, c;
            c = a + b;
            Console.WriteLine(c);
            Console.WriteLine("this is costructor function");
        }
        ~student()
        {
            Console.WriteLine("this is destructor function");
        }
    }
    class Program
    {
        public static void main(string[] args)
        {
            student s = new student();
        }
    }
}
12. 1---- - 100 মরযয িাইম ন্াম্বার থব্র করার থিাগ্রামc# program
namespace program
{
    class Program
    {
        public static void main(string[] args)
        {
            int i, j;
            for (i = 2; i <= 100; i = i + 1)
            {
                for (j = 2; j <= i; j = j + 1)
                    if (i % j == 0)
                        break;
                if (i == j)
                    console.writeline(i);
            }
        }
    }
}
13. 2 + 4 + 6 +……………100 =? c# program
namespace program
{
    class Program
    {
        public static void main(string[] args)
        {
            int I, sum = 0;
            for (i = 2; i <= 100; i = i + 1)
                sum = sum + i;
            console.writeline(sum);
        }
    }
}
