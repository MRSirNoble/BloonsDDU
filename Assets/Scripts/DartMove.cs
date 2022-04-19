using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartMove : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;
    public Currencyfloat coinsCollected;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.gameObject.tag == "Enemy")
        {
            coinsCollected.Currency += collision.gameObject.GetComponent<coinScript>().coins;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
