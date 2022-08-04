using Amazon.Lambda.APIGatewayEvents;
using System.Net;
using System.Text.Json;

namespace Nitro.Dotnet.Functions.Response
{
    public class FunctionResponse : APIGatewayProxyResponse
    {
        public FunctionResponse(object data, HttpStatusCode httpStatusCode)
        {
            Body = JsonSerializer.Serialize(data);
            StatusCode = (int)httpStatusCode;
            Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } };
        }
    }
}