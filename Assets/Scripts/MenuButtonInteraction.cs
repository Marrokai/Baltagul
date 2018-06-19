using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButtonInteraction : MonoBehaviour
{
    public GameObject MenuUI;
    public GameObject OptionsUI;
    public GameObject GraphicsUI;
    public GameObject SoundsUI;

	public void StartGame()
    {
        SceneManager.LoadScene("Test_landscape");
    }
    public void MainMenuToOptions()
    {
        MenuUI.SetActive(false);
        OptionsUI.SetActive(true);
    }
    public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void OptionsToMainMenu()
    {
        MenuUI.SetActive(true);
        OptionsUI.SetActive(false);
    }
    public void GameToMainMenu()
    {
        SceneManager.LoadScene("Main_menu");
        Time.timeScale = 1;
    }
}
