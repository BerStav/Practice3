// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

int ExpNum( int numA, int numB)
    {
        int res = 1;
        for(int i=1; i <= numB; i++)
            {
                res = res * numA;
            }
        return res;
    }

Console.Write("Please, enter the number A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Please, enter the number B: ");
int numB = int.Parse(Console.ReadLine());

int Result = ExpNum(numA, numB);
Console.WriteLine("The degree A from B is: " + Result + "  (" + numA + ")^" + numB);