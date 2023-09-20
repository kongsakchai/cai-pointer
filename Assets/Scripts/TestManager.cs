using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    public static TestManager main;
    [SerializeField] GameObject[] question;
    [SerializeField] int start;
    void Awake()
    {
        main = this;
    }

    void Start()
    {
        Next();
    }

    public void OnCorrect(){
        Next();
    }

    public void OnIncorrect(){
        Next();
    }

    public void Next()
    {
        if (start > 0)
        {
            question[start - 1].SetActive(false);
        }
        if (start < question.Length)
        {
            question[start++].SetActive(false);
        }
    }
}
