using UnityEngine;
using UnityEngine.SceneManagement;

public class Wronganswe : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //??????????????Player???????????????????
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Wrong answer");
        }
    }
}
