Console.WriteLine("Введите однозначное число");
int n = int.Parse(Console.ReadLine());
int a = new Random().Next (1, 100);
Console.WriteLine(a);
if (a % n == 0) {
Console.WriteLine(a +" "+ "кратное");
}
else
{
    Console.WriteLine("остаток " + a % n);
}