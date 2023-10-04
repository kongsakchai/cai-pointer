using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Learn : MonoBehaviour
{
    [SerializeField] Button next;
    [SerializeField] Button prev;
    [Space]
    [SerializeField] GameObject[] pages;
    int index;
    void Start()
    {
        next.onClick.AddListener(Next);
        prev.onClick.AddListener(Prev);
    }

    public void Reset()
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(false);
        }
        index = 0;
        pages[0].SetActive(true);
        SetButton();
    }

    public void SetButton()
    {
        next.gameObject.SetActive(index < pages.Length - 2);
        prev.gameObject.SetActive(index > 0);
    }

    // Update is called once per frame
    public void Next()
    {
        if (index < pages.Length)
        {
            pages[index].SetActive(false);
            index++;
            pages[index].SetActive(true);
        }
        SetButton();
    }

    public void Prev()
    {
        if (index > 0)
        {
            pages[index].SetActive(false);
            index--;
            pages[index].SetActive(true);
        }
        SetButton();
    }
}
