using FluentAssertions;
using Synnduit.TestHelper;
using Xunit;

namespace Synnduit.Deduplication
{
    public class DuplicateTest
    {
        [Fact]
        public void Constructor_Throws_ArgumentNullException_When_DestinationSystemEntityId_Null()
        {
#pragma warning disable CA1806 // Do not ignore method results
            ArgumentTester.ThrowsArgumentNullException(
                () => new Duplicate(null, MatchWeight.Inconsistent),
                "destinationSystemEntityId");
#pragma warning restore CA1806 // Do not ignore method results
        }

        [Fact]
        public void Constructor_Throws_Argument_Exception_When_Weight_Invalid()
        {
#pragma warning disable CA1806 // Do not ignore method results
            ArgumentTester.ThrowsArgumentException(
                () => new Duplicate(1, (MatchWeight) 57),
                "weight");
#pragma warning restore CA1806 // Do not ignore method results
        }

        [Fact]
        public void DestinationSystemEntityId_Returns_DestinationSystemEntityId()
        {
            new Duplicate("abc", MatchWeight.Candidate)
                .DestinationSystemEntityId
                .Should()
                .Be((EntityIdentifier) "abc");
        }

        [Fact]
        public void Weight_Returns_Weight()
        {
            new Duplicate(5757L, MatchWeight.Candidate)
                .Weight
                .Should()
                .Be(MatchWeight.Candidate);
            new Duplicate("24ab", MatchWeight.Inconsistent)
                .Weight
                .Should()
                .Be(MatchWeight.Inconsistent);
            new Duplicate(24, MatchWeight.Positive)
                .Weight
                .Should()
                .Be(MatchWeight.Positive);
        }
    }
}
