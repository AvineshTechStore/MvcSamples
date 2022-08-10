using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLearning.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        //To get rid of Id due to maintainance issue. Use  this constant or enum or create new class like MembershipCode
        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}