﻿FinalTask1();

void FinalTask1 ()
{
    string [] arrayInput ={"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
    PrintArrayByString(arrayInput);


}



// Метод вывода массива на экран в виде строки
void PrintArrayByString(string [] array)
{
	for (int i = 0; i < array.Length; i++)
	{
        if (i == (array.Length - 1))
        {
           Console.WriteLine($"{array[i]}."); 
        }
        else
        {
           Console.Write($"{array[i]}, ");
        }
    }
}