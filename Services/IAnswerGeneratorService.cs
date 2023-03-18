namespace Chatgpt.Services
{
    public interface IAnswerGeneratorService
    {
        Task<string> GenerateAnserAsync(string Prompt);
        
    }
}
