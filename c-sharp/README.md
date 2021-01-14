# Data Structures and Algorithms
## Language: `C#`

# Reverse an Array
Reverse array code challenge.

## Challenge
Write a method to reverse an array without using any built in libraries or methods.

## Approach & Efficiency
I'm using a while loop to iterate over the array, swapping the first and last indexes moving inwards.  Iteration stops when it reaches the center of the array.

## Solution
![array reverse whiteboard](./assets/array-reverse.jpg)



# Insert Shift Array
*whiteboard done with Alan Hung and David Dicken*
insert a value into the middle index of an array

## Challenge
Take in an array and a value.  Insert that value into the middle index of the array and return the new array without using built in methods.

## Approach & Efficiency
I created a second array one index longer than the argument.  Found the center based on length, then dropped the input value in the middle index.  Then I iterated over the new array and using conditionals populating the first half and second half based on the mid point.

## Solution
![array insert shift](./assets/insertShiftArray.png)

# Challenge 3: Binary Search
*whiteboard done with Alan Hung and David Dicken*
Find a value in a sorted array.

## Challenge Description
Without using any built in C# methods take in an ordered array and a value.  Return the index of the value or -1 if the value doesn't exist.

## Approach & Efficiency
We tracked the start, end and mid point of the array with variables.  Used a while loop to start at the middle of the array.  If the value matched the mid point return the value. Or move either up or down to a new mid point in the array and do it again.

## Solution
![Binary Search Whiteboard](./assets/binary_search.png)

<br><br>
[Return to Main Page](../README.md)
