
//константа с логичным применением
using System.Numerics;

const int totalWeeks = 40;
//6 переменных разных типов
string fullName = "Иванов Иван Иванович";
string groupNumber = "ИСП-255";
string specially = "09.02.07";
int course = 2;
double grade1 = 4.0;
double grade2 = 4.5;
double grade3 = 4.6;
//арифметический расчёт с переменными
double averageGrade = (grade1 + grade2 + grade3) / 3;

bool scholarship = averageGrade >= 4.0;

Console.WriteLine("------------------------------------------------");
Console.WriteLine("           ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА           ");
Console.WriteLine("------------------------------------------------");

Console.WriteLine($"ФИО: {fullName}");
Console.WriteLine($"Группа: {groupNumber}");
Console.WriteLine($"Курс: {course}");
Console.WriteLine($"Специальность: {specially}");
Console.WriteLine();
Console.WriteLine($"Средний балл за 3 работы: {averageGrade}");
Console.WriteLine($"Стипендия положена (>= 4.0): {scholarship}");
Console.WriteLine();
Console.WriteLine($"Учебных недель осталось в семестре: {totalWeeks}");




