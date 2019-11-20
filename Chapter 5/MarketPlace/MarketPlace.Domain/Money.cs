﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain
{
    public class Money : IEquatable<Money>
    {
        public decimal Amount { get; }
        public Money(decimal amount) { Amount = amount; }

        public bool Equals(Money other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return false;
            return Amount.Equals(other.Amount);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return false;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Money)obj);
        }
        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }
        public static bool operator ==(Money left, Money right) => 
            Equals(left, right);
        public static bool operator !=(Money left, Money right) => !Equals(left, right);
    }
}
