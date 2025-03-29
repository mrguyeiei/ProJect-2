using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Menu : MonoBehaviour
{
    public void ReturntoMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Startagain()
    {
        TextShow.Score = 0;
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        TextShow.Score = 0;
        SceneManager.LoadScene(1);
    }

}
