//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.


int size=6;
int[] array= new int[size];

FillArray(array);
PrintArray(array);
Sum(array);





void PrintArray(int[] array)
{
    for (int i=0; i<size; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

void FillArray (int[] array, int startNumber=-10, int finishNumber=10)
{
    finishNumber++;
    Random random= new Random();

    for (int i=0; i<size; i++)
    {
        array[i] = random.Next (startNumber,finishNumber);
    }
}


void Sum(int[] array)
{
    int sum=0;

    for (int i=0; i<size; i++)
    {
        if(i%2!=0) sum+=array[i];
    }

Console.WriteLine ("Сумма элементов, стоящих на нечётных позициях:" + sum);
}

