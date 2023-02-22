//Вариант 1
int num = int.Parse(Console.ReadLine()?? "0");//вводим переменную
if (num>=100)
{
    char[] nik = num.ToString().ToCharArray();// Создаём строковой массив
    Console.WriteLine("Результат: "+nik[2]); // Выводим третий элемент
}
else
{
    Console.WriteLine("третьей цифры нет");
}
//Вариант 2(не используя char или string)
int numchik = int.Parse(Console.ReadLine()?? "0");
int k = 0;
int t = numchik;
while(numchik>=10){
    numchik = numchik /10;
    k++;
}

if (t>=100){
    while(k>=3)
    {
        t = t/10;
        k--;
    }
    int rez = t%10;
    Console.WriteLine("Результат: "+rez);
}
else
{
    Console.WriteLine("третьей цифры нет");
}