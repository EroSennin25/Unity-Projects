using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GetPrefs : MonoBehaviour
{
    public Text username;
    private void Start()
    {
        username.text = PlayerPrefs.GetString("username");
    }
}
