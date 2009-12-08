﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace NSubstitute.Acceptance.Specs
{
    [TestFixture]
    public class SubstitureReturnValues
    {
        private ISomething _something;

        [Test]
        public void ShouldReturnSingleValue()
        {
            _something.Count().Return(3);

            Assert.That(_something.Count(), Is.EqualTo(3), "First return");
            Assert.That(_something.Count(), Is.EqualTo(3), "Second return");
        }

        [Test]
        public void ShouldReturnMultipleValues()
        {
            _something.Count().Return(1, 2, 3);

            Assert.That(_something.Count(), Is.EqualTo(1), "First return");
            Assert.That(_something.Count(), Is.EqualTo(2), "Second return");
            Assert.That(_something.Count(), Is.EqualTo(3), "Third return");
            Assert.That(_something.Count(), Is.EqualTo(3), "Fourth return");
        }

        [SetUp]
        public void SetUp()
        {
            _something = Substitute.For<ISomething>();
        }
    }

    public interface ISomething
    {
        int Count();
    }
}