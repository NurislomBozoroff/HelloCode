﻿
Console.WriteLine("Введите имя ползователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура ето же Маша!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}