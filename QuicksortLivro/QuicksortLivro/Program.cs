int[] array = { 2, 5, 3, 6, 18, 27, 4, 1, 33, 25, 26, 29 };
//Console.WriteLine(array);
Console.WriteLine();

Array.Sort(array);
//Console.Write(array);
foreach (int i in array)
{
    Console.Write(i.ToString()+ ", ");
}
//Console.WriteLine();


//Array.Reverse(array);
//Console.WriteLine(string.Join(", ", array));
//Console.WriteLine();

