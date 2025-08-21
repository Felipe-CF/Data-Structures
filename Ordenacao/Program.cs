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

    static void Main(string[] args)
    {
        int[] array = [7, 3, 8, 9, 2, 1];

        // array = SelectionSort(array);
        // foreach (int i in array)
        //     Console.Write($"{i} ");

        Console.WriteLine();

        array = InsertionSort(array);
        foreach (int i in array)
            Console.Write($"{i} ");
    }
}
