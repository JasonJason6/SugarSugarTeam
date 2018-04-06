using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public Canvas MainCanvas;
    public Canvas LvlSelectCanvas;
    public Canvas HelpCanvas;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        LvlSelectCanvas.enabled = false;
        HelpCanvas.enabled = false;
    }

    public void LvlSelectOn()
    {
        LvlSelectCanvas.enabled = true;
        MainCanvas.enabled = false;
    }

    public void HelpOn()
    {
        HelpCanvas.enabled = true;
        MainCanvas.enabled = false;
    }

    public void ReturnOn()
    {
        LvlSelectCanvas.enabled = false;
        HelpCanvas.enabled = false;
        MainCanvas.enabled = true;
    }

    public void loadOn()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void exitOn()
    {
        Application.Quit();
    }
}
