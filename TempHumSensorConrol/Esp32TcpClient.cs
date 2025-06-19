using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TempHumSensorConrol
{
	public class Esp32TcpClient
	{
		public string IpAddress { get; set; }
		public int Port { get; set; } = 5000;
		public int TimeoutMs { get; set; } = 5000;

		private string _result = "";
		public string Result { get { return _result; } }

		public Esp32TcpClient(string ipAddress, int port = 5000)
		{
			IpAddress = ipAddress;
			Port = port;
		}

		public async Task<JsonDocument?> SendJsonCommandAsync(object command)
		{
			using TcpClient client = new TcpClient();
			try
			{
				_result = "";
				var connectTask = client.ConnectAsync(IpAddress, Port);
				if (await Task.WhenAny(connectTask, Task.Delay(TimeoutMs)) != connectTask)
					throw new TimeoutException("接続タイムアウト");

				using NetworkStream stream = client.GetStream();

				// JSON を送信（末尾に \n）
				string jsonOut = JsonSerializer.Serialize(command);
				byte[] sendBytes = Encoding.UTF8.GetBytes(jsonOut + "\n");
				await stream.WriteAsync(sendBytes);

				// 応答を受信
				byte[] buffer = new byte[1024];
				int read = await stream.ReadAsync(buffer);
				if (read == 0) throw new Exception("応答なし");

				string response = Encoding.UTF8.GetString(buffer, 0, read);
				_result = response;
				var doc = JsonDocument.Parse(pickupJson(response));
				return doc;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"[ESP32通信エラー] {ex.Message}");
				return null;
			}
		}
		public string pickupJson(string s)
		{
			string ret = "";
			if(s == null) return ret;
			s = s.Trim();
			if (s.Length <=5) return ret;
			int idx0 = s.IndexOf("{");
			int idx1 = s.LastIndexOf("}");

			if ((idx0 >= 0) && (idx0 + 1 < idx1))
			{
				ret = s.Substring(idx0, idx1-idx0+1);
			}
			return ret;
		}


	}
}
