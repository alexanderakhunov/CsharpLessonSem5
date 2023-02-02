// Задать массив из 12 элементов

int[] FillArrayNum(int size, int LeftRange, int RightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(LeftRange, RightRange + 1);
    }
    return arr;
}

void SumPositiveAndNegativeEL(int[] arr, out int SumP, out int SumN)
{
    SumP = 0;
    SumN = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            SumP += arr[i];
        }
        else
        {
            SumN += arr[i];
        }
    }
}

int[] array = FillArrayNum(12, -9, 9);


System.Console.WriteLine("[" + string.Join(", ", array) + "]");
SumPositiveAndNegativeEL(array, out int SumP, out int SumN);

System.Console.WriteLine($"Сумма положительных чисел = {SumP}, отрицательных равна = {SumN}");