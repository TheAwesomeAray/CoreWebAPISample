
using FluentAssertions;
using FunctionalTests;
using Jets.Dto;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using WebAPISample;
using Xunit;

public class JetsControllerGetLookUp : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    public HttpClient Client { get; }

    public JetsControllerGetLookUp(CustomWebApplicationFactory<Startup> factory)
    {
        Client = factory.CreateClient();
    }

    [Fact]
    public async Task ReturnLookUpForId()
    {
        var response = await Client.GetAsync("/api/jets");
        response.EnsureSuccessStatusCode();
        var stringResponse = await response.Content.ReadAsStringAsync();
        var model = JsonConvert.DeserializeObject<LookUpDto>(stringResponse);

        model.LookUpValue.Should().Be("Test Lookup");
    }
}

