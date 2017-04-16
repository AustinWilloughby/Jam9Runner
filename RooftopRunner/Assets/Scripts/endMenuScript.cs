using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class endMenuScript : MonoBehaviour {


    //endMenu UI

    public Canvas menu;
    public Button quitButton;
    public Button restartButton;
    public Text score;
    // Use this for initialization
    void Start () {
        menu.enabled = false;
      
    }

    public void RestartButton()
    {
        menu.enabled = !menu.enabled;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update () {
        TimeScoreScript getScore = GameObject.Find("Canvas").GetComponent<TimeScoreScript>();
        int endscore = getScore.timei;
        score.GetComponent<Text>().text = "Your score is: " + endscore.ToString();
    }
}
