﻿Console.Clear();
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int res = 1;
for(int i=1; i<=B; i++){  
  res *= A;
}
Console.WriteLine($"{A} в степени {B}: {res}");