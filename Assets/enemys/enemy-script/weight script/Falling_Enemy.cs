using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Enemy : MonoBehaviour
{
    public float fallSpeed;
    public Rigidbody2D rig;
    public GameObject player;
    public Player_Controller player_script;
    public Vector3 startPos;
    public bool canFall;




    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.gravityScale = 0;
        player = GameObject.FindGameObjectWithTag("Player");
        player_script = player.GetComponent<Player_Controller>();
        canFall = true;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void resetPos()
    {

    }


}
