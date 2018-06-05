using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButtonInteraction : MonoBehaviour
{
	public void StartGame()
    {
        SceneManager.LoadScene("Test_landscape");
    }
    public void OptionMenu()
    {
        SceneManager.LoadScene("Options_Menu");
    }
    public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main_menu");
    }
}
