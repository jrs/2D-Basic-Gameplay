using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30;
    public float lowerBounds = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > topBounds)
        {
            Destroy(this.gameObject);
        }
        else if(transform.position.y < lowerBounds)
        {
            Debug.Log("Game Over");
            Destroy(this.gameObject);
        }
    }
}
