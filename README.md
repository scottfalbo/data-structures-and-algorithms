# Data Structures and Algorithms
## Table of Contents


## C# .NET

### Data Structures

+ [Linked Lists](#linked-lists)
  + [`Insert()`](#insert)
  + [`Includes()`](#includes)
  + [`ToString()`](#tostring)
  + [`ToStringRecursive()`](#tostringrecursive)
  + [`Append()`](#append)
  + [`InsertBefore()`](#insertbefore)
  + [`InsertAfter()`](#insertafter)
  + [`KthFromEnd()`](#kthfromend)


### Challenges
+ [Reverse Array](#reverse-an-array)
+ [Insert Shift Array](#insert-shift-array)
+ [Binary Search](#binary-search)
+ [Zip List](#zip-list)

<hr>

# C# .NET

<hr>

## Data Structures

## **Linked Lists**
[code](https://github.com/scottfalbo/data-structures-and-algorithms/blob/master/dotnet/DataStructures/Implementations/LinkedList.cs)<br>
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
### [code]()

<hr>

[return to top of page](#data-structures-and-algorithms)
