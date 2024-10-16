using BinaryTree;
namespace binaryTreeTests;

public class BinaryTreeTests
{
    [Fact]
    public void Insert_shoudInsertValuesCorrecty()
    {
        //Arrange
        var tree = new BinaryTree.BinaryTree();
        int[] values = { 15, 10, 20, 8, 12 };

        //Act

        foreach ( var value in values ) 
        {
            tree.Insert( value );
        }

        //Assert
        Assert.True(tree.Search(10));
        Assert.True(tree.Search(12));
        Assert.False(tree.Search(5));
    }

    [Fact]
    public void Remove_ShouldRemoveLeafNode()
    {
        // Arrange
        var tree = new BinaryTree.BinaryTree();
        int[] values = { 15, 10, 20, 8, 12 };
        foreach (var value in values)
        {
            tree.Insert(value);
        }

        // Act
        tree.Remove(8); // Remove leaf node

        // Assert
        Assert.False(tree.Search(8));
        Assert.True(tree.Search(10));
    }
    [Fact]
    public void Remove_ShouldRemoveNodeWithOneChild()
    {
        // Arrange
        var tree = new BinaryTree.BinaryTree();
        int[] values = { 15, 10, 20, 8, 12 };
        foreach (var value in values)
        {
            tree.Insert(value);
        }

        // Act
        tree.Remove(10); // Remove node with one child (12)

        // Assert
        Assert.False(tree.Search(10));
        Assert.True(tree.Search(12));
        Assert.True(tree.Search(8));
    }

    [Fact]
    public void Remove_ShouldRemoveNodeWithTwoChildren()
    {
        // Arrange
        var tree = new BinaryTree.BinaryTree();
        int[] values = { 15, 10, 20, 8, 12, 17, 25 };
        foreach (var value in values)
        {
            tree.Insert(value);
        }

        // Act
        tree.Remove(15); // Remove node with two children (10, 20)

        // Assert
        Assert.False(tree.Search(15));
        Assert.True(tree.Search(10));
        Assert.True(tree.Search(20));
    }
}