using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в самый быстрый калькулятор в диком МПТ!!");
            bool exit_2 = false;
            bool exit_3 = false;

            while (true)
            {
                Console.WriteLine(" 1 - Сложение \n 2 - Вычитание \n 3 - Умножение \n 4 - Деление \n 5 - Возведение в степень \n 6 - Квадратный корень \n 7 - Процент от числа \n 8 - Факториал \n 9 - Выйти из программы ");
                Console.WriteLine("Выберите действие:");
                int answer_1 = Convert.ToInt32(Console.ReadLine());

                if (answer_1 == 1)
                {
                    while (exit_3 == false)
                    {
                        exit_2 = false;
                        int one_Input, two_Input;
                        Vvod(out one_Input, out two_Input);
                        int sum = one_Input + two_Input;
                        Console.WriteLine(one_Input + " + " + two_Input + " = " + sum);
                        Vihod(ref exit_3, ref exit_2);
                    }
                }
                else if (answer_1 == 2)
                {
                    while (exit_3 == false)
                    {
                        exit_2 = false;
                        int one_Input, two_Input;
                        Vvod(out one_Input, out two_Input);
                        int sum = one_Input - two_Input;
                        Console.WriteLine(one_Input + " - " + two_Input + " = " + sum);
                        Vihod(ref exit_3, ref exit_2);
                    }
                }
                else if (answer_1 == 3)
                {
                    while (exit_3 == false)
                    {
                        exit_2 = false;
                        int one_Input, two_Input;
                        Vvod(out one_Input, out two_Input);
                        int sum = one_Input * two_Input;
                        Console.WriteLine(one_Input + " * " + two_Input + " = " + sum);
                        Vihod(ref exit_3, ref exit_2);
                    }
                }
                else if (answer_1 == 4)
                {
                    while (exit_3 == false)
                    {
                        exit_2 = false;
                        int one_Input, two_Input;
                        Vvod(out one_Input, out two_Input);
                        float sum = one_Input / two_Input;
                        Console.WriteLine(one_Input + " / " + two_Input + " = " + sum);
                        Vihod(ref exit_3, ref exit_2);
                    }
                }
                else if (answer_1 == 5)
                {
                    while (exit_3 == false)
                    {
                        exit_2 = false;
                        int one_Input, two_Input;
                        Vvod(out one_Input, out two_Input);
                        double sum = Math.Pow(one_Input, two_Input);
                        Console.WriteLine(one_Input + " в степени " + two_Input + " = " + sum);
                        Vihod(ref exit_3, ref exit_2);
                    }
                }
                else if (answer_1 == 6)
                {
                    while (exit_3 == false)
                    {
                        exit_2 = false;
                        Console.WriteLine("Введите квадратный корень: ");
                        int one_Input = Convert.ToInt32(Console.ReadLine());
                        double sum = Math.Sqrt(one_Input);
                        Console.WriteLine("Квадратный корень " + one_Input + " = " + sum);
                        Vihod(ref exit_3, ref exit_2);

                    }
                }
                else if (answer_1 == 7)
                {
                    while (exit_3 == false)
                    {
                        exit_2 = false;
                        Console.WriteLine("Введите число: ");
                        float one_Input = Convert.ToInt32(Console.ReadLine());
                        float sum = one_Input / 100;
                        Console.WriteLine("Один процент от числа " + one_Input + " = " + sum);
                        Vihod(ref exit_3, ref exit_2);
                    }
                }
                else if (answer_1 == 8)
                {
                    while (exit_3 == false)
                    {
                        exit_2 = false;
                        Console.WriteLine("Введите число для высчета факториала: ");
                        int one_Input = Convert.ToInt32(Console.ReadLine());
                        int sum = 1;
                        for (int i = 2; i <= one_Input; i++)
                        {
                            sum *= i;
                            if (i == one_Input)
                            {
                                Console.WriteLine("Факториал числа " + one_Input + " = " + sum);
                                Vihod(ref exit_3, ref exit_2);
                            }
                        }
                    }
                }
                else if (answer_1 == 9)
                {
                    Console.WriteLine("Досвидание, дайте оценку моему калькуялтору по пятибальной шкале, где 5 самый высокий балл, а 1 самый низкий :)");
                    return;
                }
                else if (answer_1 != 1 || answer_1 != 2 || answer_1 != 3 || answer_1 != 4 || answer_1 != 5 || answer_1 != 6 || answer_1 != 7 || answer_1 != 8 || answer_1 != 9)
                {
                    Console.WriteLine("Недопустимое значение! Попробуйте еще раз.");
                }
            }
        }
        static void Vihod(ref bool exit_3, ref bool exit_2)
        {
            Console.WriteLine("Выйти в главное меню? Да/Нет");
            string three_Input = Console.ReadLine();

            if (three_Input == "Да")
            {
                exit_3 = true;
                exit_2 = true; 
            }
            else if (three_Input == "Нет")
            {
                
            }
            else
            {
                while (!exit_2)
                {
                    Console.WriteLine("Недопустимое значение, попробуйте снова. ");
                    Console.WriteLine("Выйти в главное меню? Да/Нет");
                    three_Input = Console.ReadLine();
                    if (three_Input == "Да")
                    {
                        exit_3 = true;
                        exit_2 = true; 
                    }
                    else if (three_Input == "Нет")
                    {
                        exit_2 = true; 
                    }
                }
            }
        }
        static void Vvod(out int one_Input, out int two_Input)
        {
            Console.WriteLine("Введите первое число: ");
            one_Input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            two_Input = Convert.ToInt32(Console.ReadLine());
        }
    }
}








