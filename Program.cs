using System;
using System.ComponentModel.Design;

DateTime date = new DateTime(2022, 10, 13);
//DateTime zad = new DateTime(2022, 10, 14);
//DateTime biba = new DateTime(2022, 10, 15);

int pos = 1;

Console.WriteLine(date);
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.UpArrow)
    {
        pos--;
    }
    if (key.Key == ConsoleKey.DownArrow)
    {
        pos++;
    }
    if (key.Key == ConsoleKey.LeftArrow)
    {
        date = date.AddDays(-1);
        Console.WriteLine(date);
    }
    if (key.Key == ConsoleKey.RightArrow)
    {
        date = date.AddDays(+1);
        Console.WriteLine(date);
    }
    if (date.Day == 14)
    {
        Console.WriteLine(date);
        Console.Clear();
        Console.WriteLine(date);
        onezadanie();
        if (key.Key == ConsoleKey.Enter)
        { 
        if (pos == 1)
        {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("   Описание");
                Console.WriteLine("   Дойти до метро и потом на автобус");
                Console.WriteLine("------------------------------------");
            }
        else if (pos == 2)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("   Описание");
                Console.WriteLine("   Нужно купить три бутылки короны");
                Console.WriteLine("------------------------------------");
            }
    }
    }    
    if (date.Day == 15)
    {
        Console.WriteLine(date);
        Console.Clear();
        Console.WriteLine(date);
        vtozadanie();
        if (key.Key == ConsoleKey.Enter)
        {
            if (pos == 1)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("   Описание");
                Console.WriteLine("   Открываю глаза и пойти в душ");
                Console.WriteLine("------------------------------------");
            }
            else if (pos == 2)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("   Описание");
                Console.WriteLine("   Выйти из дома и пойти на остановку");
                Console.WriteLine("------------------------------------");
            }
        }
    }
    Console.SetCursorPosition(0, pos);
    Console.WriteLine("->");
}

static void onezadanie()
{
    Console.WriteLine("   Приехать домой");
    Console.WriteLine("   Пойти в магазин за покупками");
}

static void vtozadanie()
{
    Console.WriteLine("   Проснутся");
    Console.WriteLine("   Поехатьна занятия");
}