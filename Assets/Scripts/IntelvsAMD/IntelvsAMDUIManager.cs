using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntelvsAMDUIManager : MonoBehaviour
{

    public GameObject MainMenu, AMDMenu, AMDPast, AMDPresent, AMDFuture;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Return to main menu
    public void Navigation(int option)
    {
        switch(option){

            //From IntelvsAMD Main menu to APP Main Menu
            case 0:
                UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
                break;
            //From IntelvsAMD Main Menu to AMD Menu
            case 1:
                MainMenu.SetActive(false);
                AMDMenu.SetActive(true);
                break;
            //From AMD Menu to IntelvsAMD Main Menu
            case 2:
                AMDMenu.SetActive(false);
                MainMenu.SetActive(true);
                break;
            //From AMD Menu to AMD Past
            case 3:
                AMDMenu.SetActive(false);
                AMDPast.SetActive(true);
                break;
            //From AMD Past to AMD Menu
            case 4:
                AMDPast.SetActive(false);
                AMDMenu.SetActive(true);
                break;
            //From AMD Menu to AMD Present
            case 5:
                AMDMenu.SetActive(false);
                AMDPresent.SetActive(true);
                break;
            //From AMD Present to AMD Menu
            case 6:
                AMDPresent.SetActive(false);
                AMDMenu.SetActive(true);
                break;
            //From AMD Menu to AMD Future
            case 7:
                AMDMenu.SetActive(false);
                AMDFuture.SetActive(true);
                break;
            //From AMD Future to AMD Menu
            case 8:
                AMDFuture.SetActive(false);
                AMDMenu.SetActive(true);
                break;

        }
    }
}
