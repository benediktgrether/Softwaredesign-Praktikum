using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_1_aufgabe
{

    public class TreeNode<T>
    {
        public TreeNode<T> [] _childNodes;
        private TreeNode<T>  _parentsNode;
        private T _nodeContent;
        public int _count = 0;

        // public TreeNode()
        // {
        //     _parentsNode = new T[_parentsNode.Length];
        //     _count = 0;
        // }

        public TreeNode<T> CreateNode(T treeNodes)
        {
            TreeNode<T> node = new TreeNode<T>();
            node._nodeContent = treeNodes;
            return node;
        }

        public void AppendChild(TreeNode<T> node)
        {
            if(_count == 0)
            {
                _childNodes = new TreeNode<T>[] { node };
            } 
            else 
            {
                TreeNode<T>[] array = _childNodes;
                _childNodes = new TreeNode<T>[_count + 1 ];
                Array.Copy(array, _childNodes, _count);
                _childNodes[_count] = node;
            }
            _count++;
            node._parentsNode = this;
        }
        public void removeChild()
        {
            
        }

        public void PrintTree(String AddTree = "")
        {
            Console.WriteLine(AddTree +_nodeContent.ToString());
            if(_count > 0)
            {
                foreach (var node in _childNodes)
                {
                    node.PrintTree(AddTree + "|_");
                }
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeNode<String>();
            var root = tree.CreateNode("root");
            var child1 = tree.CreateNode("child1");
            var child2 = tree.CreateNode("child1");
            root.AppendChild(child1);
            root.AppendChild(child2);
            var grand11 = tree.CreateNode("grand11");
            var grand12 = tree.CreateNode("grand12");
            var grand13 = tree.CreateNode("grand13");
            child1.AppendChild(grand11);
            child1.AppendChild(grand12);
            child1.AppendChild(grand13);
            var grand21 = tree.CreateNode("grand21");
            child2.AppendChild(grand21);
            // child1.RemoveChild(grand12);

            root.PrintTree(); 
        }
    }

}
