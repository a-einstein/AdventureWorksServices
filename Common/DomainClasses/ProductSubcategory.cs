﻿using System.Diagnostics;
using System.Runtime.Serialization;

namespace Common.DomainClasses
{
    [DataContract]
    [DebuggerDisplay("{ProductCategoryId}, {Id}, {Name}")]
    public partial class ProductSubcategory : DomainClass
    {
        [DataMember]
        public int ProductCategoryId { get; set; }
    }
}
