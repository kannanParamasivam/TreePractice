using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Node
    {
	private int value = -1;

	public int Value { get=>this.value; set { this.value = value; }}

	private Node left;
	
	public Node Left { get=>this.left; set { this.left = value; }}

	private Node right;

	public Node Right { get=>this.right; set { this.right = value; }}

	public bool Add(int value)
	{
		if(this.value < 0)
		{
			this.value = value;
			return true;
		}
		
		if(value <= this.value)
		{
			this.left = this.left?? new Node();
	                return this.left.Add(value:value);
		}
		else
		{
			this.right = this.right?? new Node();
			return this.right.Add(value:value);
		}
	}
	
	public bool Contains(int value)
	{
		if(this.value == value)
			return true;

		if(value <= this.value && this.left != null)
			return this.left.Contains(value:value);

		if(value > this.value && this.right != null)
			return this.right.Contains(value:value);

		return false;
			
	}

	public void TraverseInOrder(StringBuilder sb)
	{
		if(this.left != null)
			this.left.TraverseInOrder(sb:sb);

		sb.Append(String.Concat(" ", Convert.ToString(this.value)));
		
		if(this.right != null)
			this.right.TraverseInOrder(sb:sb);
	}
    }
}
