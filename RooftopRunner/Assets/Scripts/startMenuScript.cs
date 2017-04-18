using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class startMenuScript : MonoBehaviour {
    public Canvas menu;
    public Canvas cmenu;
    public Button playButton;
    public Button creditButton;
    public Button closecreditButton;
    // Use this for initialization
    void Start () {
        cmenu.enabled = false;

    }
    public void PlayButton()
    {
        SceneManager.LoadScene("Lv1-Peng");
    }
    public void CreditButton()
    {
        menu.enabled = !menu.enabled;
        cmenu.enabled = !cmenu.enabled;
    }
    public void CloseCreditButton()
    {
        menu.enabled = !menu.enabled;
        cmenu.enabled = !cmenu.enabled;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
