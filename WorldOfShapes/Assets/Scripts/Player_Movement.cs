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
    private Vector3 mousePos;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }



    private void Update()
    {
        MoveForword = rb.transform.position;
        rb.transform.position = new Vector3(MoveForword.x += rate, rb.transform.position.y, rb.transform.position.z);
        vertical = Input.GetAxisRaw("Vertical");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position) * Quaternion.Euler(0, 0, 90);
    }

    private void FixedUpdate()
    {
        
        rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        
        
    }
}
