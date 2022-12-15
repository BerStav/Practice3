// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

int SumNum( int x)
    {
        int NumLeng = Convert.ToString(x).Length;

        int adv = 0;
        int res = 0;

        for (int i = 0; i < NumLeng; i++)
            {
                adv = x - x % 10;
                res = res + (x - adv);
                x = x / 10;
            }
        return res;
    }

Console.Write("Please, enter the number: ");
int numN = int.Parse(Console.ReadLine());

int SumNumber = SumNum(numN);
Console.WriteLine("The Summ of Number's digits is : " + SumNumber);