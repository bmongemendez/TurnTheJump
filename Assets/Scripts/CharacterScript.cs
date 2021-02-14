using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterScript : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private float directionX;
    private float maxScore = 0.0f;
    private GameManager gmanager;
    public GameObject bulletPrefab;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0f;
        rb2d.velocity = Vector3.zero;
        gmanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gmanager.getIsStarted())
        {
            rb2d.gravityScale = 5f;

            if (rb2d.velocity.y > 0 && transform.position.y > maxScore)
            {
                maxScore = transform.position.y;

                ScoreManager.instance.sumScore(maxScore);
            }

            if (transform.position.y < maxScore - 50f)
            {
                Destroy(this.gameObject);
                SceneManager.LoadScene("StartMenuScene");
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                shoot();
            }

        }
    }

    void FixedUpdate()
    {
        if (gmanager.getIsStarted())
        {

            if (this.GetComponent<Rigidbody2D>().velocity.x > 0)
            {
                this.GetComponent<SpriteRenderer>().flipX = false;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().flipX = true;
            }

            if (Input.GetMouseButton(0))
            {
                followMouse();
            }
        }
    }

    private void followMouse()
    {
        Vector3 mousePosition = Input.mousePosition;

        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        directionX = mousePosition.x - transform.position.x;

        Vector2 direction = new Vector2(directionX, rb2d.velocity.y);

        moveCharacter(direction);
    }

    private void moveCharacter(Vector2 direction)
    {
        rb2d.velocity = direction;
    }

    private void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);

        Vector3 mousePosition = Input.mousePosition;

        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        directionX = mousePosition.x - transform.position.x;

        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(directionX, 50f);

    }
}















