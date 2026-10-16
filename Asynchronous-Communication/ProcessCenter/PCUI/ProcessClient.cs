using static PCUI.Infrastructure.Dtos;

namespace PCUI
{
    public class ProcessClient
    {
        private readonly HttpClient _http;
        public ProcessClient(HttpClient http) => _http = http;

        public async Task<List<ProcessDto>> GetAsync(Guid droneId)
            => await _http.GetFromJsonAsync<List<ProcessDto>>($"process?droneId={droneId}")
               ?? new();

        public async Task<bool> PostAsync(GrantOrderDto dto)
        {
            var response = await _http.PostAsJsonAsync("process", dto);
            return response.IsSuccessStatusCode;
        }
    }
}
