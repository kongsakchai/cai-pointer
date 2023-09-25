using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TestManager : MonoBehaviour
{
    public static TestManager main;
    [SerializeField] GameObject[] question;
    [SerializeField] int start;

    [SerializeField] int questionNumbers;
    int score;
    [SerializeField] TextMeshProUGUI textScore;
    [SerializeField] bool pretest;
    [SerializeField] bool posttest;
    [Space]
    [SerializeField] TextMeshProUGUI textPreScore;

    void Awake()
    {
        main = this;
    }

    void Start()
    {
        Next();
        if (textPreScore != null)
        {
            textPreScore.text = PlayerPrefs.GetInt("PreTest", 0) + "%";
        }
    }

    public void Next()
    {
        if (start > 0)
        {
            question[start - 1].SetActive(false);
        }

        if (start < question.Length)
        {
            question[start++].SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Post_Test");
    }

    public void updateScore()
    {
        score += 1;
        int percen = (int)((float)score / (float)questionNumbers * 100);
        textScore.text = percen + "%";

        if (pretest)
        {
            PlayerPrefs.SetInt("PreTest", percen);
        }

        if (posttest)
        {
            PlayerPrefs.SetInt("PostTest", percen);
        }
    }
}
