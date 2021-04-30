using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CutSceneController : MonoBehaviour
{
    public GameObject textBox;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenCutScene()
    {
        gameObject.SetActive(true);
    }

    public void CloseCutScene()
    {
        gameObject.SetActive(false);
    }

    public void DisplayText(string text)
    {
        textBox.GetComponent<TextMeshProUGUI>().text = text;
    }
}
