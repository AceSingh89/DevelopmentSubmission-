using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        int games = 0;

        int computerScissorsHand = 0;
        int computerRockHand = 0;
        int computerPaperHand = 0;
        int computerLizardHand = 0;
        int computerSpockHand = 0;

        int humanPaperHand = 0;
        int humanRockHand = 0;
        int humanScissorsHand = 0;
        int humanSpockHand = 0;
        int humanLizardHand = 0;

        bool SpockLizard;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SpockLizard = false;

            humanPaper.Visible = false;
            humanRock.Visible = false;
            humanScissors.Visible = false;
            humanSpock.Visible = false;
            humanLizard.Visible = false;
            computerPaper.Visible = false;
            computerRock.Visible = false;
            computerScissors.Visible = false;
            computerSpock.Visible = false;
            computerLizard.Visible = false;

            btnLizard.Visible = false;
            btnSpock.Visible = false;

            rbtnNormal.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            humanPaper.Visible = false;
            humanRock.Visible = true;
            humanScissors.Visible = false;
            humanSpock.Visible = false;
            humanLizard.Visible = false;
            computerPaper.Visible = false;
            computerRock.Visible = false;
            computerScissors.Visible = false;
            computerLizard.Visible = false;
            computerSpock.Visible = false;

            humanRockHand = humanRockHand + 1;

            Random computer = new Random();
            int computerChoice;

            computerChoice = computer.Next(1, 4);

            if (SpockLizard)
            {
                computerChoice = computer.Next(1, 6);
            }

            if (computerChoice == 1)
            {
                computerRock.Visible = true;
                lblOutput.Text = "Tie!";
                games = games + 1;
                computerRockHand = computerRockHand + 1; 
            }
            else if (computerChoice == 2)
            {
                computerPaper.Visible = true;
                lblOutput.Text ="You Lose!";
                games = games + 1;
                computerPaperHand = computerPaperHand + 1;
            }
            else if (computerChoice == 3)
            {
                computerScissors.Visible = true;
                lblOutput.Text = "You Win!";
                games = games + 1;
                computerScissorsHand = computerScissorsHand + 1;
            }
            else if (computerChoice == 4)
            {
                computerSpock.Visible = true;
                lblOutput.Text = "You Lose!";
                games = games + 1;
                computerSpockHand = computerSpockHand + 1;
            }
            else if (computerChoice == 5)
            {
                computerLizard.Visible = true;
                lblOutput.Text = "You Win!";
                games = games + 1;
                computerLizardHand = computerLizardHand + 1;
            }

            
            lblGames.Text = games.ToString();

            if (humanScissorsHand > humanRockHand && humanScissorsHand > humanPaperHand && humanScissorsHand > humanSpockHand && humanScissorsHand > humanLizardHand)
            {
                lblHumanHand.Text = "Scissors";
            }

            else if (humanRockHand > humanScissorsHand && humanRockHand > humanPaperHand && humanRockHand > humanSpockHand && humanRockHand > humanLizardHand)
            {
                lblHumanHand.Text = "Rock";
            }

            else if (humanPaperHand > humanScissorsHand && humanPaperHand > humanRockHand && humanPaperHand > humanSpockHand && humanPaperHand > humanLizardHand)
            {
                lblHumanHand.Text = "Paper";
            }
            else if (humanLizardHand > humanScissorsHand && humanLizardHand > humanRockHand && humanLizardHand > humanSpockHand && humanLizardHand > humanPaperHand)
            {
                lblHumanHand.Text = "Lizard";
            }
            else if (humanSpockHand > humanScissorsHand && humanSpockHand > humanRockHand && humanSpockHand > humanLizardHand && humanSpockHand > humanPaperHand)
            {
                lblHumanHand.Text = "Spock";
            }

            if (computerScissorsHand > computerRockHand && computerScissorsHand > computerPaperHand && computerScissorsHand > computerSpockHand && computerScissorsHand > computerLizardHand)
            {
                lblComputerHand.Text = "Scissors";
            }

            else if (computerRockHand > computerScissorsHand && computerRockHand > computerPaperHand && computerRockHand > computerSpockHand && computerRockHand > computerLizardHand)
            {
                lblComputerHand.Text = "Rock";
            }

            else if (computerPaperHand > computerScissorsHand && computerPaperHand > computerRockHand && computerPaperHand > computerSpockHand && computerPaperHand > computerLizardHand)
            {
                lblComputerHand.Text = "Paper";
            }
            else if (computerLizardHand > computerScissorsHand && computerLizardHand > computerRockHand && computerLizardHand > computerSpockHand && computerLizardHand > computerPaperHand)
            {
                lblComputerHand.Text = "Lizard";
            }
            else if (computerSpockHand > computerScissorsHand && computerSpockHand > computerRockHand && computerSpockHand > computerLizardHand && computerSpockHand > computerPaperHand)
            {
                lblComputerHand.Text = "Spock";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            humanPaperHand = humanPaperHand + 1;

            humanPaper.Visible = true;
            humanRock.Visible = false;
            humanScissors.Visible = false;
            humanSpock.Visible = false;
            humanLizard.Visible = false;
            computerPaper.Visible = false;
            computerRock.Visible = false;
            computerScissors.Visible = false;
            computerLizard.Visible = false;
            computerSpock.Visible = false;

            Random computer = new Random();
            int computerChoice;

            computerChoice = computer.Next(1, 4);

            if (SpockLizard)
            {
                computerChoice = computer.Next(1, 6);
            }

            if (computerChoice == 1)
            {
                computerRock.Visible = true;
                lblOutput.Text = "You Win!";
                games = games + 1;
                computerRockHand = computerRockHand + 1;
            }
            else if (computerChoice == 2)
            {
                computerPaper.Visible = true;
                lblOutput.Text = "Tie!";
                games = games + 1;
                computerPaperHand = computerPaperHand + 1;
            }
            else if (computerChoice == 3)
            {
                computerScissors.Visible = true;
                lblOutput.Text = "You Lose!";
                games = games + 1;
                computerScissorsHand = computerScissorsHand + 1;
            }
            else if (computerChoice == 4)
            {
                computerSpock.Visible = true;
                lblOutput.Text = "You Win!";
                games = games + 1;
                computerSpockHand = computerSpockHand + 1;
            }
            else if (computerChoice == 5)
            {
                computerLizard.Visible = true;
                lblOutput.Text = "You Lose!";
                games = games + 1;
                computerLizardHand = computerLizardHand + 1;
            }

            lblGames.Text = games.ToString();

            if (humanScissorsHand > humanRockHand && humanScissorsHand > humanPaperHand && humanScissorsHand > humanSpockHand && humanScissorsHand > humanLizardHand)
            {
                lblHumanHand.Text = "Scissors";
            }

            else if (humanRockHand > humanScissorsHand && humanRockHand > humanPaperHand && humanRockHand > humanSpockHand && humanRockHand > humanLizardHand)
            {
                lblHumanHand.Text = "Rock";
            }

            else if (humanPaperHand > humanScissorsHand && humanPaperHand > humanRockHand && humanPaperHand > humanSpockHand && humanPaperHand > humanLizardHand)
            {
                lblHumanHand.Text = "Paper";
            }
            else if (humanLizardHand > humanScissorsHand && humanLizardHand > humanRockHand && humanLizardHand > humanSpockHand && humanLizardHand > humanPaperHand)
            {
                lblHumanHand.Text = "Lizard";
            }
            else if (humanSpockHand > humanScissorsHand && humanSpockHand > humanRockHand && humanSpockHand > humanLizardHand && humanSpockHand > humanPaperHand)
            {
                lblHumanHand.Text = "Spock";
            }

            if (computerScissorsHand > computerRockHand && computerScissorsHand > computerPaperHand && computerScissorsHand > computerSpockHand && computerScissorsHand > computerLizardHand)
            {
                lblComputerHand.Text = "Scissors";
            }

            else if (computerRockHand > computerScissorsHand && computerRockHand > computerPaperHand && computerRockHand > computerSpockHand && computerRockHand > computerLizardHand)
            {
                lblComputerHand.Text = "Rock";
            }

            else if (computerPaperHand > computerScissorsHand && computerPaperHand > computerRockHand && computerPaperHand > computerSpockHand && computerPaperHand > computerLizardHand)
            {
                lblComputerHand.Text = "Paper";
            }
            else if (computerLizardHand > computerScissorsHand && computerLizardHand > computerRockHand && computerLizardHand > computerSpockHand && computerLizardHand > computerPaperHand)
            {
                lblComputerHand.Text = "Lizard";
            }
            else if (computerSpockHand > computerScissorsHand && computerSpockHand > computerRockHand && computerSpockHand > computerLizardHand && computerSpockHand > computerPaperHand)
            {
                lblComputerHand.Text = "Spock";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            humanScissorsHand = humanScissorsHand + 1;
            
            humanPaper.Visible = false;
            humanRock.Visible = false;
            humanScissors.Visible = true;
            humanSpock.Visible = false;
            humanLizard.Visible = false;
            computerPaper.Visible = false;
            computerRock.Visible = false;
            computerScissors.Visible = false;
            computerLizard.Visible = false;
            computerSpock.Visible = false;

            Random computer = new Random();
            int computerChoice;

            computerChoice = computer.Next(1, 4);

            if (SpockLizard)
            {
                computerChoice = computer.Next(1, 6);
            }

            if (computerChoice == 1)
            {
                computerRock.Visible = true;
                lblOutput.Text = "You Lose!";
                games = games + 1;
                computerRockHand = computerRockHand + 1;
            }
            else if (computerChoice == 2)
            {
                computerPaper.Visible = true;
                lblOutput.Text = "You Win!";
                games = games + 1;
                computerPaperHand = computerPaperHand + 1;
            }
            else if (computerChoice == 3)
            {
                computerScissors.Visible = true;
                lblOutput.Text = "Tie!";
                games = games + 1;
                computerScissorsHand = computerScissorsHand + 1;
            }
            else if (computerChoice == 4)
            {
                computerSpock.Visible = true;
                lblOutput.Text = "You Win!";
                games = games + 1;
                computerSpockHand = computerSpockHand + 1;
            }
            else if (computerChoice == 5)
            {
                computerLizard.Visible = true;
                lblOutput.Text = "You Lose!";
                games = games + 1;
                computerLizardHand = computerLizardHand + 1;
            }

            lblGames.Text = games.ToString();

            if (humanScissorsHand > humanRockHand && humanScissorsHand > humanPaperHand && humanScissorsHand > humanSpockHand && humanScissorsHand > humanLizardHand)
            {
                lblHumanHand.Text = "Scissors";
            }

            else if (humanRockHand > humanScissorsHand && humanRockHand > humanPaperHand && humanRockHand > humanSpockHand && humanRockHand > humanLizardHand)
            {
                lblHumanHand.Text = "Rock";
            }

            else if (humanPaperHand > humanScissorsHand && humanPaperHand > humanRockHand && humanPaperHand > humanSpockHand && humanPaperHand > humanLizardHand)
            {
                lblHumanHand.Text = "Paper";
            }
            else if (humanLizardHand > humanScissorsHand && humanLizardHand > humanRockHand && humanLizardHand > humanSpockHand && humanLizardHand > humanPaperHand)
            {
                lblHumanHand.Text = "Lizard";
            }
            else if (humanSpockHand > humanScissorsHand && humanSpockHand > humanRockHand && humanSpockHand > humanLizardHand && humanSpockHand > humanPaperHand)
            {
                lblHumanHand.Text = "Spock";
            }

            if (computerScissorsHand > computerRockHand && computerScissorsHand > computerPaperHand && computerScissorsHand > computerSpockHand && computerScissorsHand > computerLizardHand)
            {
                lblComputerHand.Text = "Scissors";
            }

            else if (computerRockHand > computerScissorsHand && computerRockHand > computerPaperHand && computerRockHand > computerSpockHand && computerRockHand > computerLizardHand)
            {
                lblComputerHand.Text = "Rock";
            }

            else if (computerPaperHand > computerScissorsHand && computerPaperHand > computerRockHand && computerPaperHand > computerSpockHand && computerPaperHand > computerLizardHand)
            {
                lblComputerHand.Text = "Paper";
            }
            else if (computerLizardHand > computerScissorsHand && computerLizardHand > computerRockHand && computerLizardHand > computerSpockHand && computerLizardHand > computerPaperHand)
            {
                lblComputerHand.Text = "Lizard";
            }
            else if (computerSpockHand > computerScissorsHand && computerSpockHand > computerRockHand && computerSpockHand > computerLizardHand && computerSpockHand > computerPaperHand)
            {
                lblComputerHand.Text = "Spock";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNormal.Checked == true)
            {
                btnLizard.Visible = false;
                btnSpock.Visible = false;

                SpockLizard = false;

                computerScissorsHand = 0;
                computerRockHand = 0;
                computerPaperHand = 0;
                computerLizardHand = 0;
                computerSpockHand = 0;

                humanPaperHand = 0;
                humanRockHand = 0;
                humanScissorsHand = 0;
                humanSpockHand = 0;
                humanLizardHand = 0;
            }
        }

        private void rbtnSpockLizard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSpockLizard.Checked == true)
            {
                SpockLizard = true;

                btnLizard.Visible = true;
                btnSpock.Visible = true;
            }

            computerScissorsHand = 0;
            computerRockHand = 0;
            computerPaperHand = 0;
            computerLizardHand = 0;
            computerSpockHand = 0;

            humanPaperHand = 0;
            humanRockHand = 0;
            humanScissorsHand = 0;
            humanSpockHand = 0;
            humanLizardHand = 0;
        }

        private void btnLizard_Click(object sender, EventArgs e)
        {
            humanLizardHand = humanLizardHand + 1;

            humanPaper.Visible = false;
            humanRock.Visible = false;
            humanScissors.Visible = true;
            humanSpock.Visible = false;
            humanLizard.Visible = true;
            computerPaper.Visible = false;
            computerRock.Visible = false;
            computerScissors.Visible = false;
            computerLizard.Visible = false;
            computerSpock.Visible = false;

            Random computer = new Random();
            int computerChoice;

            computerChoice = computer.Next(1, 6);
            
            if (computerChoice == 1)
            {
                computerRock.Visible = true;
                lblOutput.Text = "You Lose!";
                games = games + 1;
                computerRockHand = computerRockHand + 1;
            }
            else if (computerChoice == 2)
            {
                computerPaper.Visible = true;
                lblOutput.Text = "You Win!";
                games = games + 1;
                computerPaperHand = computerPaperHand + 1;
            }
            else if (computerChoice == 3)
            {
                computerScissors.Visible = true;
                lblOutput.Text = "You Lose!";
                games = games + 1;
                computerScissorsHand = computerScissorsHand + 1;
            }
            else if (computerChoice == 4)
            {
                computerSpock.Visible = true;
                lblOutput.Text = "You Win!";
                games = games + 1;
                computerSpockHand = computerSpockHand + 1;
            }
            else if (computerChoice == 5)
            {
                computerLizard.Visible = true;
                lblOutput.Text = "Tie!";
                games = games + 1;
                computerLizardHand = computerLizardHand + 1;
            }

            lblGames.Text = games.ToString();

            if (humanScissorsHand > humanRockHand && humanScissorsHand > humanPaperHand && humanScissorsHand > humanSpockHand && humanScissorsHand >humanLizardHand)
            {
                lblHumanHand.Text = "Scissors";
            }

            else if (humanRockHand > humanScissorsHand && humanRockHand > humanPaperHand && humanRockHand > humanSpockHand && humanRockHand >humanLizardHand)
            {
                lblHumanHand.Text = "Rock";
            }

            else if (humanPaperHand > humanScissorsHand && humanPaperHand > humanRockHand && humanPaperHand > humanSpockHand && humanPaperHand >humanLizardHand)
            {
                lblHumanHand.Text = "Paper";
            }
            else if (humanLizardHand > humanScissorsHand && humanLizardHand > humanRockHand && humanLizardHand > humanSpockHand && humanLizardHand >humanPaperHand)
            {
                lblHumanHand.Text = "Lizard";
            }
            else if (humanSpockHand > humanScissorsHand && humanSpockHand > humanRockHand && humanSpockHand > humanLizardHand && humanSpockHand > humanPaperHand)
            {
                lblHumanHand.Text = "Spock";
            }

            if (computerScissorsHand > computerRockHand && computerScissorsHand > computerPaperHand && computerScissorsHand > computerSpockHand && computerScissorsHand > computerLizardHand)
            {
                lblComputerHand.Text = "Scissors";
            }

            else if (computerRockHand > computerScissorsHand && computerRockHand > computerPaperHand && computerRockHand > computerSpockHand && computerRockHand > computerLizardHand)
            {
                lblComputerHand.Text = "Rock";
            }

            else if (computerPaperHand > computerScissorsHand && computerPaperHand > computerRockHand && computerPaperHand > computerSpockHand && computerPaperHand > computerLizardHand)
            {
                lblComputerHand.Text = "Paper";
            }
            else if (computerLizardHand > computerScissorsHand && computerLizardHand > computerRockHand && computerLizardHand > computerSpockHand && computerLizardHand > computerPaperHand)
            {
                lblComputerHand.Text = "Lizard";
            }
            else if (computerSpockHand > computerScissorsHand && computerSpockHand > computerRockHand && computerSpockHand > computerLizardHand && computerSpockHand > computerPaperHand)
            {
                lblComputerHand.Text = "Spock";
            }
        }

        private void btnSpock_Click(object sender, EventArgs e)
        {
            humanSpockHand = humanSpockHand + 1;

            humanPaper.Visible = false;
            humanRock.Visible = false;
            humanScissors.Visible = false;
            humanSpock.Visible = true;
            humanLizard.Visible = false;
            computerPaper.Visible = false;
            computerRock.Visible = false;
            computerScissors.Visible = false;
            computerLizard.Visible = false;
            computerSpock.Visible = true;

            Random computer = new Random();
            int computerChoice;

            computerChoice = computer.Next(1, 6);

            if (computerChoice == 1)
            {
                computerRock.Visible = true;
                lblOutput.Text = "You Win!";
                games = games + 1;
                computerRockHand = computerRockHand + 1;
            }
            else if (computerChoice == 2)
            {
                computerPaper.Visible = true;
                lblOutput.Text = "You Lose!";
                games = games + 1;
                computerPaperHand = computerPaperHand + 1;
            }
            else if (computerChoice == 3)
            {
                computerScissors.Visible = true;
                lblOutput.Text = "You Win!";
                games = games + 1;
                computerScissorsHand = computerScissorsHand + 1;
            }
            else if (computerChoice == 4)
            {
                computerSpock.Visible = true;
                lblOutput.Text = "Tie!";
                games = games + 1;
                computerSpockHand = computerSpockHand + 1;
            }
            else if (computerChoice == 5)
            {
                computerLizard.Visible = true;
                lblOutput.Text = "You Lose!";
                games = games + 1;
                computerLizardHand = computerLizardHand + 1;
            }

            lblGames.Text = games.ToString();

            if (humanScissorsHand > humanRockHand && humanScissorsHand > humanPaperHand && humanScissorsHand > humanSpockHand && humanScissorsHand > humanLizardHand)
            {
                lblHumanHand.Text = "Scissors";
            }

            else if (humanRockHand > humanScissorsHand && humanRockHand > humanPaperHand && humanRockHand > humanSpockHand && humanRockHand > humanLizardHand)
            {
                lblHumanHand.Text = "Rock";
            }

            else if (humanPaperHand > humanScissorsHand && humanPaperHand > humanRockHand && humanPaperHand > humanSpockHand && humanPaperHand > humanLizardHand)
            {
                lblHumanHand.Text = "Paper";
            }
            else if (humanLizardHand > humanScissorsHand && humanLizardHand > humanRockHand && humanLizardHand > humanSpockHand && humanLizardHand > humanPaperHand)
            {
                lblHumanHand.Text = "Lizard";
            }
            else if (humanSpockHand > humanScissorsHand && humanSpockHand > humanRockHand && humanSpockHand > humanLizardHand && humanSpockHand > humanPaperHand)
            {
                lblHumanHand.Text = "Spock";
            }

            if (computerScissorsHand > computerRockHand && computerScissorsHand > computerPaperHand && computerScissorsHand > computerSpockHand && computerScissorsHand > computerLizardHand)
            {
                lblComputerHand.Text = "Scissors";
            }

            else if (computerRockHand > computerScissorsHand && computerRockHand > computerPaperHand && computerRockHand > computerSpockHand && computerRockHand > computerLizardHand)
            {
                lblComputerHand.Text = "Rock";
            }

            else if (computerPaperHand > computerScissorsHand && computerPaperHand > computerRockHand && computerPaperHand > computerSpockHand && computerPaperHand > computerLizardHand)
            {
                lblComputerHand.Text = "Paper";
            }
            else if (computerLizardHand > computerScissorsHand && computerLizardHand > computerRockHand && computerLizardHand > computerSpockHand && computerLizardHand > computerPaperHand)
            {
                lblComputerHand.Text = "Lizard";
            }
            else if (computerSpockHand > computerScissorsHand && computerSpockHand > computerRockHand && computerSpockHand > computerLizardHand && computerSpockHand > computerPaperHand)
            {
                lblComputerHand.Text = "Spock";
            }
        }
    }
}
