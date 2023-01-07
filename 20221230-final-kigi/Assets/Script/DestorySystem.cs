
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// �����t��
    /// </summary>
    public class DestorySystem : MonoBehaviour
    {
        //public GameObject garbageMode;
        public AudioClip garbageSfx;
        public GameObject player;
        public string playerString;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name.Contains(playerString))
            {
                AudioSource.PlayClipAtPoint(garbageSfx, player.transform.position);
                //print("�������");
                Destroy(gameObject);
            }
        }
    }
}

