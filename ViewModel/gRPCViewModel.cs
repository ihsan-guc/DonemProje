using Grpc.Core;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static DonemProje.HelloworldXamarin.Helloworld;

namespace DonemProje.ViewModel
{
    public class gRPCViewModel : NotifyPropertyChanged
    {
        const int Port = 50051;
        int count = 1;
        public gRPCViewModel()
        {
            btngRPC = new Command(gRPCRequest);
            BtnText = "İstek Atın";
        }
        private ICommand btngRPC;
		public ICommand BtngRPC
		{
			get { return btngRPC; }
			set { btngRPC = value; }
		}
		private string btnText;

		public string BtnText
		{
			get { return btnText; }
			set { btnText = value; OnPropertyChanged(); }
		}
		public void gRPCRequest(object e)
		{
            SayHello();
        }
        private void SayHello()
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

            BtnText = "Greeting: " + reply.Message;

            channel.ShutdownAsync().Wait();
            server.ShutdownAsync().Wait();
            count++;
        }
        class GreeterImpl : DonemProje.HelloworldXamarin.HelloworldGrpc.Greeter.GreeterBase
        {
            public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
            {
                return Task.FromResult(new HelloReply { Message = "Hello " + request.Name });
            }
        }
    }
}
