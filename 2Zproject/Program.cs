
/* Elias er dum

var rand = new Random().Next(1,7);

int tirsdag = rand;

if (tirsdag == 2)
{
 Console.WriteLine("Er det tirsdag? Ja");
}
else
{
 Console.WriteLine("Er det tirsdag? Nej");
}
*/
//Console.WriteLine("You have got " + Money +" Dollars");
/*

ulong Money = 0;
ulong Moneyperclick = 1;
ulong multi = 1;


while(true)
{
 Console.WriteLine("Dollars: "+Money);
 Console.WriteLine("Multi: "+multi);
 Console.WriteLine("\nPress q to buy multi");
 Console.WriteLine("Press m to generate money");



 string input1 = Console.ReadKey().Key.ToString().ToLower();

 Console.Clear();

 if (input1 == "m")
 {
  Money += Moneyperclick*multi;
 }
 
 if (input1 == "q" && Money >= 100) {
  multi = multi*2;
  Money -= 100;
 }



 
 
}

*/

/*
char a = Console.ReadKey().KeyChar;
char b = Console.ReadKey().KeyChar;
char t = Console.ReadKey().KeyChar;

Console.WriteLine($"\n{t} {b} {a}");
*/



/*Console.WriteLine("Enter your number.");
int number = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter your width.");
int width = Int32.Parse(Console.ReadLine());
Console.Clear();

for (int i = width; i > 0; i--)
{
 for (int j = 0; j < i; j++)
 {
  Console.Write(number);
 }
 Console.Write("\n");
 
}
*/

int attempts = 0;

int numberofrightanswers = 0;
static void write(string a){
 foreach (char c in a) {
  Console.Write(c);
  Thread.Sleep(40);
 }
 Console.Write("\n");
}

write("WELCOME TO THE PASSWORD GAME!");
write("\nToday we will be testing your skills.");


while(true)
{

 var rand = new Random().Next(100000,999999);

 write("The password will be shown in");
 Thread.Sleep(1000);
 Console.WriteLine("3");
 Thread.Sleep(1000);
 Console.WriteLine("2");
 Thread.Sleep(1000);
 Console.WriteLine("1");
 Thread.Sleep(1000);
 Console.WriteLine(rand);
 Thread.Sleep(1000);
 Console.Clear();
 write("What was the number?");

string password = Console.ReadLine();

 if(password == rand.ToString())
 {
  write("Thats correct!");
  numberofrightanswers++;


 }

 else
 {
  write("\nThat was incorrect.\n\nYou got "+numberofrightanswers+ " right.");
  numberofrightanswers = 0;
  write("\nThe correct answer was "+ rand);
  write("\nPress any key to try again.");
  Console.ReadKey();
 }
 











}





