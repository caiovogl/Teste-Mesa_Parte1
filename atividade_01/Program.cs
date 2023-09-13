// See https://aka.ms/new-console-template for more information
using System;

//Problema 1

int[] v = new int[10];

int a = 10;
int b = 20;
int c = (a+b)/2;
c = c - 40;

v[3] = a+b+c;

Console.WriteLine("Problema 1:");

Console.WriteLine(v[3]);

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

//Problema 2

Console.WriteLine("Problema 2:");

a = 2;
while(a<6){
    v[a] = a*10;
    Console.WriteLine(v[a]);
    a++;
}

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

//Problema 3

Console.WriteLine("Problema 3:");

v = new int[10];

a = 7;
b = a-6;
while(b<a){
    v[b] = a+b;
    Console.WriteLine(v[b]);
    b+=2;
}

