using System;
using System.Threading;
using grpc = global::Grpc.Core;

namespace DonemProje.HelloworldXamarin
{
    public class HelloworldGrpc
    {
        public static partial class Greeter
        {
            static readonly string __ServiceName = "helloworld.Greeter";

            static readonly grpc::Marshaller<global::DonemProje.HelloworldXamarin.Helloworld.HelloRequest> __Marshaller_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DonemProje.HelloworldXamarin.Helloworld.HelloRequest.Parser.ParseFrom);
            static readonly grpc::Marshaller<global::DonemProje.HelloworldXamarin.Helloworld.HelloReply> __Marshaller_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DonemProje.HelloworldXamarin.Helloworld.HelloReply.Parser.ParseFrom);

            static readonly grpc::Method<global::DonemProje.HelloworldXamarin.Helloworld.HelloRequest, global::DonemProje.HelloworldXamarin.Helloworld.HelloReply> __Method_SayHello = new grpc::Method<global::DonemProje.HelloworldXamarin.Helloworld.HelloRequest, global::DonemProje.HelloworldXamarin.Helloworld.HelloReply>(
                grpc::MethodType.Unary,
                __ServiceName,
                "SayHello",
                __Marshaller_HelloRequest,
                __Marshaller_HelloReply);
            public abstract partial class GreeterBase
            {
                public virtual global::System.Threading.Tasks.Task<global::DonemProje.HelloworldXamarin.Helloworld.HelloReply> SayHello(global::DonemProje.HelloworldXamarin.Helloworld.HelloRequest request, grpc::ServerCallContext context)
                {
                    throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
                }

            }
            public partial class GreeterClient : grpc::ClientBase<GreeterClient>
            {
                public GreeterClient(grpc::Channel channel) : base(channel)
                {
                }
                protected GreeterClient(ClientBaseConfiguration configuration) : base(configuration)
                {
                }
                public virtual global::DonemProje.HelloworldXamarin.Helloworld.HelloReply SayHello(global::DonemProje.HelloworldXamarin.Helloworld.HelloRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
                {
                    return SayHello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
                }
                public virtual global::DonemProje.HelloworldXamarin.Helloworld.HelloReply SayHello(global::DonemProje.HelloworldXamarin.Helloworld.HelloRequest request, grpc::CallOptions options)
                {
                    return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
                }
                protected override GreeterClient NewInstance(ClientBaseConfiguration configuration)
                {
                    return new GreeterClient(configuration);
                }
            }
            public static grpc::ServerServiceDefinition BindService(GreeterBase serviceImpl)
            {
                return grpc::ServerServiceDefinition.CreateBuilder()
                    .AddMethod(__Method_SayHello, serviceImpl.SayHello).Build();
            }
        }
    }
}
