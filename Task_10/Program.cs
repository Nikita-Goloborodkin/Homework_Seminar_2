int num = new Random().Next(100, 999);//Вводим рандомное число от 100 до 999
Console.WriteLine(num);
int num_1 = num/100; //Ищем первую цифру трехзначного числа
int num_2 = num - num_1*100; // Ищем две последние цифры числа
int num_3 = num_2/10;
Console.WriteLine("Результат: "+num_3);