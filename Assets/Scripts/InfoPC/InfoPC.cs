using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class InfoPC : MonoBehaviour
{

    public TextMeshProUGUI ProccesorTypeText;
    public TextMeshProUGUI ProccesorCount;
    public TextMeshProUGUI DeviceNameAndType;
    public TextMeshProUGUI ProccesorFrecuency;
    public TextMeshProUGUI SystemMemorySize;
    public TextMeshProUGUI GraphicsDeviceName;
    public TextMeshProUGUI GraphicsMemorySize;
    public TextMeshProUGUI GraphicsDeviceVersion;
    public TextMeshProUGUI DeviceModel;
    public TextMeshProUGUI OperatingSystem;


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
        DeviceNameAndType.text = SystemInfo.deviceName + " || " + SystemInfo.deviceType; 
        ProccesorTypeText.text = SystemInfo.processorType;
        ProccesorCount.text = SystemInfo.processorCount.ToString();
        ProccesorFrecuency.text = SystemInfo.processorFrequency.ToString() + " MHz";
        SystemMemorySize.text = SystemInfo.systemMemorySize.ToString() + " MB";
        GraphicsDeviceName.text = SystemInfo.graphicsDeviceName;
        GraphicsMemorySize.text = SystemInfo.graphicsMemorySize.ToString() + "MB";
        GraphicsDeviceVersion.text = SystemInfo.graphicsDeviceVersion;
        DeviceModel.text = SystemInfo.deviceModel;
        OperatingSystem.text = SystemInfo.operatingSystemFamily + " || " + SystemInfo.operatingSystem;
    }

    //Return to main menu
    public void ReturnToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
