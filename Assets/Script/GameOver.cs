using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //?????????????????
        Move componect = other.gameObject.GetComponent<Move>();
        if (componect != null)
        {
            //?????????????
            SceneManager.LoadScene("GameOver");
        }
    }
}
