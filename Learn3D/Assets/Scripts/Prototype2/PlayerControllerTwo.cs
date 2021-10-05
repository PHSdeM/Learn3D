using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTwo : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject projectilePrefabs;
       
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        // Keep in the player bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.y);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.y);
        }

        horizontalInput = Input.GetAxis("Horizontal1");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed );

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefabs, transform.position, projectilePrefabs.transform.rotation);
        }
    }
}
