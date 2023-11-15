string a=Console.ReadLine();
string[] b = a.Split(' ');
string[] mas = new string[10];
for (int i = 0; i < 10; i++)
{
    mas[i] = b[i];
}
for (int i = 0;i < 10;i++)
{
    Console.WriteLine(mas[i]);
}