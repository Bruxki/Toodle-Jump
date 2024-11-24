using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager2 : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
