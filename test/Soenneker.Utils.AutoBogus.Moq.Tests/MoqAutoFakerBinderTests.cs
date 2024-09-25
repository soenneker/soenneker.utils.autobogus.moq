using FluentAssertions;
using Soenneker.Tests.FixturedUnit;
using Soenneker.Utils.AutoBogus.Moq.Tests.Dtos;
using Xunit;
using Xunit.Abstractions;

namespace Soenneker.Utils.AutoBogus.Moq.Tests;

[Collection("Collection")]
public class MoqAutoFakerBinderTests : FixturedUnitTest
{
    private readonly AutoFaker _faker;

    public MoqAutoFakerBinderTests(Fixture fixture, ITestOutputHelper testOutputHelper) : base(fixture, testOutputHelper)
    {
        _faker = new AutoFaker
        {
            Binder = new MoqAutoFakerBinder()
        };
    }

    [Fact]
    public void Should_Generate()
    {
        var result = _faker.Generate<TestClass>();
        result.Should().NotBeNull();
    }

    [Fact]
    public void Should_Generate_Abstract()
    {
        var result = _faker.Generate<TestAbstractClass>();
        result.Should().NotBeNull();
    }
}
