![cf](http://i.imgur.com/7v5ASc8.png) Class 26: DSA Challenges
=====================================

## Instructions

- Select and complete enough code challenges to accumulate 10 points. (or more!)
- Every challenge is worth a specified amount of points related to its complexity.
- Follow the traditional whiteboard proccess and submission instructions in order to plan and prepare to code each challenge.
    - If you don't have a whiteboard at hand, you can submit a picture of a drawing in a piece of paper.
    - Include unit tests with your code submissions. (At least 2 tests per challenge)
- The problem statements are in cases vague in order for you to clarify your understanding of the problem with your instructional team.

## Problem Set

### Calculate the height of a binary tree (4 Points)
Implement a method with the following signature `int CalculateBinaryTreeHeight(Node root)` that calculates the height
of a binary tree.

_Hint: The height of a binary tree is the height of its root_

#### Stretch Goal (1 Additional Point)
Once you calculate the height of a tree, write a similar function to calculate the number of levels for a tree.

### Check if a binary tree is Balanced (3 Points)
Implement a method with the following signature `bool IsBinaryTreeBalanced(Node root)` that determines if a binary tree is balanced.

_Reminder: We define a balanced binary tree as a binary tree in which the depth of the two subtrees of every node never differ by more than 1._

### Determine if two values in a binary tree have an ancestry relationship. (3 Points)
Implement a method with the following signature `bool IsAncestor(int A, int B, Node root)` that returs true if the value A is an ancestor of the value B in the provided binary tree; the function will return false otherwise.

- You can assume that the binary tree will have unique values.

### Determine if all the characters in a string are unique (2 Points)
Implement a method with the following signature `bool AreCharactersUnique(string input)` that returns true if all the characters in the string are unique.

### Remove duplicated values from a linked list (3 Points)
Implement a method with the following signature `void RemoveDuplicatens(LinkedLst list)` that removes all duplicated values from the linked list. The modifications must happen in place (i.e. avoid making a copy of the linked list)

### Remove duplicated values from a string (1 Point)
Implement a method with the following signature `string RemoveDuplicatens(string input)` that removes all characters values from the string.

### Shuffle a linked list (3 Points)
Implement a method with the following signature `void ShuffleLinkedList(LinkedLst list)` that re-arranges the nodes of the linked list in a random order. The modifications must happen in-place (i.e. avoid making a copy of the linked list)

### Implement a Stack and a Queue using an Array (2 Points)
Create a Stack and a Queue class that use an array as internal storage. The stack and queue class need to be able to resize its internal storage when required.

### Generate all combinations of balanced parentheses (6 Points)
Implement a method `string[] GenerateBalancedParethesesCombinations(int n)` that generates all possible pairs of balanced (i.e. every open parenthesis has a matching closed parenthesis)

##### Examples
```
n=1
"{}"]

n=2
["{}{}","{{}}"]
```

### Create an Acronym Generator (1 Point)
Write a function that will take in a string and return the acronym of that string. Words that cannot go in the acronym: `["a", "for", "an", "and", "of", "or", "the", "to", "with"]`

##### Examples
```
acronym('The Federal Bureau of Investigation') // Returns 'FBI'
acronym('') //Returns null
```

### String Compression (1 Point)
Implement a method to perform basic string compression using counts of repeated characters. For example, aabcccccaaa would become a2b1c5a3. If compressed string isn't smaller than the original, return the original.








