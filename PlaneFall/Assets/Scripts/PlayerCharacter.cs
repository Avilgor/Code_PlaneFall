using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//public Health : 1;

public class PlayerCharacter : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 1f;
    public Vector2 movement;
    // Start is called before the first frame update
    void Start()        //set objetos comprados en la tienda aqui
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.AddForce(direction * Speed);
    }
}
