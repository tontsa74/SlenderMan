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

    Button mainMenuButton;

    // Start is called before the first frame update
    void Start()
    {
        
            mainMenuButton = gameObject.GetComponentInChildren<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Cursor.lockState.Equals(CursorLockMode.None)) {
            mainMenuButton.gameObject.SetActive(true);
        } else  {
            
            mainMenuButton.gameObject.SetActive(false);
        }
    }

    public void ChangeScene(int sceneID)
    {
        print("CLIKCED MAINMENU");
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
