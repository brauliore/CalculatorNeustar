using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        public class Node
        {
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }
            public int Weight { get; set; }
        }
        public class Logger
        {
            public void Log(string message) { Console.WriteLine(message); }
        }


        public List<int> GetOrderedWeights(Node tree)
        {
            List<int> orderedWeights = new List<int>();

            if (tree != null)
            {
                orderedWeights.Add(tree.Weight);
                orderTree(orderedWeights, tree.LeftChild, tree.RightChild);
            }

            return orderedWeights;
        }

        private List<int> orderTree(List<int> orderedWeights, Node leftChild, Node rightChild)
        {
            Logger log = new Logger();
            if (leftChild == null && rightChild == null)
            {
                return null;
            }
            if (leftChild != null)
            {
                orderedWeights.Add(leftChild.Weight);
                orderTree(orderedWeights, leftChild.LeftChild, leftChild.RightChild);
            }
            if (rightChild != null)
            {
                orderedWeights.Add(rightChild.Weight);
                orderTree(orderedWeights, rightChild.LeftChild, rightChild.RightChild);
            }
            for (int i = (orderedWeights.Count - 1); i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (orderedWeights[j - 1] > orderedWeights[j])
                    {
                        var temp = orderedWeights[j - 1];
                        orderedWeights[j - 1] = orderedWeights[j];
                        orderedWeights[j] = temp;
                    }
                }
            }

            return orderedWeights;

        }
    }

}
