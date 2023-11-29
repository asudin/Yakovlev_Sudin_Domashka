namespace GunPatterns
{
    public class MultipleShotsPattern : IBulletShooter
    {
        private const int AmmoPerShot = 3;

        private int _totalAmmo;

        public MultipleShotsPattern(int ammo)
        {
            _totalAmmo = AmmoPerShot >= ammo ? AmmoPerShot : ammo;
        }

        public bool CanShoot() => _totalAmmo > AmmoPerShot;

        public int BulletsPerShot()
        {
            if (CanShoot() == false)
                return 0;

            _totalAmmo -= AmmoPerShot;

            return AmmoPerShot;
        }
    }
}