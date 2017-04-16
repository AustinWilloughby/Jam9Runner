using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class escMenuScript : MonoBehaviour {

	public Canvas menu;
    public Button quitButton;
    public Button resumeButton;
    // Use this for initialization
	void Start () {
        menu.enabled = false;
    }
    public void ResumeButton()
    {
        menu.enabled = !menu.enabled;
        Time.timeScale = 1;
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu.enabled = !menu.enabled;
            Time.timeScale = 0;
        }
    }
}
