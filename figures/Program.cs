using System;

namespace Figury_s15752
{
    class Program
    {
        static decimal firstLength, secondLenght, thirdLength, fourthLength, resultFigure, figure;
        static String firstLengthString, secondLengthString, thirdLengthString, fourthLengthString;

        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz figurę do sprawdzenia: ");
            Console.WriteLine("1. Trójkąt");
            Console.WriteLine("2. Czworokąt");

            String result = Console.ReadLine();
            Decimal.TryParse(result, out figure);

            Console.WriteLine("Podaj długość pierwszego boku: ");
            firstLengthString = Console.ReadLine();
            Console.WriteLine("Podaj długość drugiego boku: ");
            secondLengthString = Console.ReadLine();
            Console.WriteLine("Podaj długość trzeciego boku: ");
            thirdLengthString = Console.ReadLine();

            Decimal.TryParse(firstLengthString, out firstLength);
            Decimal.TryParse(secondLengthString, out secondLenght);
            Decimal.TryParse(thirdLengthString, out thirdLength);


            if (figure == 1) { triangle(firstLengthString, secondLengthString, thirdLengthString); }

            else if (figure == 2)
            {
                Console.WriteLine("Podaj długość czwartego boku: ");
                fourthLengthString = Console.ReadLine();
                Decimal.TryParse(fourthLengthString, out fourthLength);
                quadrangle(firstLengthString, secondLengthString, thirdLengthString, fourthLengthString);
            }
            else { Console.WriteLine("Upsik, coś poszło nie tak.."); }
        }

        public static void triangle(String firstLengthString, String secondLengthString, String thirdLengthString)
        {
            if(firstLength + secondLenght > thirdLength || firstLength + thirdLength > secondLenght || secondLenght + thirdLength > firstLength)
            {
                if (firstLength == secondLenght & firstLength == thirdLength)
                { Console.WriteLine("Z podanych długości można zbudować trójkąt równoboczny"); }

                else if (firstLength == secondLenght || firstLength == thirdLength || secondLenght == thirdLength)
                { Console.WriteLine("Z podanych długości można zbudować trójkąt równoramienny"); }

                else { Console.WriteLine("Z podanych długości można zbudować trójkąt (o różnych bokach)"); }
            }
            else { Console.WriteLine("Z podanych długości boków nie da się zbudować trójkąta (długość nie może być równa 0)"); }
        }

        public static void quadrangle(String firstLengthString, String secondLengthString, String thirdLengthString, String fourthLengthString)
        {
            if (firstLength != 0 & secondLenght != 0 & thirdLength != 0 & thirdLength != 0)
            {
                if (firstLength == secondLenght & secondLenght == thirdLength & thirdLength == fourthLength)
                { Console.WriteLine("Z podanych długości boków można zbudować kwadrat"); }

                else if (firstLength == secondLenght & thirdLength == fourthLength) { Console.WriteLine("Z podanych długości boków można zbudować prostokąt"); }
                else if (firstLength == thirdLength & secondLenght == fourthLength) { Console.WriteLine("Z podanych długości boków można zbudować prostokąt"); }
                else if (firstLength == fourthLength & secondLenght == thirdLength) { Console.WriteLine("Z podanych długości boków można zbudować prostokąt"); }

                else { Console.WriteLine("Z podanych długości boków można zbudować czworobok"); }

            }
            else 
            {
                Console.WriteLine("Z podanych długości boków nie da się zbudować czworokąta (długość nie może być równa 0)");
            }
        }
    }
}
