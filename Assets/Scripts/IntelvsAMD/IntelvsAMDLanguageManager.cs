using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IntelvsAMDLanguageManager : MonoBehaviour
{
    public TextMeshProUGUI AMDPast, AMDPastText;

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
            AMDPast.text = "Pasado de AMD";
            AMDPastText.text = "La arquitectura de AMD precedente a la actual Zen, fue la denominada como Bulldozer.\n\nCon esta arquitectura AMD prometía la llegada de los 8 núcleos a equipos de escritorio.\n\nLa realidad detrás de esto es que los núcleos se agrupaban de 2 en 2, como vemos en la fotografía, compartiendo la mayoría de los recursos. Esto provocaba que el rendimiento de 2 de estos núcleos era equivalente a 1 núcleo de Intel.Esto le costó a AMD una demanda colectiva.\n\nTodo esto sumado a sus malas temperaturas, altos consumos y bajo rendimiento provocó el abandono de la arquitectura en 2014 por parte de AMD.";
        }

        if (language == "ENGLISH")
        {
            AMDPast.text = "AMD's Past";
            AMDPastText.text = "The AMD architecture preceding the current Zen, was the so-called Bulldozer.\n\nWith this architecture AMD promised the arrival of the 8 cores to desktops.\n\nThe reality behind this is that the cores were grouped 2 by 2, as we see in the photograph, sharing most of the resources. This resulted in the performance of 2 of these cores being equivalent to 1 Intel core, which cost AMD a class action lawsuit.\n\n\nAll this added to its bad temperatures, high consumption and low performance caused the abandonment of architecture in 2014.";
        }
    }
}
