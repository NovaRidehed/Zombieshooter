namespace Zombieshooter
{
    internal class Zombie
    {
        private const int MAX_LEFT = 1163;
        private const int MIN_LEFT = 350;

        private int hitPoints;
        private int speedPercentPerSec;
        private int locationPercent;

        private Form form;
        private PictureBox pic;
        private Label label;

        public Zombie(Form form, int hitPoints, int speedPercentPerSec, int locationPercent)
        {
            this.hitPoints = hitPoints;
            this.speedPercentPerSec = speedPercentPerSec;
            this.locationPercent = locationPercent;
            this.form = form;

            pic = newPic();
            label = newLabel();
            form.Controls.Add(pic);
            form.Controls.Add(label);
            pic.BringToFront();
            label.BringToFront();

            updateView();

        }

        public void Move(int millis)
        {
            int distancePercent = (millis * speedPercentPerSec) / 1000;
            locationPercent = Math.Min(100, locationPercent + distancePercent);
            updateView();            
        }

        public void Shoot(Weapon weapon)
        {
            // TODO create damage and maybe die
            die();
        }

        public bool IsDead()
        {
            // TODO
            return false;
        }

        public bool IsBiting()
        {
            return locationPercent == 100;
        }

        private void die()
        {
            // TODO sound effect
            form.Controls.Remove(pic);
            form.Controls.Remove(label);
        }

        private void updateView()
        {
            pic.Left = MIN_LEFT + (100 - locationPercent) * (MAX_LEFT - MIN_LEFT) / 100;
            label.Left = pic.Left;
        }

        private static PictureBox newPic()
        {
            PictureBox pic = new PictureBox();
            pic.Image = Properties.Resources.zombie;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Top = 12;
            pic.Left = 0; // set elsewhere
            pic.Width = 300;
            pic.Height = 380;
            pic.BackColor = Color.Transparent;
            return pic;
        }

        private static Label newLabel()
        {
            Label label = new Label();
            label.Font = new Font("Stencil", 14, FontStyle.Bold);
            label.Top = 12;
            label.Left = 0; // set elsewhere
            label.Width = 120;
            label.Text = "HP: 999"; // set elsewhere
            label.ForeColor = Color.White;
            label.BackColor = Color.Transparent;
            return label;
        }
    }
}
