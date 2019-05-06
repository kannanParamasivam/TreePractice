using System;
using TreePractice;
using Xunit;

namespace TreePracticeTest
{
    public class TreeTest
    {
        [Fact]
        public void Tree_When_RootIsNull_Should_ThrowException()
        {
            ArgumentNullException ane = Assert.Throws<ArgumentNullException>(() => new Tree(null));
            Assert.Equal("Value cannot be null.\r\nParameter name: root", ane.Message);
        }

        [Fact]
        public void Tree_When_ValidRootWithChildren_Should_ContainIt()
        {
            Node root = new Node("1", new Node("2"), new Node("3"));
            Tree tree = new Tree(root);

            Assert.True(tree.Root != null && tree.Root.Data.Equals("1"));
            Assert.True(tree.Root.Ln != null && tree.Root.Ln.Data.Equals("2"));
            Assert.True(tree.Root.Rn != null && tree.Root.Rn.Data.Equals("3"));
        }

        [Fact]
        public void Height_When_ValidTree_Should_ReturnHeightOfTheTree()
        {
            Node root = new Node("1", new Node("2", new Node("4"), new Node("5", new Node("8"), new Node("9"))), new Node("3", null, new Node("7")));
            Tree tree = new Tree(root);
            Assert.Equal(4, tree.Height);
        }
    }
}
