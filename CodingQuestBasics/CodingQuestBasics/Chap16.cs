﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestBasics
{
    // *** Recursion ***
    // 16.1 The Towers of Hanoi problem . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 254
    // 16.2 Generate all nonattacking placements of n-Queens . . . . . . . . . . . . . . . . . . 256
    // 16.3 Generate permutations . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 258
    // 16.4 Generate the power set . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 259
    // 16.5 Generate all subsets of size k . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 261
    // 16.6 Generate strings of matched parens . . . . . . . . . . . . . . . . . . . . . . . . . . . 262
    // 16.7 Generate palindromic decompositions . . . . . . . . . . . . . . . . . . . . . . . . . 264
    // 16.8 Generate binary trees . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 265
    // 16.9 Implement a Sudoku solver . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 266
    // 16.10 Compute a Gray code . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 268
    // 16.11 Compute the diameter of a tree . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 270
    class Chap16
    {
        
    //The Towers of Hanoi problem
    public void _16_1_TheTowersofHanoi(int numberofdisc,int start, int aux,int end)
    {
        if(numberofdisc>0)
        {
            TheTowersofHanoi(numberofdisc-1,start,end,aux);
            Console.WriteLine("Move from " + start + " to " + end);
            TheTowersofHanoi(numberofdisc-1,aux,start,end);
        }
        
    }
    
    public void _16_3_Generatepermutations(char[] list,int i,int m)
    {
        
         if(i==m)
        {
             Console.WriteLine(list);
        }
        else
        {
        for(int j=i;j<=m;j++)
        {
            swap(ref list[j],ref list[i]);
            Prem(list,i+1,m);
            swap(ref list[j],ref list[i]);
        }
        }
        
    }
    public void swap(ref char a,ref char b)
    {
       
        char temp;
        temp =b;
        b=a;
        a=temp;
        
    }
    
    
        
    }
}
