using Util;

class Program
{
    static void Main()
    {
        int[] array = new int[10] { 10, 25, 1, 30, 100, 2, 40, 15, 13, 7 };
        OperacoesArray operacoes = new OperacoesArray();
        operacoes.ImprimirArray(array);
        Console.WriteLine("Array Ordenado: ");
        operacoes.BubbleSort(ref array);
        operacoes.ImprimirArray(array);
    }
}