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

if ((value1 + value2) > 10) {
  Console.WriteLine("The answer is greater than 10.");
}


if (myTest) { // is true
  Console.WriteLine("The answer is greater than 10, but this time using the bool type.");
}
else { 
  Console.WriteLine("The answer is LESS than 10.");
}

if ((value1 + value2 + value3 > 10) && (value4 == 10)) {
  Console.WriteLine("The Logic of 'AND' is working!");
}

