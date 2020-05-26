using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAbout : MonoBehaviour
{
    public string HwCCode, HwCBuilds, jpguiradoGithub;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Open V-Algo Code Github Proyect
    public void OpenHwCCode()
    {
        Application.OpenURL(HwCCode);
    }

    //Open V-Algo Builds Github Proyect
    public void OpenHwCBuilds()
    {
        Application.OpenURL(HwCBuilds);
    }

    //Open jpuirado github profile
    public void OpenjpguiradoGuthub()
    {
        Application.OpenURL(jpguiradoGithub);
    }
}
