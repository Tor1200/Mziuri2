//ამოცანა 1
double a1 = Convert.ToDouble(Console.ReadLine()), b1 = Convert.ToDouble(Console.ReadLine());
char op1 = Convert.ToChar(Console.ReadLine());
if(op1 == '+')
{
    Console.WriteLine(a1 + b1);
}
else if(op1 == '-')
{
    Console.WriteLine(a1 - b1);
}
else if(op1 == '*')
{
    Console.WriteLine(a1 * b1);
}
else if (op1 == '/')
{
    if (a1 == 0)
    {
        Console.WriteLine("0-ზე გაყოფა შეუძლებელია");
    }
    else
    {
        Console.WriteLine(a1 / b1);
    }
}
else
{
    Console.WriteLine("ოპერატორი უცნობია");
}

//ამოცანა 2
int a2 = Convert.ToInt32(Console.ReadLine()), b2 = Convert.ToInt32(Console.ReadLine()), c2 = Convert.ToInt32(Console.ReadLine());
if(a2 > b2){
    if(a2 > c2){
        Console.WriteLine(a2);
    }else{
        Console.WriteLine(c2);
    }
}else{
    if(b2 > c2){
        Console.WriteLine(b2);
    }else{
        Console.WriteLine(c2);
    }
}

//ამოცანა 3
int a3 = Convert.ToInt32(Console.ReadLine()), b3 = Convert.ToInt32(Console.ReadLine()), c3 = Convert.ToInt32(Console.ReadLine());
if (a3 > (b3 + c3) || b3 > (a3 + c3) || c3 > (a3 + b3))
{
    Console.WriteLine("სამკუთხედი შეუძლებელია");
}
else
{
    Console.WriteLine("სამკუთხედი შესაძლებელია");
}