using UnityEngine;

public enum GunType
{
    Pistol = 0,
    Rifle = 1,
    Shotgun = 2,
}

public class Gun : Weapon  // 총 클래스는 Weapon 클래스를 상속받습니다.
{
    public float range; // 사정거리
    public float accuracy;  // 정확도
    public float reloadTime;    // 재장전 속도

    public int reloadBulletCount; // 장전할 총알 수
    public int currentBulletCount; // 현재 장탄 수
    public int maxBulletCount; // 총의 최대 장탄 수
    public int carryBulletCount; // 총의 최대 휴대 가능 총알 수

    public float retroActionForce; // 반동 세기
    public float retroActionFineSightForce; // 정조준 반동 세기

    public ParticleSystem muzzleFlash; // 총구 화염

    public AudioClip fireSound; // 발사 소리
}
