using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using BankLoanSystem.Entities;
using BankLoanSystem.Interfaces;
using Volo.Abp.Application.Services;

namespace BankLoanSystem.Services;

public class ScoringCalculationService : ApplicationService, IScoringCalculationService
{
    private readonly HttpClient _httpClient;

    public ScoringCalculationService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<decimal> GetDataReturnData(AdditionalInfo additionalInfo, LoanRequest request)
    {
        var apiUrl = "localhost:11434";

        string prompt = $"You are a scoring AI. Based on the provided user data, return only a decimal score between 0.00 and 1.00, nothing else. Do not explain your answer.\nData::" +
                              $"a man with a wage: {additionalInfo.Wage}" +
                              $"properties: {string.Join(',', additionalInfo.Properties)}" +
                              $"experience in months: {additionalInfo.ExperienceInMonths}" +
                              $"social programs: {additionalInfo.SocialPrograms}" +
                              $"type of employment: {additionalInfo.TypeOfEmployment}" +
                              $"term of credit in months: {request.TermInMonths}" +
                              $"interest rate: {request.InterestRate}" +
                              $"amount of money to be lent: {request.Amount}" +
                              $"type of credit: {request.Type}" +
                              "\nReturn only the decimal score now.";

        var requestBody = new
        {
            model = "llama3.2",
            prompt = prompt,
            stream = false
        };
        
        var response = await _httpClient.PostAsJsonAsync("http://localhost:11434/api/generate", requestBody);
        
        if (!response.IsSuccessStatusCode)
        {
            Console.WriteLine($"Ollama error: {response.StatusCode}");
            return 0;
        }
        
        var json = await response.Content.ReadAsStringAsync();
        var doc = JsonDocument.Parse(json);
        var responseText = doc.RootElement.GetProperty("response").GetString();

        // Извлекаем decimal с помощью regex
        if (decimal.TryParse(System.Text.RegularExpressions.Regex.Match(responseText, @"\d+(\.\d+)?").Value, out var score))
        {
            return score;
        }

        return 0;
    }
}