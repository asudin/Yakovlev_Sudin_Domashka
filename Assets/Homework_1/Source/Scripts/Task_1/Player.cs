using System.Collections.Generic;
using UnityEngine;

namespace GunPatterns
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private List<BaseWeapon> _weapons;
        [SerializeField] private Transform _weaponPosition;
        [SerializeField] private Transform _inventory;

        private const KeyCode _singleShotGunKey = KeyCode.Q;
        private const KeyCode _threeShotGunKey = KeyCode.W;
        private const KeyCode _unlimitedAmmoGunKey = KeyCode.E;
        private BaseWeapon _currentWeapon;

        private void Awake()
        {
            _currentWeapon = Instantiate(_weapons[0], _inventory.position, Quaternion.identity);
            _currentWeapon.Initialize(new SingleShotPattern(50));
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _currentWeapon?.Shoot(_weaponPosition);
            }

            if (Input.GetKeyDown(_singleShotGunKey))
            {
                ChangeWeapon(_singleShotGunKey);
            }

            if (Input.GetKeyDown(_threeShotGunKey))
            {
                ChangeWeapon(_threeShotGunKey);
            }

            if (Input.GetKeyDown(_unlimitedAmmoGunKey))
            {
                ChangeWeapon(_unlimitedAmmoGunKey);
            }
        }

        private void ChangeWeapon(KeyCode key)
        {
            if (_weapons.Count == 0)
                return;

            Destroy(_currentWeapon);

            switch (key)
            {
                case KeyCode.Q:
                    _currentWeapon = Instantiate(_weapons[0], _inventory.position, Quaternion.identity);
                    _currentWeapon.Initialize(new SingleShotPattern(50));
                    break;

                case KeyCode.W:
                    _currentWeapon = Instantiate(_weapons[1], _inventory.position, Quaternion.identity);
                    _currentWeapon.Initialize(new MultipleShotsPattern(50));
                    break;

                case KeyCode.E:
                    _currentWeapon = Instantiate(_weapons[2], _inventory.position, Quaternion.identity);
                    _currentWeapon.Initialize(new UnlimitedAmmoPattern());
                    break;

                default:
                    _currentWeapon = Instantiate(_weapons[0], _inventory.position, Quaternion.identity);
                    _currentWeapon.Initialize(new SingleShotPattern(50));
                    break;
            }

            Debug.Log($"Selected weapon: {_currentWeapon}.");
        }
    }
}