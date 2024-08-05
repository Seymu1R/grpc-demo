using Grpc.Core;
using grpcMessageServerStream;

namespace grpcServer.Services;

public class MessageServiceStream : MessageStream.MessageStreamBase
{
    public override Task SendMessage(MessageRequest request, IServerStreamWriter<MessageReply> responseStream, ServerCallContext context)
    {
        return base.SendMessage(request, responseStream, context);
    }
}