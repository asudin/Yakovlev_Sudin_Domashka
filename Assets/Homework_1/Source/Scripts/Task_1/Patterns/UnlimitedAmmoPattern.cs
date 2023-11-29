namespace GunPatterns
{
    public class UnlimitedAmmoPattern : IBulletShooter
    {
        private const int AmmoPerShot = 1;

        public bool CanShoot() => true;

        public int BulletsPerShot() => AmmoPerShot;
    }
}