Console.Clear();
Console.WriteLine("Введите число: ");
string? n = Console.ReadLine();
int sum = 0;
for(int i=0; i<=n.Length-1;i++){
    sum = sum + int.Parse(n[i].ToString());
}
Console.WriteLine(sum);