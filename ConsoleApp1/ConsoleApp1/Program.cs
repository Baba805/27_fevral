//task2
var num = 11;
var bolenlerinSayi = 0;

for (var i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        bolenlerinSayi++;
    }

}
if (bolenlerinSayi == 1 || bolenlerinSayi == 0)
{
    System.Console.WriteLine("eded ne sadedir nede murekkeb");
        }
else if (bolenlerinSayi > 2)
        {
    System.Console.WriteLine("eded murekkebdir");
        }
else {
    System.Console.WriteLine("eded sadedir");
        };



