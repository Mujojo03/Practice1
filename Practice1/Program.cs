// Switch statement and nested switch
//int month = 5;
//int week = 2;
//switch (month)
//{
//    case 1:
//        Console.WriteLine("It Is June");
//        break;

//    case 2:
//        Console.WriteLine("It Is July");
//        break;

//    case 3:
//        Console.WriteLine("It Is August");
//        break;

//    case 4:
//        Console.WriteLine("It Is September");

//        switch (week)
//        {
//            case 1:
//                Console.WriteLine("First Week of The Month");
//                break;

//            case 2:

//                Console.WriteLine("Second Week of The Month");
//                break;

//            case 3:
//                    Console.WriteLine("Third Week of The Month");
//                break;

//            default:
//                Console.WriteLine("Its a Good Week");
//                break;
//        }
//        break;

//    case 5:
//        Console.WriteLine("It Is October");
//        break;

//    case 6:
//        Console.WriteLine("It Is November");
//        break;

//    default:
//        Console.WriteLine("This Month Is Cold");
//        break;
//}



//int i = 10, j;
//Console.WriteLine(j = i * 2);


//Excersise
//public class Employee
//{
//    public int salary;
//}
//public class Program
//{
//    public static void Main()
//    {
//        Employee emp = new Employee();
//        Console.WriteLine(emp.salary);
//    }
//}// output will be 0 because static variables are automatically assigned a default value, which in this case default value of int is 0



//implicitly typed variable (var is used to declare a variable)
//var i = 10;
//Console.WriteLine(i);


//implicit casting
//int myNum = 2;
//double myDouble = myNum;

//Console.WriteLine(myNum);
//Console.WriteLine(myDouble);


//for loop....[has short cut, for(;;)]
//first set rep INNITIALIZER, second set rep CONDITION, third rep SEQUENCE.
// loop means we are going to start from zero, then calues to be looped are less or equal to 10, and we are increasing the values(++)
//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine("Value of i:{0}",i);
//}


//adding a break point in a loop 
//for (int i = 0;i <= 10; i++)
//{
//    if (i == 8)
//        break;

//    Console.WriteLine("Value of i:{0}",i);
//}
//loop will reach upto 8


//foreach loop
//string[] carLogos = { "BMW", "Tesla", "Jaguar", "Nissan", "Toyota" };
//foreach (string car in carLogos)
//{
//    Console.WriteLine(car);
//}
//outputs all the car logos

//using foreach to looop through the array
//string[] carlogos = { "bmw", "tesla", "jaguar", "nissan", "toyota" };
//foreach (string car in carlogos)
//{
//	if (car == "tesla")
//	{
//		Console.WriteLine(car);
//	}
//}
//outputs tesla


//accessing strings using []
//to output the first letter of every car logo
//string[] carBrands = { "bmw", "tesla", "jaguar", "nissan", "toyota" };
//foreach (string car in carBrands)
//{
//    Console.WriteLine(car[0]);
//}



//Array
// data type, [], name of array = new, data type
//code to output the first item in the array and the array length
//string[] cities = { "Nairobi", "Nakuru", "Kampala" };
//Console.WriteLine(cities[0]);
//Console.WriteLine(cities.Length);


//to output the array length (total number of the items in the array)
//string[] fruits = { "Mango", "Avocado", "Apple", "Banana" };
//Console.WriteLine(fruits.Length);
//outputs 4


//multidimensional array
//int[,] numbers = { {1, 2, 3 },{ 4, 5, 6 } };
//Console.WriteLine(numbers[1,1]);
//outputs 5

//dictionary serves the same purpose like outputing one thing
//Dictionary<string, string> CapitalCities = new Dictionary<string, string>();
//CapitalCities.Add("Kenya", "Nairobi");
//CapitalCities.Add("Uganda", "Kampala");
//CapitalCities.Add("Tanzania", "Dar");
//Console.WriteLine(CapitalCities["Tanzania"]);
//outputs the value of key Tanzania

