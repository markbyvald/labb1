// See https://aka.ms/new-console-template for more information

Console.WriteLine("skriv in vad du vill");
string inmat = Console.ReadLine();

for (int start = 0; start < inmat.Length; start++)
{

    for (int step = start + 1; step < inmat.Length; step++)
    {
        if (!char.IsDigit(inmat[step]))
        {
            break;
        }
        if (inmat[start] == inmat[step])
        {
            PrintMarkedString(inmat, start, step);
        }

    }

}


        
        static void PrintMarkedString(string inmat, int start, int step)
{
    for (int i = 0; i < inmat.Length; i++)
    {

        Console.ForegroundColor = ConsoleColor.White;

        if (i >= start && i <= step)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.Write(inmat[i]);

    }
    Console.WriteLine();
}