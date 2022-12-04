using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playable_Megumi : CharacterBase
{
    private Rigidbody ratRigid;
    private float ratSpeed = 10f;
    private float jumpPower = 10f;

    private Animator _animator;
    private void Awake()
    {
        ratRigid = this.GetComponent<Rigidbody>();
        _animator = this.transform.GetChild(0).GetComponent<Animator>();
        _animator.SetFloat("Direction",0);
        // TODO : CharacterBase 에 정보 적용하기.
        base_moveObject = this.gameObject.transform;
        base_RotObject = this.gameObject.transform.GetChild(0);
        moveSpeed = ratSpeed;
        base_jumpPower = jumpPower;
        base_rigidBody = ratRigid;
    }
    

    protected override void action_Jump()
    {
        Debug.Log("점프!");
        base.action_Jump();
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
