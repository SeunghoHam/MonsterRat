using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameManager : MonoBehaviour
{
    // TODO : 현재 포제스중인 객체의 정보를 저장시켜놔야함
    
    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState =  CursorLockMode.Confined;
    }

    void Update()
    {
        // 마우스 커서 활성 / 비활성화
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
        }
    }
}
