using static System.Formats.Asn1.AsnWriter;

namespace KiddiesQuiz
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 5;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                // work out the percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.dog;
                    questionsTab.Text = "What is the name of the animal?";
                    button1.Text = "Sheep";
                    button2.Text = "Dog";
                    button3.Text = "Rat";
                    button4.Text = "Rabbit";
                    correctAnswer = 2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Elephant;
                    questionsTab.Text = "What is the name of the animal?";
                    button1.Text = "Giraffe";
                    button2.Text = "Tiger";
                    button3.Text = "Lion";
                    button4.Text = "Elephant";
                    correctAnswer = 4;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.fish;
                    questionsTab.Text = "What is the name of the animal?";
                    button1.Text = "Fish";
                    button2.Text = "Horse";
                    button3.Text = "Ant";
                    button4.Text = "Donkey";
                    correctAnswer = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.pig;
                    questionsTab.Text = "What is the name of the animal?";
                    button1.Text = "Sheep";
                    button2.Text = "Pig";
                    button3.Text = "Fish";
                    button4.Text = "Dog";
                    correctAnswer = 2;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.tortoise;
                    questionsTab.Text = "What is the name of the animal?";
                    button1.Text = "Snail";
                    button2.Text = "Goat";
                    button3.Text = "Cat";
                    button4.Text = "Tortoise";
                    correctAnswer = 4;
                    break;
            }
        }
    }
}
