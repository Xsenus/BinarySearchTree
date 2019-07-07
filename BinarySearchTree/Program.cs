﻿using BinarySearchTree.Model;
using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();

            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);
            tree.Add(4);

            Console.Write("Preorder: ");
            foreach (var item in tree.Preorder())
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.Write("Postorder: ");
            foreach (var item in tree.Postorder())
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.Write("Inorder: ");
            foreach (var item in tree.Inorder())
            {
                Console.Write($"{item} ");
            }
            
            Console.ReadLine();
        }
    }
}
