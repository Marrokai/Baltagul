using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour {
    public GameObject FullScreenActivat;
    public GameObject FullScreenDezactivat;
    /*int currentResolutionIndex = 0;
    Resolution[] resolutions;
    public Dropdown resolutionDropdown;
    List<string> options = new List<string>();*/
    public static bool FullScreenActive = true;
    public Text text;
    
    int resolution_width, resolution_height;
    /*void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();
        
        
        int j = 0;
        foreach(Resolution res in resolutions)
        {
            /*string option = resolutions[i].width + "x" + resolutions[i].height;
            if (!options.Contains(option))
            {
                options.Add(option);
                j++;
            }*\/
            
            if(res.refreshRate == 60) options.Add(res.width + "x" + res.height);
            Debug.Log(res.width + "x" + res.height+ " " + res.refreshRate);
            if (res.width == Screen.currentResolution.width &&
               res.height == Screen.currentResolution.height)
            {
                currentResolutionIndex = j;
            }
            j++;
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }*/
    public void setFullScreen (bool isFullScreen)
    {
        if (isFullScreen)
        {
            FullScreenActivat.SetActive(true);
            FullScreenDezactivat.SetActive(false);
            FullScreenActive = true;
        }
        else
        {
            FullScreenActive = false;
            FullScreenActivat.SetActive(false);
            FullScreenDezactivat.SetActive(true);
        }
        /*if(fullScreenMode == 0)
        {
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        }
        if (fullScreenMode == 1)
        {
            Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
        }
        if (fullScreenMode == 2)
        {
            Screen.fullScreenMode = FullScreenMode.MaximizedWindow;
        }
        if (fullScreenMode == 3)
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
        }*/
    }
    /*public void setResolution(int resolutionIndex,bool isFullScreen)
    {
        Screen.SetResolution(resolutions[resolutionIndex].width, resolutions[resolutionIndex].height, isFullScreen);
    }*/
    public void Apply()
    {
        Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, FullScreenActive);
        gameObject.GetComponent<MenuButtonInteraction>().CloseGraphicsMenu();
        //setResolution(resolutionDropdown.value, FullScreenActive);
        
    }
    private void Update()
    {
        text.text = Screen.currentResolution.width + "x" + Screen.currentResolution.height;
    }
}
