using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playable_Rat : CharacterBase
{
    private Rigidbody ratRigid;
    private float ratSpeed = 10f;
    private float jumpPower = 10f;
    private void Awake()
    {
        ratRigid = this.GetComponent<Rigidbody>();
        // TODO : CharacterBase 에 정보 적용하기.
        base_moveObject = this.gameObject.transform;
        base_RotObject = this.gameObject.transform.GetChild(0);
        moveSpeed = ratSpeed;
        base_jumpPower = jumpPower;
        base_rigidBody = ratRigid;
    }

    protected override void KeyDown_W()
    {
        Debug.Log("나 이동중!");
        base.KeyDown_W();
    }

    protected override void action_Jump()
    {
        Debug.Log("점프!");
        base.action_Jump();
    }

    protected override void KeyUp_W()
    {
        //Debug.Log("전진 애니메이션 없도록");
        base.KeyUp_W();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            // 이속 빨라지기
            moveSpeed += 2f;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            action_Jump();
        }
        base_Movement();
        base_MouseRotator();
    }
}
