using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    protected Transform base_moveObject;
    protected Transform base_RotObject;
    protected Rigidbody base_rigidBody;

    
    protected float moveSpeed;
    protected float base_jumpPower;
    private float posX;
    private float posZ;
    private float posY;

    protected float GetMoveSpeed()
    {
        return moveSpeed;
    }


    private float horizontal;
    private float vertical;
    protected void base_Movement()
    {
        // GetAxis = -1.0~ 1.0 값이 서서히 변함
        // GetAxisRaw= = -1,0,1 3개의 값이 존재함
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        Vector3 nor_direction =  new Vector3(horizontal, 0, vertical).normalized;
        Vector3 moveDirection =Vector3.zero;


        if (nor_direction.magnitude >= 0.1f) // 입력된 이동이 있는 경우에만
        {
            if (nor_direction.x >= 0.1f) // horizontal value
            {
                moveDirection += base_RotObject.transform.right;
            }
            else if (nor_direction.x <= -0.1f)
            {
                moveDirection -= base_RotObject.transform.right;
            }

            if (nor_direction.z >= 0.1f)
            {
                moveDirection += base_RotObject.transform.forward;
            }
            else if (nor_direction.z <= -0.1f)
            {
                moveDirection -= base_RotObject.transform.forward;
            }

            base_moveObject.Translate(
                moveDirection * moveSpeed * Time.deltaTime
            );
        }
        //else // 입력이 없는 경우
            //returnDirection(Vector3.zero);

    }

    /*
    protected Vector2 returnDirection()
    {
        return new Vector2(Direction.x, Direction.y);
    }*/

    protected virtual void KeyDown_W()
    {
        posZ += moveSpeed * Time.deltaTime;
        base_moveObject.transform.localPosition +=
            new Vector3(
                0,0, posZ
                );
        Debug.Log("움직이는 속도1 : " + moveSpeed);
    }
    
    
    
    protected virtual void KeyUp_W()
    {
        
    }

    void KeyDown_A()
    {
        
    }

    void KeyUp_A()
    {
        
    }

    void Keydown_S()
    {
        
    }

    void KeyUp_S()
    {
        
    }

    void KeyDown_D()
    {
        
    }

    void KeyUp_D()
    {
        
    }
    protected virtual void action_Jump()
    {
        base_rigidBody.AddForce(new Vector3(0,1f,0) * base_jumpPower, ForceMode.Impulse);
    }

    protected virtual void KeyDown_Flying()
    {
        
    }

    private float mouseX;
    private float mouseY;
    private float sensitivity = 0.8f;
    
    
    protected void base_MouseRotator()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitivity;
        mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        base_RotObject.transform.eulerAngles +=
            new Vector3(-0, mouseX, 0);
    }
}