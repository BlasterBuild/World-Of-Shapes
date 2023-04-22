using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    private float rate = 0.01f;
    private Vector2 MoveForword;
    private float vertical;
    private float speed = 10.0f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    private void Update()
    {
        MoveForword = rb.transform.position;
        rb.transform.position = new Vector3(MoveForword.x += rate, rb.transform.position.y, rb.transform.position.z);
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, vertical*speed);
    }
}
