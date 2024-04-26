namespace Zombieshooter
{
    internal class Weapon
    {
        private int damage;
        private TimeSpan fireRate;
        private DateTime lastTimeFired = DateTime.Now;

        public Weapon(int damage, TimeSpan fireRate)
        {
            this.damage = damage;
            this.fireRate = fireRate;
        }

        public int GetDamage()
        {
            return damage;
        }

        public bool Fire()
        {
            if (lastTimeFired + fireRate >= DateTime.Now)
            {
                lastTimeFired = DateTime.Now;
                return true;
            }
            return false;
        }
    }
}
