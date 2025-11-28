using System.Diagnostics.Eventing.Reader;

namespace Quiz_02___Selection
{
    public partial class Form1 : Form
    {//global varibles
        string secretpass;
        string music;
        int grade;
        string jacket;
        int temp;
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

        private void q1Button_Click(object sender, EventArgs e)
        {
            try
            {
                secretpass = Convert.ToString(q1TextBox.Text);
                if (secretpass == "banana")
                    q1OutputLabel.Text = "SECRET UNLOCKED";
                else
                    q1OutputLabel.Text = "try again";

            }
            catch
            {

            }
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            try
            {
                music = Convert.ToString(q2TextBox.Text);
                if (music == "r")
                    q2Outputlabel2.Text = "ROCK ON!";
                else if (music == "c")
                    q2Outputlabel2.Text = "GIDDY-UP!";
                else
                    q2Outputlabel2.Text = "That is not an option :(";
            }
            catch
            {

            }
        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            try
            {
                grade = Convert.ToInt32(q3TextBox.Text);
                switch (grade)
                {
                    case < 51:
                        q3OutputLabel.Text = "Fail";
                        break;
                    case < 80:
                        q3OutputLabel.Text = "You Pas sed";
                        break;
                    case > 79:
                        q3OutputLabel.Text = "Excellent Effort!";
                        break;

                }
            }
            catch
            {
                q3OutputLabel.Text = "enter a number";
            }
        }

        private void q4Button_Click(object sender, EventArgs e)
        {
            try
            {
                temp = Convert.ToInt32(q4TempTextBox.Text);
                jacket = Convert.ToString(q4CoatTextBox.Text);
                switch (temp)
                {
                    case < 15:
                        if (jacket == "y")
                            q4OutputLabel.Text = "you will be comfortable";
                        else if (jacket == "n")
                            q4OutputLabel.Text = "you may be cold";
                        break;
                    case > 15:
                        if (jacket == "y")
                            q4OutputLabel.Text = "you will be hot";
                        else if (jacket== "n")
                            q4OutputLabel.Text = "you will be comfortable";
                        break;

                }    
            }catch
            {
                q4OutputLabel.Text = "you may need to enter a number or enter y or n in the corrosponding textbox";
            }
        }
    }
}
