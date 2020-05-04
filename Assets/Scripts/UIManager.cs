using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
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

    //Quit application
    public void QuitApplication()
    {
        Application.Quit();
    }
}
