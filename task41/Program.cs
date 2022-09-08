/*Console.Clear();
Console.WriteLine("Введите первое число ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите четвертое число ");
int num4 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите пятое число ");
int num5 = int.Parse(Console.ReadLine());
int count = 0;
if (num1 > 0) count += 1;
if (num2 > 0) count += 1;
if (num3 > 0) count += 1;
if (num4 > 0) count += 1;
if (num5 > 0) count += 1;
Console.WriteLine("Количестиво чисел больше ноля " + count);
*/

Console.Clear();
Console.WriteLine("Сколько чисел вы хотите ввести? ");
int [] array = new int[int.Parse(Console.ReadLine())];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите следующее число ");
    array[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count += 1;
}
Console.WriteLine("Количестиво чисел больше ноля " + count);