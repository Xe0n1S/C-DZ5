int [] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for (int i =0; i< size; i++){
        res[i] = new Random().Next(minValue, maxValue +1);
    } 
    return res;
}


//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

/*
int[] array = GetArray (10, 100, 1000);
Console.WriteLine(String.Join(" ", array));
int count= 0;
for (int i = 0; i < array.Length; i++){
    if (array[i] % 2 ==0){
        count++;
    }
}
Console.WriteLine(String.Join(" ", count));
*/

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int[] array = GetArray (4, -10, 10);
Console.WriteLine(String.Join(" ", array));
int sum = 0;
for (int i = 1; i < array.Length; i++){
    if (i % 2 == 1 ){
        sum = sum + array[i];
    }
}
Console.WriteLine(String.Join(" ", sum));
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
int[] array = GetArray (5, -10000, 10000);
Console.WriteLine(String.Join(" ", array));
int min = 0;
int max = 0;
int result = 0;
for (int i = 0; i < array.Length; i++){
    if (array[i] > max){
        max = array[i];
    }else {
        if (array[i] < min){
        min = array[i];
        }
    }result = max - min;
}

Console.WriteLine(String.Join($"", result));
*/