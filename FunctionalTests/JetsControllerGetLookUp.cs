
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
    public async Task Get_GivenValidId_ReturnsAppropriateJsonResult()
    {
        var response = await Client.GetAsync("/api/jets/1");
        response.EnsureSuccessStatusCode();
        var stringResponse = await response.Content.ReadAsStringAsync();
        var model = JsonConvert.DeserializeObject<LookUpDto>(stringResponse);

        model.LookUpValue.Should().Be("Value 1");
    }

    [Fact]
    public async Task Get_GivenInvalidId_ReturnsNotFound()
    {
        var response = await Client.GetAsync("/api/jets/9999");

        response.StatusCode.Should().Be(404);
    }
}

