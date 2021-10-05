using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -5.5f);

    // Update is called once per frame
    void LateUpdate()
    {
        // offset the camera behind the player by adding to the player position

        transform.position = player.transform.position + offset;
    }
}
