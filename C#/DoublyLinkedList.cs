// using System;
// using System.Collections.Generic;
// class Program {
//   public static void Main (string[] args) {
    
//     // LinkedList linkedList = new LinkedList(10);
//     // linkedList.append(4);
//     // linkedList.append(10);
//     // linkedList.append(20);
//     // linkedList.append(45);
//     // linkedList.printAllValues();
//   }

//   public class Node {
//     public int valuee {get; set;}
//     public Node next {get; set;}
//     public Node prev {get; set;}
//     public Node(){}
    
//     public Node(int value, Node next, Node prev){
//       this.valuee = value;
//       this.next = next;
//       this.prev = prev;
//     } 
//   }

//   public class DoublyLinkedList {
//      public Node head;
//      public Node tail;
//      public Node prev;
//      public int Length;
//      public DoublyLinkedList(){}
//      public DoublyLinkedList(int value){
//        head = new Node() {valuee = value};
//        tail = head;
//        Length = 1;
//      }

//     public DoublyLinkedList append(int value){
//       Node node = new Node (){ valuee = value, };
//       node.prev = tail;
//       tail.next = node;
//       tail = node;
//       Length++;
//       return this;
//     }

//     public DoublyLinkedList prepend(int value){
//       Node newNode = new Node() {valuee=value};
//       newNode.next = head;
//       head.prev = newNode;
//       head = newNode;
//       Length++;
//       return this;
//     }

//     public DoublyLinkedList insert(int index, int value){
//       if(index >= Length){
//         return this.append(value);
//       }
//       Node newNode = new Node(){valuee = value};
//       Node leader = traverseToindex(index - 1);
//       Node follower = leader.next;  
//       leader.next = newNode;
//       newNode.prev = leader;
//       newNode.next = follower;
//       follower.prev = newNode;
//       Length++;
//       return this;
      
//     }

//     public DoublyLinkedList delete(int index){
        
//         Node leader = traverseToindex(index - 1);
//         Node nodeNotWanted = leader.next;
//         leader.next = nodeNotWanted.next;
//         Length--;
//       return this;
//     }

//     public Node traverseToindex(int index){
//       //TODO: Defensive test
//       int counter = 0;
//       Node currentNode = this.head;
//       while(counter != index){      
//         currentNode = currentNode.next;
//         counter++;
//       }
//       return currentNode;
//     }

//     public string printAllValues(){
//       string output = string.Empty;
//       Node currentNode = this.head;
//       while(currentNode.next != null){
//         Console.WriteLine(currentNode.valuee);      
//         currentNode = currentNode.next;
    
//       }
//       return output;
//     }
    
//   }
  

    
   
  
// }

