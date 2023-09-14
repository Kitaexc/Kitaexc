using System.Threading.Channels;
Console.WriteLine("Добро пожаловать в самый быстрый калькулятор в диком МПТ!!");
bool exit = false;
bool exit_2 = false;
while (true)
{
    exit = false;
    Console.WriteLine("1 - Сложение \n 2 - Вычитание \n 3 - Умножение \n 4 - Деление \n 5 - Возведение в степень \n 6 - Квадратный корень \n 7 - Процент от числа \n 8 - Факториал \n 9 - Выйти из программы ");
    Console.WriteLine("Выберите действие:");
    int answer_1 = Convert.ToInt32(Console.ReadLine());
    if (answer_1 == 1)
    {
        while (true)
        {
            exit_2 = false;
            Console.WriteLine("Введите первое число: ");
            int one_Input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int two_Input = Convert.ToInt32(Console.ReadLine());
            int sum = one_Input + two_Input;
            Console.WriteLine(one_Input + " + " + two_Input + " = " + sum);
            Console.WriteLine("Выйти в главное меню? Да/Нет");
            string three_Input = Console.ReadLine();
            if (three_Input == "Да")
            {
                break;
            }
            else if (three_Input == "Нет")
            {

            }
            else if (three_Input != "Нет" && three_Input != "Да")
            {
                while (exit_2 == false)
                {
                    Console.WriteLine("Недопустимое значение, попробуйте снова. ");
                    Console.WriteLine("Выйти в главное меню? Да/Нет");
                    three_Input = Console.ReadLine();
                    if (three_Input == "Да")
                    {
                        exit_2 = true;
                    }
                    else if (three_Input == "Нет")
                    {
                        three_Input = "";
                        exit_2 = true;
                    }
                }
            }
            if (three_Input == "Да")
            {
                break;
            }
        }
    }
    else if (answer_1 == 2)
    {
        while (true)
        {
            exit_2 = false;
            Console.WriteLine("Введите первое число: ");
            int one_Input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int two_Input = Convert.ToInt32(Console.ReadLine());
            int sum = one_Input - two_Input;
            Console.WriteLine(one_Input + " - " + two_Input + " = " + sum);
            Console.WriteLine("Выйти в главное меню? Да/Нет");
            string three_Input = Console.ReadLine();
            if (three_Input == "Да")
            {
                break;
            }
            else if (three_Input == "Нет")
            {

            }
            else if (three_Input != "Нет" && three_Input != "Да")
            {
                while (exit_2 == false)
                {
                    Console.WriteLine("Недопустимое значение, попробуйте снова. ");
                    Console.WriteLine("Выйти в главное меню? Да/Нет");
                    three_Input = Console.ReadLine();
                    if (three_Input == "Да")
                    {
                        exit_2 = true;
                    }
                    else if (three_Input == "Нет")
                    {
                        three_Input = "";
                        exit_2 = true;
                    }
                }
            }
            if (three_Input == "Да")
            {
                break;
            }
        }
    }
    else if (answer_1 == 3)
    {
        while (true)
        {
            exit_2 = false;
            Console.WriteLine("Введите первое число: ");
            int one_Input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int two_Input = Convert.ToInt32(Console.ReadLine());
            int sum = one_Input * two_Input;
            Console.WriteLine(one_Input + " * " + two_Input + " = " + sum);
            Console.WriteLine("Выйти в главное меню? Да/Нет");
            string three_Input = Console.ReadLine();
            if (three_Input == "Да")
            {
                break;
            }
            else if (three_Input == "Нет")
            {

            }
            else if (three_Input != "Нет" && three_Input != "Да")
            {
                while (exit_2 == false)
                {
                    Console.WriteLine("Недопустимое значение, попробуйте снова. ");
                    Console.WriteLine("Выйти в главное меню? Да/Нет");
                    three_Input = Console.ReadLine();
                    if (three_Input == "Да")
                    {
                        exit_2 = true;
                    }
                    else if (three_Input == "Нет")
                    {
                        three_Input = "";
                        exit_2 = true;
                    }
                }
            }
            if (three_Input == "Да")
            {
                break;
            }
        }
    }
    else if (answer_1 == 4)
    {
        while (true)
        {
            exit_2 = false;
            Console.WriteLine("Введите первое число: ");
            int one_Input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int two_Input = Convert.ToInt32(Console.ReadLine());
            int sum = one_Input / two_Input;
            Console.WriteLine(one_Input + " / " + two_Input + " = " + sum);
            Console.WriteLine("Выйти в главное меню? Да/Нет");
            string three_Input = Console.ReadLine();
            if (three_Input == "Да")
            {
                break;
            }
            else if (three_Input == "Нет")
            {

            }
            else if (three_Input != "Нет" && three_Input != "Да")
            {
                while (exit_2 == false)
                {
                    Console.WriteLine("Недопустимое значение, попробуйте снова. ");
                    Console.WriteLine("Выйти в главное меню? Да/Нет");
                    three_Input = Console.ReadLine();
                    if (three_Input == "Да")
                    {
                        exit_2 = true;
                    }
                    else if (three_Input == "Нет")
                    {
                        three_Input = "";
                        exit_2 = true;
                    }
                }
            }
            if (three_Input == "Да")
            {
                break;
            }
        }
    }
    else if (answer_1 == 5)
    {
        while (true)
        {
            exit_2 = false;
            Console.WriteLine("Введите первое число: ");
            int one_Input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень числа: ");
            int two_Input = Convert.ToInt32(Console.ReadLine());
            double sum = Math.Pow(one_Input,two_Input);
            Console.WriteLine(one_Input + " в степени " + two_Input + " = " + sum);
            Console.WriteLine("Выйти в главное меню? Да/Нет");
            string three_Input = Console.ReadLine();
            if (three_Input == "Да")
            {
                break;
            }
            else if (three_Input == "Нет")
            {

            }
            else if (three_Input != "Нет" && three_Input != "Да")
            {
                while (exit_2 == false)
                {
                    Console.WriteLine("Недопустимое значение, попробуйте снова. ");
                    Console.WriteLine("Вы хотите выйти? Да/Нет");
                    three_Input = Console.ReadLine();
                    if (three_Input == "Да")
                    {
                        exit_2 = true;
                    }
                    else if (three_Input == "Нет")
                    {
                        three_Input = "";
                        exit_2 = true;
                    }
                }
            }
            if (three_Input == "Да")
            {
                break;
            }
        }
    }
    else if (answer_1 == 6)
    {
        while (true)
        {
            exit_2 = false;
            Console.WriteLine("Введите квадратный корень: ");
            int one_Input = Convert.ToInt32(Console.ReadLine());
            double sum = Math.Sqrt(one_Input);
            Console.WriteLine("Квадратный корень " + one_Input + " = " + sum);
            Console.WriteLine("Выйти в главное меню? Да/Нет");
            string three_Input = Console.ReadLine();
            if (three_Input == "Да")
            {
                break;
            }
            else if (three_Input == "Нет")
            {

            }
            else if (three_Input != "Нет" && three_Input != "Да")
            {
                while (exit_2 == false)
                {
                    Console.WriteLine("Недопустимое значение, попробуйте снова. ");
                    Console.WriteLine("Выйти в главное меню? Да/Нет");
                    three_Input = Console.ReadLine();
                    if (three_Input == "Да")
                    {
                        exit_2 = true;
                    }
                    else if (three_Input == "Нет")
                    {
                        three_Input = "";
                        exit_2 = true;
                    }
                }
            }
            if (three_Input == "Да")
            {
                break;
            }

        }
    }
    else if (answer_1 == 7)
    {
        while (true)
        {
            exit_2 = false;
            Console.WriteLine("Введите число: ");
            float one_Input = Convert.ToInt32(Console.ReadLine());
            float sum = one_Input / 100;
            Console.WriteLine("Один процент от числа " + one_Input + " = " + sum);
            Console.WriteLine("Выйти в главное меню? Да/Нет");
            string three_Input = Console.ReadLine();
            if (three_Input == "Да")
            {
                break;
            }
            else if (three_Input == "Нет")
            {

            }
            else if (three_Input != "Нет" && three_Input != "Да")
            {
                while (exit_2 == false)
                {
                    Console.WriteLine("Недопустимое значение, попробуйте снова. ");
                    Console.WriteLine("Выйти в главное меню? Да/Нет");
                    three_Input = Console.ReadLine();
                    if (three_Input == "Да")
                    {
                        exit_2 = true;
                    }
                    else if (three_Input == "Нет")
                    {
                        three_Input = "";
                        exit_2 = true;
                    }
                }
            }
            if (three_Input == "Да")
            {
                break;
            }
        }
    }
    else if (answer_1 == 8)
    {
        while (exit == false)
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
                    Console.WriteLine("Выйти в главное меню? Да/Нет");
                    string three_Input = Console.ReadLine();
                    if (three_Input == "Да")
                    {
                        exit = true;
                    }
                    else if (three_Input == "Нет")
                    {

                    }
                    else if (three_Input != "Нет" && three_Input != "Да")
                    {
                        while (exit_2 == false)
                        {
                            Console.WriteLine("Недопустимое значение, попробуйте снова. ");
                            Console.WriteLine("Выйти в главное меню? Да/Нет");
                            three_Input = Console.ReadLine();
                            if (three_Input == "Да")
                            {
                                exit_2 = true;
                            }
                            else if (three_Input == "Нет")
                            {
                                three_Input = "";
                                exit_2 = true;
                            }
                        }
                    }
                    if (three_Input == "Да")
                    {
                        exit = true;
                    }
                }
            }
        }
    }
    else if (answer_1 == 9)
    {
        Console.WriteLine("Досвидание, дайте оценку моему калькуялтору по пятибальной шкале, где 5 самый высокий балл, а 1 самый низкий :)");
        return;
    }
    else if (answer_1 != 1 || answer_1 != 1 || answer_1 != 1 || answer_1 != 1 || answer_1 != 1 || answer_1 != 1 || answer_1 != 1 || answer_1 != 1 || answer_1 != 9)
    {
        Console.WriteLine("Недопустимое значение! Попробуйте еще раз.");    
    }
}
