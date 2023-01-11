using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// 切換場景
    /// </summary>
    public class SceneSystem : MonoBehaviour
    {

        void Start()
        {
            this.GetComponent<Button>().onClick.AddListener(OnClick);
        }

        void OnClick()
        {
            SceneManager.LoadScene(3);
        }
    }
}

