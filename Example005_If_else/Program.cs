Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "дина")
{
    Console.WriteLine("А я тя люблю!");
}
else
{
    Console.Write("Привета!");
    Console.WriteLine(username);
}