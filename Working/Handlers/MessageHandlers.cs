using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;
using Newtonsoft.Json;

namespace Working.Handlers
{
    public class MessageHandlers
    {

        public MessageHandlers()
        {
        }

        public Task HelloWorld(SQSEvent @event, ILambdaContext context)
        {
            return Task.FromResult(JsonConvert.SerializeObject(new { Message = "Hello world!" }));
        }
    }
}
