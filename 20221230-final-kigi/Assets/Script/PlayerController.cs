
using UnityEngine;
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
        
        private void Update()
        {
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.forward * Time.deltaTime * speedBackAndForward * v);
            transform.Rotate(Vector3.up * Time.deltaTime * speedTurn  * h);
        }
    }
}

