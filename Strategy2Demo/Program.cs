﻿using System;
using Strategy2Demo.ConcreteStrategy;
using Strategy2Demo.Context;

namespace Strategy2Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var studentRecords = new SortedList();
            studentRecords.Add("Karwan");
            studentRecords.Add("Nishtiman");
            studentRecords.Add("Baran");
            studentRecords.Add("Lewan");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();


            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();


            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();


            Console.ReadLine();
        }
    }
}
