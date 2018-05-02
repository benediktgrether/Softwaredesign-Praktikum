using System;
using System.Collections.Generic;

namespace _4_1_aufgabe
{
    public class TreeNode<T>
    {
        public T Data;
        public List<TreeNode<T>> Children = new List<TreeNode<T>>();

        public TreeNode<T> CreateNode(T data)
        {
            TreeNode<T> newNode = new TreeNode<T>
            {
                Data = data
            };
            return newNode;
        }

        public void AppendChild(TreeNode<T> child)
        {
            Children.Add(child);
        }
        public void RemoveChild(TreeNode<T> child)
        {
            Children.Remove(child);
        }

        // public void FindChild(TreeNode<T> child)
        // {
        //     Children.Find(x => x.Children.Contains(child));
        //     //Console.WriteLine();
        // }

        public void PrintTree(String AddTree = "")
        {
            Console.WriteLine(AddTree + Data);
            foreach (TreeNode<T> child in Children)
            {
                child.PrintTree(AddTree + "*");
            }
        }
    }
}