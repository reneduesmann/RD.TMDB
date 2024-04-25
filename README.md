# RD.TMDB.Client - Wrapper for the TMDB Api

A complete wrapper for v3 and v4 of the TMDB's API (TheMovieDb - https://www.themoviedb.org/)

## Table of Contents
* [Examples](#examples)
  * [V4](#V4)
* [Dependencies](#Dependencies)
* [Informations](#Informations)
* [License](#License)
* [ToDos](#ToDos)
* [Work with api categories](#Work-with-api-categories)

## Examples

Get details about a movie:
```csharp 
ITmdbClient client = new TmdbClient("Token");
MovieDetail movie = await client.GetMovieDetailsAsync(693134);
```

Search for movies:
```csharp
ITmdbClient client = new TmdbClient("Token");
ResultContainer<Movie> movies = await client.DiscoverMoviesAsync(new DiscoverMovieRequest()
{
    Language = Iso639_1.English,
    Year = 2024
});
```

Get additional informations about a movie in a single request:
```csharp
ITmdbClient client = new TmdbClient("Token");
MovieDetail movie = await client.GetMovieDetailsAsync(693134, 
    MovieInformation.Videos | MovieInformation.Images);

foreach (Video video in movie.Videos.Results)
{}

foreach (ImageBase image in movie.Images.Posters)
{}
```

### V4
> [!NOTE]  
> To use the V4 Api, you need to use the `TmdbV4Client`.
 
Add media items to a list:
```csharp
ITmdbV4Client client = new TmdbV4Client("Token");
ItemsResponse response = await client.AddItemsToListAsync(139699, new ItemsRequest<ItemRequest>()
{
    Media = new List<ItemRequest>()
    {
        new ItemRequest("movie", 550),
        new ItemRequest("movie", 244786),
        new ItemRequest("tv", 1396)
    }
});
```

## Dependencies

- [Refit](https://github.com/reactiveui/refit) (Interfaces to define the api endpoints)
- [RD.Extensions.Enum](https://github.com/reneduesmann/RD.Extensions.Enums) (Decorate enum values with additional data)

## Informations
- All methods provide a `CancellationToken` to cancel the request.
- `TmdbClient` contains all methods for the v3 api.
- `TmdbClient` provide public properties to set default values for the Language and Country (Default is set to English and United States).
- Methods and Requests support enum values for easy usage like `Iso639_1` for the language
and `Iso3166_1` for countries.
- Most static values like languages, countries, genres, etc. are provided as enums.

## License
RD.TMDB.Client is licensed under the [MIT License](https://github.com/reneduesmann/RD.TMDB/blob/main/LICENSE). See the LICENSE file for more informations.

## ToDos

- [ ] Add Unit Tests
- [ ] Add examples
- [ ] Add method documentations

## Work with api categories
The [TMDB api](https://developer.themoviedb.org/reference/intro/getting-started) is divided into different categories. Each category is represented by an interface. The `TmdbClient` and `TmdbV4Client` classes implement all interfaces.
The categories are as example Account, Authentication, Movies, TvShows, etc.
Append to the category name the word `Provider` to get the interface name.
To get the interfaces, you can define it like this:
```csharp
ITmdbClient client = new TmdbClient("Token");
IMovieProvider movieProvider = client;
//or
IMovieProvider movieProvider = new TmdbClient("Token");

MovieDetail movie = await movieProvider.GetMovieDetailsAsync(693134);
```