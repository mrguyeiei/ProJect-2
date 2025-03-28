using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ReturntoMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Startagain()
    {
        SceneManager.LoadScene(1);
    }

}
