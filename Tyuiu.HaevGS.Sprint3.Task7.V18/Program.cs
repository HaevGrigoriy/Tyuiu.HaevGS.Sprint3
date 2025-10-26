using Tyuiu.HaevGS.Sprint3.Task7.V18.Lib;

DataService ds = new DataService();

int startValue = -5;   
int stopValue = 5;

int len = ds.GetMassFunction(startValue, stopValue).Length;
double[] valueArray;
valueArray = new double[len];

Console.WriteLine("+---------+---------+");
Console.WriteLine("|    x    |   f(x)  |");
Console.WriteLine("+---------+---------+");

for (int i = 0; i <= len-1; i++)
{
    Console.WriteLine("===");
    startValue++;
}
Console.ReadKey();