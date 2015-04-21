using System;

class ChackArray
{
    static void Main()
    {
        Console.WriteLine("Въведете дължината на масив1:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Въведете дължината на масив2:");
        int m = int.Parse(Console.ReadLine());
        int check = 0;
        int[] m1 = new int[n];
        int[] m2 = new int[m];
        if (n!=m)
        {
            Console.WriteLine("Двата масива са различни.");
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Масив 1 елемент {0}", i);
                m1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Масив 2 елемент {0}", i);
                m2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (m1[i]==m2[i])
                {
                    Console.WriteLine("Елемент {0} --> {1} и {2} - да", i, m1[i],m2[i]);
                }
                else
                {
                    check = 1;
                    Console.WriteLine("Елемент {0} --> {1} и {2} - не", i, m1[i], m2[i]);
                }
            }
            if (check==0)
            {
                Console.WriteLine("Двата масива са еднакви");
            }
            else
            {
                Console.WriteLine("Двата масива са разрични");
            }
        }
    }
}

