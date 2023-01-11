
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class SceneSystem2 : MonoBehaviour
{
    /// <summary>
    /// 切換場景
    /// </summary>
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        SceneManager.LoadScene(1);
    }
}
