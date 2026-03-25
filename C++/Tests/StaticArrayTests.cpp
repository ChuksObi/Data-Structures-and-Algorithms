#include <gtest/gtest.h>
#include "../Array/StaticArray.h"

class StaticArrayFixture : public ::testing::Test {
protected:
    DSA::StaticArray<int, 4> arr;
};

TEST_F(StaticArrayFixture, StartsEmpty) {
    EXPECT_EQ(arr.size(), 0u);
    EXPECT_EQ(arr.capacity(), 4u);
}

TEST_F(StaticArrayFixture, PushIncreasesSizeAndStoresValue) {
    arr.push(42);
    EXPECT_EQ(arr.size(), 1u);
    EXPECT_EQ(arr.get(0), 42);
}

TEST_F(StaticArrayFixture, PopOnEmptyThrows) {
    EXPECT_THROW(arr.pop(), std::out_of_range);
}