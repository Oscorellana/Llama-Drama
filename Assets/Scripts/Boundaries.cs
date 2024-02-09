using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectDimensions;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectDimensions = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectDimensions = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectDimensions, screenBounds.x - objectDimensions);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + objectDimensions, screenBounds.y - objectDimensions);
        transform.position = viewPos;
    }
}
