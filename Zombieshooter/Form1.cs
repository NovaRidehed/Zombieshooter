using System.Windows.Forms;

namespace Zombieshooter
{
    public partial class Form1 : Form
    {
        // lista som inneh�ller alla levande zombies
        List<Zombie> zombieList = new List<Zombie>();

        // vapen med olika egenskaper
        Weapon revolver = new Weapon(50, TimeSpan.FromMilliseconds(200), "revolver");
        Weapon shotgun = new Weapon(200, TimeSpan.FromMilliseconds(600), "shotgun");

        public int score = 1;

        // ljudeffekt f�r shotgun
        System.Media.SoundPlayer shotgunSound =
            new System.Media.SoundPlayer(Properties.Resources.shotgun_sound);

        // ljudeffekt f�r revolver
        System.Media.SoundPlayer revolverSound =
            new System.Media.SoundPlayer(Properties.Resources.revolver_sound);

        // ljudeffekt f�r n�r spelaren d�r
        System.Media.SoundPlayer deathSound =
            new System.Media.SoundPlayer(Properties.Resources.wilhelm_scream);

        // ljudeffekt f�r n�r zombie d�r
        System.Media.SoundPlayer zombieDeathSound =
            new System.Media.SoundPlayer(Properties.Resources.zombie_death);

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 1. Avfyra shotgunen om det inte �verskrider "firing rate"
        /// 2. Den n�rmase zombien skadas
        /// 3. Om den skadade zombien f�rlorar alla sina HP d�r den och spelaren f�r po�ng
        /// </summary>
        private void picShotgun_Click(object sender, EventArgs e)
        {
            shotgunSound.Play();

            bool didFire = shotgun.Fire();
            if (didFire && zombieList.Count > 0)
            {
                zombieList[0].Shoot(shotgun);
            }
        }

        public void removeFirstZombie()
        {
            zombieList.RemoveAt(0);
            labelScore.Text = "Score: " + score++;
            
        }

        /// <summary>
        /// 1. Avfyra revolvern om det inte �verskrider "firing rate"
        /// 2. Den n�rmase zombien skadas
        /// 3. Om den skadade zombien f�rlorar alla sina HP d�r den och spelaren f�r po�ng
        /// </summary>
        private void picRevolver_Click(object sender, EventArgs e)
        {
            revolverSound.Play();

            bool didFire = revolver.Fire();
            if (didFire && zombieList.Count > 0)
            {
                zombieList[0].Shoot(revolver);
            }
        }

        /// <summary>
        /// Kontrollera om en zombie kommit hela v�gen fram. Kommer en zombie hela v�gen fram
        /// f�rlorar man spelet.
        /// </summary>
        private void loseGameIfZombieIsBiting()
        {
            if (zombieList.Count > 0 && zombieList[0].IsBiting())
            {
                deathSound.Play();
                labelYouDied.Visible = true;
                labelYouDied.BringToFront();
                timerMove.Stop();
                timerSpawn.Stop();
            }
            // TODO om zombie kommit hela v�gen fram f�rlorar man spelet
        }

        /// <summary>
        /// Flytta alla zombies. Kontrollera om n�gon kommit �nda fram.
        /// </summary>
        private void timerMove_Tick(object sender, EventArgs e)
        {
            foreach (Zombie zombie in zombieList)
            {
                zombie.Move(timerMove.Interval);
            }
            loseGameIfZombieIsBiting();
        }

        /// <summary>
        /// Skapa (eng. spawn) en ny zombie och l�gg till i listan.
        /// </summary>
        private void timerSpawn_Tick(object sender, EventArgs e)
        {
            Zombie zombie = new Zombie(this, 800, 15, 0);
            zombieList.Add(zombie);
        }

        /// <summary>
        /// Starta spelet n�r man klickar p� knappen.
        /// </summary>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(zombieList.Count > 0)
            {
                restart();
            }
            timerMove.Start();
            timerSpawn.Start();
            labelYouDied.Visible = false;
        }
        private void restart()
        {
            score = 0;
            labelScore.Text = "Score: " + score;
            while(zombieList.Count > 0)
            {
                zombieList[0].resetZombie();
                zombieList.RemoveAt(0);
            }
        }
    }
}