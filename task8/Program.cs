Console.WriteLine("Input a number from 10 to 99");
int n = int.Parse (Console.ReadLine());
int a = n / 10;
int b = n % 10;
if (a > b){
    Console.WriteLine(a + "- max");
}
else
  {
    Console.WriteLine(b + "- max");
  }  