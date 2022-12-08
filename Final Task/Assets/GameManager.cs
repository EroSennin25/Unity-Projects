using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public void CompleteLevel()
    {
        Debug.Log("We Won");
    }
}
