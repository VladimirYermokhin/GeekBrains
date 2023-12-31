/* 
void OpenMatryoshka(int size)
{
    if (size == 1)
    {
        System.Console.WriteLine("Smallest!");
        return;
    }
    OpenMatryoshka(size - 1);
    Console.WriteLine($"Opening matryoshka of size {size}...");

}

OpenMatryoshka(5); 
*/

/* 
void ShowMsg(string msg)
{
    Console.Write(msg + " " );
}
ShowMsg("Hello");
Console.Write("World"); 
*/
/* 
Раскручивание рекурсии - процесс возврата к местам вызова функций
В памяти сохраняются(стек - область памяти где сохраняются значения):
Места вызова функции
Значение параметров функции при вызове 
*/

int Factorial(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop:{n}");
        return 1;
    }
    Console.WriteLine(n);
    return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(5));