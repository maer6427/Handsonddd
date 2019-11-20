using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain
{
    public class ClassifiedAdId
    {
        private readonly Guid _value;
        public ClassifiedAdId(Guid value)
        {
            if (value == default)
            {
                throw new ArgumentNullException(nameof(value), "Calssified ad id cannot be empty");
                _value = value;
            }
        }
    }
}
