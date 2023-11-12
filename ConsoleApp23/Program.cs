#region Reverse 
using System.Text;
using Reverse.Models;
using Reverse.Models;
using Reverse.Models;

Console.WriteLine(Reverse("Salam necesen"));
string Reverse(string text)
{
    StringBuilder builder = new StringBuilder();
    for (int i = text.Length - 1; i >= 0; i--)
    {
        builder.Append(text[i]);
    }
    return builder.ToString();
}
#endregion

#region login

Console.WriteLine(" username yaz ");
string user = Console.ReadLine();
Console.WriteLine(" password yaz ");
string pass = Console.ReadLine();

Account account1 = new(username: "lorem123", password: "123456*");
Console.WriteLine(account1.Login(user, pass));
#endregion

#region factorial


Factorial factorial1 = new(1);
Factorial factorial2 = new(12);
Console.WriteLine(factorial1.Function(1));
Console.WriteLine(factorial2.Function(12));
#endregion



int Value1 = int.Parse(Console.ReadLine());
char Symbol = char.Parse(Console.ReadLine());
int Value2 = int.Parse(Console.ReadLine());

Calculator calculation = new Calculator(Value1, Symbol, Value2);
Console.WriteLine(calculation.Calculate());