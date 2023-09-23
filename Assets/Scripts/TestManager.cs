using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestManager : MonoBehaviour
{
    public static TestManager main;
    [SerializeField] GameObject[] question;
    [SerializeField] int start;

    [SerializeField] int questionNumbers;
    int score;
    [SerializeField] TextMeshProUGUI textScore;

    void Awake()
    {
        main = this;
    }

    void Start()
    {
        Next();
    }

    public void OnCorrect()
    {
        Next();
    }

    public void OnIncorrect()
    {
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

    public void updateScore()
    {
        score += 1;
        textScore.text = ((int)(((float)score / (float)questionNumbers) * 100)).ToString() + "%";
    }
}
