using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    public int lane = 1;
    public int maxLane = 3;

    public float laneWidth = 1;

    public float moveSpeed = 1;
    public float moveLaneSpeed = 3;

    protected Rigidbody2D rb2d;

    protected float startX;
    protected float destinationX;

  
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        startX = transform.position.x;
        destinationX = startX;

        moveLaneSpeed *= laneWidth;

        Debug.Log(GetComponent<SpriteRenderer>().sprite.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (destinationX == transform.position.x)
        {
            if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") > 0)
            {
                if (lane != maxLane)
                {
                    destinationX = transform.position.x + laneWidth;
                    lane++;
                }
            }
            else if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") < 0)
            {
                if (lane != 1)
                {
                    destinationX = transform.position.x - laneWidth;
                    lane--;
                }
            }
        }

        //transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * speed);

        if(destinationX == transform.position.x)
        {
            transform.position += new Vector3(0, -moveSpeed * Time.deltaTime);
        } else if (destinationX > transform.position.x)
        {
            transform.position += new Vector3(Mathf.Min(destinationX - transform.position.x, moveLaneSpeed * Time.deltaTime), -moveSpeed * Time.deltaTime);
        } else
        {
            transform.position += new Vector3(Mathf.Max(destinationX - transform.position.x, -moveLaneSpeed * Time.deltaTime), -moveSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log();

        string name = other.GetComponent<SpriteRenderer>().sprite.name;

        if(name.Equals("Rock") || name.Equals("Tree Ugly") || name.Equals("Water Block"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
