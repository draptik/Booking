﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit.Extensions;
using Ploeh.AutoFixture.Xunit;
using Xunit;

namespace Ploeh.Samples.Booking.DomainModel.UnitTest
{
    public class CapacityTests
    {
        [Theory, AutoDomainData]
        public void RemainingIsCorrect([Frozen]int expected, Capacity sut)
        {
            Assert.Equal<int>(expected, sut.Remaining);
        }
    }
}