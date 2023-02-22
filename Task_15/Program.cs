//Вариант 1
int numch = int.Parse(Console.ReadLine()?? "0"); // Вводим интовую переменную
if(numch >=1 && numch<= 7){ // Проверка на день недели
    if (numch >0 && numch <=5){
        Console.WriteLine("нет");
    }
    else{
        Console.WriteLine("да");
    }
}
else{
    Console.WriteLine("Число не является днем недели");
}
//Вариант 2
int geo = int.Parse(Console.ReadLine() ??"0");
if(geo>=1 && geo<=7){
    var days = new Dictionary<int, string>()
    {
        [1] = "нет",
        [2] = "нет",
        [3] = "нет",
        [4] = "нет",
        [5] = "нет",
        [6] = "да",
        [7] = "да",

    };
    Console.WriteLine(days[geo]);
}
else{
    Console.WriteLine("Число не является днем недели");
}


