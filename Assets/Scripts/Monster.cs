using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Character"))
        {
            Debug.Log("Touched");
            Destroy(other.gameObject);
            SceneManager.LoadScene("StartMenuScene");
        }
    }
}
