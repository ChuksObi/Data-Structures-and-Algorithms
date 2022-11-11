// using System;
// using System.Collections.Generic;
// class Program {
//   public static void Main (string[] args) {
//      HashTable hashTable = new HashTable(50);
//      hashTable.set("chuks", 4);
//      hashTable.set("aoples", 12);
//      hashTable.keys();
//       hashTable.get("chuks");
//   }

//   public class Node {
//     public string key {get; set;}
//     public int value {get; set;}
//     public Node(){}
    
//     public Node(string key, int value){
//       this.key = key;
//       this.value = value;
//     } 
//   }

//   public class HashTable{
//     private int length; 
//     Node [] data;
    
//     public HashTable(int size){
//       this.length = size;
//       this.data = new Node [size];
//     }

//     private int hash(string key){
//       int hash = 0;
//       for (int i = 0; i < key.Length; i++){
//         hash = (hash + (int)key[i] * i) % this.length;
//         //https://stackoverflow.com/questions/3414900/how-to-get-a-char-from-an-ascii-character-code-in-c-sharp
//       }
//       return hash;
//     }

//     // public void printAllFromNode(Node[] array){ 
//     //   foreach(var x in array){
//     //   Console.WriteLine(x);
//     //     if(x != null){
//     //       Console.WriteLine(x.key + " _ "+ x.value);
//     //     }
//     //   }  
//     // }

//     public string[] keys(){
//       List<string> _keys = new List<string>();
//       int count = 0;
//       for(int i = 0; i < data.Length; i++){
//         if(data[i] != null){
//           _keys.Add(data[i].key);
//           count++;
//         }
//       }
//       return _keys.ToArray();
//     }

//     public Node get(string key){
//       int address = hash(key);
//       Node currentNode = data[address];
      
//       if(currentNode == null)
//         return new Node();
      
//       if(currentNode.key.Equals(address))
//         return currentNode;
        
//       return new Node();
//     }

//     public Node set(string key, int value){
//       int address = hash(key);
//         if(data[address] != null){
//           data[address] = null;   
//         }
//         data[address] = new Node(key, value);
//          // printAllFromNode(data);
//       return data[address];
//     }
    
   
//   }
// }

