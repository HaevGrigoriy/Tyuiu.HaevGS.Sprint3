using Tyuiu.HaevGS.Sprint3.Task7.V18.Lib;

DataService ds = new DataService();


Console.Title = "Спринт #3 | Выполнил: Хаев Г.С. | ПКТБ-25-1";
Console.WriteLine("###########################################################################");
Console.WriteLine("# Спринт #3                                                               #");
Console.WriteLine("# Тема: Добавление к решению итоговых проектов по спринту                 #");
Console.WriteLine("# Задание #7                                                              #");
Console.WriteLine("# Вариант #14                                                            #");
Console.WriteLine("# Выполнил Хаев Григорий Сергеевич  | ПКТБ-25-1                           #");
Console.WriteLine("###########################################################################");
Console.WriteLine("# УСЛОВИЕ:                                                                #");
Console.WriteLine("# Написать программу, которая выводит таблицу значений функции            #");
Console.WriteLine("#                                                                         #");
Console.WriteLine("#                                                                         #");
Console.WriteLine("###########################################################################");
Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
Console.WriteLine("###########################################################################");

int startValue = -5;
int stopValue = 5;
double[] res = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("Начало числового отрезка = " + startValue);
Console.WriteLine("Конец числового отрезка = " + stopValue);


Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

Console.WriteLine(res);
Console.ReadKey();