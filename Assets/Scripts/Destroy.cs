using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject character;

    public GameObject platformPrefab;
    public GameObject superJumpPrefab;
    public GameObject monsterFrogPrefab;
    public GameObject monsterPinkPrefab;
    public GameObject monserMaskPrefab;
    public GameObject rotatePlatformPrefab;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector2 newPlatformPosition = new Vector2(Random.Range(-7.5f, 7.5f), character.transform.position.y + (36 + Random.Range(0.5f, 1.0f)));

        if (collision.gameObject.name.StartsWith("Platform"))
        {
            if (Random.Range(1, 12) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(superJumpPrefab, newPlatformPosition, Quaternion.identity);
                selectMonsterToInstantiate(newPlatformPosition);
            }
            else if (Random.Range(1, 25) == 1)
            {
                Instantiate(rotatePlatformPrefab, newPlatformPosition, Quaternion.identity);
                selectMonsterToInstantiate(newPlatformPosition);
            }
            else
            {
                collision.gameObject.transform.position = newPlatformPosition;
                selectMonsterToInstantiate(newPlatformPosition);
            }
        }
        if (collision.gameObject.name.StartsWith("Rotate"))
        {
            if (Random.Range(1, 12) == 1)
            {

                Instantiate(superJumpPrefab, newPlatformPosition, Quaternion.identity);
                selectMonsterToInstantiate(newPlatformPosition);
            }
            else if (Random.Range(1, 25) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(rotatePlatformPrefab, newPlatformPosition, Quaternion.identity);
                selectMonsterToInstantiate(newPlatformPosition);
            }
            else
            {
                collision.gameObject.transform.position = newPlatformPosition;
                selectMonsterToInstantiate(newPlatformPosition);
            }
        }
        else if (collision.gameObject.name.StartsWith("SuperJump"))
        {
            if (Random.Range(1, 12) == 1)
            {
                collision.gameObject.transform.position = newPlatformPosition;
                selectMonsterToInstantiate(newPlatformPosition);
            }
            else if (Random.Range(1, 25) == 1)
            {
                Instantiate(rotatePlatformPrefab, newPlatformPosition, Quaternion.identity);
                selectMonsterToInstantiate(newPlatformPosition);
            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, newPlatformPosition, Quaternion.identity);
                selectMonsterToInstantiate(newPlatformPosition);
            }
        }
        if (collision.gameObject.name.StartsWith("Monster"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void selectMonsterToInstantiate(Vector2 position)
    {
        if (Random.Range(1, 15) == 15)
        {
            instatiateMonsters(monsterFrogPrefab, position);
        }
        else if (Random.Range(1, 25) == 15)
        {
            instatiateMonsters(monsterPinkPrefab, position);
        }
        else if (Random.Range(1, 35) == 15)
        {
            instatiateMonsters(monserMaskPrefab, position);
        }
    }

    private void instatiateMonsters(GameObject prefab, Vector2 position)
    {
        Instantiate(prefab, position, Quaternion.identity);
    }
}
