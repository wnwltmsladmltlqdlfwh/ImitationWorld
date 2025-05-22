using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance; // 싱글톤 인스턴스

    public GameObject player; // 플레이어 오브젝트

    void Awake()
    {
        // 싱글톤 인스턴스 설정
        if (instance == null)
            instance = this;
    }

    
}
