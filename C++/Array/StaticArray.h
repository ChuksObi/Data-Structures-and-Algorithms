#pragma once
#include <cstddef>
#include <stdexcept>
// Implement an Static Array Class with common methods below
// [] index access
// .get
// .pop
// .push
// .size
// .capacity
//TODO: rework not to throw exception


//explicit | const | | 
namespace DSA {
    template<typename T, std::size_t N>
    class StaticArray {
        public:
            StaticArray() = default;
            // Complier will generate uneccessary to declare
            // StaticArray(const StaticArray&);

            // StaticArray(StaticArray&&);

            // StaticArray& operator=(StaticArray&&);
            // StaticArray& operator=(const StaticArray&);

            const T& get(std::size_t index) const;
            T& get(std::size_t index);

            T pop();

            void push(const T& newItem);

            [[nodiscard]] std::size_t size() const noexcept {
                return size_;
            }

            [[nodiscard]] std::size_t capacity() const noexcept { 
                return N;
            }

            T& operator[](std::size_t index);
            const T& operator[](std::size_t index) const;

            ~StaticArray() = default; 
        private:
            std::size_t size_ {0};
            T data_[N]{};

    };

    template<typename T, std::size_t N>
    const T& StaticArray<T, N>::get(std::size_t index) const {
        if (index >= size_) {
            throw std::out_of_range("Index is out of range");
        }
        return data_[index];
    }

    template<typename T, std::size_t N>
    T& StaticArray<T, N>::get(std::size_t index) {
        if (index >= size_) {
            throw std::out_of_range("Index is out of range");
        }
        return data_[index];
    }
    
    template<typename T, std::size_t N>
    T StaticArray<T, N>::pop(){
        if (size_ == 0) {
            throw std::out_of_range("Array is empty");
        }
        T temp = data_[size_-1];
        size_--;
        // data_[size_] = T(); //TODO:avoiding extra write, 
        return temp;
    }

    template<typename T, std::size_t N>
    void StaticArray<T,N>::push(const T& newItem){
        if (size_ >= N) {
            throw std::out_of_range("Array is full");
        }
        data_[size_] = newItem;
        size_++;
    }

    template<typename T, std::size_t N>
    T& StaticArray<T, N>::operator[](std::size_t index){
        return data_[index];
    }

    template<typename T, std::size_t N>
    const T& StaticArray<T, N>::operator[](std::size_t index) const {
        return data_[index];
    }

}