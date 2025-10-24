using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "NN MRI GIOVNN";
            char A = 'A';

            cerca_lettera(s, A);
        }
        public static void cerca_lettera(string s, char A) 
        {
            bool a_is_present = false;
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == A)
                {
                    Console.Write($"lettera A presente alla posizione {i.ToString()}\n");
                    a_is_present = true;
                }
            }

            if (!a_is_present)
            {
                Console.WriteLine("non ce nussun carattere A al interno della frase");
            }
        }

    }
}
