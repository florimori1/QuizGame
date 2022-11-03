namespace QuizGame
{
    public partial class Form1 : Form
    {
        int korrekteAntwort;
        int fragenZahl = 1;
        int score;
        int prozent;
        int totalAnzahlFragen;

        public Form1()
        {
            InitializeComponent();

            askQuestion(fragenZahl);

            totalAnzahlFragen = 6;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == korrekteAntwort)
            {
                score++; 
            }

            if(fragenZahl == totalAnzahlFragen)
            {
                prozent = (int)Math.Round((double)(score * 100) / totalAnzahlFragen);

                MessageBox.Show(
                    "Quiz vorbei!" + Environment.NewLine + 
                    "Du hast " + score + " Fragen korrekt beantwortet." + Environment.NewLine + 
                    "Somit hast du " + prozent + "% der Fragen richtig." + Environment.NewLine + 
                    "Dr�cke OK um erneut zu spielen!"
                    );

                score = 0;
                fragenZahl = 0;
                askQuestion(fragenZahl);
            }

            fragenZahl++;
            askQuestion(fragenZahl);
        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.deutschlandfrage1;

                    lblFrage.Text = "Wie viele Bundesl�nder gibt es in Deutschland?";

                    button1.Text = "13";
                    button2.Text = "14";
                    button3.Text = "15";
                    button4.Text = "16";

                    korrekteAntwort = 4;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.saarland;

                    lblFrage.Text = "Was ist die Landeshauptstadt von Saarland?";

                    button1.Text = "Saarburgen";
                    button2.Text = "Saarbr�cken";
                    button3.Text = "Saarlangen";
                    button4.Text = "Saarbr�ck";

                    korrekteAntwort = 2;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.zugspitze;

                    lblFrage.Text = "Wie hoch ist die Zugspitze?";

                    button1.Text = "2.900 m";
                    button2.Text = "2.600 m";
                    button3.Text = "3.200 m";
                    button4.Text = "2.200 m";

                    korrekteAntwort = 1;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.besatzungszonen;

                    lblFrage.Text = "Welche L�nder teilten nach dem Zweiten Weltkrieg Deutschland in verschiedene Besatzungszonen ein?";

                    button1.Text = "�sterreich, Niederlande, Italien und Frankreich";
                    button2.Text = "Schweiz, Slowenien, Sowjetunion und Belgien";
                    button3.Text = "USA, Japan, Frankreich und Gro�britannien";
                    button4.Text = "Gro�britannien, Sowjetunion, Frankreich und USA";

                    korrekteAntwort = 4;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.nachbarlaender;

                    lblFrage.Text = "Wie viele Nachbarl�nder besitzt Deutschland?";

                    button1.Text = "9";
                    button2.Text = "10";
                    button3.Text = "11";
                    button4.Text = "12";

                    korrekteAntwort = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.fluss;

                    lblFrage.Text = "Wie hei�t der l�ngste Fluss in Deutschland?";

                    button1.Text = "Rhein";
                    button2.Text = "Elbe";
                    button3.Text = "Donau";
                    button4.Text = "Main";

                    korrekteAntwort = 1;

                    break;
            }


        }
    }
}