using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuLanguageManager : MonoBehaviour
{

    public TextMeshProUGUI Language, ReturnSettings, ReturnAbout;


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
           
            ReturnSettings.text = "VOLVER";
            ReturnAbout.text = "Volver";
            Language.text = "IDIOMA";
        }

        if (language == "ENGLISH")
        {
            ReturnSettings.text = "RETURN";
            ReturnAbout.text = "Return";
            Language.text = "LANGUAGE";
        }
    }
}
