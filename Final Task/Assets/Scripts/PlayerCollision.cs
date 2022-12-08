using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager transistion;
    

    public void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.name == "IsEnd")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
