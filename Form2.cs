using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace hypapp_test2
{
    public partial class Form2 : Form
    {
        IWebDriver dr = new ChromeDriver();
        SpeechRecognitionEngine recg = new SpeechRecognitionEngine();
        SpeechSynthesizer synth = new SpeechSynthesizer();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MaximizeBox = true;
            Choices commands = new Choices();
            commands.Add(new string[] { "hello assistant", "who is the best", "f1 in schools info", "about the challenge", "team info", "team members info", "stop", "sponsors", "how are you ", "thank you", "about da team", });
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(commands);
            Grammar g2 = new Grammar(gb);

            recg.LoadGrammarAsync(g2);
            recg.SetInputToDefaultAudioDevice();
            recg.SpeechRecognized += recg_SpeechRecognized;

        }

        private void recg_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Result.Text == "hello assistant")
            {

                synth.SpeakAsync("Greetings! I am HB assistant. I can tell you many things about our team. So lets get started. Use the voice commands to interact with me");

            }
            else if (e.Result.Text == "f1 in schools info")
            {
                synth.SpeakAsync("F1 in Schools is an international STEM competition for school children in which groups of 3–6 students have to design and manufacture a miniature out of the official F1 Model Block using CAD/CAM design tools. The cars are powered by C O 2 cartridges and are attached to a track by a nylon wire. They are timed from the moment they are launched to when they pass the finish line by a computer. It raises awareness of STEM and Formula 1");

            }
            /* else if (e.Result.Text == "about the challenge")
             {

                 synth.SpeakAsync("Spanning age ranges of 9 to 19 our main objective is to help change the perceptions of science, technology, engineering and maths by creating a fun and exciting learning environment for young people to develop an informed view about careers in engineering, Formula 1, science, marketing and technology.");
                 synth.SpeakAsync("F1 in Schools Ltd is a social enterprise working with committed industry partners to provide an exciting yet challenging educational experience through the magnetic appeal of Formula 1, f1 in schools is the only truly global educational programme that raises awareness of STEM and Formula 1 among students and school children in every region, in every country, on every continent.");
             }*/
            else if (e.Result.Text == "who is the best")
            {
                synth.SpeakAsync("Hyperbolt");



            }
            else if (e.Result.Text == "team info")
            {

                synth.SpeakAsync("HyperBolt was awarded the team identity award, sponsorship and marketting award and were crowned pressure challenge winners. We were nominated for 7 more awards. Hyperbolt has been crowned regional champions");



            }
            else if (e.Result.Text == "team values")
            {
                synth.SpeakAsync("Result-oriented, Committed, Adaptable, Innovative, Daring, Socially responsible, Trustworthy, Supportive, Organized, Creative");



            }
            else if (e.Result.Text == "team members info")
            {

                synth.SpeakAsync("Aaryan. Team Manager, Design Engineer, Graphic Designer and project manager. He has an experience of 3 years in the competition. This season, Aaryan has developed various prototypes for the car, he has planned outcomes of our documents using project management techniques and has maintained a strong team identity that makes the word hyperbolt ring bells when heard. The World Finals podium is where, Aaryan aspires to be.");
                synth.SpeakAsync("Siddharth. Manufacturing manager and research analyst. He, has had the experience in f1 in schools for over 2 years in a row. This season, He has been closely analyzing the various designs of the car and suggesting improvements for a better car. Siddharth also has gathered a database of material properties that was useed to decide the strength and weight of the car. He also coded 2 bots to bring innovation to the team. The World Finals podium is where, Siddharth aspires to be.");
                synth.SpeakAsync("Shaurya. Sponsorship and resource Manager . Shaurya is the resource manager of the team. The budget for the team was planned initially and accordingly sponsorship and marketing activities were planned to achieve that. He has been successful in bringing cash sponsorships for the team. Alongside, he been promoting the team and F1 in Schools at various platforms. The World Finals podium is where, Shaurya aspires to be.");

            }
            else if (e.Result.Text == "stop")
            {

                synth.SpeakAsyncCancelAll();


            }
            else if (e.Result.Text == "challenge")
            {

                synth.SpeakAsync("Our biggest challenge to reach the World finals has been the formation of our team when given an opportunity to participate as one of our team members dropped out of the competition");


            }


            else if (e.Result.Text == "thank you")
            {
                synth.SpeakAsync("you are welcome. Have a nice day");



            }
            else if (e.Result.Text == "sponsors")
            {
                synth.SpeakAsync("Hyperbolt's sponsors are: Launch your career, bubuno, Share india, OCI cables and our collaboratos are 3D paradise, Abec 3, 5, 7, and F M A E");

            }
            else if (e.Result.Text == "learning")
            {
                synth.SpeakAsync("Creativity, Collaboration and Problem solving");
            }


            else if (e.Result.Text == "how are you")
            {

                synth.SpeakAsync("I am doing just fine. I hope you are too.");

            }
            else if (e.Result.Text == "car info")
            {

                synth.SpeakAsync("We are calling our car H B 21 after the way cars are named in formula 1");

            }
            else
            {
                synth.SpeakAsync("Sorry, I cannot understand");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recg.RecognizeAsync(RecognizeMode.Multiple);
            button2.Enabled = true;
            button1.Enabled = false;
            synth.SpeakAsync("Hello! I am HB assistant! please use the voice commands to interact with me. Incase I cannot recognize your voice, use buttons.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recg.RecognizeAsyncStop();
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("F1 in Schools is an international STEM competition for school children in which groups of 3–6 students have to design and manufacture a miniature out of the official F1 Model Block using CAD/CAM design tools. The cars are powered by C O 2 cartridges and are attached to a track by a nylon wire. They are timed from the moment they are launched to when they pass the finish line by a computer. It raises awareness of STEM and Formula 1");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("Aaryan. Team Manager, Design Engineer, Graphic Designer and project manager. He has an experience of 3 years in the competition. This season, Aaryan has developed various prototypes for the car, he has planned outcomes of our documents using project management techniques and has maintained a strong team identity that makes the word hyperbolt ring bells when heard. The World Finals podium is where, Aaryan aspires to be.");
            synth.SpeakAsync("Siddharth. Manufacturing manager and research analyst. He, has had the experience in f1 in schools for over 2 years in a row. This season, He has been closely analyzing the various designs of the car and suggesting improvements for a better car. Siddharth also has gathered a database of material properties that was useed to decide the strength and weight of the car. He also coded 2 bots to bring innovation to the team. The World Finals podium is where, Siddharth aspires to be.");
            synth.SpeakAsync("Shaurya. Sponsorship and resource Manager . Shaurya is the resource manager of the team. The budget for the team was planned initially and accordingly sponsorship and marketing activities were planned to achieve that. He has been successful in bringing cash sponsorships for the team. Alongside, he been promoting the team and F1 in Schools at various platforms. The World Finals podium is where, Shaurya aspires to be.");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("Hyperbolt's sponsors are: Launch your career, bubuno, Share india, OCI cables and our collaboratos are 3D paradise, Abec 3, 5, 7, and F M A E");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("HyperBolt was awarded the team identity award, sponsorship and marketting award and were crowned pressure challenge winners. We were nominated for 7 more awards. Hyperbolt has been crowned regional champions");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // dr.Navigate().GoToUrl("https://www.instagram.com");
            //Thread.Sleep(5000);
            try
            {
                dr.Navigate().GoToUrl("https://www.hyperbolt.in");
                // Thread.Sleep(5000);
            }
            catch (Exception)
            {
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("Oh no! Looks like you have cloesed the chrome tab. Restart this application and try again");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("Result-oriented, Committed, Adaptable, Innovative, Daring, Socially responsible, Trustworthy, Supportive, Organized, Creative");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("Our biggest challenge to reach the World finals has been the formation of our team when given an opportunity to participate as one of our team members dropped out of the competition");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("Creativity, Collaboration and Problem solving");

        }

        private void button12_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("car name: HB21. Length: 202 millimeters. Height: 55.5 millimeter. Width: 72 millimeter. Weight: 62grams ");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
