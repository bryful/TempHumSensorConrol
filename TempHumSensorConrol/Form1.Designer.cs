namespace TempHumSensorConrol
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			SensorList = new ListBox();
			gbTCP = new GroupBox();
			numPort = new NumericUpDown();
			btnAddList = new Button();
			btnTest = new Button();
			label3 = new Label();
			tbID = new TextBox();
			label2 = new Label();
			label1 = new Label();
			tbIP = new TextBox();
			button1 = new Button();
			groupBox1 = new GroupBox();
			gbTCP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numPort).BeginInit();
			SuspendLayout();
			// 
			// SensorList
			// 
			SensorList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			SensorList.FormattingEnabled = true;
			SensorList.ItemHeight = 15;
			SensorList.Location = new Point(12, 26);
			SensorList.Name = "SensorList";
			SensorList.Size = new Size(229, 229);
			SensorList.TabIndex = 0;
			// 
			// gbTCP
			// 
			gbTCP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			gbTCP.Controls.Add(numPort);
			gbTCP.Controls.Add(btnAddList);
			gbTCP.Controls.Add(btnTest);
			gbTCP.Controls.Add(label3);
			gbTCP.Controls.Add(tbID);
			gbTCP.Controls.Add(label2);
			gbTCP.Controls.Add(label1);
			gbTCP.Controls.Add(tbIP);
			gbTCP.Location = new Point(12, 268);
			gbTCP.Name = "gbTCP";
			gbTCP.Size = new Size(229, 170);
			gbTCP.TabIndex = 1;
			gbTCP.TabStop = false;
			gbTCP.Text = "TpcConnection";
			// 
			// numPort
			// 
			numPort.Location = new Point(58, 55);
			numPort.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
			numPort.Name = "numPort";
			numPort.Size = new Size(149, 23);
			numPort.TabIndex = 8;
			numPort.Value = new decimal(new int[] { 12345, 0, 0, 0 });
			// 
			// btnAddList
			// 
			btnAddList.Location = new Point(132, 128);
			btnAddList.Name = "btnAddList";
			btnAddList.Size = new Size(75, 23);
			btnAddList.TabIndex = 7;
			btnAddList.Text = "AddList";
			btnAddList.UseVisualStyleBackColor = true;
			// 
			// btnTest
			// 
			btnTest.Location = new Point(17, 128);
			btnTest.Name = "btnTest";
			btnTest.Size = new Size(75, 23);
			btnTest.TabIndex = 6;
			btnTest.Text = "Test";
			btnTest.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(23, 88);
			label3.Name = "label3";
			label3.Size = new Size(18, 15);
			label3.TabIndex = 5;
			label3.Text = "ID";
			// 
			// tbID
			// 
			tbID.Location = new Point(56, 84);
			tbID.Name = "tbID";
			tbID.Size = new Size(151, 23);
			tbID.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(23, 59);
			label2.Name = "label2";
			label2.Size = new Size(29, 15);
			label2.TabIndex = 3;
			label2.Text = "Port";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(23, 30);
			label1.Name = "label1";
			label1.Size = new Size(17, 15);
			label1.TabIndex = 1;
			label1.Text = "IP";
			// 
			// tbIP
			// 
			tbIP.Location = new Point(56, 26);
			tbIP.Name = "tbIP";
			tbIP.Size = new Size(151, 23);
			tbIP.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(259, 26);
			button1.Name = "button1";
			button1.Size = new Size(75, 49);
			button1.TabIndex = 2;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			groupBox1.Location = new Point(247, 232);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(541, 206);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "groupBox1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(groupBox1);
			Controls.Add(button1);
			Controls.Add(gbTCP);
			Controls.Add(SensorList);
			Name = "Form1";
			Text = "Form1";
			gbTCP.ResumeLayout(false);
			gbTCP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numPort).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private ListBox SensorList;
		private GroupBox gbTCP;
		private Label label2;
		private Label label1;
		private TextBox tbIP;
		private Button btnAddList;
		private Button btnTest;
		private Label label3;
		private TextBox tbID;
		private Button button1;
		private GroupBox groupBox1;
		private NumericUpDown numPort;
	}
}
