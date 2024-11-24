using UnityEngine;

public class ResetButton : MonoBehaviour
{
    private void Start()
    {
    }

    public void ScoreReset()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}
