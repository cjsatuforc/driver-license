using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DriversLicense
{
    public class Soundex
    {
        public static string Compute(string word)
        {
            return Compute(word, 4);
        }

        public static string Compute(string word, int length)
        {
            string value = "";
            int size = word.Length;
            if (size > 1)
            {
                word = word.ToUpper();
                char[] chars = word.ToCharArray();
                StringBuilder buffer = new StringBuilder();
                buffer.Length = 0;
                int prevCode = 0;
                int currCode = 0;
                buffer.Append(chars[0]);
                for (int i = 1; i < size; i++)
                {
                    switch (chars[i])
                    {
                        case 'A':
                            currCode = 0;
                            break;
                        case 'E':
                            currCode = 0;
                            break;
                        case 'I':
                            currCode = 0;
                            break;
                        case 'O':
                            currCode = 0;
                            break;
                        case 'U':
                            currCode = 0;
                            break;
                        case 'H':
                            currCode = 0;
                            break;
                        case 'W':
                            currCode = 0;
                            break;
                        case 'Y':
                            currCode = 0;
                            break;
                        case 'B':
                            currCode = 1;
                            break;
                        case 'F':
                            currCode = 1;
                            break;
                        case 'P':
                            currCode = 1;
                            break;
                        case 'V':
                            currCode = 1;
                            break;
                        case 'C':
                            currCode = 2;
                            break;
                        case 'G':
                            currCode = 2;
                            break;
                        case 'J':
                            currCode = 2;
                            break;
                        case 'K':
                            currCode = 2;
                            break;
                        case 'Q':
                            currCode = 2;
                            break;
                        case 'S':
                            currCode = 2;
                            break;
                        case 'X':
                            currCode = 2;
                            break;
                        case 'Z':
                            currCode = 2;
                            break;
                        case 'D':
                            currCode = 3;
                            break;
                        case 'T':
                            currCode = 3;
                            break;
                        case 'L':
                            currCode = 4;
                            break;
                        case 'M':
                            currCode = 5;
                            break;
                        case 'N':
                            currCode = 5;
                            break;
                        case 'R':
                            currCode = 6;
                            break;
                    }
                    if (currCode != prevCode)
                    {
                        if (currCode != 0)
                            buffer.Append(currCode);
                    }
                    prevCode = currCode;
                    if (buffer.Length == length)
                        break;
                }
                size = buffer.Length;
                if (size < length)
                    buffer.Append('0', (length - size));
                value = buffer.ToString();
            }
            return value;
        }
    }
}