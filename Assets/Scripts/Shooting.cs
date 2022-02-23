using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed_shooting;

    private Vector2 MousePosition, ObjectPosition;
    private Vector3 lastposition;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = rb.velocity = transform.right * speed_shooting;
        lastposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (lastposition != transform.position){
            transform.right = transform.position - lastposition;
            lastposition = transform.position;
        }
    }
}
