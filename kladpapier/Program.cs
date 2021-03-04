using System;
using System.Collections.Generic;
using System.Numerics;


namespace Teamwork
{
    public class Program
    {
        /*        public static void Main(string[] args)
        OPDRACHT ALGORITMIEK 1
                {
                    int total = 0;
                    int small = 3;
                    int big = 5;
                    int fivexprint = 0;
                    int threexprint = 0;
                    for (int i = 0; i < 1000;i++)
                    {
                        if(threexprint+3 < 1000)
                        { 
                            threexprint = small * i;
                            total = total + (i * small);
                            Console.WriteLine(threexprint);
                        }
                        if (fivexprint+ 5 < 1000)
                        { 
                            fivexprint = big * i;
                            total = total + (i * big);
                            Console.WriteLine(fivexprint);
                        }
                    }
                    Console.WriteLine(total);
                }*/
        /*        public static void Main(string[] args)
                //OPDRACHT 2
                {
                    int tweeTerug;
                    int eenTerug = 1;
                    int newNumber = 1;
                    int total = 0;
                    int max = 4000000;
                    for (int i = 0; newNumber < max; i++)
                    {
                        Console.WriteLine(newNumber);
                        tweeTerug = eenTerug;
                        eenTerug = newNumber;
                        newNumber = eenTerug + tweeTerug;
                        if(newNumber%2 == 0)
                        {
                            total = total + newNumber;
                        }
                    }
                    Console.WriteLine("Totaal = "+ total);
                }*/
        /*        public static void Main(string[] args)
                //OPDRACHT 3
                {
                    decimal number = 600851475143;
                    long max = 600851475143;
                    for (int i = 1; i < max; i++)
                    {
                        decimal newNumber = number / i;
                        if (CheckIfDecimal(newNumber) == true)
                        {
                            Console.WriteLine("Getal is een priemfactor = " + i);
                            number = newNumber;
                            i++;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                public static bool CheckIfDecimal(decimal number)
                {
                    if (number % 1 > 0)
                    {
                        return false;
                    }
                    else if (number % 1 == 0)
                    {
                        return true;
                    }
                    return false;
                }
            */
        /*        public static void Main(string[] args)
         *       //Opdracht 4
                {
                    int highest = 0;
                    string highestString = "";
                    for (int i = 0; i < 1000; i++)
                    {
                        for (int x = 0; x < 1000; x++)
                        {
                            int result = i * x;
                            string resultString = Convert.ToString(result);
                            if (resultString.Length % 2 != 1)
                            {
                                string firstHalf = resultString.Substring(0, resultString.Length / 2);
                                string secondHalf = resultString.Substring((resultString.Length / 2), resultString.Length / 2);
                                string secondHalfReversed = Reverse(secondHalf);
                                if (firstHalf == secondHalfReversed)
                                {
                                    Console.WriteLine(x + " * " + i + " = " + resultString);
                                    if (result > highest)
                                    {
                                        highest = result;
                                        highestString = Convert.ToString( x + " * " + i + " = " + resultString);
                                    }
                                }

                            }
                        }

                    }
                    Console.WriteLine("biggest pallindrome = " + highestString);
                }
                public static string Reverse(string toReverse)
                {
                    char[] charArray = toReverse.ToCharArray();
                    Array.Reverse(charArray);
                    return new string(charArray);
                }*/
        /*        public static void Main(string[] args)
         *        //OPDRACHT5
                {
                    int max = 20;
                    decimal result = 0;
                    int reeks = 0;
                    int found = 0;
                    for (decimal x = 1;found <1; x++)
                    {
                        for (decimal i = 1; i <=max; i++)
                        {
                            result = x / i;
                            if (CheckIfDecimal(result) == true)
                            {
                                reeks++;
                                if (reeks>=max)
                                {
                                    Console.WriteLine(x);
                                    found++;
                                }
                            }
                            else
                            {
                                reeks = 0;
                                i = 0;
                                x++;
                            }
                        }
                    }
                }
                public static bool CheckIfDecimal(decimal number)
                {
                    if (number % 1 > 0)
                    {
                        return false;
                    }
                    else if (number % 1 == 0)
                    {
                        return true;
                    }
                    return false;
                }*/
        /*        public static void Main(string[] args)
                //OPDRACHT6
                {
                    double total = 0;
                    double amount = 100;
                    double addUp = 0;
                    for (int i = 0; i <= amount; i++)
                    {
                        total= total+ Square(i);
                        addUp = addUp + i;
                    }
                    double firstPart = total;
                    double secondPart = Square(addUp);
                    double result = secondPart - firstPart;
                    Console.WriteLine(firstPart+ " - "+secondPart+ " = " +result);

                }
                public static double Square(double getal)
                {
                    double uitkomst = Math.Pow(getal, 2);
                    return (uitkomst);
                }*/
        /*        public static void Main(string[] args)
                //OPDRACHT7
                {
                    int goal = 10001;
                    int count = 0;
                    decimal primeNumber = 0;
                    for (decimal i = 1; count < goal; i++)
                    {
                        int amount = 0;
                        for (decimal x = 1; x<=i; x++)
                        {
                            if (x != 0 && x<=i)
                            {
                                decimal check = i / x;
                                if (CheckIfDecimal(check)==true)
                                {
                                    amount++;
                                    if(amount >2)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        if (amount == 2)
                        {
                            count++;
                            primeNumber = i;
                            Console.WriteLine("Prime number = "+ primeNumber+ " current count = "+count);
                        }
                    }
                }
                public static bool CheckIfDecimal(decimal number)
                {
                    if (number % 1 > 0)
                    {
                        return false;
                    }
                    else if (number % 1 == 0)
                    {
                        return true;
                    }
                    return false;
                }*/
        /*        public static void Main(string[] args)
                //OPDRACHT8
                {
                    string longString = ("7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450");
                    string stringWon = "";
                    int biggestNumber = 0;
                    List<int> splitNumbers = new List<int>();
                    for (int i = 0; i <= longString.Length-13; i++)
                    {
                        string currentString = "";
                        int calculatedNumber = 1;
                        currentString = longString.Substring(i, 13);
                        for(int x = 0; x<=12; x++)
                        {
                            splitNumbers.Add(Convert.ToInt32(currentString.Substring(x, 1)));
                        }
                        for(int y = 0;y<splitNumbers.Count;y++)
                        {
                            calculatedNumber = calculatedNumber * splitNumbers[y];
                        }
                        if (calculatedNumber > biggestNumber)
                        {
                            stringWon = currentString;
                            biggestNumber = calculatedNumber;
                        }
                        splitNumbers.Clear();
                    }
                    Console.WriteLine("biggest = "+biggestNumber+ " string won = "+ stringWon);
                }*/


