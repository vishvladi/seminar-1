int n = 100;
int i = new Random().Next(1, 999);
Console.WriteLine(i);
int a = i % 10;
if (i < n){
    Console.WriteLine("Третья цифра отсутствует");
}
else {
    Console.WriteLine(a + "третья цифра");
}