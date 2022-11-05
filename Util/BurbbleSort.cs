namespace Util;

public class BurbbleSort
{
    public void BubbleSort(ref int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                // Se o valor do array[j] for maior que o valor na próxima posição array[j + 1]
                if (array[j] > array[j + 1])
                {
                    // temp recebe o valor da próxima posição
                    temp = array[j + 1];
                    // a próxima posição recebe o valor da posição anterior
                    array[j + 1] = array[j];
                    // e a posição atual recebe o valor atribuido a temp
                    array[j] = temp;
                }
            }
        }
    }

    public void ImprimirArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
}