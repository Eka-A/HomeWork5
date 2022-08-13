//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int size=6;
double[] array = new double[size];

FillArray(array);
PrintArray(array);

double maxPosition=0;

for (int i=0; i<size; i++)
{
    if(array[i]>maxPosition)
    {
        maxPosition = array[i];
    }
}

Console.WriteLine($"Максимальный элемент: {maxPosition}");

double minPosition=0;

for (int i=0; i<size; i++)
{
    if(array[i]<minPosition)
    {
        minPosition = array[i];
    }

}

Console.WriteLine($"Минимальный элемент: {minPosition}");

Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {maxPosition-minPosition}");


void FillArray (double[] array, double startNumber=-100, double finishNumber=100)
{
    finishNumber++;
    Random random= new Random();

    for (int i=0; i<size; i++)
    {
        array[i] = random.Next(-100, 100) + random.NextDouble();

    }
}


void PrintArray(double[] array)
{
    for (int i=0; i<size; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}











