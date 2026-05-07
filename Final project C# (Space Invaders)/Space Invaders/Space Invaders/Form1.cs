namespace Space_Invaders
{
    public partial class WelcomeForm : Form
    {

        public WelcomeForm()
        {
            InitializeComponent();

        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            SettingForm settings = new SettingForm();
            settings.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string Nickname;
            Nickname = tbName.Text;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void bStart_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.ShowDialog();
        }
    }
}