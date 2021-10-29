using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGameScript : MonoBehaviour
{
    public GameObject ResumeButton;
    public GameObject MenuButton;

    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            Pause();   
        }
    }

    public void Pause()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
            ResumeButton.SetActive(true);
            MenuButton.SetActive(true);
            Cursor.visible = true;
        }

        else
        {
            Time.timeScale = 1;
            ResumeButton.SetActive(false);
            MenuButton.SetActive(false);
            Cursor.visible = false;
        }
    }

    public void ResumeGame()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
            ResumeButton.SetActive(false);
            MenuButton.SetActive(false);
            Cursor.visible = false;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScreen");
    }
}
