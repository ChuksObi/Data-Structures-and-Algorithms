#include <gtest/gtest.h>

// White-box access for learning-focused tests.
#define private public
#include "../LinkedList/SingleLinkedLists.h"
#undef private

class SingleLinkedListFixture : public ::testing::Test {
protected:
    DSA::SingleLinkedList<int> list;
};

TEST_F(SingleLinkedListFixture, StartsEmpty) {
    EXPECT_EQ(list.size_, 0u);
    EXPECT_EQ(list.head_, nullptr);
    EXPECT_EQ(list.tail_, nullptr);
}

TEST_F(SingleLinkedListFixture, AppendFirstNodeSetsHeadAndTail) {
    int value = 10;
    list.append(value);

    ASSERT_NE(list.head_, nullptr);
    ASSERT_NE(list.tail_, nullptr);
    EXPECT_EQ(list.size_, 1u);
    EXPECT_EQ(list.head_->current_, 10);
    EXPECT_EQ(list.tail_->current_, 10);
    EXPECT_EQ(list.head_->next_, nullptr);
}

TEST_F(SingleLinkedListFixture, PrependOnNonEmptyMovesHead) {
    int ten = 10;
    int five = 5;
    list.append(ten);
    list.prepend(five);

    ASSERT_NE(list.head_, nullptr);
    ASSERT_NE(list.tail_, nullptr);
    EXPECT_EQ(list.size_, 2u);
    EXPECT_EQ(list.head_->current_, 5);
    EXPECT_EQ(list.head_->next_->current_, 10);
    EXPECT_EQ(list.tail_->current_, 10);
}

TEST_F(SingleLinkedListFixture, InsertOutOfRangeThrows) {
    int value = 1;
    EXPECT_THROW(list.insert(1, value), std::out_of_range);
}

TEST_F(SingleLinkedListFixture, InsertAtSizeAppends) {
    int one = 1;
    int two = 2;
    list.append(one);
    list.insert(1, two);

    EXPECT_EQ(list.size_, 2u);
    ASSERT_NE(list.head_, nullptr);
    ASSERT_NE(list.head_->next_, nullptr);
    EXPECT_EQ(list.head_->current_, 1);
    EXPECT_EQ(list.head_->next_->current_, 2);
    EXPECT_EQ(list.tail_->current_, 2);
}

TEST_F(SingleLinkedListFixture, DeleteIndexOutOfRangeThrows) {
    EXPECT_THROW(list.deleteIndex(0), std::out_of_range);
}
