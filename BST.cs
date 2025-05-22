using System;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data, Node left = null, Node right = null)
    {
        Data = data;
        Left = left;
        Right = right;
    }
}

public class BST
{
    public Node Root;

    public BST()
    {
        Root = null;
    }

    public void InsertNode(int val)
    {
        Node newNode = new Node(val);
        if (Root == null)
        {
            Root = newNode;
            return;
        }
        Node current = Root;
        Node parent = null;
        while (current != null)
        {
            parent = current;
            if (val == current.Data)
            {
                return;
            }
            else if (val < current.Data)
            {
                current = current.Left;
            }
            else
            {
                current = current.Right;
            }
        }
        if (val < parent.Data)
        {
            parent.Left = newNode;
        }
        else
        {
            parent.Right = newNode;
        }
    }

    public Node Search(int n)
    {
        Node temp = Root;
        while (temp != null)
        {
            if (temp.Data == n)
            {
                return temp;
            }
            else if (n < temp.Data)
            {
                temp = temp.Left;
            }
            else
            {
                temp = temp.Right;
            }
        }
        return null;
    }
}
