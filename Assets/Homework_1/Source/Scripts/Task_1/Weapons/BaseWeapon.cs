using System.Collections;
using UnityEngine;

namespace GunPatterns
{
    public abstract class BaseWeapon : MonoBehaviour
    {
        [SerializeField] private Bullet _bullet;

        private IBulletShooter _weaponShooter;

        public void Initialize(IBulletShooter shootingPattern)
        {
            _weaponShooter = shootingPattern;
        }

        public void Shoot(Transform shootingPoint)
        {
            if (_weaponShooter.CanShoot() == false)
                return;

            StartCoroutine(ShootBullets(shootingPoint));
        }

        private IEnumerator ShootBullets(Transform shootingPoint)
        {
            var bulletsDelay = 0.1f;

            for (int i = 0; i < _weaponShooter.BulletsPerShot(); i++)
            {
                Instantiate(_bullet, shootingPoint.position, Quaternion.identity);

                yield return new WaitForSeconds(bulletsDelay);
            }
        }
    }
}