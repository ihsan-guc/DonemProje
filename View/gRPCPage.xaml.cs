using Grpc.Core;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static DonemProje.HelloworldXamarin.Helloworld;

namespace DonemProje.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class gRPCPage : ContentPage
    {
        const int Port = 50051;
        int count = 1;
        public gRPCPage()
        {
            InitializeComponent();
            btn.Clicked += delegate { SayHello(btn); };
        }
        private void SayHello(Button button)
        {
            Server server = new Server
            {
                Services = { DonemProje.HelloworldXamarin.HelloworldGrpc.Greeter.BindService(new GreeterImpl()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            // use loopback on host machine: https://developer.android.com/studio/run/emulator-networking
            //10.0.2.2:50051
            Channel channel = new Channel("localhost:50051", ChannelCredentials.Insecure);

            var client = new DonemProje.HelloworldXamarin.HelloworldGrpc.Greeter.GreeterClient(channel);
            string user = "Xamarin " + count;

            var reply = client.SayHello(new DonemProje.HelloworldXamarin.Helloworld.HelloRequest { Name = user });

            button.Text = "Greeting: " + reply.Message;

            channel.ShutdownAsync().Wait();
            server.ShutdownAsync().Wait();

            count++;
        }
        class GreeterImpl : DonemProje.HelloworldXamarin.HelloworldGrpc.Greeter.GreeterBase
        {
            // Server side handler of the SayHello RPC
            public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
            {
                return Task.FromResult(new HelloReply { Message = "Hello " + request.Name });
            }
        }
    }
}