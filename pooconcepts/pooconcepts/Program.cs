// See https://aka.ms/new-console-template for more information

using pooconcepts;


Console.WriteLine("POO concepts");
Console.WriteLine("====");
try
{

	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(1974, 9, 23));
	Console.WriteLine(new Date(1985, 11, 30));

}
catch (Exception error)
{
	Console.WriteLine(error .Message);

}




