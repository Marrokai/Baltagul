using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButtonInteraction : MonoBehaviour
{
    public GameObject GraphicsUI;
    public GameObject SoundsUI;
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
    public void GraphicsMenu()
    {
        if (GraphicsUI.activeSelf == false)
        {
            SoundsUI.SetActive(false);
            GraphicsUI.SetActive(true);
        }
    }
    public void SoundsMenu()
    {
        if(SoundsUI.activeSelf == false)
        {
            GraphicsUI.SetActive(false);
            SoundsUI.SetActive(true);
            
        }
    }
    public void CloseGraphicsMenu()
    {
        GraphicsUI.SetActive(false);
    }
    public void CloseSoundsMenu()
    {
        SoundsUI.SetActive(false);
    }
}
