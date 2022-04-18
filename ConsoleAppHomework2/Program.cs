// See https://aka.ms/new-console-template for more information

Console.WriteLine("----------------1.uzd.----------------");
Console.WriteLine("Kā tevi sauc?");
string  userName = Console.ReadLine();
Console.WriteLine("Sveiks, " + userName);

Console.WriteLine("");
Console.WriteLine("----------------2.uzd.----------------");
Console.WriteLine("Kāds ir tavs vecums?");
int     userAge = int.Parse(Console.ReadLine());
bool    isAdult = userAge >= 18;
int     userAgeNextYear = userAge + 1;

if (isAdult)
{
    Console.WriteLine("Nākamgad tev paliks " + userAgeNextYear + ", tu esi pilngadīgs");
}
else
{
    Console.WriteLine("Nākamgad tev paliks " + userAgeNextYear + ", pagaidām vēl neesi pilngadīgs");
}

Console.WriteLine("");
Console.WriteLine("----------------3.uzd.----------------");
Console.WriteLine("Ievadi skaitļus, lai atrastu lielāko");
int     firstNumberForMax = int.Parse(Console.ReadLine());
int     secondNumberForMax = int.Parse(Console.ReadLine());
int     thirdNumberForMax = int.Parse(Console.ReadLine());
int     fourthNumberForMax = int.Parse(Console.ReadLine());
int     fifthNumberForMax = int.Parse(Console.ReadLine());
int     sixthNumberForMax = int.Parse(Console.ReadLine());
int     seventhNumberForMax = int.Parse(Console.ReadLine());
int     eighthNumberForMax = int.Parse(Console.ReadLine());
int     firstMax = Math.Max(firstNumberForMax, secondNumberForMax);   
int     secondMax = Math.Max(thirdNumberForMax, fourthNumberForMax);   
int     thirdMax = Math.Max(fifthNumberForMax, sixthNumberForMax);   
int     fourthMax = Math.Max(seventhNumberForMax, eighthNumberForMax);   
int     firstBiggest = Math.Max(firstMax, secondMax);   
int     secondBiggest = Math.Max(thirdMax, fourthMax);
int     maxNumber = Math.Max(firstBiggest, secondBiggest);

Console.WriteLine("Lielākais no ievadītājiem skaitļiem ir " + maxNumber);

Console.WriteLine("");
Console.WriteLine("----------------4.uzd.----------------");
Console.WriteLine("Ievadi skaitļus, lai atrastu mazāko");
int     firstNumberForMin = int.Parse(Console.ReadLine());
int     secondNumberForMin = int.Parse(Console.ReadLine());
int     thirdNumberForMin = int.Parse(Console.ReadLine());
int     fourthNumberForMin = int.Parse(Console.ReadLine());
int     fifthNumberForMin = int.Parse(Console.ReadLine());
int     sixthNumberForMin = int.Parse(Console.ReadLine());
int     seventhNumberForMin = int.Parse(Console.ReadLine());
int     eighthNumberForMin = int.Parse(Console.ReadLine());
int     firstMin = Math.Min(firstNumberForMin, secondNumberForMin);
int     secondMin = Math.Min(thirdNumberForMin, fourthNumberForMin);
int     thirdMin = Math.Min(fifthNumberForMin, sixthNumberForMin);
int     fourthMin = Math.Min(seventhNumberForMin, eighthNumberForMin);
int     firstSmallest = Math.Min(firstMin, secondMin);
int     secondSmallest = Math.Min(thirdMin, fourthMin);
int     minNumber = Math.Min(firstSmallest, secondSmallest);

Console.WriteLine("Mazākais no ievadītājiem skaitļiem ir " + minNumber);

Console.WriteLine("");
Console.WriteLine("----------------5.uzd.----------------");
Console.WriteLine("Ievadi pirmo skaitli");
int     firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Ievadi otro skaitli");
int     secondNumber = int.Parse(Console.ReadLine());
int     result = firstNumber % secondNumber;
Console.WriteLine("Dalījuma atlikums ir " + result);

Console.WriteLine("");
Console.WriteLine("----------------6.uzd.----------------");
Console.WriteLine("Ievadi skaitli, lai atpazītu, vai tas ir pāra vai nepāra");
int     userInput = int.Parse(Console.ReadLine());
bool    evenNumber = userInput % 2 == 0;

if (evenNumber)
{
    Console.WriteLine("Skaitlis {0} ir pāra skaitlis", userInput);
}
else
{
    Console.WriteLine("Skaitlis {0} ir nepāra skaitlis", userInput);
}

Console.WriteLine("");
Console.WriteLine("----------------7.uzd.----------------");
Console.WriteLine("Ievadi taisnstūra malu garumus");
double  firstRectangleEdge = double.Parse(Console.ReadLine());
double  secondRectangleEdge = double.Parse(Console.ReadLine());
double  rectangleArea = Math.Round(firstRectangleEdge * secondRectangleEdge, 2);
Console.WriteLine("Taisnstūra laukums ir {0} kv.vien.", rectangleArea);

Console.WriteLine("");
Console.WriteLine("----------------8.uzd.----------------");
Console.WriteLine("Ievadi trijstūra malas garumu");
double  TriangleEdge = double.Parse(Console.ReadLine());
double  triangleArea = Math.Round((TriangleEdge * TriangleEdge) /2, 2);
Console.WriteLine("Trijstūra laukums ir {0} kv.vien.", triangleArea);


Console.WriteLine("");
Console.WriteLine("----------------9.uzd.----------------");
Console.WriteLine("Kā tevi sauc?");
string  userInputName = Console.ReadLine();
Console.WriteLine("Kāds ir tavs vecums?");
int     userInputAge = int.Parse(Console.ReadLine());
Console.WriteLine($"Sveiks {userInputName}, tavs vecums ir {userInputAge}");