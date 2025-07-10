using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priorities and dequeue the highest.
    // Expected Result: The item with the highest priority is removed first
    // Defect(s) Found: Logic for finding the highest priority index had an off-by-one bug.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("B", result);
    }

    [TestMethod]
    // Scenario: Enqueue two items with the same highest priority
    // Expected Result: The first one inserted with that priority should be returned first
    // Defect(s) Found: Off-by-one bug skipped the Last item in the queue during search
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("X", 4);
        priorityQueue.Enqueue("Y", 5); //Highest put in first
        priorityQueue.Enqueue("Z", 5); //Also highest, put in second

        var result1 = priorityQueue.Dequeue();
        var result2 = priorityQueue.Dequeue();

        Assert.AreEqual("Y", result1); //Y should come out first
        Assert.AreEqual("Z", result2); //Z coming out second
    }

    // Add more test cases as needed below.

    [TestMethod]
// Scenario: Dequeue from an empty priority queue.
// Expected Result: Should throw InvalidOperationException with an appropriate message.
// Defect(s) Found: Exception not thrown or wrong exception thrown if queue is empty.
public void TestPriorityQueue_EmptyQueue_ThrowsException()
{
    var priorityQueue = new PriorityQueue();

    try
    {
        priorityQueue.Dequeue();
        Assert.Fail("Expected InvalidOperationException was not thrown.");
    }
    catch (InvalidOperationException ex)
    {
        Assert.AreEqual("The queue is empty.", ex.Message);
    }
}
}