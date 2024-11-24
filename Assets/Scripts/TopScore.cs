using UnityEngine;
using UnityEngine.UI;

public class TopScore : MonoBehaviour
{
    public Text TopScore1;

    private void Update()
    {
        TopScore1.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
