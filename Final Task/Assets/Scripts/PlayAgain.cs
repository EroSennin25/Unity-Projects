using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayAgain : MonoBehaviour
{
    public void PlayAgains()
    {
        SceneManager.LoadScene("Menu");
    }
}
