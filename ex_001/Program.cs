//Задача 34:Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


int size=6;
int[] array= new int[size];
int count = 0;

FillArray(array,100,999);
PrintArray(array);

for(int i=0; i< array.Length; i++)
{
    if(array[i]%2==0)
    {
        count++;
    }
}

Console.WriteLine(count);




void PrintArray(int[] array)
{
    for (int i=0; i<size; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

void FillArray (int[] array, int startNumber, int finishNumber)
{
    finishNumber++;
    Random random= new Random();

    for (int i=0; i<size; i++)
    {
        array[i] = random.Next (startNumber,finishNumber);
    }
}



