int result = 257;
int num = 257;
int count = 0;
int sum = 0;
while (num > 0)
{
    num -= num % 10;
    num /= 10;
    count++;
    sum = result + (3 * (10 ** count));
}
Console.WriteLine(sum);



