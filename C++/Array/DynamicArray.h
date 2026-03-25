#pragma once
#include <cstddef>
#include <stdexcept>
// Implement an Dynamic Array Class with common methods below aka std::vector
// [] index access
// .get
// .pop
// .push
// .size
// .reserve
// .capacity
//TODO: rework not to throw exception

//explicit | const | | 
namespace DSA {
template<typename T>
class DynamicArray {
    public:    
        DynamicArray() : size_(0),
         capacity_(1024),
         data_(new T[1024]) {}

        DynamicArray(const DynamicArray& other){
            size_ = other.size_;
            capacity_ = other.capacity_;
            data_ = new T[capacity_];
            for(std::size_t i =0; i < size_; i++){
                data_[i] = other.data_[i];
            }
        }

        DynamicArray(DynamicArray&& other) noexcept{
            size_ = other.size_;
            capacity_ = other.capacity_;
            data_ = other.data_;
            other.size_ = 0;
            other.capacity_ = 0;
            other.data_ = nullptr;

        }
        DynamicArray& operator=(const DynamicArray& other){
            if(this == &other){
                return *this;
            }
            delete [] data_;
            size_ = other.size_;
            capacity_ = other.capacity_;
            data_ = new T[other.capacity_];
            for(std::size_t i =0; i < size_; i++){
                data_[i] = other.data_[i];
            }
            return *this;
        }
        DynamicArray& operator=(DynamicArray&& other) noexcept{
            if(this == &other){
                return *this;
            }
            size_ = other.size_;
            capacity_ = other.capacity_;
            T* temp = other.data_;
            other.data_ = nullptr;
            delete [] data_;
            data_ = temp;
            other.size_ = 0;
            other.capacity_ = 0;
            return *this;
        }



        T& get(std::size_t index);
        const T& get(std::size_t index) const;

        T pop();

        void push(const T& newItem);

        [[nodiscard]] std::size_t size() const{
            return size_;
        }

        [[nodiscard]] std::size_t capacity() const{
            return capacity_;
        }

        T& operator[](std::size_t index);
        const T& operator[](std::size_t index) const;

        void reserve(std::size_t capacity);

        ~DynamicArray() {
            delete[] data_;
        }
    
    private:
        T* data_;
        std::size_t size_;
        std::size_t capacity_;
};

template<typename T>
const T& DynamicArray<T>::get(std::size_t index) const {
    
    if(index >= size_){
        throw std::out_of_range("Index out of range");
    }
    return data_[index];
}

template<typename T>
T& DynamicArray<T>::get(std::size_t index) {
    if(index >= size_){
        throw std::out_of_range("Index out of range");
    }
    return data_[index];
}

template<typename T>
void DynamicArray<T>::push(const T& newItem){
    if(size_ == capacity_){
        reserve(capacity_ * 2);
    }
    data_[size_] = newItem;
    size_++;
}

template<typename T>
void DynamicArray<T>::reserve(std::size_t newCapacity){
    if(newCapacity <= capacity_){
        return;
    }

    T* newData = new T[newCapacity];
    for(std::size_t i = 0; i < size_; i++){
        newData[i] = data_[i];
    }
    delete [] data_;
    data_ = newData;
    capacity_ = newCapacity;
}

template<typename T>
T DynamicArray<T>::pop(){
    if(size_ == 0){
        throw std::out_of_range("No Items");
    }
    T& temp = data_[size_-1]; 
    size_--;
    return temp;
}

template<typename T>
T& DynamicArray<T>::operator[](std::size_t index){
    return data_[index];
}

template<typename T>
const T& DynamicArray<T>::operator[](std::size_t index) const{
    return data_[index];
}


}