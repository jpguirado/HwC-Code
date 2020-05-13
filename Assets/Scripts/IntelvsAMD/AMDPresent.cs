using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AMDPresent : MonoBehaviour
{
    //Monolithic vs Chiplet
    public Image CPUImageMonolithicChiplet;
    public TextMeshProUGUI CPUTextMonolithicChiplet;
    public Sprite MonolithicSprite;
    public Sprite ChipletSprite;


    //Zen 1 vs Zen 2
    public Image ZenVsZen2;
    public TextMeshProUGUI ZenVsZen2Text;
    public Sprite ZenSprite;
    public Sprite Zen2Sprite;

    // Start is called before the first frame update
    void Start()
    {
        ChangeImageMonolithicChiplet();
        ChangeZenVsZen2();
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

        if (CPUImageMonolithicChiplet.sprite == MonolithicSprite) {
            CPUImageMonolithicChiplet.sprite = ChipletSprite;
            CPUTextMonolithicChiplet.text = "Chiplet";
        }
        else {
            CPUImageMonolithicChiplet.sprite = MonolithicSprite;
            if (language == "ESPAÑOL")
                CPUTextMonolithicChiplet.text = "Monolítico";
            else
                CPUTextMonolithicChiplet.text = "Monolithic";
        }
    }

    //Change the image of the processor's type
    public void ChangeZenVsZen2()
    {
        
        if (ZenVsZen2.sprite == Zen2Sprite)
        {
            ZenVsZen2.sprite = ZenSprite;
            ZenVsZen2Text.text = "Zen";
        }
        else
        {
            ZenVsZen2.sprite = Zen2Sprite;
            ZenVsZen2Text.text = "Zen 2";
        }
    }
}
