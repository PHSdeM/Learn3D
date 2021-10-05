using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTwoX : MonoBehaviour
{
    public GameObject dogPrefab;

    [SerializeField]
    private float _waitBeforeSpawn = 1.5f;
    private float _timer;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time >= _timer)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                _timer = Time.time + _waitBeforeSpawn;
            }
        }
    }
}
