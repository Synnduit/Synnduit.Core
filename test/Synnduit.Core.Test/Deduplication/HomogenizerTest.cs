using System;
using FluentAssertions;
using Xunit;

namespace Synnduit.Deduplication
{
    public class HomogenizerTest
    {
        [Fact]
        public void Value_Type_Homogenizer_Homogenizes_Instances_Of_Supported_Type()
        {
            var homogenizer = new DoublingHomogenizer();
            homogenizer
                .Homogenize(7)
                .Should()
                .Be(14);
            homogenizer
                .Homogenize(-4)
                .Should()
                .Be(-8);
            homogenizer
                .Homogenize(0)
                .Should()
                .Be(0);
            int? nullableValue = 27;
            homogenizer
                .Homogenize(nullableValue)
                .Should()
                .Be(54);
            int? nullValue = null;
            homogenizer
                .Homogenize(nullValue)
                .Should()
                .BeNull();
        }

        [Fact]
        public void Value_Type_Homogenizer_Does_Not_Affect_Instances_Of_Unsupported_Types()
        {
            var homogenizer = new DoublingHomogenizer();
            homogenizer
                .Homogenize(787.0m)
                .Should()
                .Be(787.0m);
            homogenizer
                .Homogenize(57L)
                .Should()
                .Be(57L);
            homogenizer
                .Homogenize("Islands in the Stream")
                .Should()
                .Be("Islands in the Stream");
            var instance = new object();
            homogenizer
                .Homogenize(instance)
                .Should()
                .Be(instance);
            var anotherInstance = new InvalidCastException();
            homogenizer
                .Homogenize(anotherInstance)
                .Should()
                .Be(anotherInstance);
            DateTime now = DateTime.Now;
            homogenizer
                .Homogenize(now)
                .Should()
                .Be(now);
            long? nullValue = null;
            homogenizer
                .Homogenize(nullValue)
                .Should()
                .BeNull();
            Exception anotherNullValue = null;
            homogenizer
                .Homogenize(anotherNullValue)
                .Should()
                .BeNull();
        }

        [Fact]
        public void Reference_Type_Homogenizer_Homogenizes_Instances_Of_Supported_Type()
        {
            var homogenizer = new ToUpperCaseHomogenizer();
            homogenizer
                .Homogenize("For Whom the Bell Tolls")
                .Should()
                .Be("FOR WHOM THE BELL TOLLS");
            homogenizer
                .Homogenize("something STUPID")
                .Should()
                .Be("SOMETHING STUPID");
            string nullValue = null;
            homogenizer
                .Homogenize(nullValue)
                .Should()
                .BeNull();
        }

        [Fact]
        public void Reference_Type_Homogenizer_Does_Not_Affect_Instances_Of_Unsupported_Types()
        {
            var homogenizer = new ToUpperCaseHomogenizer();
            homogenizer
                .Homogenize(24)
                .Should()
                .Be(24);
            homogenizer
                .Homogenize(3.141592684d)
                .Should()
                .Be(3.141592684d);
            DateTimeOffset now = DateTimeOffset.Now;
            homogenizer
                .Homogenize(now)
                .Should()
                .Be(now);
            var instance = new OutOfMemoryException();
            homogenizer
                .Homogenize(instance)
                .Should()
                .Be(instance);
            uint? anotherInstance = uint.MaxValue;
            homogenizer
                .Homogenize(anotherInstance)
                .Should()
                .Be(uint.MaxValue);
            ArgumentNullException nullValue = null;
            homogenizer
                .Homogenize(nullValue)
                .Should()
                .BeNull();
            decimal? anotherNullValue = null;
            homogenizer
                .Homogenize(anotherNullValue)
                .Should()
                .BeNull();
        }

        private class DoublingHomogenizer : Homogenizer<int>
        {
            protected override object Homogenize(int value)
            {
                return value * 2;
            }
        }

        private class ToUpperCaseHomogenizer : Homogenizer<string>
        {
            protected override object Homogenize(string value)
            {
                return value.ToUpper();
            }
        }
    }
}
