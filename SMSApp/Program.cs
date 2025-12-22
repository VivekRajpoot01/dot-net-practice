// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SMSApp;

StudentBL sBLobj = new StudentBL();
sBLobj.AcceptStudentDetails();
sBLobj.calcTotal();
sBLobj.calcAvg();

int t1; //Total
float p1; //Percentage

sBLobj.calcResult(out t1, out p1);

// System.Console.WriteLine($"Total: {sBLobj.calcTotal()}");
// System.Console.WriteLine($"Percentage: {sBLobj.calcAvg()}");

System.Console.WriteLine($"Total: {t1}");
System.Console.WriteLine($"Percentage: {p1}");


