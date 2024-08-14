using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleFlip : MonoBehaviour
{
    public Rigidbody2D rb;
    public List<GameObject> targets = new List<GameObject>();
    public float rotateSpeed;
    public float Power = 1.5f;
    public bool HasWon;
    public bool IsAlive;
    void Start()
    {
        IsAlive = true;
        HasWon = false;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && IsAlive == true)
        {
            Jump();
        }
    }

    void Jump()
    {
        Vector3 newPosition = new Vector3(10f, 10f, 0f);
        rb.AddForce(newPosition * Power);
        rb.AddTorque(rotateSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle" && IsAlive)
        {
            IsAlive = false;
        }
        if (collision.gameObject.tag == "Ground" && IsAlive)
        {
            Power = 20;
        }
        if(collision.gameObject.tag != "Ground" && IsAlive)
        {
            Power = 15;
        }
    }
}
