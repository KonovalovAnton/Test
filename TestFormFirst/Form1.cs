using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestFormFirst
{
    public partial class Form1 : Form
    {
        Model.Tamagochi pet;
        Model.TamagochiController tamagochiController;

        System.Windows.Forms.Timer aTimer;
        System.Windows.Forms.Timer bTimer;        
        DateTime date1 = DateTime.Now;

        Dictionary<ParameterType, ProgressBar> _progressBars;
        Dictionary<ParameterType, Label> _labels;

        public Form1(ModelProvider modelProvider, ControllerProvider controllerProvider)
        {
            InitializeComponent();

            _progressBars = new Dictionary<ParameterType, ProgressBar>()
            {
                [ParameterType.Energy] = Energy,
                [ParameterType.Hunger] = Hunger,
                [ParameterType.Mood] = Mood,
                [ParameterType.Walk] = Walk
            };

            _labels = new Dictionary<ParameterType, Label>()
            {
                [ParameterType.Energy] = labelEnergyStatus,
                [ParameterType.Hunger] = labelHungerStatus,
                [ParameterType.Mood] = labelMoodStatus,
                [ParameterType.Walk] = labelWalkStatus
            };

            tamagochiController = controllerProvider.TamagochiController;
            pet = modelProvider.Model.Pet;
            SubscribeParameters();
            pet.Init();

            aTimer = new System.Windows.Forms.Timer();
            aTimer.Tick += new EventHandler(OnChangeParameters);
            aTimer.Interval = 1000;
            aTimer.Start();          
            
            bTimer = new System.Windows.Forms.Timer();
            aTimer.Tick += new EventHandler(TimerChanger);
            bTimer.Interval = 1000;
            bTimer.Start();

            CheckData();
        }

        private void SubscribeParameters()
        {
            pet.OnParamsChanged += OnParameterChange;
        }

        private void UnsubscribeParameters()
        {
            pet.OnParamsChanged -= OnParameterChange;
        }

        private void OnParameterChange(ParameterType arg1, int arg2, int arg3)
        {
            _progressBars[arg1].Value = arg3;
            _labels[arg1].Text = arg3.ToString();
        }

        private void CheckData()
        {
            labelEnergyPlus.Text = null;
            var delta = PetStatusChanges.Delta[pet.GetStatus()];
            
            foreach (var item in delta)
            {               
                labelEnergyPlus.Text += $"{item.Key} : {item.Value} \n";
            }
                
        }

        private void TimerChanger(object sender, EventArgs e)
        {
            DateTime X = DateTime.Now;
            label5.Text ="Текущая дата и время: " + X.ToString(/*"HH:mm:ss"*/);
            labelTimer.Text = "Прошло с начала игры: " + X.Subtract(date1).ToString(/*"HH:mm:ss"*/); //почему-то не может показывать в таком формате
        }

        private void OnChangeParameters(object sender, EventArgs e)
        {
            tamagochiController.UpdateDelta();
        }    

        private void ClickPlay(object sender, EventArgs e)
        {
            pet.SetStatus(Status.Playing);
            labelStatus.Text = "Playing";
            pictureBox1.Image = Properties.Resources.playing;
            CheckData();
        }

        private void ClickSleep(object sender, EventArgs e)
        {
            pet.SetStatus(Status.Sleeping);
            labelStatus.Text = "Sleeping";
            pictureBox1.Image = Properties.Resources.sleep;
            CheckData();
        }

        private void ClickEat(object sender, EventArgs e)
        {
            pet.SetStatus(Status.Eating);
            labelStatus.Text = "Eating";
            pictureBox1.Image = Properties.Resources.eat;
            CheckData();
        }

        private void ClickWalk(object sender, EventArgs e)
        {
            pet.SetStatus(Status.Walking);
            labelStatus.Text = "Walking";
            pictureBox1.Image = Properties.Resources.walking;
            CheckData();
        }

        private void ClickIdle(object sender, EventArgs e)
        {
            pet.SetStatus(Status.Idle);
            labelStatus.Text = "Idle";
            pictureBox1.Image = Properties.Resources.nothing;
            CheckData();
        }

       
    }
}
