
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// 毀滅系統
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
                //print("物件消失");
                Destroy(gameObject);
            }
        }
    }
}

