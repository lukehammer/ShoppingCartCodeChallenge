using FluentAssertions;
using ShoppingCart.Items;
using Xunit;

namespace ShoppingCart.Tests
{
    public class ItemTests
    {
        public class ItemATests
        {
            [Fact]
            public void ItemA_IsAnItem()
            {
                //Arrange
                var itemA = new ItemA();

                //Act


                //Assert
                itemA.Should().BeAssignableTo<Item>();
            }

            [Theory]
            [InlineData(1, 2)]
            [InlineData(2, 4)]
            [InlineData(4, 7)]
            [InlineData(5, 9)]
            public void TheoryItemAsPrice(int quantity, decimal expectedTotalPrice)
            {
                //Arrange
                var itemA = new ItemA();

                //Act


                //Assert
                var total = itemA.GetPriceForQuantity(quantity);
                total.Should().Be(expectedTotalPrice);
            }
        }


        public class ItemBTests
        {
            [Fact]
            public void ItemB_IsAnItem()
            {
                //Arrange
                var ItemB = new ItemB();

                //Act


                //Assert
                ItemB.Should().BeAssignableTo<Item>();
            }

            [Theory]
            [InlineData(1, 12)]
            [InlineData(2, 24)]
            public void TheoryItemBsPrice(int quantity, decimal expectedTotalPrice)
            {
                //Arrange
                var ItemB = new ItemB();
                //Act

                //Assert
                var total = ItemB.GetPriceForQuantity(quantity);
                total.Should().Be(expectedTotalPrice);
            }
        }


        public class ItemCTests
        {
            [Fact]
            public void itemC_IsAnItem()
            {
                //Arrange
                var itemC = new ItemC();

                //Act


                //Assert
                itemC.Should().BeAssignableTo<Item>();
            }

            [Theory]
            [InlineData(1, 1.25)]
            [InlineData(6, 6)]
            [InlineData(7, 7.25)]

            public void TheoryItemCsPrice(int quantity, decimal expectedTotalPrice)
            {
                //Arrange
                var itemC = new ItemC();
                //Act

                //Assert
                var total = itemC.GetPriceForQuantity(quantity);
                total.Should().Be(expectedTotalPrice);
            }
        }


        public class ItemDTests
        {
            [Fact]
            public void itemD_IsAnItem()
            {
                //Arrange
                var itemD = new ItemD();

                //Act


                //Assert
                itemD.Should().BeAssignableTo<Item>();
            }

            [Theory]
            [InlineData(1, .15)]
            [InlineData(3, .45)]
            public void TheoryItemDsPrice(int quantity, decimal expectedTotalPrice)
            {
                //Arrange
                var itemD = new ItemD();
                //Act

                //Assert
                var total = itemD.GetPriceForQuantity(quantity);
                total.Should().Be(expectedTotalPrice);
            }
        }











    }
}