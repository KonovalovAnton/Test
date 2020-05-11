using System;
using System.Windows.Forms;

namespace TestFormFirst
{
    public partial class Form1 : Form
    {
        Pet pet;
        //System.Timers.Timer aTimer;
        System.Windows.Forms.Timer aTimer;
        System.Windows.Forms.Timer bTimer;        
        DateTime date1 = DateTime.Now;

        public Form1()
        {
            InitializeComponent();

            pet = new Pet();
            UpdateParameters();

            //aTimer = new System.Timers.Timer(1000)
            //aTimer.Elapsed += OnChangeParameters;
            //aTimer.AutoReset = true;
            //aTimer.Enabled = true;
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

        private void CheckData()
        {
            labelEnergyPlus.Text = null;
            var delta = PetStatusChanges.Delta[pet.Status]; //со словарем не совсем понятна работа
            
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

        private void OnChangeParameters(object sender, EventArgs e) //у нас нет ни объекта входящего, ни аргумента, нахрена они указываются?
        {
           
            var delta = PetStatusChanges.Delta[pet.Status]; //со словарем не совсем понятна работа

            foreach (var item in delta)
            {                
                pet.Parameters[item.Key] += item.Value;                               
                   
                if (pet.Parameters[item.Key] < 0)
                {
                    pet.Parameters[item.Key] = 0;                   
                }

                if(pet.Parameters[item.Key] > 100)
                {
                    pet.Parameters[item.Key] = 100;                    
                }

               
            }
            UpdateParameters();
        }

        private void UpdateParameters()
        {
            Mood.Value = pet.Parameters[ParameterType.Mood];
            Hunger.Value = pet.Parameters[ParameterType.Hunger];
            Energy.Value = pet.Parameters[ParameterType.Energy];
            Walk.Value = pet.Parameters[ParameterType.Walk];

            labelEnergyStatus.Text = pet.Parameters[ParameterType.Energy].ToString();
            labelHungerStatus.Text = pet.Parameters[ParameterType.Hunger].ToString();
            labelMoodStatus.Text = pet.Parameters[ParameterType.Mood].ToString();
            labelWalkStatus.Text = pet.Parameters[ParameterType.Walk].ToString();            
        }
               

        private void ClickPlay(object sender, EventArgs e)
        {
            pet.Status = Status.Playing;
            labelStatus.Text = "Playing";
            pictureBox1.Image = Properties.Resources.playing;
            CheckData();
        }

        private void ClickSleep(object sender, EventArgs e)
        {
            pet.Status = Status.Sleeping;
            labelStatus.Text = "Sleeping";
            pictureBox1.Image = Properties.Resources.sleep;
            CheckData();
        }

        private void ClickEat(object sender, EventArgs e)
        {
            pet.Status = Status.Eating;
            labelStatus.Text = "Eating";
            pictureBox1.Image = Properties.Resources.eat;
            CheckData();
        }

        private void ClickWalk(object sender, EventArgs e)
        {
            pet.Status = Status.Walking;
            labelStatus.Text = "Walking";
            pictureBox1.Image = Properties.Resources.walking;
            CheckData();
        }

        private void ClickIdle(object sender, EventArgs e)
        {
            pet.Status = Status.Idle;
            labelStatus.Text = "Idle";
            pictureBox1.Image = Properties.Resources.nothing;
            CheckData();
        }

       
    }
}
