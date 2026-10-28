using StreamForge.Domain;

namespace StreamForge.Tests;

public class SolutionSmokeTests
{
    [Fact]
    public void DomainAssemblyCanBeLoaded()
    {
        var assemblyName = typeof(AssemblyMarker).Assembly.GetName().Name;

        Assert.Equal("StreamForge.Domain", assemblyName);
    }
}
