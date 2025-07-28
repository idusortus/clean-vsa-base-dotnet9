// using System.Net.Http.Json;
// using Application.Abstractions.External;
// using Application.Features.Dogs;
// using SharedCore;

// namespace Infrastructure.External;

// public class DogApiService(HttpClient client) : IDogApiService
// {
//     public async Task<Result<DogFactResponse>> GetDogFact(int count, CancellationToken ct)
//     {
//         var url = $"api/v2/facts/?limit={count}";
//         var response = await client.GetFromJsonAsync<DogFactResponse>(url);
//         return Result.Success(response);
//     }

//     Task<Result<Application.Features.Dogs.DogFactResponse>> IDogApiService.GetDogFact(int count, CancellationToken ct)
//     {
//         throw new NotImplementedException();
//     }
// }

// public class DogFactResponse
// {
//     public List<DogFactRecord> Data { get; set; } = [];
// }

// public class DogFactRecord
// {
//     public string Id { get; set; } = string.Empty;
//     public string Type { get; set; } = string.Empty;
//     public DogFactAttributes Attributes { get; set; } = new();
// }

// public class DogFactAttributes
// {
//     public string Body { get; set; } = string.Empty;
// }
