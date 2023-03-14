using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_Script : Snail_Script
{
    public bool movingToTarget;
    public Vector3 targetPos;
    public Vector3 startPos;

    private void Start()
    {
        Start();
        startPos = transform.position;
        targetPos = GetComponentInChildren<Slime_Target>();
        target = new Vector3(target.transform.position, startPos.y, startPos.z);
        movingToTarget = true;
    }

    public void move()
    {
        if (movingToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            if(transform.position == targetPos)
            {
                movingToTarget = false;
                moveDir *= -1;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos, moveSpeed * Time.deltaTime);
            if(transform.position == startPos)
            {
                movingToTarget = true;
                moveDir *= -1;
            }
        }
    }

    private void Update()
    {
        if (isActive)
        {
            animator.SetBool("isdead", isdead);
            move();
        }
    }

    private void OnBecameInvisible()
    {
        isActive = false;
    }



}
