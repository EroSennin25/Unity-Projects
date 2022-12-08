using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameManager gameManager;
    public void OnCollisionEnter(Collision collision)
    {
        gameManager.CompleteLevel();
    }
}
