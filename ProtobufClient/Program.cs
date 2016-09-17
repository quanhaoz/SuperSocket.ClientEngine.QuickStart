using System;
using System.IO;
using System.Net;
using Google.Protobuf;
using SuperSocket.ClientEngine;

namespace ProtobufClient
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			EasyClient client = new EasyClient();
            client.Initialize(new ProtobufReceiveFilter(), (info =>
            {
                switch (info.Type)
                {
                    case DefeatMessage.Types.Type.BackMessage:
                        Console.WriteLine("BackMessage:{0}", info.Body.BackMessage.Content);
                        break;
                    case DefeatMessage.Types.Type.CallMessage:
                        Console.WriteLine("CallMessage:{0}", info.Body.CallMessage.Content);
                        break;

                }
            }));
		    var flag = client.ConnectAsync(new DnsEndPoint("127.0.0.1", 2012));
		    if (flag.Result)
		    {
               
		           

                using (var stream = new MemoryStream())
                {

                    CodedOutputStream os = new CodedOutputStream(stream);

                    for (int i = 0; i < 10; i++)
                    {
                        var callMessage = (new CallMessage());
                        callMessage.Content = ("Hello I am form C# client by SuperSocket ClientEngine "+i);
                        var message = new DefeatMessage();
                        message.CallMessage = callMessage;

                        os.WriteMessage(message);

                        os.Flush();

                        byte[] data = stream.ToArray();
                        client.Send(new ArraySegment<byte>(data));
                        stream.Position = 0;
                     
                    }
                   
                }
                
            }
            Console.ReadKey();
        }

    }
}
