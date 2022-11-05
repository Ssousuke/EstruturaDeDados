using System;

public class Arrays
{
    static void Array(int tamanho, params int[] valores)
    {
        int[] array = new int[tamanho];
        for (int i = 0; i < valores.Length; i++)
        {
            array[i] = valores[i];
        }

        foreach (var i in array)
        {
            Console.WriteLine($" {i} ");
        }
    }


    static void Matriz(int linhas, int colunas, int[,] valores)
    {
        int[,] matriz = new int[linhas, colunas];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = valores[i, j];
            }
        }

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.WriteLine($" {matriz[i, j]}");
            }
        }
    }
}
