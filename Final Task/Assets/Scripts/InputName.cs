using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class InputName : MonoBehaviour
{
    public InputField username;
    public void ClickSave ()
    {
        PlayerPrefs.SetString("username", username.text);
        SceneManager.LoadScene("maze1");
    }
}
