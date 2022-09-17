// for last index need length and substring 
// for first need only substring 
Console.WriteLine("Enter your credit card number :");
string cname = Console.ReadLine();
int len = cname.Length;
if ( len <= 4 )
{
    Console.WriteLine(cname);
    Console.ReadKey();
}
else
{
    string first = "**************";
    string last = cname.Substring(cname.Length -4);
    Console.WriteLine(first+last);
    Console.ReadKey();


}

