﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ploeh.Samples.Booking.PersistenceModel
{
    public interface IStoreWriter<T>
    {
        Stream OpenStreamFor(T item);
    }
}
