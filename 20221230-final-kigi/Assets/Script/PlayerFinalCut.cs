
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Uzai
{
    public class PlayerFinalCut : MonoBehaviour
    {
        [SerializeField]
        private string nameTarget;
        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameTarget))
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}

