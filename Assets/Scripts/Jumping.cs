using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    // Start is called before the first frame update
    Camera m_MainCamera;

    private void Start()
    {
        m_MainCamera = Camera.main;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0 && collision.gameObject.CompareTag("Character"))
        {
            if (this.gameObject.name.StartsWith("Platform"))
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 700f);
            }
            else if (this.gameObject.name.StartsWith("SuperJump"))
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 1500f);

            }
            else if (this.gameObject.name.StartsWith("Rotate"))
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 700f);
                if (Camera.main.transform.rotation == Quaternion.Euler(0, 0, 90f))
                {
                    Camera.main.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    Camera.main.transform.rotation = Quaternion.Euler(0, 0, 90f);
                }


            }
        }
    }
}
