namespace RD.TMDB.Core.Contracts.Factories;

public interface IRefitApiFactory
{
    public TApi CreateClient<TApi>();
}
