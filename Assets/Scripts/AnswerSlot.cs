using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AnswerSlot : MonoBehaviour
{
    public Image[] answers;
    public int[] answersCorrection = new int[10];
    int[] answersData = new int[10];

    DraggableItem currentAnswer;

    public Vector2 findDropPosition(DraggableItem newAnswer, Vector2 initPosition)
    {
        for (int i = 0; i < answers.Length; i++)
        {
            float distance = Vector3.Distance(newAnswer.transform.position, answers[i].transform.position);
            if (distance < 30)
            {
                if (currentAnswer)
                {
                    currentAnswer.resetPosition();
                }
                currentAnswer = newAnswer;
                answersData[i] = newAnswer.getData();
                return answers[i].transform.position;
            }
        }
        return initPosition;
    }

    public void checkAnswer()
    {
        bool isCorrect = true;
        for (int i = 0; i < answersCorrection.Length; i++)
        {
            if (answersCorrection[i] != answersData[i])
            {
                isCorrect = false;
            }
        }

        if (isCorrect)
        {
            Debug.Log("CORRECT");
        }
        else
        {
            Debug.Log("INCORRECT");
        }
    }
}
