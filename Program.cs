Console.WriteLine("Ты хочешь сахар в чай?");
string txt = Console.ReadLine();
if (txt == "Yes")
{
    Console.WriteLine("Сколько ложек сахара ты хочешь?");
    int sum = Convert.ToInt32(Console.ReadLine());
    int i = sum;

        Console.WriteLine("Добавили " + i + " ложек сахара");


}