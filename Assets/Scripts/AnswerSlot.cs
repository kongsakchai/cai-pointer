using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AnswerSlot : MonoBehaviour
{
    public Image[] answers;
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
                return answers[i].transform.position;
            }
        }
        return initPosition;
    }
}
