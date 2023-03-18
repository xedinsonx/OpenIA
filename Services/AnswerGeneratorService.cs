using OpenAI_API;
using OpenAI_API.Completions;

namespace Chatgpt.Services
{
    public class AnswerGeneratorService: IAnswerGeneratorService
    {
       

        public async Task<string> GenerateAnserAsync(string Prompt)
        {
            string apiKey = "YOU_API_KEY";
            string answer = string.Empty;

            var openai = new OpenAIAPI(apiKey);
            CompletionRequest completion = new CompletionRequest();
            completion.Prompt= Prompt;
            completion.MaxTokens = 4000;
            var result = await openai.Completions.CreateCompletionAsync(completion);
            if(result != null) 
            {
                foreach(var item in result.Completions) 
                {
                    answer = item.Text;
                }
            }


            return answer;
        }
    }
}
