using FakeItEasy;
using RD.TMDB.Core.Contracts.Factories;
using RD.TMDB.Core.Providers;

namespace RD.TMDB.Core.UnitTests;

public abstract class TestBase
{
    protected TmdbClient Client { get; }

    protected string BearerToken { get; }

    public IRefitApiFactory RefitApiFactory { get; set; }

    protected TestBase()
    {
        this.BearerToken = "emptyToken";
        this.RefitApiFactory = A.Fake<IRefitApiFactory>();
        this.Client = new TmdbClient(this.BearerToken, this.RefitApiFactory);
    }
}
