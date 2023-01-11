
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class PassScene : MonoBehaviour
{
    /// <summary>
    /// ��������
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
