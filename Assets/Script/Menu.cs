using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Menu : MonoBehaviour
{
    public void ReturntoMenu()
    {
        SceneManager.LoadScene("Start");
    }
    public void Startagain()
    {
        TextShow.Score = 0;
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        TextShow.Score = 0;
        SceneManager.LoadScene("SampleScene");
    }
    public void Next1()
    {
        SceneManager.LoadScene("Answer questions");
    }
    public void Next2()
    {
        SceneManager.LoadScene("End");
    }
    public void Tryagain()
    {
        SceneManager.LoadScene("Answer questions");
    }

}
