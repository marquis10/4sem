int n = Convert.ToInt32(Console.ReadLine()); // захват вводимого значения
int[] array = new int[n]; // Объявление массива с количеством элементов n
string[] input = Console.ReadLine().Split(" "); // объявление массива строкового типа, захват значений введённых через пробел
for (int i = 0; i < input.Length; i++)  // Проход по всем введённы значениям
    array[i] = int.Parse(input[i].ToString()); // запись введённых значений в массив
// сбор ягод
int maxSumma = 0; // сохраняем максимальное количество собранных ягод
for (int i = 1; i < array.Length - 1; i++) // Проход по 3 кустам
{
    int sum = array[i - 1] + array[i] + array[i + 1]; // Сумма ягод в 3 кустах
    if (sum > maxSumma) // Сравниваем количество ягод с максимальным
        maxSumma = sum; // Если сумма больше, то перезаписываем максимамум
}
if (array[0] + array[1] + array[array.Length - 1] > maxSumma)
    maxSumma = array[0] + array[1] + array[array.Length - 1];

if (array[array.Length - 1] + array[array.Length - 2] + array[0] > maxSumma)
    maxSumma = array[array.Length - 1] + array[array.Length - 2] + array[0];

Console.WriteLine(maxSumma);
