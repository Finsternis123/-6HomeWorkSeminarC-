//Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).
int[] array = GetArray(6); 
Console.WriteLine($"[{String.Join(";", array)}]");
int[] array2 = Sort(array);
Console.WriteLine($"[{String.Join(";", array2)}]");


int[] GetArray (int size) 
{ 
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        array[i] = new Random().Next(0, 100);
    } 
    return array; 
}

int[] Sort (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[min]) min = j;
        }
        int temp = array[i];
        array[i] = array[min];
        array[min] = temp;
    }
    return array;
}
