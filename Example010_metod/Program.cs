﻿int[] array={1,2,3,8,5,9,6,3,5,4};

int n = array.Length;
int find = 4;

int index=0;
while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
    }
    index++;
}
