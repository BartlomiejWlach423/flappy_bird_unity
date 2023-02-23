using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float JumpHeight;
    public float mass;
    Rigidbody rB;
    public bool IsHit = false;
    private void Start()
    {
        rB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rB.velocity = new Vector3( speed, rB.velocity.y, rB.velocity.z);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(JumpHeight<5.5f)
            {
                JumpHeight += 0.025f;
                speed += 0.05f;
                mass += 0.06f;
                rB.mass = mass;
            }
            rB.velocity = new Vector3(speed, JumpHeight, rB.velocity.z);
        }
        if(transform.position.y > 7.4f)
        {
            transform.position = new Vector3(transform.position.x, 7.2f, transform.position.z);
            rB.velocity = new Vector3(rB.velocity.x, 0, 0);
        }
        else if(transform.position.y < 0.4f)
        {
            transform.position = new Vector3(transform.position.x, 0.4f, transform.position.z);
            rB.velocity = new Vector3(rB.velocity.x, 0, 0);
        }
        transform.rotation = Quaternion.Euler(rB.velocity.y - 45, -87.763f, 268.256f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        IsHit = true;
    }
}
