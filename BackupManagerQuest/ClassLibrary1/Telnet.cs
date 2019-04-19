using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using TentacleSoftware.Telnet;

namespace GetBackup
{
    public class Telnet
    {
        private string IPAddress;
        private string Username;
        private string Password;

        public Telnet(string ip, string username, string password)
        {
            this.IPAddress = ip;
            this.Username = username;
            this.Password = password;
        }

        public async void Start()
        {
            CancellationTokenSource source = new CancellationTokenSource();
            var telnetClient = new TelnetClient( IPAddress, 1153, TimeSpan.FromSeconds(10), source.Token);
            telnetClient.ConnectionClosed += HandleConnectionClosed;
            telnetClient.MessageReceived +=  HandleMessage;
            await telnetClient.Connect();
            Thread.Sleep(10000);
            await telnetClient.Send(Username);
            await telnetClient.Send(Password);
            await telnetClient.Send("get all");
            telnetClient.Disconnect();
        }

        private void HandleConnectionClosed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HandleMessage(object sender, string s)
        {
            throw new NotImplementedException();
        }
    }
}
