using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour {
    public GameObject FullScreenActivat;
    public GameObject FullScreenDezactivat;
    public Text text;   //va fi sters dupa confirmare
    
    int resolution_width, resolution_height;
    private void Start()
    {
        if (Screen.fullScreen)
        {
            FullScreenActivat.SetActive(true);
            FullScreenDezactivat.SetActive(false);
        }
        else
        {

            FullScreenActivat.SetActive(false);
            FullScreenDezactivat.SetActive(true);
        }
    }
    public void setFullScreen (bool isFullScreen)
    {
        if (isFullScreen)
        {
            FullScreenActivat.SetActive(true);
            FullScreenDezactivat.SetActive(false);
            Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
        }
        else
        {
            
            FullScreenActivat.SetActive(false);
            FullScreenDezactivat.SetActive(true);
            Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, false);
        }
    }
    private void Update() //pot scoate dupa verificarea functionalitatii
    {
        text.text = Screen.currentResolution.width + "x" + Screen.currentResolution.height;
    }
}
