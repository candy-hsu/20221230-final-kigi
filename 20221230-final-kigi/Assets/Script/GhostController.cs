
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// °­ªº±±¨î¾¹
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

