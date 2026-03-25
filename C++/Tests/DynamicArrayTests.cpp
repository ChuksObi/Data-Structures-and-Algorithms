#include <gtest/gtest.h>
#include "../Array/DynamicArray.h"

class DynamicArrayFixture : public ::testing::Test {
protected:
    DSA::DynamicArray<int> arr;
};

TEST_F(DynamicArrayFixture, StartsWithDefaultCapacityAndZeroSize) {
    EXPECT_EQ(arr.size(), 0u);
    EXPECT_EQ(arr.capacity(), 1024u);
}

TEST_F(DynamicArrayFixture, PushAndGetWork) {
    arr.push(10);
    arr.push(20);

    EXPECT_EQ(arr.size(), 2u);
    EXPECT_EQ(arr.get(0), 10);
    EXPECT_EQ(arr.get(1), 20);
}

TEST_F(DynamicArrayFixture, PopReturnsLastItem) {
    arr.push(10);
    arr.push(20);

    EXPECT_EQ(arr.pop(), 20);
    EXPECT_EQ(arr.size(), 1u);
    EXPECT_EQ(arr.get(0), 10);
}

TEST(DynamicArrayCopyTest, CopyConstructorCreatesDeepCopy) {
    DSA::DynamicArray<int> original;
    original.push(1);
    original.push(2);

    DSA::DynamicArray<int> copy(original);
    copy[0] = 99;

    EXPECT_EQ(original[0], 1);
    EXPECT_EQ(copy[0], 99);
    EXPECT_EQ(original.size(), 2u);
    EXPECT_EQ(copy.size(), 2u);
}

TEST(DynamicArrayMoveTest, MoveConstructorTransfersOwnership) {
    DSA::DynamicArray<int> original;
    original.push(7);
    original.push(8);

    DSA::DynamicArray<int> moved(std::move(original));

    EXPECT_EQ(moved.size(), 2u);
    EXPECT_EQ(moved[0], 7);
    EXPECT_EQ(moved[1], 8);
    EXPECT_EQ(original.size(), 0u);
    EXPECT_EQ(original.capacity(), 0u);
}

TEST(DynamicArrayAssignTest, CopyAssignmentCreatesDeepCopy) {
    DSA::DynamicArray<int> source;
    source.push(5);
    source.push(6);

    DSA::DynamicArray<int> target;
    target = source;
    target[1] = 42;

    EXPECT_EQ(source[1], 6);
    EXPECT_EQ(target[1], 42);
}

TEST(DynamicArrayAssignTest, MoveAssignmentTransfersOwnership) {
    DSA::DynamicArray<int> source;
    source.push(3);
    source.push(4);

    DSA::DynamicArray<int> target;
    target = std::move(source);

    EXPECT_EQ(target.size(), 2u);
    EXPECT_EQ(target[0], 3);
    EXPECT_EQ(target[1], 4);
    EXPECT_EQ(source.size(), 0u);
    EXPECT_EQ(source.capacity(), 0u);
}

TEST_F(DynamicArrayFixture, PopOnEmptyThrows) {
    EXPECT_THROW(arr.pop(), std::out_of_range);
}
