using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject SettingsMenu;
    public GameObject AboutMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    //Charge Info PC Scene
    public void OnClickInfoPC()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("InfoPC");
    }


    public void OnClickIntelVsAMD()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("IntelvsAMD");
    }

    //On click button settings
    public void OnClickSettings()
    {
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }

    //On click button settings
    public void OnClickAbout()
    {
        MainMenu.SetActive(false);
        AboutMenu.SetActive(true);
    }

    //Return to Main Menu
    public void ReturnMainMenu (int menuOrigin)
    {
        switch(menuOrigin)
        {
            //Settings Menu
            case 0:
                SettingsMenu.SetActive(false);
                break;
            //About Menu
            case 1:
                AboutMenu.SetActive(false);
                break;
        }
        MainMenu.SetActive(true);
    }

    //Quit application
    public void QuitApplication()
    {
        Application.Quit();
    }
}
