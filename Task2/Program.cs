﻿// Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.

string s_a = Console.ReadLine();
string s_b = Console.ReadLine();
string s_c = Console.ReadLine();

int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);

if(a<b){
    a=b;
}
if(a<c){
    a=c;
}
Console.WriteLine ("{0} максимальное число" , a );

