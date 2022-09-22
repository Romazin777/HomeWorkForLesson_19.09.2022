// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");
int numb = int.Parse(Console.ReadLine());
if (numb < 1) Console.WriteLine("Нумерация дней недели начинается с 1 ");
else if (numb > 7) Console.WriteLine("В неделе 7 дней");
else if (numb >= 1 && numb <= 5) Console.WriteLine($"{numb}-й день недели НЕ является выходным днем");
else Console.WriteLine($"{numb}-й день в неделе является выходным");