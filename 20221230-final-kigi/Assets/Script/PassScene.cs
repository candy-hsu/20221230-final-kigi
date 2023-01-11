
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class PassScene : MonoBehaviour
{
    /// <summary>
    /// ¤Á´«³õ´º
    /// </summary>
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        SceneManager.LoadScene(0);
    }
}
