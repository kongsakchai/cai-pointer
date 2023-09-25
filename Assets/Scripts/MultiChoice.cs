using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class MultiChoice : MonoBehaviour
{
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
        // Debug.Log("Correct");
        TestManager.main.updateScore();
        TestManager.main.Next();
    }

    public void OnIncorrect()
    {
        // Debug.Log("Incorrect");
        TestManager.main.Next();
    }
}


[System.Serializable]
class Choice
{
    public Button button;
    public bool answer;
}