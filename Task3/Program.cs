// Задать массив и проверить присутствует ли число

int[] arrayFill(int size, int leftr, int rightr)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftr, rightr + 1);
    }
    return array;
}

void PrintArr(int [] array)
{
    System.Console.WriteLine($"[" + String.Join(", ", array) + "]");
}

int inputNumb()
{
    System.Console.WriteLine("Введите число: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

bool numbCheck(int numb, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (numb == array[i])
        {
            return true;
        }
           
    }
     return false;
}


int[] arr = arrayFill(10, -5, 5);
PrintArr(arr);
int number = inputNumb();

if(numbCheck(number, arr))
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}