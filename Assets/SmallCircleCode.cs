using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCircleCode : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;

    bool controlMove = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!controlMove)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "turningcircletag")
        {
            transform.SetParent(collision.transform);
            controlMove = true;
            Debug.Log("toxundu");
        }
    }
}
