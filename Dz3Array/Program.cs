// 1. Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.


int[] array = new int [10];
int count=0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,20);
    Console.Write(array[i]+ " ");

    if (array[i]%2==0 )
    {
        count++;
    }
}

Console.WriteLine();
Console.Write ("Количество четных чисел в массиве:" + count);





//2. Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, 
//значения которых лежат в отрезке [20,90].


int[] array = new int [10];
int count=0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,101);
    Console.Write(array[i]+ " ");

    if (array[i] >=20 && array[i]<=90)
    {
        count++;
    }
}

Console.WriteLine();
Console.Write ("Количество элементов, значения которых лежат в отрезке [20,90]:  " +count);



// 3.Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.


Console. Write ("Введите размер массива:  ");
int N = Convert.ToInt32(Console.ReadLine());

double[] array = new double[N]; 
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next (0,15) + rand.NextDouble();
    Console.Write(array[i]+ " ");

}
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>max)
    {
        max=array[i];
    }
    if (array[i]<min)
    {
       min=array[i];
    }
}

Console.WriteLine();
Console.Write ("Разница между максимальныи и минимальным элементом массива:  " +(max-min));



/
// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем.
// Размер массива должен быть равен количеству цифр.

Console. Write ("Введите натуральное число в диапазоне от 1 до 100 000 : ");
int num = Convert.ToInt32(Console.ReadLine());

string str = num.ToString();
int[] array = new int[str.Length];

for( int i=0; i< str.Length; i++)
{
     array[i] = Convert.ToInt32(str[i].ToString());
     Console.Write(array[i]+ " ");
}
