using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InfoPC : MonoBehaviour
{

    public TextMeshProUGUI InfoPCText;



    // Start is called before the first frame update
    void Start()
    {
        ShowPcInfo();
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShowPcInfo()
    {
        InfoPCText.text = SystemInfo.processorType;
        InfoPCText.text += "\n";
        InfoPCText.text += "Número de hilos: " + SystemInfo.processorCount;
        InfoPCText.text += "\n";
        InfoPCText.text += "Memoria RAM: " + SystemInfo.systemMemorySize;
        InfoPCText.text += "\n";
        InfoPCText.text += SystemInfo.graphicsDeviceName;
        InfoPCText.text += "\n";
        InfoPCText.text += SystemInfo.operatingSystem;
    }

    //Return to main menu
    public void ReturnToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
