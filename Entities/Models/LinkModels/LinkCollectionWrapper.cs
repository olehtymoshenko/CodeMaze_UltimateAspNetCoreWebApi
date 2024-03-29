﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.LinkModels
{
    public class LinkCollectionWrapper<T> : LinkResourceBase
    {
        public List<T> Value { get; init; } = new();

        public LinkCollectionWrapper() { }

        public LinkCollectionWrapper(List<T> value)
        {
            Value = value;
        }
    }
}
