using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 7.5f;
    public float xRange = 14;
    // everything above this line works
    public float yRange = 14;
    public GameObject projectilePrefab;

    public Transform rightSpawner;
    public Transform leftSpawner;
    public Transform bottomSpawner;
    public Transform topSpawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the player around the map
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        // Keep the player in bounds on x axis
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //keep player in bounds on y axis
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(yRange, transform.position.x, transform.position.z);
        }
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(-yRange, transform.position.x, transform.position.z);
        }
        // Launch a projectile from the player
        if (Input.GetKeyDown(KeyCode.Space))
        {
           if (Input.GetKey(KeyCode.RightArrow))
            {
                Instantiate(projectilePrefab, rightSpawner.position, rightSpawner.rotation);
            }
           else if (Input.GetKey(KeyCode.LeftArrow))
            {
                Instantiate(projectilePrefab, leftSpawner.position, leftSpawner.rotation);
            }
           else if (Input.GetKey(KeyCode.UpArrow))
            {
                Instantiate(projectilePrefab, topSpawner.position, topSpawner.rotation);
            }
           else if (Input.GetKey(KeyCode.DownArrow))
            {
                Instantiate(projectilePrefab, bottomSpawner.position, bottomSpawner.rotation);
            }
        }
    }
}
