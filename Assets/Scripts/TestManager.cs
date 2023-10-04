using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TestManager : MonoBehaviour
{
    public static TestManager main;
    int score;
    int module;
    int count;
    [SerializeField] GameObject[] question;
    [SerializeField] int start;
    [SerializeField] int[] countInModule;
    [SerializeField] TextMeshProUGUI[] textScore;
    [SerializeField] TextMeshProUGUI[] textPreScore;
    [Space]
    [SerializeField] bool pretest;
    [SerializeField] bool posttest;
    [SerializeField] string preText;
    [SerializeField] string postText;

    void Awake()
    {
        main = this;
    }

    void Start()
    {
        if (textPreScore.Length > 0)
        {
            for (int i = 0; i < textPreScore.Length; i++)
            {
                textPreScore[i].text = preText + PlayerPrefs.GetInt("PreTest" + i, 0) + "%";
            }
        }
        module = score = count = 0;
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
            question[start++].SetActive(true);
        }

        if (module < countInModule.Length && count > countInModule[module])
        {
            Debug.Log(countInModule[module] + " " + score);
            int percen = (int)((float)score / (float)countInModule[module] * 100);

            if (pretest)
            {
                PlayerPrefs.SetInt("PreTest" + module, percen);
            }
            if (posttest)
            {
                PlayerPrefs.SetInt("PostTest" + module, percen);
            }

            textScore[module].text = postText + percen + "%";
            module++;
            score = 0;
            count = 0;
        }

        count++;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Post_Test");
    }

    public void updateScore()
    {
        score += 1;
    }
}
