using Banking;
using Maths;

Account acc123=new Account(60000);
acc123.Deposit(15000);
float  currentBalance123=acc123.GetBalance();
Console.Write(currentBalance123);

Complex  c1=new Complex(34,56);
Complex c2=new Complex(11,78);
Complex c3=c1 + c2;
Complex c4=new Complex();
