using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class textOutput : MonoBehaviour
{
    public TextMeshProUGUI dialogText;
    public string text = "Discover a fire accident\r\n-------analyzing-------\r\nLocation:Forest\r\nType:Forest fire\r\n------processing------\r\nSending to the Fire Station...\r\nSending successfully\r\n";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Typedialog(text));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Typedialog(string dialog)
    {
        dialogText.text = "";
        foreach (char letter in dialog)
        {
            dialogText.text += letter;
            yield return null;
        }
    }
}
