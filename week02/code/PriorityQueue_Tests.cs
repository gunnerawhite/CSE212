using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adding elements with different priorities and removing them in order of priority
    // Expected Result: Elements are removed in the order of their priority (higher priority first)
    // Defect(s) Found: Ensure correct ordering of elements
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low Priority Task", 1);
        priorityQueue.Enqueue("Medium Priority Task", 5);
        priorityQueue.Enqueue("High Priority Task", 10);
        
        var highestPriorityTask = priorityQueue.Dequeue();
        Assert.AreEqual("High Priority Task", highestPriorityTask, "Expected to dequeue the highest priority task first.");

        var mediumPriorityTask = priorityQueue.Dequeue();
        Assert.AreEqual("Medium Priority Task", mediumPriorityTask, "Expected to dequeue the medium priority task next.");

        var lowestPriorityTask = priorityQueue.Dequeue();
        Assert.AreEqual("Low Priority Task", lowestPriorityTask, "Expected to dequeue the lowest priority task last.");
    }

    [TestMethod]
    // Scenario: Attempting to dequeue from an empty priority queue
    // Expected Result: An exception is thrown indicating the queue is empty
    // Defect(s) Found: Ensure proper exception handling for empty queue
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "Expected an exception when dequeuing from an empty queue.");
    }

}