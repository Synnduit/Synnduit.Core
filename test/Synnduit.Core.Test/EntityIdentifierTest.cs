using FluentAssertions;
using Synnduit.TestHelper;
using System;
using Xunit;

namespace Synnduit
{
    public class EntityIdentifierTest
    {
        [Fact]
        public void Equal_Returns_True_If_Identifiers_Equal()
        {
            var identifierOne = new EntityIdentifier("Alpha");
            var identifierTwo = new EntityIdentifier("ALPHa");
            EntityIdentifier
                .Equal(identifierOne, identifierTwo)
                .Should()
                .BeTrue();
        }

        [Fact]
        public void Equal_Returns_True_If_Both_Identifiers_Null()
        {
            EntityIdentifier
                .Equal(null, null)
                .Should()
                .BeTrue();
        }

        [Fact]
        public void Equal_Returns_False_If_Identifiers_Differ()
        {
            var identifierOne = new EntityIdentifier("Bravo");
            var identifierTwo = new EntityIdentifier("Charlie");
            EntityIdentifier
                .Equal(identifierOne, identifierTwo)
                .Should()
                .BeFalse();
        }

        [Fact]
        public void Equal_Returns_False_If_One_Identifier_Null()
        {
            EntityIdentifier
                .Equal(new EntityIdentifier(885), null)
                .Should()
                .BeFalse();
            EntityIdentifier
                .Equal(null, new EntityIdentifier(Guid.NewGuid()))
                .Should()
                .BeFalse();
        }

        [Fact]
        public void Equals_Operator_Returns_True_If_Identifiers_Equal()
        {
            var identifierOne = new EntityIdentifier(8877);
            var identifierTwo = new EntityIdentifier(8877);
            bool equal = identifierOne == identifierTwo;
            equal.Should().BeTrue();
        }

        [Fact]
        public void Equals_Operator_Returns_True_If_Both_Identifiers_Null()
        {
            EntityIdentifier identifierOne = null;
            EntityIdentifier identifierTwo = null;
            bool equal = identifierOne == identifierTwo;
            equal.Should().BeTrue();
        }

        [Fact]
        public void Equals_Operator_Returns_False_If_Identifiers_Differ()
        {
            var identifierOne = new EntityIdentifier(Guid.NewGuid());
            var identifierTwo = new EntityIdentifier(Guid.NewGuid());
            bool equal = identifierOne == identifierTwo;
            equal.Should().BeFalse();
        }

        [Fact]
        public void Equals_Operator_Returns_False_If_One_Identifier_Null()
        {
            bool equal = new EntityIdentifier("Zulu") == (EntityIdentifier) null;
            equal.Should().BeFalse();
            equal = null == new EntityIdentifier(57);
            equal.Should().BeFalse();
        }

        [Fact]
        public void Not_Equals_Operator_Returns_False_If_Identifiers_Equal()
        {
            var identifierOne = new EntityIdentifier("Uniform");
            var identifierTwo = new EntityIdentifier("uNIFORM");
            bool notEqual = identifierOne != identifierTwo;
            notEqual.Should().BeFalse();
        }

        [Fact]
        public void Not_Equals_Operator_Returns_False_If_Both_Identifiers_Null()
        {
            var identifierOne = new EntityIdentifier(Guid.NewGuid());
            var identifierTwo = new EntityIdentifier(Guid.NewGuid());
            bool notEqual = identifierOne == identifierTwo;
            notEqual.Should().BeFalse();
        }

        [Fact]
        public void Not_Equals_Operator_Returns_True_If_Identifiers_Differ()
        {
            var identifierOne = new EntityIdentifier(5L);
            var identifierTwo = new EntityIdentifier(6L);
            bool notEqual = identifierOne != identifierTwo;
            notEqual.Should().BeTrue();
        }