//Dictionary<int, string> Numbers = new Dictionary<int, string>();
//Numbers.Add(1, "One");
//Numbers.Add(2, "Two");
//Numbers.Add(3, "Three");
//Console.WriteLine(Numbers[1]);
//dictionary using int outputs 'one'


//class maths, to perform mathematical tasks on numbers
//maximum number
//Console.WriteLine( Math.Max(111,12));

//minimum number
//Console.WriteLine(Math.Min(111, 17));

//square root
//Console.WriteLine(Math.Sqrt(144));

//absolute positive number
//Console.WriteLine(Math.Abs(-8));

//round of to the nearest whole number
//Console.WriteLine(Math.Round(3.99));


//String Concatenation, combining strings using (+)
//string firstName = "Jane ";
//string lastName = "Rose";
//string name = firstName + lastName;
//Console.WriteLine(name);
// I put a space after ""Jane to space the name"

//for numbers
//string x = "20";
//string y = "20";
//string z = x+ y;
//Console.WriteLine(z);
//outputs 2020, for integers it will add the two numbers and give you the sum


//String Interpolation, another way of string concantenation
//string FirstName = "Jane ";
//string LastName = "Rose";
//string Name = $"My Full Name Is: {FirstName} {LastName}";
//Console.WriteLine(Name);


//Lists
//class that can hold objects of a specified type, it grows as you put elements to it
// create a string called bigCities, assign it values by using the (.add), then find the count of the items in the string list
//List<string> bigCities = new List<string>();
//bigCities.Add("New York");
//bigCities.Add("Las Vegas");
//bigCities.Add("London");
//bigCities.Add("LA");
//Console.WriteLine(bigCities.Count);
//outputs the total number of items in the string list

//List<int> numberlist = new List<int>();
//numberlist.Add(1);
//numberlist.Add(2);
//numberlist.Add(3);
//numberlist.Add(4);
//numberlist.Add(5);
//Console.WriteLine(numberlist.Count);
//outputs total number of items in the int list

//accessing a list using square brackets
//List<int> NumberList = new List<int>() { 12, 21, 39, 44, 52, 67 };
//Console.WriteLine(NumberList[0]);
//Console.WriteLine(NumberList[1]);
//Console.WriteLine(NumberList[2]);
//Console.WriteLine(NumberList[3]);
// outputs 12, 21, 39, 44
// other methods of listing are, remove, contain, sort...

//exercise
//class Person
//{
//    public void Introduction()
//    {
//        Console.WriteLine("I am a person");
//    }
//    public void Introduction(string name)
//    {
//        Console.WriteLine("My Name is" + name);
//    }
//    public void Introduction(string name, int age = 0)
//    {
//        Console.WriteLine($"My Name is {name} and age is {age}");

//    }
//}

//Person p = new Person();
//p.Introduction("Steve");
//will output Steve since the method Introduction has been called and it has only one parameter
//an optiona parameter must come last


//sum is an implicitly typed varable whose data type will be determined at compile time and so it would be float type.
//float f = 10.5F;
//int i = 20;
//var sum = f + i;
//Console.WriteLine(sum);

//ASCII table
//Console.WriteLine(Convert.ToInt32('A'));

//var x = "5";
//Console.WriteLine(x.GetType());
// outputs System.String

//method overiding
//using Practice1;

//Student student = new Student();
//student.ShowData();

//Child child = new Child();
//child.ShowData();


//determines its value during runtime
//dynamic Value;
//Value = 3;
//Console.WriteLine(Value.GetType());


//error handling
//try
//{

//    int[] numbers = { 1, 2, 3, 4, 5, };
//    Console.WriteLine(numbers[4]);
//}
//catch (Exception)
//{
//    Console.WriteLine("An Error Occurred");
//}

//finally
//{
//    Console.WriteLine("Please Wait");
//}


//type casting assigning a value of one type to another type.
double x = 2.5;
int y = (int)x;
Console.WriteLine(y);