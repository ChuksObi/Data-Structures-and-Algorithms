#pragma once
#include <cstddef>
#include <stdexcept>

//Append by value
//Prepend by value
//Insert by index & value
//Delete by index

namespace DSA {

template<typename T>
struct Node {

    Node(T currentItem): current_(currentItem), 
    next_(nullptr) {}

    T current_;
    Node<T>* next_;

};

template<typename T>
class SingleLinkedList {

    public:
        void append(T& newItem);
        void prepend(T& newItem);
        void insert(std::size_t index, T& newItem);
        void deleteIndex(std::size_t index);

    private:
        Node<T>* head_{nullptr};
        Node<T>* tail_{nullptr};
        std::size_t size_{0};
};

template<typename T>
void SingleLinkedList<T>::append(T& newItem){
    Node<T>* temp = new Node<T>(newItem);
    if(size_ == 0){
        head_ = temp;
        tail_ = temp;
        size_++;
        return;
    }

    tail_->next_ = temp;
    tail_ = temp;
    size_++;
}

template<typename T>
void SingleLinkedList<T>::prepend(T& newItem){
    Node<T>* newNode = new Node<T>(newItem);
    if(size_ == 0){
        head_ = newNode;
        tail_ = newNode;
        size_++;
        return;
    }
    
    newNode->next_ = head_;
    head_ = newNode;
    size_++;
    return;
}

template<typename T>
void SingleLinkedList<T>::insert(std::size_t index, T& newItem){
    if (index > size_){
        throw std::out_of_range("Index does not exist");
    }
    if(size_ == 0){
        prepend(newItem);
        return;
    }
    if(size_ == index){
        append(newItem);
        return;
    }
    //change loop behaviour to loop from either ends depending how close it is, only for double since we can only move forward
    //create the newNode
    Node<T>* newNode = new Node<T>(newItem);
    Node<T>* current = head_;

    for(std::size_t i = 0; i < index-1; i++){
        current = current->next_;
    }
    newNode->next_ = current->next_;
    current->next_ = newNode;
    size_++;
}

template<typename T>
void SingleLinkedList<T>::deleteIndex(std::size_t index){
    if (index > size_ || index == 0){
        throw std::out_of_range("Index does not exist");
    }

    Node<T>* current = head_;

    for(std::size_t i = 0; i < index-1; i++){
        current = current->next_;
    }
    Node<T>* temp = current->next_->next_;
    delete current->next_;
    current->next_ = temp;
    size_--;
}



}