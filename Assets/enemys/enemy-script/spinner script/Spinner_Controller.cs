using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner_Controller : Snail_Script
{
    public bool movingToTarget;
    public Vector3 targetPos;
    public Vector3 startPos;
    public GameObject player;
    public Player_Controller player_script;

    // Start is called before the first frame update
    void Start()
    {
        Start();
        startPos = transform.position;
        targetPos = GetComponentInChildren<Spinner_Target>();
        target = new Vector3(target.transform.position, startPos.y, startPos.z);
        movingToTarget = true;
        player = GameObject.FindGameObjectWithTag("Player");
        player_script = player.GetComponent<Player_Controller>();
    }

    public void move()
    {
        if (movingToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            if (transform.position == targetPos)
            {
                movingToTarget = false;
                moveDir *= -1;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos, moveSpeed * Time.deltaTime);
            if (transform.position == startPos)
            {
                movingToTarget = true;
                moveDir *= -1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player_script.die();
        }
    }
}
