﻿FinalTask1();

void FinalTask1 ()
{
    string [] arrayInput ={"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
    PrintArrayByString(arrayInput);
    string [] arrayTemp = new string [arrayInput.Length];
    int j = 0;
    for (int i = 0; i < arrayInput.Length; i++)
    {
        if (arrayInput [i].Length <= 3)
        {
            arrayTemp [j] = arrayInput [i];
            j++;
        }
    }
    if (j < arrayInput.Length)
    {
       string [] arrayOutput = new string [j + 1]; 
       for (int k = 0; k <= j; k++)
       {
            arrayOutput [k] = arrayTemp [j];
       }
       PrintArrayByString(arrayOutput);
    }
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