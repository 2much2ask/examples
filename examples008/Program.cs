﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result)result = arg2;
    if(arg3 > result)result = arg3;
    return result;
}

int a1 = 20;
int b1 = 10;
int c1 = 15;
int a2 = 99;
int b2 = 55;
int c2 = 34;
int a3 = 919;
int b3 = 525;
int c3 = 3;

// int max1 = Max(a1, b1,c1);
// int max2 = Max(a2, b2,c2);
// int max3 = Max(a3, b3,c3);

int max = Max(Max(a1, b1,c1), 
        Max(a2, b2,c2), 
        Max(a3, b3,c3));

Console.WriteLine(max);