using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public GameObject dedPlayer;

    public GameObject alivPlayer;

    public void Deatho()
    {
        GameObject original = dedPlayer;
        Vector3 position2 = (base.transform.position = alivPlayer.transform.position);
        Object.Instantiate(original, position2, Quaternion.identity);
        Object.Destroy(alivPlayer.gameObject);
        SceneManager.LoadScene("Dead");
    }
}
