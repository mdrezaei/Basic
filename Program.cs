using System;
using System.Reflection.Emit;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1_TopLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //string b = "a" + a;
            //string c = "10";
            //Console.WriteLine(a + b + c);
            //>>5a510
            //---------------------------------------------------------------------------------------------------------------------------
            //int 60 = 60; //Error
            //int _60 = 60;
            //int a_60 = 60;
            //int _a60 = 60;
            //int -a = 60; //Error
            //int a-_d = 60; //Error
            //int $a = 60; //Error
            //---------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("Hello World!");
            //int a = 20;
            //int b = a;
            //a += 1;
            //a--;
            //Console.WriteLine(a + b);
            //--------------------------------------------------------------------------------------------------------------------------
            //int Num1, Num2;
            //try
            //{
            //    Console.WriteLine("Enter Number 1:");
            //    Num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter Number 2:");
            //    Num2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Sum is :" + (Num1 + Num2));
            //}
            //catch
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Just Number");
            //    Console.ResetColor();
            //}
            //// Console.WriteLine("Sum is :" + (Num1 + Num2));//اگه تونستی بگی چرا ارور میده

            //--------------------------------------------------------------------------------------------------------------------------
            //int a = 5;
            //int b = 6;
            //int c = 7;
            //int d = 8;
            //string e = "A";

            //if (a == 5 && b != 5 && c >= 5 && d <= 8 && e == "A")
            //{
            //    Console.WriteLine("True1");
            //}
            //if (a == 5 && b != 5 && c >= 5 && d <= 8 && e == "a")
            //{
            //    Console.WriteLine("True2");
            //}
            //else
            //{
            //    Console.WriteLine("false2");
            //}
            //if (a == 5 && b != 5 && c >= 5 && d <= 7 && e == "A")
            //{
            //    Console.WriteLine("True3");
            //}
            //else
            //{
            //    Console.WriteLine("false3");
            //}
            //if (a == 5 && b != 5 && c >= 5 && d <= 7 || e == "A")
            //{
            //    Console.WriteLine("True4");
            //}
            //--------------------------------------------------------------------------------------------------------------------------
            //string a = Console.ReadLine();
            //if (a.ToLower() == "a")
            //{
            //    Console.WriteLine("t");
            //}
            //else
            //{
            //    Console.WriteLine("f");
            //}
            //--------------------------------------------------------------------------------------------------------------------------
            //string a = Console.ReadLine();
            //switch (a.ToLower())
            //{

            //    case "a":
            //        {
            //            Console.WriteLine(55);
            //            break;
            //        }

            //    case "b":
            //        {
            //            Console.WriteLine(66);
            //            break;
            //        }

            //    default:
            //        {
            //            Console.WriteLine(90 + 90);
            //            break;
            //        }

            //}
            //--------------------------------------------------------------------------------------------------------------------------
            //for (int e = 0; e < 1;)
            //{
            //    for (int i = 0; i < 1;)
            //    {
            //        try
            //        {
            //            Console.ForegroundColor = ConsoleColor.Cyan;
            //            Console.WriteLine("Please Enter Your First Number:");
            //            double FirstNumber = Convert.ToDouble(Console.ReadLine());
            //            Console.ResetColor();


            //            for (int q = 0; q < 1;)
            //            {

            //                Console.ForegroundColor = ConsoleColor.Yellow;
            //                Console.WriteLine("Please Choose Your Math Operator From +,-,*,/:");
            //                string MathOperator = Console.ReadLine();
            //                Console.ResetColor();

            //                if (MathOperator == "+" || MathOperator == "-" || MathOperator == "*" || MathOperator == "/")
            //                {
            //                    for (int w = 0; w < 1;)
            //                    {
            //                        try
            //                        {
            //                            Console.ForegroundColor = ConsoleColor.Cyan;
            //                            Console.WriteLine("Please Enter Your Second Number:");
            //                            double SecondNumber = Convert.ToDouble(Console.ReadLine());
            //                            Console.ResetColor();

            //                            switch (MathOperator)
            //                            {
            //                                case "+":
            //                                    {
            //                                        Console.ForegroundColor = ConsoleColor.Green;
            //                                        Console.WriteLine("The SUM Is :" + (FirstNumber + SecondNumber));
            //                                        Console.ResetColor();
            //                                        break;
            //                                    }
            //                                case "-":
            //                                    {
            //                                        Console.ForegroundColor = ConsoleColor.Green;
            //                                        Console.WriteLine("The SUBTRACTION Is :" + (FirstNumber - SecondNumber));
            //                                        Console.ResetColor();
            //                                        break;
            //                                    }
            //                                case "*":
            //                                    {
            //                                        Console.ForegroundColor = ConsoleColor.Green;
            //                                        Console.WriteLine("The MULTIPLY Is :" + (FirstNumber * SecondNumber));
            //                                        Console.ResetColor();
            //                                        break;
            //                                    }
            //                                case "/":
            //                                    {
            //                                        Console.ForegroundColor = ConsoleColor.Green;
            //                                        Console.WriteLine("The DIVIDE Is :" + (FirstNumber / SecondNumber));
            //                                        Console.ResetColor();
            //                                        break;
            //                                    }
            //                            }

            //                            w = 1;
            //                        }
            //                        catch
            //                        {
            //                            Console.ForegroundColor = ConsoleColor.Red;
            //                            Console.WriteLine("Only Number!");
            //                            Console.ResetColor();
            //                            w = 0;
            //                        }
            //                    }
            //                    q = 1;
            //                }
            //                else
            //                {
            //                    Console.ForegroundColor = ConsoleColor.Red;
            //                    Console.WriteLine("Only (+,-,*,/)!");
            //                    Console.ResetColor();
            //                    q = 0;
            //                }
            //            }
            //            i = 1;
            //        }
            //        catch
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("Only Number!");
            //            Console.ResetColor();
            //            i = 0;
            //        }
            //    }
            //    for (int r = 0; r < 1;)
            //    {
            //        Console.WriteLine("Do You Want To Continu?(Yes/No)");
            //        string DoYouWantToContinu = Console.ReadLine().ToLower();
            //        if (DoYouWantToContinu == "yes")
            //        {
            //            e = 0;
            //            r = 1;
            //        }
            //        else if (DoYouWantToContinu == "no")
            //        {
            //            e = 1;
            //            r = 1;
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("Only YES or NO !");
            //            Console.ResetColor();
            //            r = 0;
            //        }
            //    }

            //}
            //--------------------------------------------------------------------------------------------------------------------------
            //for (int i = 0; i < 100; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();
            //--------------------------------------------------------------------------------------------------------------------------
            //string[] names = { "A", "B", "C", "D" };
            //string name = names[0];
            //Console.WriteLine( name);
            ////string[3] secondnames = { "A", "B", "C"}; // اشتباهه نمیشه همینجوری اندازه ارایه رو مشخص کرد 
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine((i + 1 + "-") + names[i]);
            //}
            //--------------------------------------------------------------------------------------------------------------------------
            //string[] names = { "A", "B", "C", "D" };
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine((i + 1 + "-") + names[i]);
            //}
            //--------------------------------------------------------------------------------------------------------------------------
            //int Number = Convert.ToInt32(Console.ReadLine());

            //string[] Names = new string[Number];

            //for (int i = 0; i < Number; i++)
            //{
            //    Console.WriteLine("Enter Name " + (i + 1));
            //    Names[i] = Console.ReadLine();
            //}

            //foreach (string Name in Names)
            //{
            //    Console.WriteLine(Name);
            //}

            //for (int i = 0; i < Number; i++)
            //{
            //    Console.WriteLine(i + 1 + "-" + Names[i]);
            //}
            //--------------------------------------------------------------------------------------------------------------------------
            //int i = 0;

            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i += 2;
            //}

            //Console.WriteLine("---------");

            //int x = 0;

            //while (x <= 10)
            //{
            //    if (x % 2 == 1)
            //    {
            //        Console.WriteLine(x);
            //    }

            //    x++;
            //}
            //--------------------------------------------------------------------------------------------------------------------------
            //int x = 8;
            ////Console.WriteLine(x%5);
            //x %= 3;
            //Console.WriteLine(x);

            ////x &= 3;
            //Console.WriteLine(x);

            //---------------------------------------------------------------------------------------------------------------

            //int x = 5;
            //int y = 3;
            //Console.WriteLine(x > y); // returns True because 5 is greater than 3

            //Console.WriteLine(!(x > y));

            //---------------------------------------------------------------------------------------------------------------

            //string a = "true";
            //string b = "True";
            //string c = "yes";
            //string d = "1";
            //string e = "false";
            //bool q = Convert.ToBoolean(a);
            //bool q1 = Convert.ToBoolean(b);
            ////bool q2 = Convert.ToBoolean(c);
            ////bool q3 = Convert.ToBoolean(d);
            //bool q4 = Convert.ToBoolean(e);
            //Console.WriteLine(q);
            //Console.WriteLine(q1);
            ////Console.WriteLine(q2);
            ////Console.WriteLine(q3);
            //Console.WriteLine(q4);
            //bool w = 5 > 2;
            //Console.WriteLine(w);
            //bool s = Convert.ToBoolean(4);           
            //Console.WriteLine(s);
            //bool s1 = Convert.ToBoolean(0);
            //Console.WriteLine(s1);
            //bool s2 = Convert.ToBoolean(1);
            //Console.WriteLine(s2);
            //--------------------------------------------------------------------------------------------------------------------------
            //دستور بیرک کلن باعث میشه اون حلقه یا عملیات انجام نشه
            //دستور کانتنیو باعث میشه در حلقه ها اون دور از حلقه اجرا نشه
            //البته کد های حلقه تا قبل از رسیدن به کانتنیو اجرا میشوند
            //--------------------------------------------------------------------------------------------------------------------------
            // Create an array of four elements, and add values later
            // string[] cars = new string[4];
            // Create an array of four elements and add values right away
            // string[] cars1 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            // Create an array of four elements without specifying the size
            // string[] cars2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            // Create an array of four elements, omitting the new keyword, and without specifying the size
            // string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };

            // Console.WriteLine(cars.Length);


            // you should note that if you declare an array and initialize it later, you have to use the new keyword

            //  Declare an array
            // string[] cars4;

            // Add values, using new
            //cars4 = new string[] { "Volvo", "BMW", "Ford" };

            // Add values without using new (this will cause an error)
            //cars4 = { "Volvo", "BMW", "Ford"};

            //There are many array methods available, for example Sort(), which sorts an array alphabetically or
            //in an ascending order

            //--------------------------------------------------------------------------------------------------------------------------

            //string[] aa = new string[4];
            //اون چهار طولش هست

            //Console.WriteLine(aa.Length);

            //for (int i = 0; i < aa.Length; i++)
            //{
            //    aa[i] = Console.ReadLine();
            //}
            //این که ای از صفر شروع میشه و تا سه ادامه داره این ایندکسش هست که با طولش متفاوته

            //foreach (string a in aa)
            //{
            //    Console.Write(a + ", ");
            //}


            //int[,] numbers = new int[3, 5];
            //ارایه دو بعدی که میشه سه تا ردیف یا سه تا سطر یا سه تا اکس
            //پنج تا سطون یا میشه پنج تا وای

            //[0, 0], [0, 1], [0, 2], [0, 3], [0, 4]
            //[1,0] , [1,1] , [1,2] , [1,3] , [1,4]
            //[2,0] , [2,1] , [2,2] , [2,3] , [2,4] 
            //مکان های ارایه

            //Console.WriteLine("\n\n" + numbers.Length);

            //for (int row = 0; row < numbers.GetLength(0); row++)
            //{
            //    for (int col = 0; col < numbers.GetLength(1); col++)
            //    {
            //        numbers[row, col] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //foreach (int number in numbers)
            //{
            //    Console.Write(number + "  ");
            //}

            //for (int row = 0; row < numbers.GetLength(0); row++)
            //{
            //    Console.WriteLine();

            //    for (int col = 0; col < numbers.GetLength(1); col++)
            //    {
            //        Console.Write(numbers[row, col] + " ");
            //    }
            //}

            //متد گت لنگف مانند متد لنگف برای کلاس ارایه هستش
            //برای گرفتن طول بعد های ارایه ولی استفاده میشود
            //پس باید مشخص کنیم کدام بعد را میخوایم که طولش رو بگیره
            //بعد های ارایه شمارششان از صفر شروع میشود

            //--------------------------------------------------------------------------------------------------------------------------

            //const
            //کلمه کلیدی کانست که با سی کوچیک هم شروع میشه اگر
            //پشت تایپ متغیر بیاد متغیر رو رید انلی میکنه تا دیگه نشه اوررایتش کرد و دوباره مقدارش داد

            //const int number = 15;
            //number = 20;

            //int a;
            //const int b;
            //ما نمیتونیم متغیری را که کانست هست بدون مقدار دهی اولیه ایجادش کنیم و ارور میگیریم


            //--------------------------------------------------------------------------------------------------------------------------

            //there might be two or more methods in a class with the same name but
            //different numbers, types, and order of parameters, it is called method overloading

            //Just like other methods, class constructors can be overloaded by using different numbers of parameters
            //Class constructors are special methods

            //static int PlusMethod(int x, int y)
            //{
            //    return x + y;
            //}

            //static double PlusMethod(double x, double y)
            //{
            //    return x + y;
            //}

            //public static void PlusMethod(int x, int y)
            //{
            //    Console.WriteLine(x + y);
            //    Console.WriteLine(x - y);
            //    Console.WriteLine(x * y);
            //}

            //public static double PlusMethod(double x, double y)
            //{
            //    return x + y;
            //}


            //To override a method in C#, we need to use the override keyword when
            //defining the method in the derived class. The method in the derived class must also
            //have the same name, return type, and parameter list. We must mark the base method as
            //virtual , or abstract for the derived class to override it

            //--------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine();
            //توی یک خط مینویسه و بعد بقیه رو مجبور میکنه برن خط بعدی . بعد از
            //اینکه نوشتنشتموم بشه دیگه اجازه نمیده جلوش چیزی باشه
            //انگار که در اخرش یعنی بعد از نوشتن چیزی که باید بنویسه یک
            //\n 
            //اضافه میکنه 

            Console.Write("");
            //توی یک خط مین.یسه و بقیه رو هم میزاره جلوش بنویسن
            //این اگه بعد از دات رایت لاین بیاد میره خط بعدی
            //ولی اگه دات رایت لاین بعد این بیاد با هم جلوی هم مینویسن


            //--------------------------------------------------------------------------------------------------------------------------


            //long a = 100000000L;
            //double b = 1.546789D;
            //float c = 1.0234F;

            //Console.WriteLine(5000000);
            //Console.WriteLine(5e6);

            //--------------------------------------------------------------------------------------------------------------------------


            //Math Class

            //int a = 4;
            //double b = 4.2;
            //int c = -4;

            //Math.Max(a, b);

            //Console.WriteLine(Math.Max(a, b));

            //Math.Min(a, b);
            //Math.Sqrt(a);//رادیکال میگیره یا جذر یا ریشه دوم
            //Math.Sqrt(64);//8
            //Math.Abs(c);//مثبت میکند . منفی رو میپرونه . قدر مطلق
            //Math.Abs(-4.8);
            //Math.Round(b);//گرد میکنه
            //Math.Round(4.5);//چهار . خیلی عجیبه چرا؟
            //The integer nearest a. If the fractional component of a is halfway between two integers,
            //one of which is even and the other odd, then the even number is returned.
            //Note that this method returns a Double instead of an integral type
            //Math.Round(5.5);//6
            //Math.Round(4.51);//پنج
            //Math.Round(4.49);//چهار
            //Math.Round(2.5, 0, MidpointRounding.AwayFromZero);//3
            //Math.Round(2.57, 1, MidpointRounding.AwayFromZero);//2.6
            //Math.Round(2.57, 0, MidpointRounding.AwayFromZero);//3
            //عدد اول که عددی هست که میخوایم گردش کنیم
            //عدد دوم که اینت هم هست عددی هستش که میگه چند اعشار رو نگه داریم
            //سومین ورودی هم میگه چه جوری گردش کنیم که اگه روش نگه داریم تعریفش رو نوشته
            //You can specify how Math.Round should round mid-points using an overload which takes a MidpointRounding value


            //--------------------------------------------------------------------------------------------------------------------------

            //string text = "abcdefg";
            //int a = text.Length;

            //Console.WriteLine(a);//7
            //Console.WriteLine(text[0]);//a
            //Console.WriteLine(text[5]);//f
            //Console.WriteLine(text.IndexOf("f"));//5
            //Console.WriteLine(text.IndexOf("F"));//-1
            //Console.WriteLine(text.IndexOf("x"));//-1

            //string subText = text.Substring(2, 3);//عدد اول از سمت چپ یعنی از کدوم ایندکس شروع کنه به انتخاب و
            //                                      //عدد دوم یعنی طول رشته چقدر باشد
            //Console.WriteLine(subText);//cde

            //string subText1 = text.Substring(2, 6);
            //Console.WriteLine(subText1);//Error


            //--------------------------------------------------------------------------------------------------------------------------

            //در استرینگ و کر

            // \ بک اسلش
            // / اسلش یا فوروارد اسلش
            //برای این که در استرینگ یا کر بیایم و دابل کوت " یا کوت ' رو چاپ کنیم مشکل داریم برای همین میایم و 
            //پشت اون ها از بک اسلش استفاده میکنیم تا بگیم که این کوت یا دابل کوت نشانه انتهای رشته یا کارکتر نیستند
            //حالا اگه خواستیم خود بک اسلش رو چاپ کنیم چی؟ \ حالا از دوتا بک اسلش استفاده میکنیم \\ این جوری

            //Console.WriteLine("\"");
            //Console.WriteLine("\'");
            //Console.WriteLine("\\");

            //میدونیم کنسول دات رایت لاین خطوط بعد خودش رو مجبور میکنه برن خط بعد البته که خودش اگه
            //مجبور نشه بره خط بعدی هر جایی میشینه
            //بک اسلش ان خط های بعد از خودش رو مجبور میکنه برن خط بعدی
            //\n

            //Console.Write(" line 1");
            //Console.WriteLine(" line 2");
            //Console.Write(" line 3");

            //Console.Write(" line 1 \n");
            //Console.WriteLine(" line 2");
            //Console.Write(" line 3");

            //Console.WriteLine("line 1");
            //Console.WriteLine("\nline 1");
            //Console.Write("\nline 1");

            // \t   //فاصله به اندازه یک تب
            // \b   //یک حرف قبلی خودش رو پاک میکنه


            //--------------------------------------------------------------------------------------------------------------------------

            //شرت یک خطی

            //پرانتز شرط رو داخلش مینویسی . بعد علامت سوال و بعد علامت سوال نتیجه ای که اگر شرط درست بود برمیگردونیم و بعد 
            //دو نقطه که بعد از دو نقطه نتیجه ای که اگر شرط درست نبود برمیگردونیم رو مینویسیم
            //شرط سه عملگرد هم میگنش

            //string x = (19 > 18) ? "true" : "else";
            //int y = (19 > 20) ? 1 : 0;
            //Console.WriteLine((19 > 20) ? 1 : 0);
            //Console.WriteLine(x);
            //Console.WriteLine(y);


            //--------------------------------------------------------------------------------------------------------------------------


            //access modifier
            //public                 Access is not restricted.
            //protected              Access is limited to the containing class or types derived from the containing class.
            //internal               Access is limited to the current assembly.
            //protected internal     Access is limited to the current assembly or types derived from the containing class.
            //private                Access is limited to the containing type.
            //private protected      Access is limited to the containing class or types derived from the containing class
            //                       within the current assembly.

            //By default, all members of a class are private if you don't specify an access modifier

            //--------------------------------------------------------------------------------------------------------------------------


            //The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users.To achieve this, you must:

            //declare fields/ variables as private
            //provide public get and set methods, through properties, to access and update the value of a private field

            //--------------------------------------------------------------------------------------------------------------------------

            //If you don't want other classes to inherit from a class, use the sealed keyword

            //--------------------------------------------------------------------------------------------------------------------------


        }
    }
}
