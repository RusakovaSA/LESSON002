// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());

bool c = a % 7 ==0 && a % 23 ==0;

if (c)
{
    Console.WriteLine("Число " + a + " кратно 7 и 23 "  );
}
else
{
    Console.WriteLine("Число " + a + " не кратно 7 и 23");
}



// int a = int.Parse(Console.ReadLine());

// bool OutputKratnoLi(int a)
// {
//     if ((a % 7 == 0) && (a % 23 == 0))
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }

// }
// Console.WriteLine(OutputKratnoLi(a));
