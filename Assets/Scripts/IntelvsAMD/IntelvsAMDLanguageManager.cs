﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IntelvsAMDLanguageManager : MonoBehaviour
{
    public TextMeshProUGUI AMDPast, AMDPastText, AMDPresent, AMDPresentText;

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
            AMDPastText.text = "La arquitectura de AMD precedente a la actual Zen, fue la denominada como Bulldozer.\n\nCon esta arquitectura AMD prometía la llegada de los 8 núcleos a equipos de escritorio.\n\nLa realidad detrás de esto es que los núcleos se agrupaban de 2 en 2, como vemos en la fotografía, compartiendo la mayoría de los recursos. Esto provocaba que el rendimiento de 2 de estos núcleos era equivalente a 1 núcleo de Intel y le costó a AMD una demanda colectiva.\n\nTodo esto sumado a sus malas temperaturas, altos consumos y bajo rendimiento provocó el abandono de la arquitectura en 2014 por parte de AMD.";
            AMDPresent.text = "Presente AMD";
            AMDPresentText.text = "En 2017 AMD vuelve al mercado de CPU de sobremesa, alto rendimiento y servidores con su nueva arquitectura Zen\n\nLa principal novedad de esta arquitectura es la división de los núcleos en varios chips, en vez de hacer un chip único(monolítico).Esto permite que la producción de procesadores con muchos núcleos sea más barata y sencilla.\n\nEn las 2 primeras iteraciones de Zen los núcleos se dividían en unidades CCX de 4 núcleos / 8 hilos y estas a su vez se disponían de 2 en 2 en unidades Zeppelin, cada una con su hardware necesario de entrada y salida.\n\nEl tener hardware duplicado en cada una de las unidades Zeppelin fue el mayor lastre de Zen y Zen +.Debido a esto, AMD decidió que con Zen 2 los núcleos estarían en unidades de 8 núcleos / 16 hilos conocidas como chiplets y todo el hardware de entrada y salida en un chip aparte y común conocido como IOD.";
        }

        if (language == "ENGLISH")
        {
            AMDPast.text = "AMD's Past";
            AMDPastText.text = "The AMD architecture preceding the current Zen, was the so-called Bulldozer.\n\nWith this architecture AMD promised the arrival of the 8 cores to desktops.\n\nThe reality behind this is that the cores were grouped 2 by 2, as we see in the photograph, sharing most of the resources. This resulted in the performance of 2 of these cores being equivalent to 1 Intel core, which cost AMD a class action lawsuit.\n\nAll this added to its bad temperatures, high consumption and low performance caused the abandonment of architecture in 2014.";
            AMDPresent.text = "AMD's Present";
            AMDPresentText.text = "In 2017 AMD returns to the desktop, high performance and server CPU market with its new Zen architecture.\n\nThe main novelty of this architecture is the division of the cores into several chips, instead of making a single (monolithic) chip. This allows making the production of processors with many cores cheaper and easier.\n\n\nIn the first 2 iterations of Zen the cores were divided into 4-core / 8-wire CCX units and these in turn were available 2 by 2 in Zeppelin units, each with its necessary input and output hardware.\n\nHaving duplicate hardware in each of the Zeppelin units was the biggest drag on Zen and Zen +. Because of this, AMD decided that with Zen 2 the cores would be in units of 8 cores / 16 threads known as chiplets and all input and output hardware on a separate common chip known as IOD.";
        }
    }
}
