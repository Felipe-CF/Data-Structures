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
    static void Main(string[] args)
    {
        int[] array = [7, 3, 8, 9, 2, 1];

        array = SelectionSort(array);

        foreach (int i in array)
            Console.Write($"{i} ");
    }
}
