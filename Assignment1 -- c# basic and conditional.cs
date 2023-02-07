using System.Runtime.InteropServices;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        //problem 1 -- Welcome Aliens

        //Console.WriteLine("Enter your name : ");
        //String s = Console.ReadLine();
        //Console.WriteLine("Hello " + s + "! Welcome to our planet earth");


        //problem 2 -- Dynamic Web Site --- Prototype

        //Console.WriteLine("Enter College Name : ");
        //String col = Console.ReadLine();
        //Console.WriteLine("Enter College Locality : ");
        //String loc = Console.ReadLine();
        //Console.WriteLine("Enter College's Vision: ");
        //String vis = Console.ReadLine();
        //Console.WriteLine("Enter College's Mission: ");
        //String mis = Console.ReadLine();
        //Console.WriteLine("Enter the number of departments: ");
        //int dep = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter Student Strength: ");
        //int str = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter College Rating: ");
        //char rat = char.Parse(Console.ReadLine());

        //Console.WriteLine(col);
        //Console.WriteLine(loc);
        //Console.WriteLine("_______________________________");
        //Console.WriteLine("Vision");
        //Console.WriteLine(vis);
        //Console.WriteLine("_______________________________");
        //Console.WriteLine("Mission");
        //Console.WriteLine(mis);
        //Console.WriteLine("_______________________________");
        //Console.WriteLine("Number of departments: ");
        //Console.WriteLine(dep);
        //Console.WriteLine("_______________________________");
        //Console.WriteLine("Student Strength: ");
        //Console.WriteLine(str);
        //Console.WriteLine("_______________________________");
        //Console.WriteLine("College Rating: ");
        //Console.WriteLine(rat);

        //problem 3 -- Calculating Gain Percentage
        //Console.WriteLine("Price of old scooter: ");
        //int old = int.Parse(Console.ReadLine());
        //Console.WriteLine("Repair Amount: ");
        //int repair = int.Parse(Console.ReadLine());
        //Console.WriteLine("Selling Price: ");
        //int sell = int.Parse(Console.ReadLine());
        //int cal = (sell - (old + repair));
        //float gp = (cal / (float)sell) * 100;
        //Console.Write("The gain percentage is : ");
        //Console.WriteLine(Math.Round(gp, 2));

        //problem 4 -- Celsius to Fahrenheit Converter
        //Console.WriteLine("Temperature to celsius: ");
        //int cel = int.Parse(Console.ReadLine());
        //float far = ((float)cel * 1.8f) + 32;
        //Console.Write("Temperature in fahrenheit: ");
        //Console.WriteLine(far+"f");

        //problem 5 -- Finding Odd or Even
        //Console.WriteLine("Enter a number: ");
        //int n = int.Parse(Console.ReadLine());
        //if(n%2==0)
        //{
        //    Console.WriteLine(n + " Is An Even Number");
        //}
        //else
        //{
        //    Console.WriteLine(n + " Is An Odd Number");
        //}

        //Problem 6 -- Checking Divisibility By 7 and 3
        //Console.WriteLine("Enter a number : ");
        //int m = int.Parse(Console.ReadLine());
        //if(m%3==0 && m%7==0)
        //{
        //    Console.WriteLine(m + " is divisible by both 3 and 7");
        //}
        //else
        //{
        //    Console.WriteLine(m + " is not divisible by both 3 and 7");
        //}

        //problem 7 -- Maximum of Three Numbers
        //Console.WriteLine("Enter three number : ");
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int c = int.Parse(Console.ReadLine());
        //int temp = a;
        //if(temp<b)
        //{
        //    temp = b;
        //}
        //else if (temp<c)
        //{
        //    temp = c;
        //}
        //else
        //{
        //    temp = a;
        //}

        //Console.WriteLine(temp + " is the maximum number");


        //problem 8 -- Finding Leap Year
        //Console.WriteLine("Enter a Year: ");
        //int n = int.Parse(Console.ReadLine());
        //if(n%4==0 && n%100!=0 || n%400==0)
        //{
        //    Console.WriteLine(n + " is a Leap Year");
        //}
        //else
        //{
        //    Console.WriteLine(n + " is not a leap year");
        //}

        //problem 9 -- EarthQuake Intensity Decision

        //Console.WriteLine("Richter Magnitude");
        //float f = float.Parse(Console.ReadLine());

        //if (f <= 2.4)
        //{
        //    Console.WriteLine("Micro");
        //}
        //else if (f >= 2.5 && f <= 5.4)
        //{
        //    Console.WriteLine("light");
        //}
        //else if (f >= 5.5 && f <= 6.0)
        //{
        //    Console.WriteLine("Moderate");
        //}
        //else if (f >= 6.1 && f <= 6.9)
        //{
        //    Console.WriteLine("Strong");
        //}
        //else if (f >= 7.0 && f <= 7.9)
        //{
        //    Console.WriteLine("major"); 
        //}
        //else
        //{
        //    Console.WriteLine("Great");
        //}



        // problem 10 -- Grade Calculation

        //Console.WriteLine("Enter the marks: ");
        //int n = int.Parse(Console.ReadLine());
        //  if(n<=100)
        //{
        //    Console.Write("The Student Obtained a ");
        //}
        //if(n==100)
        //{
        //    Console.WriteLine("S Grade");
        //}
        //else if(n>=90 &&  n<100)
        //{
        //    Console.WriteLine("A Grade");
        //}
        //else if(n>=80 && n<90)
        //{
        //    Console.WriteLine("B Grade");
        //}
        //else if(n>=70 && n<80)
        //{
        //    Console.WriteLine("C Grade");
        //}
        //else if(n>=60 && n < 70)
        //{
        //    Console.WriteLine("D Grade");
        //}
        //else if(n>=50 && n<60)
        //{
        //    Console.WriteLine("E Grade");
        //}
        //else if(n<50)
        //{
        //    Console.WriteLine("F Grade");
        //}
        //else
        //{
        //    Console.WriteLine("inavlid Input");
        //}


        //problem 11 -- Palindromic Prize
        //Console.WriteLine("Enter a number : ");
        //int n = int.Parse(Console.ReadLine());
        //int k = n;
        //int m = 0;
        //int rem;
        //while(k!=0)
        //{
        //    rem = k% 10;
        //    m = m * 10 + rem;
        //  k /= 10;
        //}

        //if (n == m)
        //{
        //    Console.WriteLine("Yes");
        //}
        //else
        //{
        //    Console.WriteLine("No");
        //}

        //problem 12 --  Sorted Prize
        //Console.WriteLine("Enter a number: ");
        //int m = int.Parse(Console.ReadLine());
        //int[] num = new int[3];
        //for (int i = 0; i < 3; i++)
        //{
        //    num[i] = m % 10;
        //    m /= 10;
        //}
        //for (int i = 0; i < 1; i++)
        //{
        //    if (num[i] > num[i + 1] && num[i + 1] > num[i + 2])
        //    {
        //        Console.WriteLine("Yes");
        //    }
        //    else if (num[i] < num[i + 1] && num[i + 1] < num[i + 2])
        //    {
        //        Console.WriteLine("yes");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No");
        //    }
        //}




    }
}