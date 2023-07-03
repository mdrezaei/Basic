using System;

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
        }
    }
}
