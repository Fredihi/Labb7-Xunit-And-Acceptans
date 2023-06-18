using Labb7_Xunit_And_Acceptans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_Xunit_And_Acceptans_XUnit
{
    public class MenuTests
    {
        [Fact]
        public void GetFirstNumberInput_ShouldReturnNumberThatWasInput()
        {
            //Arrange
            Menu men = new Menu();

            //Act
            var actual = men.GetFirstNumberInput(20);
            var expected = 20;

            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
