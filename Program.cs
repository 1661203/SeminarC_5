/*Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]
Найдите сумму отрицательных и положительных элементов массива.

int [] CreatRandomArray (int size, int minVal, int maxVal)      //метод создания массива размера size со значениями от minVal до maxVal
{
    int [] newArray = new int [size];
    for (int i=0; i<size; i++)
    newArray [i] = new Random().Next (minVal, maxVal+1);
    return newArray;
}

void ShowArray (int [] array1)
{
    for (int i=0; i<array1.Length; i++)
    Console.Write(array1 [i]+ " ");
    Console.WriteLine();
}

int FindSummNegativeElem (int []array)
{
    int sumNegative = 0;
    for (int i=0; i<array.Length; i++)
    if (array [i] < 0)
    sumNegative += array [i];
    return sumNegative;
}

int FindSummPositiveElem (int []array)
{
    int sumPositive = 0;
    for (int i=0; i<array.Length; i++)
    if (array [i] > 0)
    sumPositive += array [i];
    return sumPositive;
}

int sizeArray = 12;
int minValue = -9;
int maxValue = 9;

int [] createdArray = CreatRandomArray (sizeArray, minValue, maxValue);

ShowArray (createdArray);

Console.WriteLine ($"Summ of positive elements is {FindSummPositiveElem (createdArray)}");

int resultNegative = FindSummNegativeElem (createdArray);

Console.WriteLine ($"Summ of negative elements is {resultNegative}");*/

/*Найдите произведение пар чисел в одномерном массиве.
Парой считается первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.

int [] FindMultiPar (int []arrayforMulti)
{
    int sizeTemp;                                       //длина массива с произведениями
    if (arrayforMulti.Length % 2 == 0)
        sizeTemp = arrayforMulti.Length/2;
    else sizeTemp = (arrayforMulti.Length +1)/2;

    int [] arrayMulti = new int[sizeTemp];              //Создаём массив для хранения результатов умножения
    for (int i =0; i < arrayforMulti.Length / 2; i++)   //для парных значений произведений умножения 
    {
        arrayMulti[i] = arrayforMulti[i]*arrayforMulti [arrayforMulti.Length -1 -i];
    }
    if (arrayforMulti.Length %2 !=0)                    // Если в исходном массиве нечетное количество элементов, то в конечный массив на последнюю позицию записать элементы из исходного массива с этой же позиции
    arrayMulti [sizeTemp -1] = arrayforMulti [sizeTemp -1];

    return arrayMulti;
}

int sizeStart = 5;
int minPossibleVal = 1;
int maxPossibleVal = 9;

int [] arrayStart = CreatRandomArray (sizeStart, minPossibleVal, maxPossibleVal);   //Создали рандомный массив
ShowArray (arrayStart);     // продемонстрировали

int [] arrayFinish = FindMultiPar (arrayStart); // Создали и заполнили массив с результатом умножения
ShowArray (arrayFinish);                        // Продемонстрировали массив с умножениями
*/

/*Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].

int [] CreatRandomArray (int size, int minVal, int maxVal) 
{
    int [] newArray = new int [size];
    for (int i=0; i<size; i++)
    newArray [i] = new Random().Next (minVal, maxVal+1);
    return newArray;
}

void ShowArray (int [] array1)
{
    for (int i=0; i<array1.Length; i++)
    Console.Write(array1 [i]+ " ");
    Console.WriteLine();
}

void Count1099 (int [] arrayForFind)
{
    int count = 0;
    for (int i=0; i<arrayForFind.Length; i++)
    if (arrayForFind[i] >= 10 && arrayForFind[i]<=99)
    count ++;
    Console.WriteLine ($"Count of 2digit elements is {count}");
}

int sizeStart = 123;
int minPossibleVal = 1;
int maxPossibleVal = 999;

int [] arrayStart = CreatRandomArray (sizeStart, minPossibleVal, maxPossibleVal); 
ShowArray (arrayStart);   
Count1099(arrayStart);*/


//Домашнее задание.

/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2


void FillArrayRandomNumbers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);

PrintArray(numbers);

int count = 0;

for (int i = 0; i < numbers.Length; i++)
    {   
        if (numbers[i] % 2 == 0)
        count++;
    }

Console.WriteLine($"{count} even numbers");
*/

/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Console.WriteLine ("Enter the size of the array: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
for (int i = 0; i < a; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}
}

int kol(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while (i < randomArray.Length)
        {
            sum = sum + randomArray[i];
            i = i + 2;
        }
    return sum;
}

mas(a);
Console.WriteLine ();
Console.WriteLine ($"The sum of elements in odd positions is: {kol(randomArray)}");
*/

/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76

Console.WriteLine("Enter the size of the array:");
int n = Convert.ToInt32(Console.ReadLine()); 

int [] mass  = new int[n];      
Random rnd = new Random();      
for (int i = 0; i < n; i++)
    { mass[i] = rnd.Next(-50, 50);  
    Console.Write($" {mass[i]} ");
    }

int min = 0;
int max = 0;
foreach (int i in mass)  
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine();
Console.WriteLine($" Max element is: {max}");
Console.WriteLine($" Min element is: {min}");
Console.WriteLine($" Difference between max and min element is: {max-min}");
*/