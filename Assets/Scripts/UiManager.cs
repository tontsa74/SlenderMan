using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class UiManager : MonoBehaviour
{

    public TextMeshProUGUI p1Score;
    public TextMeshProUGUI p2Score;

    int p1Kills;
    int p2Kills;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void HealthBarListener(Slider slider)
    {
        if(slider.value == 0)
        {
            if(slider.name =="HealthBarP1")
            {
                p2Kills++;
                p2Score.SetText("Score " + p2Kills);
            //    slider.value = 3;
            }
            else if (slider.name == "HealthBarP2")
            {
                p1Kills++;
                p1Score.SetText("Score " + p1Kills);
             //   slider.value = 3;
            }
        }
    }
}
