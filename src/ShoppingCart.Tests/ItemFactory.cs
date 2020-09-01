using System;
using FluentAssertions;
using ShoppingCart.Items;
using Xunit;

namespace ShoppingCart.Tests
{
    public class ItemFactory
    {

        [Fact]
        public void FactoryTest_ReturnItemA()
        {
            //Arrange

            var item = Items.ItemFactory.GetItem("A");
            //Act


            //Assert
            item.Should().BeOfType<ItemA>();
        }



        [Fact]
        public void FactoryTest_WithUnusedCode_ShouldThrowException()
        {
            //Arrange

            Action act = () => Items.ItemFactory.GetItem("T");
            //Act

            //Assert

            act.Should().Throw<InvalidOperationException>();




        }

    }
}