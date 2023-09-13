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

a = 2;
while(a<6){
    v[a] = a*10;
    a++;
}

Console.WriteLine("Problema 2:");

for(int i = 0;i<7;i++){
    Console.WriteLine(v[i]);
}

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

//Problema 3

v = new int[10];

a = 7;
b = a-6;
while(b<a){
    v[b] = a+b;
    b+=2;
}

Console.WriteLine("Problema 3:");

for(int i = 0;i<8;i++){
    Console.WriteLine(v[i]);
}

