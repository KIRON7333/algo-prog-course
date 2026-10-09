string myName = "Кира Крицкая";
string groupName = "ИСП-254";
int courseNumber = 2;
double averageGrade = 4.6;
bool isBudget = true;

Console.WriteLine("Знакомство");
Console.WriteLine($"Студент: {myName}");
Console.WriteLine($"Группа: {groupName}");
Console.WriteLine($"Курс: {courseNumber}");
Console.WriteLine($"Средний балл: {averageGrade}");
Console.WriteLine($"Бюджетное место: {isBudget}");

Console.WriteLine();
Console.WriteLine("Ремонт: комната");

double roomWidth = 3.5;
double roomLength = 4.2;

double roomArea = roomWidth * roomLength;
double roomPerimeter = (roomWidth + roomLength) * 2;
Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
Console.WriteLine($"Площадь: {roomArea} кв.м");
Console.WriteLine($"Периметр: {roomPerimeter} м");

Console.WriteLine();
Console.WriteLine("Покупка ноутбука в рассрочку");

int laptopPrice = 65000;
int mothsCount = 12;
double interestRate = 0.08;

double totalWithInterest = laptopPrice * (1 + interestRate);
double monthlyPayment = totalWithInterest / mothsCount;

Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
Console.WriteLine($"Платёж в месяц: {monthlyPayment} руб.");

Console.WriteLine();
Console.WriteLine("Внимание: деление int");

int totalStudents = 25;
int groupsCount = 4;

int studentsPerGroupWrong = totalStudents / groupsCount;
double studentsPerGroupCorrect = (double)totalStudents / groupsCount;

Console.WriteLine($"25 / 4 как int:     {studentsPerGroupWrong}");
Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");
int scholarship = 1500;
int monthlyExpenses = 300;
int expenses = (scholarship - monthlyExpenses);
Console.WriteLine($"остаток дохода к концу месяца: {expenses}");
Console.WriteLine();

double celsius = 23.5;
double inFahrenheit = celsius * 9 / 5 + 32;
double inKelvin = celsius + 273.15;

Console.WriteLine($" {celsius}°C = {inFahrenheit}°F = {inKelvin}K ");
Console.WriteLine();

int totalMinutes = 500;
int minutesPerLesson = 45;
int fullLesson = totalMinutes / minutesPerLesson;
int remainingMinutes = totalMinutes % minutesPerLesson;
Console.WriteLine($"{totalMinutes} минут = {fullLesson} полных занятий + {remainingMinutes} минут");
