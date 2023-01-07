using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
namespace Uzai
{
    public class SceneSystem : MonoBehaviour
    {

        void Start()
        {
            this.GetComponent<Button>().onClick.AddListener(OnClick);
        }

        void OnClick()
        {
            SceneManager.LoadScene(1);
        }
    }
}

