using System.Linq;

int start = 4;
int end = 17;
string five= "5";

int distance = end - start;
foreach (var i in Enumerable.Range(start, ++distance).Where(x=> !x.ToString().Contains(five)))
{
    Console.Write(i+" ");
}