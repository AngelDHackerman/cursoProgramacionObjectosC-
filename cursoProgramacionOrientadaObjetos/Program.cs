int a = 20100000;
int b = 30000000;
long c = (long)a + (long)b;  // (long) es una conversion explicita o "cast" para pasar el dato de tipo "int" a tipo "long".
Console.WriteLine(c);



double aa = 42.1; // Natural type
float bb = 38.2F;  // La "F" es para convertir el tipo natural de "double" al tipo "float"
double cc = aa + bb;
Console.WriteLine(cc);

decimal a1 = 42.1M;  // Explicit type
decimal a2 = 38.2M;
decimal b1 = a1 + a2;
Console.WriteLine(b1);

// Conditional logic 

int value1 = 5;
int value2 = 4;
int value3 = value1 + value2;
int value4 = 10;


bool myTest = value3 > 10;  // will be true or false

if ((value1 + value2) > 10)
{
  Console.WriteLine("The answer is greater than 10.");
}


if (myTest)
{ // is true
  Console.WriteLine("The answer is greater than 10, but this time using the bool type.");
}
else
{
  Console.WriteLine("The answer is LESS than 10.");
}

if ((value1 + value2 + value3 > 10) && (value4 == 10))
{
  Console.WriteLine("The Logic of 'AND' is working!");
}


// While and Do While Loops

int counter = 0;
while (counter < 5)
{
  counter++;
  Console.WriteLine(counter);
}

int counter2 = 10;
do { 
  Console.WriteLine(counter2);
  counter2++;
}
while (counter2 < 15);

// For Loops 

for (
  int i = 0; i < 5; i++

) {
  Console.WriteLine($"This is the For Loop iteration {i}");
}

// For loops and if conditions 

for (int i = 0; i < 5; i++) {
  if (i == 3) {
    Console.WriteLine($"This is the for loop condition iteration N. {i}");
  }
}

// List of T List<T> 

var names = new List<string> { "Scott", "Ana", "Felipe"};

names.Add("David");
names.Add("Damian");
names.Add("Maria");

foreach (string name in names) {
  Console.WriteLine($"Hello {name}");
}

// Arryas, list, indexing, foreach

Console.WriteLine(names[1]);
Console.WriteLine(names[^1]);  // the hat ^ makes you see the last indexed item

foreach(string name in names[2..4]) {  // [2..4] here we are indexing from the 2nd to the 4th, (the last number is exclusive)
  Console.WriteLine($"Indexing from 2nd to 4th: {name}");
}

// Arrays 

var names2 = new string[] { "Angel", "Dario", "Juan"};  // this is also a list of t list<T>

// names2.Add("Carlos");  // Arrays are fixed and cannot be changed

foreach (string name2 in names2) {
  Console.WriteLine($"Hello {name2}");
}