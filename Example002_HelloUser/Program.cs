Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.Write("Введите ваше имя ");
string username = Console.ReadLine();
Console.WriteLine($"Привет, {username}");


