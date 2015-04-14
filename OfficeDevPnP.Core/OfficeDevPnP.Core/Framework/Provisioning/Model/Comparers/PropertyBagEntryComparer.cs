﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.Core.Framework.Provisioning.Model.Comparers
{
    public static class PropertyBagEntryComparer
    {
        public static Func<PropertyBagEntry, bool> GetComparer(PropertyBagEntry model)
        {
            return (other) =>
            {
                return (model.Key == other.Key && model.Value == other.Value);
            };
        }
    }
}
