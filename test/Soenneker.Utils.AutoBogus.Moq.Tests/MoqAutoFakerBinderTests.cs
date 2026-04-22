using AwesomeAssertions;
using Soenneker.Tests.HostedUnit;
using Soenneker.Utils.AutoBogus.Moq.Tests.Dtos;


namespace Soenneker.Utils.AutoBogus.Moq.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class MoqAutoFakerBinderTests : HostedUnitTest
{
    private readonly AutoFaker _faker;

    public MoqAutoFakerBinderTests(Host host) : base(host)
    {
        _faker = new AutoFaker
        {
            Binder = new MoqAutoFakerBinder()
        };
    }

    [Test]
    public void Should_Generate()
    {
        var result = _faker.Generate<TestClass>();
        result.Should().NotBeNull();
    }

    [Test]
    public void Should_Generate_Abstract()
    {
        var result = _faker.Generate<TestAbstractClass>();
        result.Should().NotBeNull();
    }
}
