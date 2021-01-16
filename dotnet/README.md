# DOT .NET
## DATA STRUCTURES AND ALGORITHMS
[Back to Root Menu](./../README.md)

## Challege Class 05: Linked List Implementation

## Singly Linked List
Singly Linked Lists are a data structure that stores a value in a `node` which contains a pointer to the `next` node in the list.  `nodes` reference memory locations from the heap.

## Challenge
Write three methods for the `LinkedList` class.
  + `Insert` - Take an argument a add a new `node` of that value to `Head`.  Makes to new `Head` point to the previous head.
  + `Includes` - Iterate over a `LinkedList` object to see if a given value is present.  `Return true : false`;
  + `toString` - Iterate over and `LinkedList` object and write each value to the terminal.  Start at `Head` and end with `"NULL"`.
  

## Approach & Efficiency
+ `Insert` - make a new node, set the next node to current head value, and set the Head to the new node.
  + O(1) / O(1)
+ `Includes` - iterate over the list object with a while loop until next is null.  Use a conditional to check each nodes value against the param value.
  + O(N) / O(1)
+ `ToString` - Create a new node with value of head. Iterate while next isn't null.  Write each value and set the node to the next node.
  + O(N) / O(1)

## API
+ `Insert(int)` - Takes in an integer value.  Creates a new `Node` object with that value, and inserts into the front of a `LinkedList` object setting it to the `Head`
  + ### Usage: `myListObject.Insert(3);`
+ `Includes(int)` - Take in an integer value. Iterates over a `LinkedList` object and returns `true` if the value is present, else it returns `false`.
  + ### Usage: `bool isInList = myListObject.Insert(5);`
+ `ToString()` - Takes in no argument.  Simply iterates over the `LinkedList` object with a while loop and writes the values to the terminal.
  + ### Usage: `myListObject.ToString();`
+ `ToStringRecursive(Node)` - Takes in a `Node` object as an argument.  Based on that nodes `Head` recursively iterates over the `LinkedList` object and writes the values to the terminal.
  + ### Usage: `myListObject.ToStringRecursive(myListObject.Head);`


[Back to Root Menu](./../README.md)