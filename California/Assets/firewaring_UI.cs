using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firewaring_UI : MonoBehaviour
{
    public static bool isFireUI = false;

    public GameObject Forest_Ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isFireUI)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Forest_Ui.SetActive(false);
        Time.timeScale = 1f;
        isFireUI = false;

    }

    void Pause()
    {
        Forest_Ui.SetActive(true);
        Time.timeScale = 0;
        isFireUI = true;
    }
}
