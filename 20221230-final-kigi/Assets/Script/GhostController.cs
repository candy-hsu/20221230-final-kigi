
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// �������
    /// </summary>
    public class GhostController : MonoBehaviour
    {
        //public void HiddenObject()
        //{
            //gameObject.SetActive(false);
       // }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains("PlayerCapsule"))
            {
                gameObject.SetActive(true);
            }
        }
    }
}

