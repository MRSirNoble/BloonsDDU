using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float speed;
    public float jump;
    public int tempForScriptableObject;
    public Currencyfloat coinsCollected;
    Rigidbody2D rb;
    public float distance;
    public float dartDistance;
    public LayerMask mask;
    public LayerMask dartMask;
    bool grounded;
    int jumpCount;
    public GameObject dartObject;
    public Transform spawnPosition;
    List<GameObject> baloonShotAt;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        baloonShotAt = new List<GameObject>();
    }

    // Update is called once per frame

    private void Update()
    {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.position, Vector2.down, distance, mask);
        Debug.DrawRay(transform.position, Vector2.down * distance, Color.red);
        if (hit)
        {
            Debug.Log(hit.collider.name);
            grounded = true;
            jumpCount = 1;
        }

        else
        {
            grounded = false;
        }

        RaycastHit2D balloonHit;
        balloonHit = Physics2D.Raycast(transform.position, Vector2.right, dartDistance, dartMask);
        Debug.DrawRay(transform.position, Vector2.right * dartDistance, Color.blue);
        if (balloonHit)
        {
            if(baloonShotAt.Contains(balloonHit.collider.gameObject) == false)
            {
                Debug.Log(baloonShotAt.Count);
                Instantiate(dartObject, spawnPosition.position, Quaternion.identity);
                baloonShotAt.Add(balloonHit.collider.gameObject);
            }
           
        }

         
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Mouse0) && (grounded == true || jumpCount > 0))
        {
            rb.velocity = new Vector2(speed, jump);
            jumpCount -= 1;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            coinsCollected.Currency += collision.gameObject.GetComponent<coinScript>().coins;
            Destroy(collision.gameObject);
        }
    }
}

