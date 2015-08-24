using System;
/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
namespace BusinessCase3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Business Case 3 - Implementing a simple/naive encryption function");

            string s;

            Console.WriteLine("Please type in a string to be encrypted using the AlphaNumeric Characters only, i.e. a-z, A-Z & 0-9: ");
            s = GetCleanUserInput();

            Console.WriteLine("\n\nAfter Encryption:\n\n" + Encrypt(s) + "\n");
        }

        static string GetCleanUserInput()
        {
            int i, curr_i;
            string strTemp = "";
            Boolean InputClean = true, CheckedNotOK = true;

            do
            {
                try
                {
                    strTemp = "";
                    strTemp = Convert.ToString(Console.ReadLine());

                    i = 0;
                    InputClean = true;

                    while((i < strTemp.Length) && InputClean)
                    {
                        curr_i = GetASCIICode(strTemp[i]);

                        // a = 97
                        // z = 122
                        // A = 65
                        // Z = 90
                        // 0 = 48
                        // 9 = 57

                        if ((curr_i >= 97 && curr_i <= 122) || (curr_i >= 65 && curr_i <= 90) || (curr_i >= 48 && curr_i <= 57))
                            InputClean = true;
                        else
                        {
                            InputClean = false;
                        }

                        i++;
                    }

                    if (InputClean)
                        CheckedNotOK = false;
                    else
                    {
                        CheckedNotOK = true;
                        Console.WriteLine("Input unacceptable. Please try again: ");
                    }

                }
                catch
                {
                    CheckedNotOK = true;
                }

            } while (CheckedNotOK);


            return strTemp;
        }

        static int GetASCIICode(char currChar)
        {
            return (int)currChar;
        }

        static string Encrypt(string s)
        {
            string strFirstTrans, strSecondTrans;

            strFirstTrans = FirstTransformation(s);

            strSecondTrans = SecondTransformation(strFirstTrans);

//            return strFirstTrans;
            return strSecondTrans;
        }

        static string FirstTransformation(string s)
        { // a > b, p > q, A > Z, P > Q, z > a, Z > A, 1 > 2, 9 > 0

            string strTemp = "";
            int key = 1; // i.e. move the ASCII code one position fwd (greater in value)

            int[] intArrASCIICodes = new int[s.Length];
            int[] intArrTranslatedCode = new int[s.Length];

            intArrASCIICodes = GetASCIINumbers(s);

            intArrTranslatedCode = TranslateASCIICode(intArrASCIICodes, key);

            strTemp = TranslateBackToCharacters(intArrTranslatedCode);

            return strTemp;
        }

        static int[] GetASCIINumbers(string s)
        {
            // a = 97
            // z = 122
            // A = 65
            // Z = 90
            // 0 = 48
            // 9 = 57

            int[] intArrS = new int[s.Length];
            int i;

            for (i = 0; i < s.Length; i++)
            {
                intArrS[i] = (int)s[i];
            }

            return intArrS;
        }

        static int[] TranslateASCIICode(int[] intArrASCIICode, int key)
        {
            int[] intArrTranslatedCode = new int[intArrASCIICode.Length];
            int i;

            for (i = 0; i < intArrASCIICode.Length; i++)
            {
                switch (intArrASCIICode[i])
                {
                    case  57: intArrTranslatedCode[i] = (48 - 1) + key; break; // case '9' > ('0' - 1)
                    case  90: intArrTranslatedCode[i] = (65 - 1) + key; break; // case 'Z' > ('A' - 1)
                    case 122: intArrTranslatedCode[i] = (97 - 1) + key; break; // case 'z' > ('a' - 1)
                    default : intArrTranslatedCode[i] = intArrASCIICode[i] + key; break;
                }
            }

            return intArrTranslatedCode;
        }

        static string TranslateBackToCharacters(int[] intArrTranslatedASCIICode)
        {
            string strTemp = "";
            int i;

            for (i = 0; i < intArrTranslatedASCIICode.Length; i++)
            {
                strTemp = strTemp + (char)intArrTranslatedASCIICode[i];
            }

            return strTemp;
        }

        static string SecondTransformation(string s)
        {
            string strTemp = "";
            int i;

            for (i = (s.Length - 1); i >= 0; i--)
            {
                strTemp = strTemp + s[i];
            }

            return strTemp;
        }
    }
}
