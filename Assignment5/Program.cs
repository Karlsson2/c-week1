// See https://aka.ms/new-console-template for more information

var A = 50;
var B = 45;
var C = 90;

var total = A+B+C;

int smallest = Math.Min(Math.Min(A, B), C);

total = total - smallest;

Console.WriteLine($"Your total is ${total}:-");