        [Fact]
        public void Not_Equals_Operator_Returns_True_If_One_Identifier_Null()
        {
            bool notEqual = new EntityIdentifier("Hotel") != null;
            notEqual.Should().BeTrue();
            notEqual = null != new EntityIdentifier(Guid.NewGuid());
            notEqual.Should().BeTrue();
        }

        [Fact]
        public void Implicit_Conversion_From_String_Creates_Expected_Identifier()
        {
            EntityIdentifier identifier = "Yankee";
            identifier.Identifier.Should().Be("Yankee");
        }

        [Fact]
        public void Implicit_Conversion_From_Null_String_Creates_Null_Reference_Identifier()
        {
            string identifierAsString = null;
            EntityIdentifier identifier = identifierAsString;
            identifier.Should().BeNull();
        }

        [Fact]
        public void Implicit_Conversion_From_Guid_Creates_Expected_Identifier()
        {
            EntityIdentifier identifier =
                Guid.Parse("71948420525b4577ac833d0704aaa194");
            identifier.Identifier.Should().Be("71948420-525b-4577-ac83-3d0704aaa194");
        }

        [Fact]
        public void Implicit_Conversion_From_Int32_Creates_Expected_Identifier()
        {
            EntityIdentifier identifier = -5478;
            identifier.Identifier.Should().Be("-5478");
        }

        [Fact]
        public void Implicit_Conversion_From_Int64_Creates_Expected_Identifier()
        {
            EntityIdentifier identifier = -565656L;
            identifier.Identifier.Should().Be("-565656");
        }

        [Fact]
        public void Implicit_Conversion_From_UInt32_Creates_Expected_Identifier()
        {
            EntityIdentifier identifier = 455U;
            identifier.Identifier.Should().Be("455");
        }

        [Fact]
        public void Implicit_Conversion_From_UInt64_Creates_Expected_Identifier()
        {
            EntityIdentifier identifier = 777548UL;
            identifier.Identifier.Should().Be("777548");
        }

        [Fact]
        public void Implicit_Conversion_To_String_Creates_Expected_String()
        {
            string identifier = new EntityIdentifier("Tango");
            identifier.Should().Be("Tango");
        }

        [Fact]
        public void Implicit_Conversion_From_Null_To_String_Creates_Null_Reference_String()
        {
            EntityIdentifier identifier = null;
            string identifierAsString = identifier;
            identifierAsString.Should().BeNull();
        }

        [Fact]
        public void Explicit_Conversion_To_Guid_Creates_Expected_Guid()
        {
            Guid identifier = (Guid) new EntityIdentifier(
                "630aa1b8-6e76-4ce5-829b-ab85cd517b9d");
            identifier.Should().Be(
                Guid.Parse("630aa1b8-6e76-4ce5-829b-ab85cd517b9d"));
        }

        [Fact]
        public void Explicit_Conversion_To_Int32_Creates_Expected_Int32()
        {
            int identifier = (int) new EntityIdentifier("87");
            identifier.Should().Be(87);
        }

        [Fact]
        public void Explicit_Conversion_To_Int64_Creates_Expected_Int64()
        {
            long identifier = (long) new EntityIdentifier("-756");
            identifier.Should().Be(-756);
        }

        [Fact]
        public void Explicit_Conversion_To_UInt32_Creates_Expected_UInt32()
        {
            uint identifier = (uint) new EntityIdentifier("1888");
            identifier.Should().Be(1888);
        }

        [Fact]
        public void Explicit_Conversion_To_UInt64_Creates_Expected_UInt64()
        {
            ulong identifier = (ulong) new EntityIdentifier("6655");
            identifier.Should().Be(6655);
        }

        [Fact]
        public void Constructor_Throws_ArgumentNullException()
        {
#pragma warning disable CA1806 // Do not ignore method results
            ArgumentTester.ThrowsArgumentNullException(
                () => new EntityIdentifier(null),
                "identifier");
#pragma warning restore CA1806 // Do not ignore method results
        }

