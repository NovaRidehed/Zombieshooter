namespace Zombieshooter
{
    public partial class Form1 : Form
    {
        List<Zombie> zombieList = new List<Zombie>();
        Weapon revolver = new Weapon(50, TimeSpan.FromMilliseconds(200));
        Weapon shotgun = new Weapon(200, TimeSpan.FromMilliseconds(600));

        System.Media.SoundPlayer shotgunSound =
            new System.Media.SoundPlayer(Properties.Resources.shotgun_sound);
        System.Media.SoundPlayer revolverSound =
            new System.Media.SoundPlayer(Properties.Resources.revolver_sound);
        System.Media.SoundPlayer deathSound =
            new System.Media.SoundPlayer(Properties.Resources.wilhelm_scream);
        System.Media.SoundPlayer zombieDeathSound =
            new System.Media.SoundPlayer(Properties.Resources.zombie_death);

        public Form1()
        {
            InitializeComponent();
            Zombie zombie = new Zombie(this, 100, 15, 0);
            zombieList.Add(zombie);
        }

        private void picShotgun_Click(object sender, EventArgs e)
        {
            shotgunSound.Play();
            // TODO test
            Zombie z1 = new Zombie(this, 10, 10, 10);
            zombieList.Add(z1);

            bool didFire = shotgun.Fire();
            if (didFire)
            {
                shotgunSound.Play();
            }
        }

        private void picRevolver_Click(object sender, EventArgs e)
        {
            zombieDeathSound.Play();
            //revolverSound.Play();
            // TODO test
            if (zombieList.Count > 0)
            {
                Zombie zombie = zombieList[0];
                zombie.Shoot(revolver);
            }
        }

        private void loseGameIfZombieIsBiting()
        {
            // TODO
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            foreach (Zombie zombie in zombieList)
            {
                zombie.Move(timerMove.Interval);
            }
            loseGameIfZombieIsBiting();
        }

        private void timerSpawn_Tick(object sender, EventArgs e)
        {
            Zombie zombie = new Zombie(this, 100, 15, 0);
            zombieList.Add(zombie);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }
    }
}