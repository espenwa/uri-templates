﻿using NUnit.Framework;

namespace Resta.UriTemplates.Tests
{
    [TestFixture]
    public class SpecNegativeTests
    {

        private const string FileName = "testcases/negative-tests.json";

        [Test, TestCaseSource(typeof(TestCaseData), nameof(TestCaseData.GetSamples), new object[] { FileName })]
        public void SpecTest(TestCase testCase)
        {
            SpecBaseTests.SpecTest(testCase);
        }

        [Test, TestCaseSource(typeof(TestCaseData), nameof(TestCaseData.GetInvalidSamples), new object[] { FileName })]
        public void SpecInvalidTest(TestCase testCase)
        {
            SpecBaseTests.SpecInvalidTest(testCase);
        }
    }
}