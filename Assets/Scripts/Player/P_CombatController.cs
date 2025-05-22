using UnityEngine;

public class P_CombatController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private Weapon currentWeapon;
    public Weapon CurrentWeapon
    {
        get { return currentWeapon; }
        set
        {
            switch (value.weaponType)
            {
                case WeaponType.GunWeapon:
                    currentWeapon = value;
                    break;
                case WeaponType.MeleeWeapon:
                    currentWeapon = value;
                    break;
                default:
                    currentWeapon = null;
                    break;
            }
        }
    }

    [SerializeField]
    private float currentFireRate;

    void Update()
    {
        FireRateCalc();
        TryFire();
    }

    private void FireRateCalc()
    {
        // 연사 속도 계산
        if (currentWeapon.fireRate > 0)
            currentFireRate -= Time.deltaTime;
    }

    private void TryFire()
    {
        // 총을 발사하는 로직
        if (InputManager.Instance.FireHeld && currentFireRate <= 0)
        {
            animator.SetTrigger("Fire");
            Fire();
        }
    }

    private void Fire()
    {
        currentFireRate = currentWeapon.fireRate;
        if(currentWeapon.weaponType == WeaponType.GunWeapon)
        {
            Shoot(currentWeapon as Gun);
        }
        else if (currentWeapon.weaponType == WeaponType.MeleeWeapon)
        {
            // 근접 무기 발사 로직
            Debug.Log("Melee Attack! " + currentWeapon.weaponName);
        }
    }

    private void Shoot(Gun currentGun)
    {
        // 총을 발사하는 로직
        // 총알 발사, 발사 소리 재생, 총구 화염 재생 등
        Debug.Log("Fire! " + currentGun.weaponName);
        currentGun.muzzleFlash.Play(); // 총구 화염 재생
        AudioSource.PlayClipAtPoint(currentGun.fireSound, transform.position); // 발사 소리 재생
    }

    private void SetWeapon(Weapon weapon)
    {

    }
}
