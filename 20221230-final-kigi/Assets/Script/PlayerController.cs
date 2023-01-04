
using UnityEngine;
using UnityEngine.EventSystems;

namespace Uzai
{
    /// <summary>
    /// 玩家控制器
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        [SerializeField, Header("前後移動速度"), Range(3, 10)]
        private float speedBackAndForward = 5;
        [SerializeField, Header("旋轉速度"), Range(10, 100)]
        private float speedTurn = 50;

        public ParticleSystem DirstSplatter;

        public Animator playerAnim;

        private void Start()
        {
            playerAnim = GetComponent<Animator>();
        }

        private void Update()
        {
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.forward * Time.deltaTime * speedBackAndForward * v);
            transform.Rotate(Vector3.up * Time.deltaTime * speedTurn * h);

            if (v > 0.2 || v < -0.2)
            {
                playerAnim.SetFloat("Speed_f", 1);
                DirstSplatter.Play();
            }
            else
            {
                playerAnim.SetFloat("Speed_f", 0);
                DirstSplatter.Stop();
            }

            

        }
    }
}

