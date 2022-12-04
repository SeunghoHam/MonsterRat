using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    private static CameraManager _instnace;

    public static CameraManager instance
    {
        get { return _instnace; }
    }


    private CinemachineBrain brain;
    private GameObject CameraBase;
    [SerializeField] private GameObject cam_3;
    [SerializeField] private GameObject cam_1;
    private void Awake()
    {
        _instnace = this;
        brain = this.GetComponent<CinemachineBrain>();

        // TODO : 카메라 할당 해줘야함
        CameraBase =GameObject.Find("CameraBase");
        cam_3 = CameraBase.transform.GetChild(0).gameObject;
        cam_1 = CameraBase.transform.GetChild(1).gameObject;
        
        cam_3.SetActive(true);
        cam_1.SetActive(false);
    }

    private int count = 0;
    // 활|비활성화로 카메라 조절 가능.
    public void ChangeCamera()
    {
        if (count==0)
        {
            cam_1.SetActive(false);
            cam_3.SetActive(true);
            count++;
        }
        else
        {
            count = 0;
            cam_1.SetActive(true);
            cam_3.SetActive(false);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeCamera();
        }
    }
}
