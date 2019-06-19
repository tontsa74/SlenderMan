using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

using UnityStandardAssets.Characters.FirstPerson;


public class UiManager : MonoBehaviour
{

    public Camera cam;

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
        
        if (sceneID == 0) {
            MouseLook ml = cam.GetComponent<MouseLook>();
            ml.SetCursorLock(false);
        } 

        SceneManager.LoadScene(sceneID);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
