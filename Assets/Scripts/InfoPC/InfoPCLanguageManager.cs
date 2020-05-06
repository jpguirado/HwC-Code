using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfoPCLanguageManager : MonoBehaviour
{
    public TextMeshProUGUI DeviceNameAndType, CPUThreads, CPUFrecuency, RAMSize, GraphicsCard, GraphicsMemory, GraphicsVersion, Motherboard, OperativeSystem;


    // Start is called before the first frame update
    void Start()
    {
        SetLanguage();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetLanguage()
    {
        string language = PlayerPrefs.GetString("language");

        //There is no language established
        if (language == "")
        {
            PlayerPrefs.SetString("language", "ENGLISH");
            language = "ENGLISH";
        }

        if (language == "ESPAÑOL")
        {
            DeviceNameAndType.text = "Nombre y tipo equipo";
            CPUThreads.text = "Hilos CPU";
            CPUFrecuency.text = "Frecuencia CPU";
            RAMSize.text = "Tamaño RAM";
            GraphicsCard.text = "Tarjeta gráfica";
            GraphicsMemory.text = "Memoria gráfica";
            GraphicsVersion.text = "Version API Gráfica";
            Motherboard.text = "Placa base";
            OperativeSystem.text = "Sistema operativo";
        }

        if (language == "ENGLISH")
        {
            DeviceNameAndType.text = "Device Name & Type";
            CPUThreads.text = "CPU Threads";
            CPUFrecuency.text = "CPU Frecuency";
            RAMSize.text = "RAM Size";
            GraphicsCard.text = "Graphics Card";
            GraphicsMemory.text = "Graphics Memory";
            GraphicsVersion.text = "Graphics API Version";
            Motherboard.text = "Motherboard";
            OperativeSystem.text = "Operative System";
        }
    }
}
