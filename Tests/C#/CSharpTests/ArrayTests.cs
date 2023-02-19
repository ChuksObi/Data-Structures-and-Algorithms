using main.Array;
using Xunit;

namespace CSharpTests
{
    public class ArrayTests
    {


        [Theory]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        public void MyArray_Push_ReturnsTheItemEntered(int value)
        {
            //Act
            MyArray<int> myArray = new MyArray<int>(10);
            //int Lenght = 4;

            //Action
            var newItem = myArray.Push(value);

            //Assert
            Assert.Equal(value, newItem);
            
        }

        [Fact]
        public void MyArray_Pop_ReturnsTheLastItemRemoved()
        {
            //Act
            MyArray<int> myArray = new MyArray<int>(10);
         
            int value = 5;
            myArray.Push(value);
            var lastItem = myArray.Data[myArray.Length - 1];

            //Action
            var removedItem = myArray.Pop();

            //Assert
            //Assert.Equal(arrayLength - 1, myArray.Length);
            Assert.Equal(lastItem, removedItem);
        }
        [Fact]
        public void MyArray_Shift_ReturnstheFirstItemRemoved()
        {
            //Act
            MyArray<int> myArray = new MyArray<int>(10);
            int value = 5;
            myArray.Push(value);

            var firstItem = myArray.Data[0];

            //Action
            var removedItem = myArray.Shift();

            //Assert
            //Assert.Equal(myArray.Length, myArray.Length);
            Assert.Equal(firstItem, removedItem);
        }
        [Theory]
        [InlineData(0)]
        public void MyArray_Get_ReturnstheItemByIndex(int index)
        {
            //Act
            MyArray<int> myArray = new MyArray<int>(10);
            int value = 5;
            myArray.Push(value);

            //Action
            int item = myArray.Get(index);

            //Assert
            Assert.Equal(myArray.Data[index], item);
        }

    }
}