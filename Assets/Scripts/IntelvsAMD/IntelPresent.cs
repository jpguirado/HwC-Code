using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IntelPresent : MonoBehaviour
{
    //Monolithic vs Chiplet
    public Image CPUImageMonolithicChiplet;
    public TextMeshProUGUI CPUTextMonolithicChiplet;
    public Sprite MonolithicSprite;
    public Sprite ChipletSprite;

    // Start is called before the first frame update
    void Start()
    {
        ChangeImageMonolithicChiplet();
    }

    // Update is called once per frame
    void Update()
    {

    }


    //Change the image of the processor's type
    public void ChangeImageMonolithicChiplet()
    {
        string language = PlayerPrefs.GetString("language");

        //There is no language established
        if (language == "")
        {
            PlayerPrefs.SetString("language", "ENGLISH");
            language = "ENGLISH";
        }

        if (CPUImageMonolithicChiplet.sprite == MonolithicSprite)
        {
            CPUImageMonolithicChiplet.sprite = ChipletSprite;
            CPUTextMonolithicChiplet.text = "Chiplet";
        }
        else
        {
            CPUImageMonolithicChiplet.sprite = MonolithicSprite;
            if (language == "ESPAÑOL")
                CPUTextMonolithicChiplet.text = "Monolítico";
            else
                CPUTextMonolithicChiplet.text = "Monolithic";
        }
    }
}
