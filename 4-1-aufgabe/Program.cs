﻿using System;

namespace _4_1_aufgabe
{


    class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeNode<String>();
            var root = tree.CreateNode("root");
            var child1 = tree.CreateNode("child1");
            var child2 = tree.CreateNode("child2");
            root.AppendChild(child1);
            root.AppendChild(child2);
            var grand11 = tree.CreateNode("grand11");
            var grand12 = tree.CreateNode("grand12");
            var grand13 = tree.CreateNode("grand13");
            child1.AppendChild(grand11);
            child1.AppendChild(grand12);
            child1.AppendChild(grand13);
            var grand111 = tree.CreateNode("grand111");
            var grand112 = tree.CreateNode("grand112");
            grand11.AppendChild(grand111);
            grand11.AppendChild(grand112);
            var grand21 = tree.CreateNode("grand21");
            child2.AppendChild(grand21);
            child1.RemoveChild(grand12);
            
            // grand11.FindChild(grand11);
            // child1.FindChild(grand11);
            // var test = tree.CreateNode(grand11);
            // root.FindChild("child1");
            var test = tree.FindChild("grand12");


            root.PrintTree();
        }
    }
}
