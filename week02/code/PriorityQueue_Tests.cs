using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue two items, one with higher priority
    // Expected Result: Dequeue should return item with highest priority
    // Defect(s) Found: None
    public void TestPriorityQueue_HigherPriorityComesOutFirst()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Low", 1);
        queue.Enqueue("High", 10);

        var result = queue.Dequeue();
        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Enqueue two items with the same priority
    // Expected Result: Dequeue should return the item enqueued first (FIFO)
    // Defect(s) Found: None
    public void TestPriorityQueue_FifoAmongSamePriority()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("First", 5);
        queue.Enqueue("Second", 5);

        var result = queue.Dequeue();
        Assert.AreEqual("First", result);
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: Should throw InvalidOperationException
    // Defect(s) Found: None
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPriorityQueue_EmptyQueueThrows()
    {
        var queue = new PriorityQueue();
        queue.Dequeue(); // Should throw
    }

    [TestMethod]
    // Scenario: Multiple Enqueue/Dequeue with varying priorities
    // Expected Result: Items returned in order of highest priority, then FIFO
    // Defect(s) Found: None
    public void TestPriorityQueue_MultipleItemsCorrectOrder()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Low", 1);
        queue.Enqueue("Medium1", 5);
        queue.Enqueue("High", 10);
        queue.Enqueue("Medium2", 5);

        Assert.AreEqual("High", queue.Dequeue());     // Highest priority
        Assert.AreEqual("Medium1", queue.Dequeue());  // Same priority, FIFO
        Assert.AreEqual("Medium2", queue.Dequeue());
        Assert.AreEqual("Low", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: All items have same priority
    // Expected Result: Items returned in FIFO order
    // Defect(s) Found: None
    public void TestPriorityQueue_AllSamePriorityFIFO()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("One", 3);
        queue.Enqueue("Two", 3);
        queue.Enqueue("Three", 3);

        Assert.AreEqual("One", queue.Dequeue());
        Assert.AreEqual("Two", queue.Dequeue());
        Assert.AreEqual("Three", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Negative priorities included
    // Expected Result: Highest number (even if negative) is considered highest priority
    // Defect(s) Found: None
    public void TestPriorityQueue_NegativePrioritiesHandled()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("MinusTwo", -2);
        queue.Enqueue("MinusOne", -1);
        queue.Enqueue("Zero", 0);

        Assert.AreEqual("Zero", queue.Dequeue());
        Assert.AreEqual("MinusOne", queue.Dequeue());
        Assert.AreEqual("MinusTwo", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Only one item
    // Expected Result: Should return that item
    // Defect(s) Found: None
    public void TestPriorityQueue_SingleItem()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Solo", 99);
        Assert.AreEqual("Solo", queue.Dequeue());
    }
}