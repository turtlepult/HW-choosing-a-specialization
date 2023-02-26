Console.WriteLine("enter a your text");
string mass = Console.ReadLine()??"0";
char[]forsplit = {' ', ',', '.', ':','\t'};
string[] mainmass = mass.Split(forsplit);
string[] tempmass = new string[mainmass.Length];
int temp = 0;

