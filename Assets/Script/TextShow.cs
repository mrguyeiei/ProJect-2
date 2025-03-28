using UnityEngine;
using UnityEngine.UI;

public class TextShow : MonoBehaviour
{
    public Text ScoreShow;
    public static int Score = 0;

    private void Update()
    {
        ScoreShow.text=(""+Score);
    }
}
