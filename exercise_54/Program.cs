// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] CreateMatrix(int n, int m){
    int[,] matrix = new int[n,m];
    for(int i=0; i<n;i++){
        for(int j=0; j<m;j++){
            int x = new Random().Next(10,100);
            matrix[i,j]=x;
            Console.Write(matrix[i,j]+" ");
        }Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}
void PrintMatrix(int[,]matrix){
    for(int i=0; i<matrix.GetLength(0);i++){
        for(int j=0; j<matrix.GetLength(1);j++){
            Console.Write(matrix[i,j]+" ");
        }Console.WriteLine();
    }
}
int[,] ReverseSort(int[,] matrix){
    for(int i=0; i< matrix.GetLength(0);i++){
        for(int j=0; j<matrix.GetLength(1);j++){
            for (int k = 0; k < matrix.GetLength(1) - j - 1; k++) 
              if (matrix[i,k] < matrix[i,k + 1])
                    {
                        int temp = matrix[i,k];
                        matrix[i,k] = matrix[i,k + 1];
                        matrix[i,k + 1] = temp;
                    }
        }
    }
        return matrix;
}
PrintMatrix(ReverseSort(CreateMatrix(8,8)));
