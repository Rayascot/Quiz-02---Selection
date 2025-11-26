namespace Quiz_02___Selection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void q04InstructionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The user will enter the temperature in the first text box and answer if they brought a jacket in the second text box.  The output will be:\r\n\r\n“You should be comfortable” if If they brought a jacket and the temperature is below 15 , or they did not bring a jacket and the temperature is above 15\r\n\r\nIf they brought a jacket and the temperature is above 15 “You will be too hot”\r\n\r\nIf they did not bring a jacket and the temperature is below 15 “You are going to be cold”\r\n\r\nMake sure you add a try catch so there are no runtime errors.\r\n  For full marks use exactly three if statements ");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change the text in this message box to answer the question:  Provi de an example to explain why you would choose 'if..else if' instead of repeated 'if' statements");
        }
    }
}
