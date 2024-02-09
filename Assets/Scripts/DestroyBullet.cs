using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    private float leftBound = -15;
    private float rightBound = 15;
    private float topBound = 15;
    private float bottomBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players view in the game, remove that object
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < bottomBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }
    }
}
