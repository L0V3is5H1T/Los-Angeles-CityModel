using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textFlash : MonoBehaviour
{
    public GameObject flashtext;
    int flashtime=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flashtime += 1;
        if (flashtime == 50)
        {
            flashtext.SetActive(false);
        }
        else if (flashtime == 100)
        {
            flashtext.SetActive(true);
            flashtime = 0;
        }
    }
}
