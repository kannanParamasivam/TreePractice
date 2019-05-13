using BinarySearchTree;
using System.Text;
using Xunit;

namespace BinarySearchTreeTest
{
    public class TreeTest
    {
        [Fact]
        public void Add_When_RootIsNull_Should_CreateRoot()
        {
            Tree bst = new Tree();
            Assert.True(bst.Root != null && bst.Root.Value == -1);
            bst.Add(value: 1);
            Assert.True(bst.Root != null && bst.Root.Value == 1);

        }

        [Fact]
        public void Add_When_ValueIsGreaterThanRoot_Should_AddAsRightChild()
        {
            Tree bst = new Tree();
            bst.Add(1);
            bst.Add(2);
            Assert.True(bst.Root != null && bst.Root.Value == 1);
            Assert.True(bst.Root.Left == null && bst.Root.Right != null && bst.Root.Right.Value == 2);
        }

        [Fact]
        public void Add_When_ValueIsLessThanRoot_Should_AddAsLeftChild()
        {
            Tree bst = new Tree();
            bst.Add(3);
            bst.Add(1);
            Assert.True(bst.Root != null && bst.Root.Value == 3);
            Assert.True(bst.Root.Right == null);
            Assert.True(bst.Root.Left != null && bst.Root.Left.Value == 1);
        }

        [Fact]
        public void Contains_When_NoRoot_Should_ReturnFalse()
        {
            Tree bst = new Tree();
            Assert.False(bst.Contains(1));
        }

        [Fact]
        public void Contains_When_ValueIsAtRoot_Should_ReturnTrue()
        {
            Tree bst = new Tree();
            bst.Add(1);
            Assert.True(bst.Contains(value: 1));
        }

        [Fact]
        public void Contains_When_ValuePresentOnTree_Should_ReturnTrue()
        {
            Tree bst = new Tree();
            bst.Add(5);
            bst.Add(4);
            bst.Add(6);
            bst.Add(8);
            bst.Add(3);
            bst.Add(7);


        }

        [Fact]
        public void PrintInOrder_When_TreeIsEmpty_Should_ReturnEmptyString()
        {
            Tree bst = new Tree();
            Assert.Equal(string.Empty, bst.PrintInOrder());
        }

        [Fact]
        public void PrintInOrder_When_TreeHasNodes_Should_PrintValuesInOrder()
        {
            Tree bst = new Tree();
            bst.Add(5);
            bst.Add(4);
            bst.Add(6);
            bst.Add(8);
            bst.Add(3);
            bst.Add(7);
            Assert.Equal("3 4 5 6 7 8", bst.PrintInOrder());
        }
    }
}
