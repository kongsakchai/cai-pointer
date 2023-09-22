using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void toMenuScene() {
        SceneManager.LoadScene("Menu_Screen");
    }

    public void toTitleScene() {
        SceneManager.LoadScene("Title");
    }

    public void toLearningScene() {
        SceneManager.LoadScene("Learning_Menu_Screen");
    }

    public void toPretestScene() {
        SceneManager.LoadScene("Pre_test");
    }
}
