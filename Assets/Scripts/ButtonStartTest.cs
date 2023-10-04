using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStartTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(StartTest);
    }

    // Update is called once per frame
    public void StartTest()
    {
        TestManager.main.Next();
    }
}
