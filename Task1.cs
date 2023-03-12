int num = 5987;
int sum = 0;
while (num != 0)
{
    sum = (sum * 10) + (num % 10);
    num /= 10;
}
Console.WriteLine(sum);