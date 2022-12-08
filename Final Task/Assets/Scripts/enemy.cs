using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    public GameObject target;
    UnityEngine.AI.NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        if(target == null)
        {
            target = GameObject.FindGameObjectWithTag("player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
