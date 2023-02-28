var goturulenDeyer = 12;
var bolenlerinSayi = 0;
var sum = 0;
for (var i = 0; i <= goturulenDeyer; i++)
{
    if (goturulenDeyer == 0 || goturulenDeyer == 1)
    {
        System.Console.WriteLine("ne tek ne cut");
    }
    else if (goturulenDeyer % i == 0)
    {
        bolenlerinSayi++;
        sum += i;
    }
}
if (bolenlerinSayi <= 2)
{
    System.Console.WriteLine(" ededimiz sade ededddir");
            }
else
{
    System.Console.WriteLine(" ededimiz sade eded deyil");
            }

System.Console.WriteLine(sum);


