# Data Structures and Algorithms
## Table of Contents


## C# .NET

### Data Structures
  + *links contain each structs methods*

+ ## [Linked Lists](#linked-lists)

+ ## [Stacks](#stacks)

+ ## [Queues](#queues)

+ ## [Binary Trees](#binary-trees)



### Challenges
+ [Reverse Array](#reverse-an-array)
+ [Insert Shift Array](#insert-shift-array)
+ [Binary Search](#binary-search)
+ [Zip List](#zip-list)
+ [Queue with Stacks](#queue-with-stacks)
+ [FIFO Animal Shelter](#fifo-animal-shelter)
+ [Multi Bracket Validation](#multi-bracket-validation)

<hr>

# C# .NET

<hr>

## Data Structures

# **Linked Lists**
A data structure of linked together `Node` objects.  The `LinkedList` object has one property of `Head`, which is a reference to the first node in the list.
### [code](https://github.com/scottfalbo/data-structures-and-algorithms/blob/master/dotnet/DataStructures/Implementations/LinkedList.cs)<br>
+ `LinkedList<T> newLinkedList = new LinkedList<T>();`
### `Insert()`
+ Insert a new node at the beginning of a linked list as the new `Head`.
  + `myList.Insert(value)`
  + + O(1) / O(1)

### `Includes()`
+ Search through a linked list to see if it contains a provided value.  <br>returns `true` : `false`
  + `bool isInList = myList.Include(value)`
  + O(N) / O(1)

### `ToString()`
+ Iterates through the list using a while loop,  and writes the values of all nodes of a linked list to the terminal.
  + `myList.ToString()`
  + O(N) / O(1)

### `ToStringRecursive()`
+ Iterates through the list recursively,  and writes the values of all nodes of a linked list to the terminal.
  + `myList.ToStringRecursive(myList.Head)`
  + O(N) / O(1)

### `Append()`
+ Append a `new Node` with a provided value to the end of a linked list.
  + `myList.Append(value)`
  + O(N) / O(1)
  + ## [whiteboard](./whiteboards/append.md)

### `InsertBefore()`
+ Given a `targetValue` and a `newValue`, insert the `newValue`, before the target value in a linked list.  If the list is empty or the `targetValue` does not exist `throw` and exception.
  + O(N) / O(1)
  + `myList.InsertBefore(targetValue, newValue)`
  + ## [whiteboard](./whiteboards/insert_before.md)

### `InsertAfter()`
+ Given a `targetValue` and a `newValue`, insert the `newValue`, after the target value in a linked list.  If the list is empty or the `targetValue` does not exist `throw` and exception.
  + O(N) / O(1)
  + `myList.InsertAfter(targetValue, newValue)`
  + ## [whiteboard](./whiteboards/insert-after.md)

### `KthFromEnd()`
+ Given a value for int `k`.  Find the node that is `k` nodes back from the end of the list.  Returns the value of the targetted node.  
+ Returns -1 in the following edge cases:
  + k is not a positive integer
  + k is >= the length of the list
  + The list is empty or only had one node
+ O(N) / O(1)
+ `int result = myList.KthFromEnd(int k)`
  + ## [whiteboard](./whiteboards/kth-from-end.md)

<hr>

# **Stacks**
A data structure that follows a *"first in, last out"* rule for adding and removing `Node` objects.  The `Stack` object has one property of `Top`, which is a reference to the top node object in the stack.  
### [code](https://github.com/scottfalbo/data-structures-and-algorithms/blob/master/dotnet/DataStructures/Implementations/Stack.cs)<br>
+ `Stack<T> newStack = new Stack<T>();`
### `Peek()`
+ Return the Value of the `Top` Node in the `Stack` object.
  + `var value = newStack.Peek()` => The value of the `Top` `Node` object in the `Stack` object.
    + `throw` NullReferenceException if the `Stack` object is empty
  + O(1) / O(1)

### `IsEmpty()`
+ Return true if the `Stack` object is empty.
  + `newStack.IsEmpty` => true : false
  + O(1) / O(1)

### `Push(T)`
+ Puts a new Node onto the `Stack` object.
   + `newStack.Push(T)` => no return, adds new `Node` object of the given type.
   + O(1) / O(1)

### `Pop()`
+ Return the Node Value and removes the node from the stack.
  + `var value = newStack.Pop()` => The value of the `Top` `Node` object in the `Stack` object.
    + `throw` NullReferenceException if the `Stack` object is empty
  + O(1) / O(1)

<hr>

# **Queues**
A data structure that follows a *"first in, first out"* rule for adding and removing 'Node' objects.  The `Queue` has two properties.  The `Front`, which is a reference to the front object in the queue.  And the `Rear`, which references the last object.
### [code](https://github.com/scottfalbo/data-structures-and-algorithms/blob/master/dotnet/DataStructures/Implementations/Queue.cs)<br>
+ `Queue<T> newQueue = new Queue<T>();`

### `Peek()`
+ Return the Value of the `Front` Node in the `Queue` object.
  + `var value = newQueue.Peek()` => The value of the `Front` `Node` object in the `Queue` object.
    + `throw` NullReferenceException if the `Queue` object is empty
  + O(1) / O(1)

### `IsEmpty()`
+ Return true if the `Queue` object is empty.
  + `newQueue.IsEmpty` => true : false
  + O(1) / O(1)

### `Enqueue(T)`
+ Puts a new Node onto the `Queue` object.
   + `newQueue.Enqueue(T)` => no return, adds new `Node` object of the given type.
   + O(1) / O(1)

### `Dequeue()`
+ Return the Node Value and removes the node from the Queue.
  + `var value = newQueue.Dequeue()` => The value of the `Front` `Node` object in the `Queue` object.
    + `throw` NullReferenceException if the `Queue` object is empty
  + O(1) / O(1)

<hr>

# **Binary Trees**
A Data Structure in which a `Root` node is linked to two children nodes, `Left`, and `Right`.  In a binary tree each node only has two children. This makes for efficient transversal as most time will be O(logN).

## `BinaryTree()`
+ ### `PreOrder()`
  + root - > left -> right
+ ### `InOrder()`
  + left -> root -> right
+ ### `PostOrder()`
  + left -> right -> root
## `BinarySearchTree`
*A sorted Binary Tree where values < Root goto the left, and values > root goto the right.*
+ ### `Add()`
  + Add a new `Node` object to the appropriate spot in the binary tree object.
+ ### `Contains()`
  + Transverse the `BinarySearchTree` object to see if a value exists within.

<hr>

## Challenges


## **Reverse an Array**
Reverse array code challenge.

### Challenge
Write a method to reverse an array without using any built in libraries or methods.

### Approach & Efficiency
I'm using a while loop to iterate over the array, swapping the first and last indexes moving inwards.  Iteration stops when it reaches the center of the array.

## [whiteboard](./whiteboards/array-reverse.md)<br>
### [code](https://github.com/scottfalbo/data-structures-and-algorithms/blob/master/c-sharp/CodeChallenges/ArrayReverse/Program.cs)

<hr>

## **Insert Shift Array**
insert a value into the middle index of an array

### Challenge
Take in an array and a value.  Insert that value into the middle index of the array and return the new array without using built in methods.

### Approach & Efficiency
I created a second array one index longer than the argument.  Found the center based on length, then dropped the input value in the middle index.  Then I iterated over the new array and using conditionals populating the first half and second half based on the mid point.

## [whiteboard](./whiteboards/insert-shift-array.md)<br>
### [code](https://github.com/scottfalbo/data-structures-and-algorithms/blob/master/c-sharp/CodeChallenges/ArrayShift/Program.cs)

<hr>

## **Binary Search**
Find a value in a sorted array.

### Challenge Description
Without using any built in C# methods take in an ordered array and a value.  Return the index of the value or -1 if the value doesn't exist.

### Approach & Efficiency
We tracked the start, end and mid point of the array with variables.  Used a while loop to start at the middle of the array.  If the value matched the mid point return the value. Or move either up or down to a new mid point in the array and do it again.

## [whiteboard](./whiteboards/binary-search.md)<br>
### [code](https://github.com/scottfalbo/data-structures-and-algorithms/blob/master/c-sharp/CodeChallenges/BinarySearch/Program.cs)

<hr>

## **Zip List**
Combine two lists together by every other item.

### Challenge Description
Create a method to take in two `LinkedLists` and combine them alternating every other value.  Return a reference to the `Head` of the new list.  Do not use any built in methods.

### Approach & Efficiency
Create a new `LinkedList`.  Iterate through the 2 provided lists at the same time until the are both null.  Use tracking variables to adjust the pointers of each node as we iterate.  When both reach null return the reference to the `Head` of the new list.
  + O(N) / O(1)

## [whiteboard](./whiteboards/ziplist.md)<br>
### [code](https://github.com/scottfalbo/data-structures-and-algorithms/blob/queue-with-stacks/dotnet/CodeChallenges/LinkedLists/LLZip.cs)

<hr>

## **Queue with Stacks**
Create Queue behavior with two stacks.

### Challenge Description
Make a class called PseudoQueue, which using two Stack objects to mimic the behavior of a Queue object.  Include two methods, one to enqueue, and one to dequeue.

### Approach & Efficiency
Used two stacks to slinky the nodes back and forth.  `Pop()` all of nodes in stack1 into stack2.  `Peek()` or `Pop()` the `Top` of stack2.  Then `Pop()` all of the nodes back into stack1.  If it's enqueue push the new value.

## [whiteboard](./whiteboards/queue-with-stacks.md)<br>
### [code](https://github.com/scottfalbo/data-structures-and-algorithms/blob/queue-with-stacks/dotnet/CodeChallenges/LinkedLists/QueueWithStacks.cs)

<hr>

## **FIFO Animal Shelter**
First in, first out principle Animal Shelter

### Challenge Description
Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.  Implement two methods, one to enqueue an animal object, and one to dequeue the first cat or dog based on input.

### Approach & Efficiency
Enqueue was the same logic as the regular `Queue.Enqueue` with logic to validate the input object.

Dequeue utilizes a second queue that we can move objects into one by one, checking for cats or dogs.  When we find the first instance of either it is stored in a variable and not put into temp queue.  Set a bool to stop searching and continue moving the queue. Then move all of the objects back to the first queue and return the saved object.
+ O(N) / O(1)

## [whiteboard](./whiteboards/fifo-animals.md)<br>
<!-- ### [code](https://github.com/scottfalbo/data-structures-and-algorithms/blob/master/dotnet/CodeChallenges/LinkedLists/FifoAnimalShelter.cs) -->

<hr>

## **Multi Bracket Validation**
Validates patterns in a string

### Challenge Description
Your function should take a string as its only argument, and should return a boolean representing whether or not the brackets in the string are balanced. There are 3 types of brackets.

### Approach and Efficiency
Iterate over the string one character at a time.  If it's an opening bracket, (, {, or [, it goes into a `Stack` object.  If it's a closing bracket the method uses a switch conditional to check the current character against the `Top` `Stack` object.  If it's not a match we return false.  If it is a match `Pop()` the `Top` object and keep going.  Throws exceptions for empty string and no brackets.
  + O(N) / O(1)

## [whiteboard](./whiteboards/multi-bracket.md)<br>
<!-- ### [code](https://github.com/scottfalbo/data-structures-and-algorithms/blob/master/dotnet/CodeChallenges/LinkedLists/MultiBracketValidation.cs) -->



[return to top of page](#data-structures-and-algorithms)
