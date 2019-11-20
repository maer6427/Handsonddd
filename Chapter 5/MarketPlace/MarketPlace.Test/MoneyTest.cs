using MarketPlace.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarketPlace.Test
{   
    public class MoneyTest
    {
        [Fact]
        public void
        Money_objects_with_the_same_amount_should_be_equal()
        {
            var firstAmount = new Money(5);
            var secondAMount = new Money(5);
            Assert.Equal(firstAmount, secondAMount);
        }
    }    
}
