using UnityEngine;

namespace GunPatterns
{
    public interface IBulletShooter
    {
        bool CanShoot();

        int BulletsPerShot();
    }
}