using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IntelvsAMDLanguageManager : MonoBehaviour
{
    public TextMeshProUGUI AMDPast, AMDPastText, AMDPresent, AMDPresentText, AMDFuture, AMDFutureRyzen4000Text, AMDFutureConsoleText, IntelPast, IntelPastText, IntelPresent, IntelPresentText, IntelFuture, WhichCPUChoose, CPUChooseAMD, CPUChooseIntel, WorldOfLaptops, WorldOfConsoles, IntelFutureManufacturing, IntelFutureGPUs, ManufacturingProcesses, IntelDiscretGPUs, NumberOfCores;
    public Sprite ProcessorsDieESPSprite, ProccesorsDieENGSprite;
    public Image ProccesorsDieImage;

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
            AMDFuture.text = "Futuro AMD";
            AMDPresentText.text = "En 2017 AMD vuelve al mercado de CPU de sobremesa, alto rendimiento y servidores con su nueva arquitectura Zen\n\nLa principal novedad de esta arquitectura es la división de los núcleos en varios chips, en vez de hacer un chip único(monolítico). Esto permite que la producción de procesadores con muchos núcleos sea más barata y sencilla.\n\nEn las 2 primeras iteraciones de Zen los núcleos se dividían en unidades CCX de 4 núcleos / 8 hilos y estas a su vez se disponían de 2 en 2 en unidades Zeppelin, cada una con su hardware necesario de entrada y salida.\n\nEl tener hardware duplicado en cada una de las unidades Zeppelin fue el mayor lastre de Zen y Zen +.Debido a esto, AMD decidió que con Zen 2 los núcleos estarían en unidades de 8 núcleos / 16 hilos conocidas como chiplets y todo el hardware de entrada y salida en un chip aparte y común conocido como IOD.";
            AMDFutureRyzen4000Text.text = "Despues de la gran acogida de la arquitectura Zen para sobremesa, alto rendimiento y servidores, AMD planea traer toda esta serie de mejoras al mundo de los portatiles, dominado casi en su totalidad por Intel.\n\nLas propuestas para portatiles de las primeras generaciones Zen no eran competitivas. Gracias a las mejoras introducidas en Zen 2, AMD ha conseguido duplicar el número de nucleos, llegando hasta los 8.La potencia de los mismos se ha incrementado notablemente y todo ello, sorprendentemente, manteniendo el mismo consumo.";
            AMDFutureConsoleText.text = "Uno de los mercados más grandes en los que se encuentra presente AMD es el de las consolas. Su entrada en el mismo se produjo con la generaciona actual, Xbox One y PS4.\n\nLa empresa estadounidense es la encargada de realizar tanto la CPU como la GPU, todo ello unido en un mismo chip SoC.\n\nLa actual generación presentaba carencias notables en el aspecto de la CPU, lo cual limita a los desarrolladores a la hora de incluir ciertos aspectos en sus videojuegos.Esta situación cambiará drásticamente con la nueva generación.\n\nAMD de nuevo será la encargada de fabricar los chips de las nuevas Xbox Series X y PS5. Incluirán las últimas tecnologias presentes en PC y supondrán un salto de rendimiento muy notable respecto a la generación anterior.\n\nEntrando en detalles más tecnicos, ambas incluiran un procesador Zen 2 de 8 nucleos y 16 hilos y una gráfica basada en la nueva arquitectura de AMD, Zen 2, con una potencia equivalente a tarjetas gráficas de gama alta presentes en el mercado actual de PC.";
            IntelPast.text = "Pasado Intel";
            IntelPresent.text = "Presente Intel";
            IntelFuture.text = "Futuro Intel";
            IntelPastText.text = "Debido a la escasa competitividad de los procesadores Bulldozer de AMD y su posterior abandono de la arquiectura, Intel acaparó casi la totalidad del mercado.\n\nEsto le permitió a Intel mantenerse en una posición cómoda y mantener la misma configuración de nucleos en sus procesadores, hasta 4 nucleos en la gama Core, durante 7 generaciones.\n\nEn 2012 la compañia se econtraba trabajabando con su proceso de fabricación a 22 nm y desarrollando el de 14nm.Sus planes en ese año eran de introducir los 10 nm a partir de 2015.La realidad fue totalmente distinta y todo se retrasó, llegando finalmente los 14nm en ese año y retrasando la llegada de los 10nm hasta la actualidad.";
            IntelPresentText.text = "Debido a los problemas relacionados con sus procesos de fabricación, Intel se encuentra en una situación complicada. El retraso de los 10 nm durante tantos años ha concluido en una confirmación por parte de Intel de que el proceso de fabricación será menos productivo que los 14 nm e incluso que los 22nm. Actualmente este proceso esta pensado solo para usarse en dispositivos de bajo consumo.\n\nDebido a esto, Intel se ve obligada a apurar al límite los 14 nm.Al no cambiar de proceso de fabricación, mantenerse en una arquitectura monolítica y verse obligados a aumentar el número de nucleos para hacer frente a la competencia, el tamaño de sus chips es cada vez mayor. Esto provoca que su producción sea más dificil y costosa, lo cual repercute en un aumento del precio de sus procesadores.";
            ProccesorsDieImage.sprite = ProcessorsDieESPSprite;
            WhichCPUChoose.text = "¿Qué CPU escoger?";
            CPUChooseAMD.text = "De forma general, los procesadores actuales de AMD son la mejor opción en productividad y mundo profesional. Dentro de este aspecto se encuentran tareas como edicion y renderizado de video, modelado 3D, compresión y descompresión de archivos, aplicaciones de cálculo científico, etc. En resumen, aplicaciones altamente demandantes que aprovechan todos los núcleos del procesador.\n\nLos procesadores de AMD son la mejor opción en este caso debido a ofrecer un mayor número de nucleos a un precio similar o inferior a sus alternativas en Intel.";
            CPUChooseIntel.text = "El mundo donde más destacan los procesadores de Intel es en el de los videojuegos, en el que las frecuencias son clave. Gracias a estas velocidades más altas, Intel se posiciona como la mejor opción para conseguir el mayor rendimiento en juegos.\n\nPor la misma razón que antes, junto a otros aspectos, hay ciertas aplicaciones que favorecen más a los procesadores Intel que a los de AMD o viceversa.Es por ello por lo que es recomendable buscar pruebas específicas sobre el software que con más frecuencia vayas a utilizar o en el que se base tu trabajo.";
            WorldOfLaptops.text = "Mundo de los portatiles -  Ryzen 4000";
            WorldOfConsoles.text = "Mundo de las consolas -  Xbox Series X y PS5";
            IntelFutureManufacturing.text = "Los retrasos en sus procesos de fabricación afectan al futuro de Intel de forma directa. La 11ª generación de procesadores para sobremesa vendrá con una nueva arquitectura, con núcleos Willow Cove. \n\nEsta nueva arquitectura estaba pensada para los 10nm, pero debido a los problemas asociados con este proceso de fabricación, finalmente los núcleos serán adaptados a los 14nm.Mientras intentan rentabilizar el proceso de fabricación a 10nm, Intel se centra en el desarrollo a futuro de los 7nm.";
            IntelFutureGPUs.text = "Hasta ahora, Intel siempre ha acompañado a sus procesadores con tarjetas gráficas integradas en el mismo chip. Estas gráficas son poco potentes y están presentes para cumplir funciones básicas y livianas.\n\nAnte una situación en la que AMD, su principal competidor, está presente en el mundo de las GPUs y NVIDIA está comenzando a crear sus propios procesadores, Intel no se puede quedar atrás y planea entrar en el mundo de las tarjetas gráficas discretas.Para ello están contratando a gente reconocida del sector, procedentes de empresas líderes en el mismo.\n\nEstas gráficas empezarán a llegar al mercado a finales de 2020 y se conocerán bajo el nombre de Intel Xe.";
            ManufacturingProcesses.text = "Procesos de fabricación";
            IntelDiscretGPUs.text = "GPUs discretas de Intel";
            NumberOfCores.text = "El número de núcleos que escoger dependerá de los requisitos específicos de nuestras aplicaciones o videojuegos más usados y de si serán capaces de aprovechar todos los núcleos. De igual forma, esto se verá afectado por el presupuesto de cada usuario.";
        }


        if (language == "ENGLISH")
        {
            AMDPast.text = "AMD's Past";
            AMDPastText.text = "The AMD architecture preceding the current Zen, was the so-called Bulldozer.\n\nWith this architecture AMD promised the arrival of the 8 cores to desktops.\n\nThe reality behind this is that the cores were grouped 2 by 2, as we see in the photograph, sharing most of the resources. This resulted in the performance of 2 of these cores being equivalent to 1 Intel core, which cost AMD a class action lawsuit.\n\nAll this added to its bad temperatures, high consumption and low performance caused the abandonment of architecture in 2014.";
            AMDPresent.text = "AMD's Present";
            AMDFuture.text = "AMD's Future";
            AMDPresentText.text = "In 2017 AMD returns to the desktop, high performance and server CPU market with its new Zen architecture.\n\nThe main novelty of this architecture is the division of the cores into several chips, instead of making a single (monolithic) chip. This allows making the production of processors with many cores cheaper and easier.\n\n\nIn the first 2 iterations of Zen the cores were divided into 4-core / 8-wire CCX units and these in turn were available 2 by 2 in Zeppelin units, each with its necessary input and output hardware.\n\nHaving duplicate hardware in each of the Zeppelin units was the biggest drag on Zen and Zen +. Because of this, AMD decided that with Zen 2 the cores would be in units of 8 cores / 16 threads known as chiplets and all input and output hardware on a separate common chip known as IOD.";
            AMDFutureRyzen4000Text.text = "After the great reception of Zen architecture for desktop, high performance and servers, AMD plans to bring all this series of improvements to the world of notebooks, almost entirely dominated by Intel.\n\nThe proposals for notebooks of the first Zen generations were not competitive.Thanks to the improvements introduced in Zen 2, AMD has managed to double the number of cores, reaching up to 8.The power of this cores has increased remarkably and all, surprisingly, maintaining the same consumption.";
            AMDFutureConsoleText.text = "One of the largest markets in which AMD is present is that of consoles. Its entry into it occurred with the current generation, Xbox One and PS4.\n\nThe American company is in charge of making both the CPU and the GPU, all united in the same SoC chip.\n\nThe current generation had notable deficiencies in the aspect of the CPU, which limits the developers when it comes to including certain aspects in their video games.This situation will change dramatically with the new generation.\n\nAMD will again be in charge of manufacturing the chips for the new Xbox Series X and PS5.They will include the latest technologies present on PC and will represent a very notable performance leap over the previous generation.\n\nGoing into more technical details, both will include an 8 - core, 16 - wire Zen 2 processor and graphics based on AMD's new architecture, Zen 2, with a power equivalent to high-end graphics cards present in today's PC market.";
            IntelPast.text = "Intel's Past";
            IntelPresent.text = "Intel's Present";
            IntelFuture.text = "Intel's Future";
            IntelPastText.text = "Due to the poor competitiveness of AMD's Bulldozer processors and their subsequent abandonment of the architecture, Intel captured nearly the entire market.\n\nThis allowed Intel to remain in a comfortable position and maintain the same core configuration in its processors, up to 4 cores in the Core range, for 7 generations.\n\n\nIn 2012 the company found itself working with its manufacturing process at 22nm and developing the 14nm one. Its plans in that year were to introduce 10nm from 2015. The reality was totally different and everything was delayed, finally reaching 14nm in that year and delaying the arrival of 10nm until today.";
            IntelPresentText.text = "Due to problems related to its manufacturing processes, Intel is in a difficult situation. The 10nm delay for so many years has ended in a confirmation by Intel that the manufacturing process will be less productive than 14nm and even 22nm. Currently this process is intended only for use in low-consumption devices.\n\n\nBecause of this, Intel is forced to rush the 14nm limit. By not changing manufacturing processes, staying in a monolithic architecture, and being forced to increase the number of cores to face the competition, the size of its chips is increasing.This causes their production to be more difficult and expensive, which results in an increase in the price of their processors.";
            ProccesorsDieImage.sprite = ProccesorsDieENGSprite;
            WhichCPUChoose.text = "Which CPU to choose?";
            CPUChooseAMD.text = "Overall, today's AMD processors are the best choice in productivity and the professional world. Within this aspect are tasks such as video editing and rendering, 3D modeling, compression and decompression of files, scientific calculation applications, etc. In short, highly demanding applications that take advantage of all the processor cores.\n\nAMD processors are the best choice in this case because they offer more cores at a price similar to or less than their alternatives at Intel.";
            CPUChooseIntel.text = "The world where Intel's processors stand out the most is in the world of video games, where frequencies are key. Thanks to these higher speeds, Intel is positioned as the best option for the best gaming performance.\n\nFor the same reason as before, along with other aspects, there are certain applications that favor Intel processors more than those of AMD or vice versa.That is why it is advisable to look for specific tests on the software that you will use most often or on which your work is based.";
            WorldOfLaptops.text = "World of laptops -  Ryzen 4000";
            WorldOfConsoles.text = "World of consoles -  Xbox Series X & PS5";
            IntelFutureManufacturing.text = "Delays in its manufacturing processes directly affect Intel's future. The 11th generation of desktop processors will come with a new architecture, featuring Willow Cove cores.\n\nThis new architecture was intended for 10nm, but due to the problems associated with this manufacturing process, the cores will eventually be adapted to 14nm.While trying to monetize the manufacturing process at 10nm, Intel is focused on the future development of 7nm.";
            IntelFutureGPUs.text = "Until now, Intel has always accompanied its processors with graphics cards integrated on the same chip. These graphics are not very powerful and are present to fulfill basic and light functions.\n\nIn a situation where AMD, its main competitor, is present in the world of GPUs and NVIDIA is starting to create its own processors, Intel cannot be left behind and plans to enter the world of discrete graphics cards. For this they are hiring recognized people in the sector, from leading companies in it.\n\nThese graphics will begin to hit the market in late 2020 and will be known under the name Intel Xe.";
            ManufacturingProcesses.text = "Manufacturing processes";
            IntelDiscretGPUs.text = "Intel discrete GPU";
            NumberOfCores.text = "The number of cores to choose will depend on the specific requirements of our most used applications or video games and whether they will be able to take advantage of all the cores. Similarly, this will be affected by the budget of each user.";
        }
    }
}
