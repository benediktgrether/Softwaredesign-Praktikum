using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_1_aufgabe
{
    public class TreeNode<T>
    {
        public T Data;
        public List<TreeNode<T>> Children = new List<TreeNode<T>>();
        public List<TreeNode<T>> Nodes = new List<TreeNode<T>>();

        public TreeNode<T> CreateNode(T data)
        {
            TreeNode<T> newNode = new TreeNode<T>
            {
                Data = data
            };
            Nodes.Add(newNode);
            return newNode;
        }
        public List<TreeNode<T>> FindChild(T search)
        {
            // return (Nodes.Where(x => x.Contains(search)));
            return (Nodes.FindAll(x => x.Data.Equals(search)));
        }



        
        public void AppendChild(TreeNode<T> child)
        {
            Children.Add(child);
        }

        public void RemoveChild(TreeNode<T> child)
        {
            Children.Remove(child);
        }

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