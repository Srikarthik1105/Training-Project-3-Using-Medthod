using System;
using System.Diagnostics.CodeAnalysis;

L: Console.Write("Enter The Program's Number : ");
int Select = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

switch (Select)
{
    case 1:
        Console.WriteLine("Give the Two Input : ");
        Console.WriteLine(Equalornot(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
        break;

    case 2:
        Console.Write("Give The Input : ");
        Console.WriteLine(Positivenegative(Convert.ToInt32(Console.ReadLine())));
        break;

    case 3:
        Console.Write("Give The Input : ");
        Console.WriteLine(Leapyear(Convert.ToInt32(Console.ReadLine())));
        break;

    case 4:
        Console.Write("Give Your Age : ");
        Console.WriteLine(Eligileforcasting(Convert.ToInt32(Console.ReadLine())));
        break;

    case 5:
        Console.Write("Enter the m Value : ");
        Console.WriteLine(Displaythevalue(Convert.ToInt32(Console.ReadLine())));
        break;

    case 6:
        Console.Write("Give The Input : ");
        naturalnumbers(Convert.ToInt32(Console.ReadLine()));
        break;

    case 7:
        Console.WriteLine(sumoftennumbers(10));
        break;

    case 8:
        Console.Write("Give The Input : ");
        Console.WriteLine(sumofnumbers(Convert.ToInt32(Console.ReadLine())));
        break;

    case 9:
        Averageandsum(10);
        break;

    case 10:
        Console.Write("Give The Input : ");
        Cubethenumber(Convert.ToInt32(Console.ReadLine()));
        break;

    case 11:
        Console.Write("Give The Input : ");
        multipleTable(Convert.ToInt32(Console.ReadLine()));
        break;

    case 12:
        Console.Write("Give The Input : ");
        Multipletablevert(Convert.ToInt32(Console.ReadLine()));
        break;

    case 13:
        Console.Write("Give The Number : ");
        Oddnaturalnumber(Convert.ToInt32(Console.ReadLine()));
        break;

    case 14:
        Console.Write("Give The Input : ");
        Asteriskpattern(Convert.ToInt32(Console.ReadLine()));
        break;

    case 15:
        Console.Write("Give The Input : ");
        Numberpattern(Convert.ToInt32(Console.ReadLine()));
        break;

    case 16:
        Console.Write("Give The Input : ");
        Numberrepeatpattern(Convert.ToInt32(Console.ReadLine()));
        break;

    case 17:
        Console.Write("Give The Input : ");
        Numberincreasedpattern(Convert.ToInt32(Console.ReadLine()));
        break;

    case 18:
        Console.Write("Give The Input : ");
        Factorial(Convert.ToInt32(Console.ReadLine()));
        break;

    case 19:
        Console.Write("Give The Input : ");
        Evennaturalnumber(Convert.ToInt32(Console.ReadLine()));
        break;

    default:
            Console.WriteLine("----INVAILD INPUT----");
            Console.WriteLine();
            goto L;
}

// 1. Program to accept two integers and check whether they are equal or not.
    bool Equalornot(int num1 , int num2)
    {
        if (num1 == num2)
        {
        return true;
        }
        else
        {
        return false;
        }
    }

// 2. Program to check whether a given number is positive or negative.
    string Positivenegative(int num1)
    {
        if (num1 >= 0)
        {
            return "It is a Positive Number";
        }
        else
        {
            return "It is a Negative Number";
        }
    }

// 3. program to find out whether a given year is a leap year or not.
    string Leapyear(int Year)
    {
        if (Year % 4 == 0)
        {
            return "It is a Leap Year";
        }
        else
        {
            return "It is a not a Leap Year";
        }

    }

//  4.Read the age of a candidate and determine whether it is eligible for casting his/her own vote.
    string Eligileforcasting(int age)
{
    if (age >= 18)
    {
        return "You are Eligible for Casting";
    }
    else
    {
        return "You are not Eligible for Casting";
    }

}

// 5. Program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
  int Displaythevalue(int m)
  {
    int n ;

    if (m > 0)
    {
        Console.Write("Value of n is : ");
        return n = 1;
    }
    else if (m == 0)
    {
        Console.Write("Value of n is : ");
        return n = 0;
    }
    else
    {
        Console.Write("Value of n is : ");
        return n = -1;
    }
  }

// 6. Display the first 10 natural numbers.
 void naturalnumbers(int num)
{
    int i;

    for (i = 1; i < num; i++)
    {
        Console.WriteLine(i);
    }
    
}

// 7. Program that displays the sum of first 10 natural numbers.
int sumoftennumbers(int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
       sum = sum + i;
    }
    Console.Write("The Sum of First 10 Natural Number is : ");
    return sum;

}

// 8. Program that displays the sum of n natural numbers.
int sumofnumbers(int n)
{
    int sum = 0;

    Console.Write("The Sum of n Natural Number is : ");
    for (int i = 1; i <= n; i++)
    {
        sum = sum + i;
    }
    return sum;

}

// 9. Program to read 10 numbers and find their average and sum.
void Averageandsum(int number)
{
    int sum = 0;
    int average = 0;

    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
        average = sum / i;
    }
    Console.Write("The Sum of 10 Number is : {0}",sum);
    Console.WriteLine();

    Console.Write("The Average of 10 Number is :{0} ",average);

}

