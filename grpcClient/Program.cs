using Grpc.Net.Client;
using grpcMessageClient;

namespace grpcClient
{
    class Program {
        static async Task Main (string[] args){

            var channel = GrpcChannel.ForAddress("http://localhost:5031");

            var messageClient = new Message.MessageClient(channel);       

            MessageReply reply = await messageClient.SendMessageAsync(new MessageRequest{
                Message = "Hello",
                Name = "Seymur"
            });
            Console.WriteLine(reply.Message);
        }
    }
}