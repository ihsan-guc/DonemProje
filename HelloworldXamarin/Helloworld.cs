using pb = global::Google.Protobuf;
using pbr = global::Google.Protobuf.Reflection;

namespace DonemProje.HelloworldXamarin
{
    public class Helloworld
    {
        public static partial class HelloworldReflection
        {
            public static pbr::FileDescriptor Descriptor
            {
                get { return descriptor; }
            }
#pragma warning disable CS0649 // Field 'Helloworld.HelloworldReflection.descriptor' is never assigned to, and will always have its default value null
            private static pbr::FileDescriptor descriptor;
#pragma warning restore CS0649 // Field 'Helloworld.HelloworldReflection.descriptor' is never assigned to, and will always have its default value null
        }
        public sealed partial class HelloRequest : pb::IMessage<HelloRequest>
        {
            private static readonly pb::MessageParser<HelloRequest> _parser = new pb::MessageParser<HelloRequest>(() => new HelloRequest());
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pb::MessageParser<HelloRequest> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pbr::MessageDescriptor Descriptor
            {
                get { return global::DonemProje.HelloworldXamarin.Helloworld.HelloworldReflection.Descriptor.MessageTypes[0]; }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            pbr::MessageDescriptor pb::IMessage.Descriptor
            {
                get { return Descriptor; }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public HelloRequest()
            {
                OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public HelloRequest(HelloRequest other) : this()
            {
                name_ = other.name_;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public HelloRequest Clone()
            {
                return new HelloRequest(this);
            }
            public const int NameFieldNumber = 1;
            private string name_ = "";
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public string Name
            {
                get { return name_; }
                set
                {
                    name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override bool Equals(object other)
            {
                return Equals(other as HelloRequest);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public bool Equals(HelloRequest other)
            {
                if (ReferenceEquals(other, null))
                {
                    return false;
                }
                if (ReferenceEquals(other, this))
                {
                    return true;
                }
                if (Name != other.Name) return false;
                return true;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override int GetHashCode()
            {
                int hash = 1;
                if (Name.Length != 0) hash ^= Name.GetHashCode();
                return hash;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override string ToString()
            {
                return pb::JsonFormatter.ToDiagnosticString(this);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void WriteTo(pb::CodedOutputStream output)
            {
                if (Name.Length != 0)
                {
                    output.WriteRawTag(10);
                    output.WriteString(Name);
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public int CalculateSize()
            {
                int size = 0;
                if (Name.Length != 0)
                {
                    size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
                }
                return size;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(HelloRequest other)
            {
                if (other == null)
                {
                    return;
                }
                if (other.Name.Length != 0)
                {
                    Name = other.Name;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(pb::CodedInputStream input)
            {
                uint tag;
                while ((tag = input.ReadTag()) != 0)
                {
                    switch (tag)
                    {
                        default:
                            input.SkipLastField();
                            break;
                        case 10:
                            {
                                Name = input.ReadString();
                                break;
                            }
                    }
                }
            }
        }
        public sealed partial class HelloReply : pb::IMessage<HelloReply>
        {
            private static readonly pb::MessageParser<HelloReply> _parser = new pb::MessageParser<HelloReply>(() => new HelloReply());
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pb::MessageParser<HelloReply> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pbr::MessageDescriptor Descriptor
            {
                get { return global::DonemProje.HelloworldXamarin.Helloworld.HelloworldReflection.Descriptor.MessageTypes[1]; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            pbr::MessageDescriptor pb::IMessage.Descriptor
            {
                get { return Descriptor; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public HelloReply()
            {
                OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public HelloReply(HelloReply other) : this()
            {
                message_ = other.message_;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public HelloReply Clone()
            {
                return new HelloReply(this);
            }
            public const int MessageFieldNumber = 1;
            private string message_ = "";
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public string Message
            {
                get { return message_; }
                set
                {
                    message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override bool Equals(object other)
            {
                return Equals(other as HelloReply);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public bool Equals(HelloReply other)
            {
                if (ReferenceEquals(other, null))
                {
                    return false;
                }
                if (ReferenceEquals(other, this))
                {
                    return true;
                }
                if (Message != other.Message) return false;
                return true;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override int GetHashCode()
            {
                int hash = 1;
                if (Message.Length != 0) hash ^= Message.GetHashCode();
                return hash;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override string ToString()
            {
                return pb::JsonFormatter.ToDiagnosticString(this);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void WriteTo(pb::CodedOutputStream output)
            {
                if (Message.Length != 0)
                {
                    output.WriteRawTag(10);
                    output.WriteString(Message);
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public int CalculateSize()
            {
                int size = 0;
                if (Message.Length != 0)
                {
                    size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
                }
                return size;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(HelloReply other)
            {
                if (other == null)
                {
                    return;
                }
                if (other.Message.Length != 0)
                {
                    Message = other.Message;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(pb::CodedInputStream input)
            {
                uint tag;
                while ((tag = input.ReadTag()) != 0)
                {
                    switch (tag)
                    {
                        default:
                            input.SkipLastField();
                            break;
                        case 10:
                            {
                                Message = input.ReadString();
                                break;
                            }
                    }
                }
            }

        }

    }
}
