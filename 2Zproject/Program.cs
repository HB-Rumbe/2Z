
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

using System.ComponentModel.DataAnnotations;



int numberofrightanswers = 0;
static void write(string a){
 foreach (char c in a) {
  Console.Write(c);
  Thread.Sleep(40);
 }
 Console.Write("\n");
}


int minlength = 0;
int maxlength = 0;
int y = 0;

write("WELCOME TO THE PASSWORD GAME!");
write("\nToday we will be testing your skills.");
Thread.Sleep(1500);

while(true)
{
 if(y == 0) {

  Console.Clear();
  write("Choose your speed.");
  write("\nSlow");
  write("\nNormal");
  write("\nFast");
  write("\nDeath Mode\n");
  

  


  switch (Console.ReadLine().ToLower())
  {
   case "slow":
   y = 2000;
   break;
   case "fast": 
   y = 500;
   break;
   case "death mode": 
   y = 250;
   break;
   case "normal":  
   default:
   y = 1000;
   break;
  
  }
  Console.Clear();

  


  write("Choose your length.");
  write("\n3 digits");
  write("\n5 digits");
  write("\n7 digits");
  write("\n9 digits\n");

  switch (Console.ReadLine().ToLower())
  {
   case "3 digits":
   minlength = 100;
   maxlength = 999;
   break;
   case "7 digits": 
   minlength = 1000000;
   maxlength = 9999999;
   break;
   case "9 digits": 
    minlength = 100000000;
    maxlength = 999999999;
   break;
   case "5 digits":  
   default:
    minlength = 10000;
    maxlength = 99999;
   break;
   
  }
  Console.Clear();
 }











   var rand = new Random().Next(minlength,maxlength);

   write("The password will be shown in");
   Thread.Sleep(1000);
   Console.WriteLine("3");
   Thread.Sleep(1000);
   Console.WriteLine("2");
   Thread.Sleep(1000);
   Console.WriteLine("1");
   Thread.Sleep(1000);
   Console.WriteLine(rand);
   Thread.Sleep(y);
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
   Console.WriteLine("-------------------------------");
   write("That was incorrect.\n\nYou got "+numberofrightanswers+ " right.");
   
   numberofrightanswers = 0;
   write("\nThe correct answer was "+ rand);
   Console.WriteLine("-------------------------------");
   Console.ReadKey();
   Console.Clear();
   write("\n\nDo you want to try again?.");
   write("\nYes");
   write("\nNo");
   string Retry = Console.ReadLine();
   if(Retry.ToLower() == "yes")
   {
    Console.Clear();
    continue;
   
   }
   else
   {
    Console.Clear();
    y = 0;
   }

  }
 
 










}





