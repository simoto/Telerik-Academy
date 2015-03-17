using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// This implementation is based on the source code posted at:
/// http://dvanderboom.wordpress.com/2008/03/15/treet-implementing-a-non-binary-tree-in-c/
/// </summary>
/// <typeparam name="T"></typeparam>
public class TreeNode<T> : IEnumerable<TreeNode<T>>
{
    private StringBuilder dataBuilder = new StringBuilder();
    private TreeNode<T> parent;

    public T Data { get; set; }

    public TreeNode<T> Parent
    {
        get
        {
            return this.parent;
        }

        set
        {
            if (value == this.parent)
            {
                return;
            }

            if (this.parent != null)
            {
                this.parent.Nodes.Remove(this);
            }

            if (value != null && !value.Nodes.Contains(this))
            {
                value.Nodes.Add(this);
            }

            this.parent = value;
        }
    }

    public int Level
    {
        get
        {
            if (this.parent == null)
            {
                return 0;
            }

            return this.parent.Level + 1;
        }
    }

    public int Depth
    {
        get
        {
            int depth = 0;
            TreeNode<T> node = this;

            while (node.Parent != null)
            {
                node = node.Parent;
                depth++;
            }

            return depth;
        }
    }


    public TreeNodeCollection<T> Nodes { get; private set; }

    public TreeNode()
        : this(default(T), null)
    {
    }

    public TreeNode(T data)
        : this(data, null)
    {
    }

    public TreeNode(T data, TreeNode<T> parent)
    {
        this.Data = data;
        this.Parent = parent;
        this.Nodes = new TreeNodeCollection<T>(this);
    }

    public TreeNode<T> GetRoot()
    {
        TreeNode<T> node = this;

        while (node.Parent != null)
        {
            node = node.Parent;
        }

        return node;
    }

    public int GetHeight()
    {
        return this.GetHeight(this);
    }

    public TreeNode<U> Map<U>(Func<T, U> selector)
    {
        return this.Map(selector, this);
    }

    public U Accumulate<U>(U seed, Func<U, T, U> func)
    {
        return this.Accumulate(seed, func, data => true);
    }

    public U Accumulate<U>(U seed, Func<U, T, U> func, Func<T, bool> predicate)
    {
        return this.Accumulate(seed, func, predicate, this);
    }

    public IEnumerable<TreeNode<T>> Filter(Func<T, bool> predicate)
    {
        return this.Where(node => predicate(node.Data));
    }

    public IEnumerator<TreeNode<T>> GetEnumerator()
    {
        return this.GetDfsEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<TreeNode<T>>)this).GetEnumerator();
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        if (this.Data != null)
        {
            result.AppendFormat("Data=[{0}], ", this.Data);
        }

        result.AppendFormat("Depth={0}, Nodes={1}", this.Depth, this.Nodes.Count);

        return result.ToString();
    }

    public string ToStringUsingDfs()
    {
        this.dataBuilder.Clear();

        this.CollectDataUsingDfs(this, string.Empty);

        return dataBuilder.ToString();
    }

    private int GetHeight(TreeNode<T> node)
    {
        if (node.Nodes.Count == 0)
        {
            return 0;
        }

        int maxHeight = int.MinValue;

        foreach (var childNode in node.Nodes)
        {
            int height = GetHeight(childNode);
            if (maxHeight < height)
            {
                maxHeight = height;
            }
        }

        return maxHeight + 1;
    }

    private void CollectDataUsingDfs(TreeNode<T> node, string space)
    {
        dataBuilder.AppendLine(space + node.Data);

        foreach (var childNode in node.Nodes)
        {
            this.CollectDataUsingDfs(childNode, space + "   ");
        }
    }

    private TreeNode<U> Map<U>(Func<T, U> selector, TreeNode<T> node)
    {
        TreeNode<U> newNode = new TreeNode<U>(selector(node.Data));

        foreach (var childNode in node.Nodes)
        {
            TreeNode<U> newChildNode = this.Map(selector, childNode);
            newNode.Nodes.Add(newChildNode);
        }

        return newNode;
    }

    private U Accumulate<U>(U seed, Func<U, T, U> func, Func<T, bool> predicate, TreeNode<T> node)
    {
        U accumulator = seed;

        if (predicate(node.Data))
        {
            accumulator = func(seed, node.Data);
        }

        foreach (var childNode in node.Nodes)
        {
            accumulator = this.Accumulate(accumulator, func, predicate, childNode);
        }

        return accumulator;
    }

    private IEnumerator<TreeNode<T>> GetBfsEnumerator()
    {
        Queue<TreeNode<T>> nodesQueue = new Queue<TreeNode<T>>();

        TreeNode<T> currentNode = this;
        nodesQueue.Enqueue(currentNode);

        do
        {
            TreeNode<T> returnNode = nodesQueue.Dequeue();

            foreach (var childNode in returnNode.Nodes)
            {
                nodesQueue.Enqueue(childNode);
            }

            yield return returnNode;
        }
        while (nodesQueue.Count > 0);
    }

    private IEnumerator<TreeNode<T>> GetDfsEnumerator()
    {
        Stack<TreeNode<T>> nodesStack = new Stack<TreeNode<T>>();

        TreeNode<T> currentNode = this;
        nodesStack.Push(currentNode);

        do
        {
            TreeNode<T> returnNode = nodesStack.Pop();

            foreach (var childNode in returnNode.Nodes)
            {
                nodesStack.Push(childNode);
            }

            yield return returnNode;
        }
        while (nodesStack.Count > 0);
    }
}
