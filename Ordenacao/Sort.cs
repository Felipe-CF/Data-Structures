namespace Ordenacao;

public class SortAlgorithm
{
    public static int[] SelectionSort(int[] array)
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

    public static int[] InsertionSort(int[] array)
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

    public static int[] BubbleSort(int[] array)
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

    public static void MergeSort(int[] array, int inicio, int fim)
    {
        if (fim - inicio > 1)
        {
            int meio = (inicio + fim) / 2;
            MergeSort(array, inicio, meio);
            MergeSort(array, meio, fim);
            Merge(array, inicio, meio, fim);
        }
    }

    private static void Merge(int[] array, int inicio, int meio, int fim)
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

    public  static void QuickSort(int[] array) => QuickSort(array, 0, array.Length-1); 

    private  static void QuickSort(int[] array, int pos_inicio, int pos_fim)
    {
        int pont_esq = pos_inicio;

        int pont_dir = pos_fim;

        int pivo = array[pos_inicio];

    
        {
            while (array[pont_esq] < pivo)
                pont_esq++;

            while (array[pont_dir] > pivo)
                pont_dir--;

            if (pont_esq <= pont_dir)
            {
                (array[pont_esq], array[pont_dir]) = (array[pont_dir], array[pont_esq]);
                pont_esq++;
                pont_dir--;
            }
        }

        if (pos_inicio < pont_dir)
            QuickSort(array, pos_inicio, pont_dir);

        if (pont_esq < pos_fim)
            QuickSort(array, pont_esq, pos_fim);

    }

}