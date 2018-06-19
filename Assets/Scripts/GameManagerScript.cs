using UnityEngine;

public class GameManagerScript : MonoBehaviour {
    bool togglePause = false;
    public GameObject PauseUI;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause_Menu();
        }
	}
    private void Pause_Menu()
    {
        if (!togglePause)    //Pune pauza
        {
            togglePause = !togglePause;
            Time.timeScale = 0;
            PauseUI.SetActive(true);
        }
        else                //Reia jocul
        {
            togglePause = !togglePause;
            Time.timeScale = 1;
            PauseUI.SetActive(false);
        }
    }
}
