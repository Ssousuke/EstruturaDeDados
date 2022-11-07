class Testes
{
    static void Main(string[] args)
    {
        var array = new Arrays();
        array.Array(10, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

        int[,] matriz = {
                { 1, 2 },
                { 2, 3 },
                { 3, 4 },
                { 4, 5 }
            };

        array.Matriz(4, 2, matriz);


        BurbbleSort burbbleSort = new BurbbleSort();
        var bSortArray = new int[10] { 6, 7, 8, 1, 2, 3, 10, 100, 13, 70 };

        burbbleSort.BubbleSort(ref bSortArray);
        burbbleSort.ImprimirArray(bSortArray);
    }
}