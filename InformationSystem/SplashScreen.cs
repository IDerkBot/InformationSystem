using System;
using System.Windows.Forms;

namespace InformationSystem
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                new Auth().Show();
                this.Hide();
            }
        }
        private void OpacityShow()
        {
            //прозрачность формы 0 - невидима 1-полностью видна
            Opacity = 0;
            //новый экзмемпляр таймера   
            Timer timerOpacity = new Timer();
            //привязываем к таймеру событие
            timerOpacity.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 1) timerOpacity.Stop();//увеличиваем прозрачность если форма полносью видна отключаем таймер
            });
            //интервал таймера в милисекундах 
            timerOpacity.Interval = 40;
            timerOpacity.Start();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            OpacityShow();
        }
    }
}
