using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class UserProfile : Entity
    {
        public int ProfileId { get; set; }
        public int UserId { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
        internal static bool Any()
        {
            throw new NotImplementedException();
        }
    }
}
