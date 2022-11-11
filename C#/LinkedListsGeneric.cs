// using System;
// using System.Collections.Generic;
// class Program {
//   public static void Main (string[] args) {
    
//     LinkedList linkedList = new LinkedList(10);
//     linkedList.append(4);
//     linkedList.append(10);
//     linkedList.append(20);
//     linkedList.append(45);
//     linkedList.printAllValues();
//   }

//   public class Node <T> {
//     public T valuee {get; set;}
//     public Node next {get; set;}
//     public Node(){}
    
//     public Node(int value, Node next){
//       this.valuee = value;
//       this.next = next;
//     } 
//   }

//   public class LinkedList {
//      public Node head;
//      public Node tail;
//      public int Length;
//      public LinkedList(){}
//      public LinkedList(int value){
//        head = new Node() {valuee = value};
//        tail = head;
//        Length = 1;
//      }

//     // public LinkedList append(int value){
//     //   Node node = new Node (){ valuee = value};
//     //   tail.next = node;
//     //   tail = node;
//     //   Length++;
//     //   return this;
//     // }

//     // public LinkedList prepend(int value){
//     //   Node newNode = new Node() {valuee=value};
//     //   newNode.next = head;
//     //   head = newNode;
//     //   Length++;
//     //   return this;
//     // }

//     // public LinkedList insert(int index, int value){
//     //   if(index >= Length){
//     //     return this.append(value);
//     //   }
//     //   Node newNode = new Node(){valuee = value};
//     //   Node leader = traverseToindex(index - 1);
//     //   Node holdingPointer = leader.next;      
//     //   leader.next = newNode;
//     //   newNode.next = holdingPointer;

//     //   return this;
      
//     // }

//     // public LinkedList delete(int index){
        
//     //     Node leader = traverseToindex(index - 1);
//     //     Node nodeNotWanted = leader.next;
//     //     leader.next = nodeNotWanted.next;
//     //     Length--;
//     //   return this;
//     // }

//     // public Node traverseToindex(int index){
//     //   //TODO: Defensive test
//     //   int counter = 0;
//     //   Node currentNode = this.head;
//     //   while(counter != index){      
//     //     currentNode = currentNode.next;
//     //     counter++;
//     //   }
//     //   return currentNode;
//     // }

//     // public string printAllValues(){
//     //   string output = string.Empty;
//     //   Node currentNode = this.head;
//     //   while(currentNode.next != null){
//     //     Console.WriteLine(currentNode.valuee);      
//     //     currentNode = currentNode.next;
    
//     //   }
//     //   return output;
//     // }
    
//   }
  

    
   
  
// }