        [Fact]
        public void Constructor_Throws_ArgumentException_When_Identifier_Too_Long()
        {
#pragma warning disable CA1806 // Do not ignore method results
            ArgumentTester.ThrowsArgumentException(
                () => new EntityIdentifier(new string(
                    'a', EntityIdentifier.MaxLength + 1)),
                "identifier");
#pragma warning restore CA1806 // Do not ignore method results
        }

        [Fact]
        public void Constructor_Does_Not_Throw_Exception_For_Maximum_Identifier_Length()
        {
#pragma warning disable CA1806 // Do not ignore method results
            Action constructorInvocation =
                () => new EntityIdentifier(new string('1', EntityIdentifier.MaxLength));
#pragma warning restore CA1806 // Do not ignore method results
            constructorInvocation.Should().NotThrow();
        }

        [Fact]
        public void Constructor_Sets_String_Identifier()
        {
            var identifier = new EntityIdentifier("This is a unique identifier!");
            identifier
                .Identifier
                .Should()
                .Be("This is a unique identifier!");
        }

        [Fact]
        public void Constructor_Sets_Guid_Identifier()
        {
            var identifier = new EntityIdentifier(
                Guid.Parse("A572507A-3876-4794-B515-5DCC0A0CF694"));
            identifier
                .Identifier
                .Should()
                .Be("a572507a-3876-4794-b515-5dcc0a0cf694");
        }

        [Fact]
        public void Constructor_Sets_Int32_Identifier()
        {
            var identifier = new EntityIdentifier(-2125483448);
            identifier
                .Identifier
                .Should()
                .Be("-2125483448");
        }

        [Fact]
        public void Constructor_Sets_Int64_Identifier()
        {
            var identifier = new EntityIdentifier(-9222371036854555806L);
            identifier
                .Identifier
                .Should()
                .Be("-9222371036854555806");
        }

        [Fact]
        public void Constructor_Sets_UInt32_Identifier()
        {
            var identifier = new EntityIdentifier(4234927293U);
            identifier
                .Identifier
                .Should()
                .Be("4234927293");
        }

        [Fact]
        public void Constructor_Sets_UInt64_Identifier()
        {
            var identifier = new EntityIdentifier(18446724073709451651UL);
            identifier
                .Identifier
                .Should()
                .Be("18446724073709451651");
        }

        [Fact]
        public void GetHashCode_Returns_UpperCase_String_Representation_Hash_Code()
        {
            var identifier = new EntityIdentifier("AbCdEfG");
            identifier
                .GetHashCode()
                .Should()
                .Be("ABCDEFG".GetHashCode());
        }

        [Fact]
        public void Equals_Returns_True_If_Other_Object_Is_Same_Identifier()
        {
            var identifier = new EntityIdentifier("AbCdEf");
            identifier
                .Equals(new EntityIdentifier("AbCdEf"))
                .Should()
                .BeTrue();
            identifier
                .Equals(new EntityIdentifier("aBcDeF"))
                .Should()
                .BeTrue();
        }

        [Fact]
        public void Equals_Returns_False_If_Other_Object_Is_Different_Identifier()
        {
            var identifier = new EntityIdentifier("12345");
            identifier
                .Equals(new EntityIdentifier("123456"))
                .Should()
                .BeFalse();
            identifier
                .Equals(new EntityIdentifier("012345"))
                .Should()
                .BeFalse();
        }

        [Fact]
        public void Equals_Returns_False_If_Other_Object_Different_Type()
        {
            var identifier = new EntityIdentifier("88");
            identifier
                .Equals(int.MaxValue)
                .Should()
                .BeFalse();
            identifier
                .Equals(new Exception())
                .Should()
                .BeFalse();
        }

        [Fact]
        public void ToString_Returns_String_Representation_Of_Identifier()
        {
            var identifier = new EntityIdentifier("Dodo");
            identifier.ToString().Should().Be("Dodo");
        }
    }
}
