# Challenge Title
## Linked List Insertion
+ I created a simple singly Linked list and it's contain some features adding node to the end, insert before or after specific node and delete specific node

## Whiteboard Process
![WhiteBoard](./LinkedList2.jpg)

## Approach & Efficiency
+ 1.First create the append method that takes a value create new Node within it and give it the value and create a current node that points to the head  make a while loop stops when the current.next equals NULL and move the current to current.next after the while make the current.next points to the new node and the new node points to NULL.
+ 2.Create the InsertBefore method with 2 values make newnode with the value, current = head, node B, and a bool value to check if the value found or not do a while loop and first check if the value you want to insert before is the head if not do else and within the conditions change the value of found to true  and after the conditions move current to the next node then check if found still false throw exception not found.
+ 3.Create insertAfter method with 2 values then make the same initialization as the Insertbefore Method  then while loop  that stops if current is null do if statment to check if the value = current.value and change the found to true if found then current=current.next and check the found as in the insertBefore method.
+ 4.Create the delete method with the same initialization in the previous methods check the current and for the logic of deleting make 2 conditions first to check the head and if it's true make the head points to the next node and change the found to true else make N =current.next then N =N.next node to save the node after the one we want to delete then current .next =N and change the found then complete as the previous methods.

## Solution
## The code 
![Code1](./Code1LL2.png)
# 
![Code2](./code2LL2.png)

## 
[Link to the code](..../LinkedList/Program.cs)

## Testing
![Testing](./Testing1.png)
#
![Testing](./Testing2.png)
#
![Testing](./testing3.png)
#
![Testing](./testing4.png)
#
[Link to the testing](../testLinkedList/UnitTest1.cs)

