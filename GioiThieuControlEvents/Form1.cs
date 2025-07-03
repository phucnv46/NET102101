namespace GioiThieuControlEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // Ep kiểu chuyển đổi sender thành button 
            switch (button.Text)
            {
                default:
                    break;
                case "+":
                    {
                        numericUpDownKQ.Value = numericUpDown1.Value + numericUpDown2.Value;
                        break;
                    }
                case "-":
                    {
                        numericUpDownKQ.Value = numericUpDown1.Value - numericUpDown2.Value;
                        break;
                    }
                case "*":
                    {
                        numericUpDownKQ.Value = numericUpDown1.Value * numericUpDown2.Value;
                        break;
                    }
                case "/":
                    {
                        if (numericUpDown2.Value == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0");
                            return;
                        }
                        numericUpDownKQ.Value = numericUpDown1.Value / numericUpDown2.Value;
                        break;
                    }
            }

        }
    }
}
