using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            //LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
             LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            List<string> lists = new List<string>();
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("Node 1");
            linkedList.AddLast("Node 2");
            linkedList.AddFirst("Node 0");

            PrintLinkedList(linkedList);

            LinkedListNode<string> fistNode = linkedList.First;
            Debug.Log("First: " + fistNode.Value);
            LinkedListNode<string> lastNode = linkedList.Last;
            Debug.Log("Last: " + lastNode.Value);
            LinkedListNode<string> node1 = linkedList.Find("Node 1");
            Debug.Log("Node: " + node1.Value);
            Debug.Log(node1.Previous.Value);
            Debug.Log(node1.Next.Value);

            if (fistNode.Previous == null)
            {
                Debug.Log("FirstNode.Previous is null");
            }
            if (lastNode.Next == null)
            {
                Debug.Log("LastNode.Next is null");
            }

            linkedList.AddAfter(node1, "Node 1.5");
            linkedList.AddBefore(node1, "Node 0.5");
            PrintLinkedList(linkedList);

            linkedList.RemoveFirst();
            PrintLinkedList(linkedList);    
            linkedList.Remove("Node 2");
            PrintLinkedList(linkedList);
            linkedList.Clear();
            PrintLinkedList(linkedList);
        }
        
        void PrintLinkedList(LinkedList<string> linkedList)
        {
            Debug.Log("----- LinkedList -----");
            foreach (string s in linkedList)
            {
                Debug.Log(s);
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Apple");
            dictionary.Add(2, "Banana");
            dictionary[3] = "Cherry";

            //Debug.Log(dictionary[1]);
            int ketToCheck = 1;
            bool hasKey = dictionary.ContainsKey(ketToCheck);
            Debug.Log($"has key {ketToCheck}:{hasKey}");
            if (hasKey)
            {
                Debug.Log($"{dictionary[ketToCheck]}");
            }
            foreach (int k in dictionary.Keys)
            {
                Debug.Log(k);
            }
            foreach (string s in dictionary.Values)
            {
                Debug.Log(s);
            }
            dictionary.Remove(1);
            foreach (string s in dictionary.Values)
            {
                Debug.Log(s);
            }

            dictionary.Clear();
            foreach (string s in dictionary.Values)
            {
                Debug.Log(s);
            }
        }

        #endregion
    }
}
