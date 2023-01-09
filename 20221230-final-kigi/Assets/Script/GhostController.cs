
using UnityEngine;
using UnityEngine.Events;

namespace Uzai
{
    /// <summary>
    /// 鬼的控制器
    /// </summary>
    public class GhostController : MonoBehaviour
    {
        //public void HiddenObject()
        //{
        //gameObject.SetActive(false);
        // }
        [SerializeField, Header("鬼")]
        private GameObject ghost;

        [SerializeField]
        private string nameTarget;

        private bool ghostyes;
        //[SerializeField, Header("隱藏和啟動事件")]
        //private UnityEvent ghostActive;

        private void Start()
        {
            ghost.SetActive(false);
            ghostyes = true;
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameTarget) && ghostyes == true)
            {
                ghost.SetActive(true);
                print("鬼出現");
                ghostyes = false;
            }
        }
        //public void HiddenObject()
        //{
           // gameObject.SetActive(false);
       // }
    }
}

