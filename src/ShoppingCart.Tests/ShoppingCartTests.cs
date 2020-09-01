using System.Runtime.CompilerServices;
using FluentAssertions;
using Xunit;

namespace ShoppingCart.Tests
{
    public class ShoppingCartTests
    {
        
        
        
        [Theory]
        
        [InlineData("ABCDABAA", 32.4)]
        [InlineData("CCCCCCC" , 7.25)]
        [InlineData("ABCD" , 15.40)]
        [InlineData("ABCDADDA", 19.70)]

        public void SampleTestFromInstructions(string items, decimal expectedTotal)
        {
            ITerminal register = new Terminal(); 
            foreach (var item in items)
            {
                register.Scan(item.ToString());
            }

            register.Total().Should().Be(expectedTotal);
        }

        [Fact]
        public void TerminalImplementsITerminal()
        {
            ITerminal register = new Terminal();
            register.Should().BeAssignableTo<ITerminal>();
        }



    }


}
