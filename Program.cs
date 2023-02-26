Console.WriteLine("enter a your text");
string mass = Console.ReadLine()??"0";
char[]forsplit = {' ', ',', '.', ':','\t'};
string[] mainmass = mass.Split(forsplit);
string[] tempmass = new string[mainmass.Length];
int temp = 0;

for (int i = 0; i < mainmass.Length; i++)
{
    if (mainmass[i].Length<=3)
    {
        tempmass[temp] = mainmass[i];
        temp++;
    }
}
foreach (var item in tempmass)
{
    Console.Write($"{item} ");
}