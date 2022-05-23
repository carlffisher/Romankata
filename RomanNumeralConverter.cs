using System;
using System.Text;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RomanKataProject1
{
    public class RomanNumeralConverter
    {
        public int FindValueOfRomanChar(char romanchar)
        {
            switch (romanchar)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }

        public int ConvertAnAdditiveRomanNumeral(string aromannumeral) // let's try converting simple additive numerals first ...
        {
           // Console.WriteLine("\nOriginal Roman numeral        : " + aromannumeral);

            int totalarabicvalue = 0;

            for (int i = 0; i < aromannumeral.Length; i++)
            {
                totalarabicvalue += FindValueOfRomanChar(aromannumeral[i]);
            }

            // Console.WriteLine("Converted to Arabic integer   : " + totalarabicvalue);

            return totalarabicvalue;
        }

        public int ConvertARomanNumeral(string aromannumeral) // now implement subtractive numerals ...
        {
            // Console.WriteLine("\nOriginal Roman numeral        : " + aromannumeral);

            int totalarabicvalue = 0;

            for (int i = 0; i < aromannumeral.Length; i++)
            {
                if (i > 0)
                {
                    if (FindValueOfRomanChar(aromannumeral[i]) > FindValueOfRomanChar(aromannumeral[i - 1]))
                    {
                        totalarabicvalue -= FindValueOfRomanChar(aromannumeral[i - 1]);;

                        totalarabicvalue += FindValueOfRomanChar(aromannumeral[i]) - FindValueOfRomanChar(aromannumeral[i - 1]);
                    }
                    else
                    {
                        totalarabicvalue += FindValueOfRomanChar(aromannumeral[i]);
                    }
                }
                else
                {
                    totalarabicvalue += FindValueOfRomanChar(aromannumeral[i]);
                }
            }

            // Console.WriteLine("Converted to Arabic integer   : " + totalarabicvalue);

            return totalarabicvalue;
        }

        /*******************************************************************
         
                    Some pseudocode to design a solution for the Arabic integer to roman Numeral conversion

                    num == Arabic Integer

                    num >= 1000 ? : int = num / 1000
                                    append M int times, num -= (1000 * int)

                    num >= 900 ? : append CM, num -= 900

                    num >= 500 ? : append D,  num -= 500

                    num >= 400 ? : append CD, num -= 400

                    num >= 100 ? : int = num / 100,
                                   append C int times, num -= (100 * int)

                    num >= 90 ? :  append XC,  num -= 90

                    num >= 50 ? :  append L,  num -= 50

                    num >= 40 ? :  append XL, num -= 40

                    num >= 10 ? :  int = num / 10,
                                   append X int times, num -= (10 * int)

                    num >= 9 ?  :  append IX,  num -= 90

                    num >= 5 ?  :  append V,  num -= 5

                    num >= 4 ? :   append IV, num -= 4

                    num >= 1 ? :   int = num / 1
                                   append I int times

                    return Roman Numeral

         *******************************************************************/

                // The long winded answer...

                // This now needs making into an iterative loop, with a couple of fixed arrays of Roman 
                // Numeral strings and decimal ints to use as a look up to build the converted output string/int.
                // However, I've spent enough time on it!

                public string ConvertAnArabicInteger(int anarabicinteger)
                {
                    //Console.WriteLine("\nOriginal Arabic integer       : " + anarabicinteger);

                    StringBuilder romannumeralstring = new StringBuilder();

                    if (anarabicinteger >= 1000)
                    {
                        for (int i = 0; i < (int) anarabicinteger / 1000; i++)
                        {
                            romannumeralstring.Append('M');
                        }

                        anarabicinteger -= (1000 * ((int)anarabicinteger / 1000));
                    }

                    if (anarabicinteger >= 900)
                    {
                        romannumeralstring.Append("CM");
                        anarabicinteger -= 900;
                    }

                    if (anarabicinteger >= 500)
                    {
                        romannumeralstring.Append('D');
                        anarabicinteger -= 500;
                    }

                    if (anarabicinteger >= 400)
                    {
                        romannumeralstring.Append("CD");
                        anarabicinteger -= 400;
                    }

                    if (anarabicinteger >= 100)
                    {
                        for (int i = 0; i < (int)anarabicinteger / 100; i++)
                        {
                            romannumeralstring.Append('C');
                        }

                        anarabicinteger -= (100 * ((int)anarabicinteger / 100));
                    }

                    if (anarabicinteger >= 90)
                    {
                        romannumeralstring.Append("XC");
                        anarabicinteger -= 90;
                    }

                    if (anarabicinteger >= 50)
                    {
                        romannumeralstring.Append('L');
                        anarabicinteger -= 50;
                    }

                    if (anarabicinteger >= 40)
                    {
                        romannumeralstring.Append("XL");
                        anarabicinteger -= 40;
                    }

                    if (anarabicinteger >= 10)
                    {
                        romannumeralstring.Append('X');
                        anarabicinteger -= 10;
                    }

                    if (anarabicinteger >= 9)
                    {
                        romannumeralstring.Append("IX");
                        anarabicinteger -= 9;
                    }

                    if (anarabicinteger >= 5)
                    {
                        romannumeralstring.Append('V');
                        anarabicinteger -= 5;
                    }

                    if (anarabicinteger >= 4)
                    {
                        romannumeralstring.Append("IV");
                        anarabicinteger -= 4;
                    }

                    if (anarabicinteger >= 1)
                    {
                        for (int i = 0; i < (int)anarabicinteger / 1; i++)
                        {
                            romannumeralstring.Append('I');
                        }
                    }

                    // Console.WriteLine("Converted to Roman numeral    : " + romannumeralstring);

                    return romannumeralstring.ToString();
                }
    }
}