using System.Runtime.CompilerServices;

namespace Ordenacao;

class Program
{

    static int[] SelectionSort(int[] array)
    {
        int min;
        for (int i = 0; i < array.Length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[min] > array[j])
                    min = j;
            }
            int aux = array[i];
            array[i] = array[min];
            array[min] = aux;
        }

        return array;
    }

    static int[] InsertionSort(int[] array)
    {
        int min, j;
        
        for (int i = 1; i < array.Length; i++)
        {
            min = array[i];

            j = i;

            for (; j > 0; j--)
            {
                if (min < array[j - 1])
                    array[j] = array[j - 1];

                else
                    break;
            }
            array[j] = min;
        }

        return array;
    }

    static int[] BubbleSort(int[] array)
    {
        bool permutacao = true;

        while (permutacao == true)
        {
            permutacao = false;

            for (int i = 0; i < array.Length-1; i++)
            {
                int aux;

                if (array[i] > array[i + 1])
                {
                    aux = array[i + 1];

                    array[i + 1] = array[i];

                    array[i] = aux;
                    
                    permutacao = true;
                }
            }
        }

        return array;
        
    }

    static void MergeSort(int[] array, int inicio, int fim)
    {
        if (fim - inicio > 1)
        {
            int meio = (inicio + fim) / 2;
            MergeSort(array, inicio, meio);
            MergeSort(array, meio, fim);
            Merge(array, inicio, meio, fim);
        }
    }

    static void Merge(int[] array, int inicio, int meio, int fim)
    {
        int[] array_left = array[inicio..meio];

        int[] array_right = array[meio..fim];

        int i=0, j=0, k=inicio;

        while (k < fim)
        {
            if (i >= array_left.Length)
                array[k] = array_right[j++];

            else if (j >= array_right.Length)
                array[k] = array_left[i++];

            else
            {
                if (array_left[i] <= array_right[j])
                    array[k] = array_left[i++];

                else
                    array[k] = array_right[j++];
            }

            k++; 
        }
    }

    static int[] QuickSort(int[] array)
    {
        return [];
    }

    static void Main(string[] args)
    {
        int[] array = [7, 3, 8, 0, 9, 2, 1];

        // array = SelectionSort(array);
        // array = InsertionSort(array);
        // array = BubbleSort(array);
        // MergeSort(array, 0, array.Length);
        // Console.WriteLine();


        foreach (int i in array)
            Console.Write($"{i} ");
    }
}
