using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    private float stopwatch;
    void Update()
    {
        stopwatch += Time.deltaTime;

        if (stopwatch > 1)
        {
            Destroy(this.gameObject);
            stopwatch = 0f;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.StartsWith("Monster"))
        {
            Destroy(other.gameObject);
        }
    }
}
