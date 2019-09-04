using System;
using System.Collections.Generic;

namespace isogram_csharp_problem
{
    public class isogram
    {

        public static bool check(string s)
        {
            HashSet<char> iso = new HashSet<char>();
            bool flag = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '-' || s[i] == ' ') continue;

                else
                {

                    if (iso.Contains(s[i]))
                    {
                        flag = false;
                        break;
                    }

                    else
                    {
                        iso.Add(s[i]);
                    }
                }
 
            }
            return flag;
        }



            public static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }


