using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            float numa = float.Parse(WeightInput.Text);
            float numb = float.Parse(HeightInput.Text);
            float status = numa / (numb*numb)*704;
            string word = "";
            if (status <= 18.4) {
                word = "Underweight";
            }
            else if (status >= 18.5 && status <= 24.9 ){
                word = "Normal";
            }
            else if (status >= 25.0 && status <= 39.9)
            {
                word = "Overweight";
            }
            else if (status >= 40.0)
            {
                word = "Obese";
            }
            Output.Text = "BMI; "+Math.Round(status, 2).ToString()+"\nStatus: "+word;
        }

        private void HeightInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