// 10. Program to display the cube of an integer up to given number.
void Cubethenumber(int number)
{
    int sum = 0;

    Console.Write("Cube Of the Number Upto Given is : ");
    for (int i = 1; i <+ number; i++)
    {
         sum = i * i * i;

        Console.Write(sum + " ");
    }
}

// 11. Display the multiplication table of a given integer.
void multipleTable(int number)
{

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("{0} X {1} = {2}", number, i, number * i);
    }
    

}

// 12. Display the multiplication table vertically from 1 to n.
void Multipletablevert(int n)
{
    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            Console.Write("{0} X {1} = {2}           ", i, j, i * j);
        }
        Console.WriteLine();

    }
}

// 13. Program to display the n terms of odd natural numbers and their sums.
void Oddnaturalnumber(int n)
{
    int sum = 0;
    int odd;

    Console.Write("The Odd Numbers is : ");
    for (int i = 1; i <= n; i++)
    {
        odd = 2 * i - 1;
        Console.Write(odd + " ");

        sum = sum + odd;
    }
    Console.WriteLine();
    Console.Write("Sum Of Odd Numbers : ");
    Console.WriteLine(sum);

}

// 14. Display a right angle triangle with an asterisk The pattern
 void Asteriskpattern(int n)
{

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}

// 15. Display a pattern like a right angle triangle with a number The pattern
void Numberpattern(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
}

// 16. Pattern like a right angle triangle with a number which repeats a number in a row.
void Numberrepeatpattern(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

// 17. Pattern like a right angle triangle with the number increased by 1
void Numberincreasedpattern(int n)
{
    int num = 1;

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(num++ + " ");
        }
        Console.WriteLine();
    }
}

// 18. Program to calculate the factorial of a given number.
void Factorial(int n)
{
    int sum = 1;

    for (int i = 1; i <= n; i++)
    {
        sum = sum * i;
    }
    Console.WriteLine("Factorial Of The Give Number is : {0}", sum);

}

// 19. Display the n terms of even natural number and their sum.
void Evennaturalnumber(int n)
{
    int sum = 0;
    int Even;

    Console.Write("The Even Numbers is : ");
    for (int i = 1; i <= n; i++)
    {
        Even = 2 * i;
        Console.Write(Even + " ");

        sum = sum + Even;
    }
    Console.WriteLine();
    Console.Write("Sum Of Even Numbers : ");
    Console.WriteLine(sum);

}

Console.ReadKey();
