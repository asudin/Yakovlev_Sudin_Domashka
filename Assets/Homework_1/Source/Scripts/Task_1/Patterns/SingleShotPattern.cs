using UnityEngine;

namespace GunPatterns
{
    public class SingleShotPattern : IBulletShooter
    {
        private const int AmmoPerShot = 1;

        private int _totalAmmo;

        public SingleShotPattern(int totalAmmo)
        {
            _totalAmmo = AmmoPerShot >= totalAmmo ? AmmoPerShot : totalAmmo;
        }

        public bool CanShoot() => _totalAmmo > AmmoPerShot;

        public int BulletsPerShot()
        {
            if (CanShoot() == false)
            {
                Debug.Log($"No ammo left");
                return 0;
            }

            _totalAmmo -= AmmoPerShot;
            Debug.Log(_totalAmmo);

            return AmmoPerShot;
        }
    }
}