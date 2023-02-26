Console.WriteLine("enter a your text");
string mass = Console.ReadLine()??"0";
char[]forsplit = {' ', ',', '.', ':','\t'};
string[] mainmass = mass.Split(forsplit);
