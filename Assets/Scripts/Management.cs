using UnityEngine;
using UnityEngine.Audio;
public class Management : MonoBehaviour {

    public AudioMixer MasterVolume;
    public AudioMixer MusicVolume;
    public AudioMixer DialogueVolume;
    public AudioMixer EnvironmentVolume;
    int currResWidth;
    int currResHeight;
    public static bool WasExecuted;
    private void Awake()
    {
        if (!WasExecuted)
        {
            InitialSetup();
        }
           
    }
    void InitialSetup()
    {
        //Apply Default Resolution
        Debug.Log(Screen.width + "x" + Screen.height);
        currResWidth = Screen.currentResolution.width;
        currResHeight = Screen.currentResolution.height;
        Screen.SetResolution(currResWidth, currResHeight, FullScreenMode.FullScreenWindow);
        //Player Settings ------ Windowed
        //Windowed-> FullScreen ; MaximizedWindow-> FullScreen ; FullScreenWindow-> FullScreen ;  ExclusiveFullScreen-> FullScreen
        //Player Settings ------ Maximized Window
        //Windowed-> FullScreen-Logo, Windowed-Game ; MaximizedWindow-> Windowed-Logo, FullScreen-Game ; FullScreenWindow-> FullScreen-rezolutii gresite ;  ExclusiveFullScreen-> FullScreen-exclusiv
        //Player Settings ------ Exclusive Fullscreen
        //Windowed-> Fullscreen-Logo(rezolutie gresita) Windowed-Game ; MaximizedWindow-> Fulscreen ; FullScreenWindow-> FullScreen ;  ExclusiveFullScreen-> FullScreen-nu pot da alt-tab
        //Player Settings ------ FullScreen Window
        //Windowed-> FullScreen-Logo, Windowed-Game ; MaximizedWindow-> Windowed-Logo, FulsScreen-Game ; FullScreenWindow-> Windowed-Logo, Fulscreen-Game;  ExclusiveFullScreen-> FullScreen-gresite rezolutiile
        Debug.Log(currResWidth + " x " + currResHeight);
        //Apply Default Sound settings

        MasterVolume.SetFloat("MasterVolume", 0);
        MusicVolume.SetFloat("MusicVolume", 0);
        DialogueVolume.SetFloat("DialogueVolume", 0);
        EnvironmentVolume.SetFloat("EnvironmentVolume", 0);
        Debug.Log("Default Settings Applied");
        WasExecuted = true;
    }

}
