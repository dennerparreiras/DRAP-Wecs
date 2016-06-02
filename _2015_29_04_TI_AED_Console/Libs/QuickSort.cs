using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_29_04_TI_AED_Console.Libs
{
    public class QuickSort<T> where T : IQuickSortComparable<T>
    {
        public static void ordenar(T[] vetor)
        {
            ordenar(vetor, 0, vetor.Length - 1, "", true);
        }

        public static void ordenar(T[] vetor, string property)
        {
            ordenar(vetor, 0, vetor.Length - 1, property, true);
        }

        public static void ordenar(T[] vetor, string property, bool ascending)
        {
            ordenar(vetor, 0, vetor.Length - 1, property, ascending);
        }

        private static void ordenar(T[] vetor, int inicio, int fim, string property, bool ascending)
        {
            if (inicio < fim)
            {
                var posicaoPivo = separar(vetor, inicio, fim, property, ascending);
                ordenar(vetor, inicio, posicaoPivo - 1, property, ascending);
                ordenar(vetor, posicaoPivo + 1, fim, property, ascending);
            }
        }

        private static int separar(T[] vetor, int inicio, int fim, string property, bool ascending)
        {
            T pivo = vetor[inicio];
            int i = inicio + 1, f = fim;
            while (i <= f)
            {
                if (vetor[i].QuickCompareTo(pivo, property, ascending) < 0)
                    i++;
                else if (vetor[f].QuickCompareTo(pivo, property, ascending) > 0)
                    f--;
                else
                {
                    var troca = vetor[i];
                    vetor[i] = vetor[f];
                    vetor[f] = troca;
                    i++;
                    f--;
                }
            }
            vetor[inicio] = vetor[f];
            vetor[f] = pivo;
            return f;
        }
    }
}
