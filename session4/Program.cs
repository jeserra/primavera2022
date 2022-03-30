Console.WriteLine("Hello, World!");

int x = 2147483647;
//cast o casteo implicito
long x2 = x;

Console.WriteLine("x2 = " + x2);


//cast o casteo explicito
long x3 = long.MaxValue;
int x4 = (int) x3;
Console.WriteLine("x4 = " + x4);

double x5 = double.MaxValue;
int x6 = (int) x5;
Console.WriteLine("x6 = " + x6);

String x7 ="10";
int x8 = int.Parse(x7);
Console.WriteLine("x8 = " + x8);

/*string x9 = "unnumero";
int x10 = int.Parse(x9);
Console.WriteLine("x10 = " + x10);
*/


int i1 =4;
int i2 = 7;
int i3 = 9;

int [] x11 = new int[3];
x11[0] = 4;
x11[1] = i2;
x11[2] = i3;

for(var i = 0; i < 3; i++)
{
    Console.WriteLine("x11[" + i + "] = " + x11[i]);
}


int [] x12 = new int[3] {8, 2, 9};

for(var i = 0; i < 3; i++)
{
    Console.WriteLine("x12[" + i + "] = " + x12[i]);
}

string [] x13 = new string[3] {"hola", "mundo", "!"};

for(var i = 0; i < 3; i++)
{
    Console.WriteLine("x13[" + i + "] = " + x13[i]);
}

///Console.WriteLine("" + x13[3]); 




