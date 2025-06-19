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
			var client = new Esp32TcpClient(tbIP.Text,(int)numPort.Value); // �q�@��IP

			var command = new { cmd = "get_data" };
			var jsonDoc = await client.SendJsonCommandAsync(command);

			if (jsonDoc != null)
			{
				var root = jsonDoc.RootElement;
				float temp = root.GetProperty("temp").GetSingle();
				float hum = root.GetProperty("hum").GetSingle();

				MessageBox.Show($"���x: {temp:F1} ��C\n���x: {hum:F1} %", "�Z���T�[�f�[�^");
			}
			else
			{
				MessageBox.Show("�q�@�Ƃ̒ʐM�Ɏ��s���܂���", "�G���[");
			}
		}
	}
