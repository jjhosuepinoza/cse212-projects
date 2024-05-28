public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue three players "Bob" with priority 2, "Tim" with priority 4, and "Sue" with priority 1.
        // Then dequeue five times.
        // Expected Result: Dequeue should return "Tim" first because he has the highest priority (4), 
        // followed by "Bob" with priority 2, then "Sue" with priority 1. The next two dequeue operations should return null 
        // because the queue will be empty.
        Console.WriteLine("Test 1");

          var players = new PriorityQueue();
        players.Enqueue("Bob", 2);
        players.Enqueue("Tim", 4);
        players.Enqueue("Sue", 1);
        for (int i = 0; i < 5; i++) {
            Console.WriteLine(players.Dequeue());

        }
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Enqueue three players "Bob" with priority 2, "Tim" with priority 4, and "Sue" with priority 4.
        // Then dequeue three times.
        // Expected Result: Dequeue should return "Tim" first because he has the highest priority (4), 
        // followed by "Sue" who has the same priority (4), then "Bob" with priority 2. The order between "Tim" and "Sue" 
        // can vary due to same priority, but both should come before "Bob".
        
Console.WriteLine("Test 2");
        players.Enqueue("Bob", 2);
        players.Enqueue("Tim", 4);
        players.Enqueue("Sue", 4);
        for (int i = 0; i < 3; i++) {
            Console.WriteLine(players.Dequeue());
        }
        
        Console.WriteLine("Test 2");

        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}