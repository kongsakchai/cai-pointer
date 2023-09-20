using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MultiChoice : MonoBehaviour
{
    [SerializeField] string scene;
    [SerializeField] Choice[] choices;
    void Start()
    {
        for (int i = 0; i < choices.Length; i++)
        {

            if (choices[i].answer)
            {
                choices[i].button.onClick.AddListener(OnCorrect);
            }
            else
            {
                choices[i].button.onClick.AddListener(OnIncorrect);
            }
        }
    }

    // Update is called once per frame
    public void OnCorrect()
    {
        Debug.Log("Correct");
        NextScene();
    }

    public void OnIncorrect()
    {
        Debug.Log("Incorrect");
        NextScene();
    }

    void NextScene()
    {
        // SceneManager.LoadScene(scene);
    }
}


[System.Serializable]
class Choice
{
    public Button button;
    public bool answer;
}