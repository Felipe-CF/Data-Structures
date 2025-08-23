using System.Runtime.CompilerServices;
using System.Security.Principal;
using System;

namespace Ordenacao;

class Program
{
    static void Main(string[] args)
    {
        bool menu = true;

        int input;

        while (menu)
        {

            Console.Write("Digite o tamanho do vetor: ");

            int tam = int.Parse(Console.ReadLine());

            Console.Write("Digite os inteiros a serem ordenados (ex: 1,2,3,4,5...) : ");

            string[] inteiros = Console.ReadLine().Split(',');

            int[] array = inteiros.Select(int.Parse).ToArray();

            Console.WriteLine("\nEscolha seu algoritmo de ordenação: ");
            Console.WriteLine("1- SelectionSort ");
            Console.WriteLine("2- InsertionSort ");
            Console.WriteLine("3- BubbleSort ");
            Console.WriteLine("4- MergeSort ");
            Console.WriteLine("5- QuickSort ");
            Console.WriteLine("6- Sair ");

            if (int.TryParse(Console.ReadLine(), out input))
            {
                switch (input)
                {
                    case 1:
                        SortAlgorithm.SelectionSort(array);

                        Console.Write("Selection Sort: ");

                        foreach (int i in array)
                            Console.Write($"{i} ");

                        Console.WriteLine();

                        break;

                    case 2:
                        SortAlgorithm.InsertionSort(array);

                        Console.Write("Insertion Sort: ");

                        foreach (int i in array)
                            Console.Write($"{i} ");

                        Console.WriteLine();
                        break;

                    case 3:
                        SortAlgorithm.BubbleSort(array);

                        Console.Write("Bubble Sort: ");

                        foreach (int i in array)
                            Console.Write($"{i} ");

                        Console.WriteLine();
                        break;

                    case 4:
                        SortAlgorithm.MergeSort(array, 0, array.Length);

                        Console.Write("Merge Sort: ");

                        foreach (int i in array)
                            Console.Write($"{i} ");

                        Console.WriteLine();
                        break;

                    case 5:
                        SortAlgorithm.QuickSort(array);

                        Console.Write("Quick Sort: ");

                        foreach (int i in array)
                            Console.Write($"{i} ");

                        Console.WriteLine();
                        break;

                    case 6:
                        menu = false;
                        break;
                }

                Console.WriteLine("Deseja continuar? 1- sim 2- não");

                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input == 2)
                        menu = false;
                }
                else
                {
                    menu = false;
                }

            }
            else
            {
                break;
            }

        }

    }
}
