using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    private bool isStarted = false;
    public Text startText;
    public GameObject startPanel;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isStarted == false)
        {
            isStarted = true;
            startText.gameObject.SetActive(true);
        }
        else if (isStarted)
        {
            startText.gameObject.SetActive(false);
            startPanel.gameObject.SetActive(false);

        }
    }

    public bool getIsStarted()
    {
        return isStarted;
    }
}
