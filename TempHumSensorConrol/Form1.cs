namespace TempHumSensorConrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
    private async void conectionTest()
		{
			var client = new Esp32TcpClient(tbIP.Text,(int)numPort.Value); // 子機のIP

			var command = new { cmd = "get_data" };
			var jsonDoc = await client.SendJsonCommandAsync(command);

			if (jsonDoc != null)
			{
				var root = jsonDoc.RootElement;
				float temp = root.GetProperty("temp").GetSingle();
				float hum = root.GetProperty("hum").GetSingle();

				MessageBox.Show($"温度: {temp:F1} °C\n湿度: {hum:F1} %", "センサーデータ");
			}
			else
			{
				MessageBox.Show("子機との通信に失敗しました", "エラー");
			}
		}
	}
