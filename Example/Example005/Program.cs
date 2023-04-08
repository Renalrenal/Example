Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "миляуша")
{
    Console.WriteLine("Привет, Моя дорогая");
}
else 
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}