using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.35f;

    private Vector2 dest = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 temp = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(temp);
        if (Input.GetKey(KeyCode.W))
        {
            dest = (Vector2)transform.position + Vector2.up;
        }
        if ( Input.GetKey(KeyCode.S))
        {
            dest = (Vector2)transform.position + Vector2.down;
        }
        if ( Input.GetKey(KeyCode.A))
        {
            dest = (Vector2)transform.position + Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dest = (Vector2)transform.position + Vector2.right;
        }
    }
   
    
       
    

}