        /*        public static void Main(string[] args)
                //OPDRACHT9
                {
                    int a = 0;
                    int b = 0;
                    int c = 0;
                    int goal = 1000;
                    bool found = false;
                    for (a = 1; a < 300; a++)
                    {
                        for (b = 1; b < 400; b++)
                        {
                            c = goal - a - b;
                            if (a * a + b * b == c * c)
                            {
                                found = true;
                                break;
                            }
                        }
                        if (found)
                        {
                            if (c > b && a < b)
                            {
                                Console.WriteLine(a + " + " + b + " + " + c + "= 1000");
                            }
                        }
                    }
                }*/

        public static void Main(string[] args)
        //OPDRACHT10

        {
            int total = 0;
            for (decimal i = 1; i < 2000000; i++)
            {
                int amount = 0;
                for (decimal x = 1; x <= i; x++)
                {
                    if (x != 0 && x <= i)
                    {
                        decimal check = i / x;
                        if (CheckIfDecimal(check) == true)
                        {
                            amount++;
                            if (amount > 2)
                            {
                                break;
                            }
                        }
                    }
                }
                if (amount == 2 && i < 2000000)
                {

                    total = total + Convert.ToInt32(i);
                    Console.WriteLine("Prime number = " + i + " total = " + total);
                }
                else if (amount == 2)
                {
                    Console.WriteLine("Last prime number = " + i + " total = " + total);
                }
            }
        }
        public static bool CheckIfDecimal(decimal number)
        {
            if (number % 1 > 0)
            {
                return false;
            }
            else if (number % 1 == 0)
            {
                return true;
            }
            return false;
        }

    }
}



