
using System.Collections.Generic;
using UnityEngine;


namespace Uzai
{
    /// <summary>
    /// 玩家控制器
    /// </summary>
    public class PlayerController2 : MonoBehaviour
    {
        [SerializeField, Header("前後移動速度"), Range(3, 10)]
        private float speedBackAndForward = 5;
        [SerializeField, Header("旋轉速度"), Range(10, 100)]
        private float speedTurn = 50;

        public GameObject DirstSplatter;

        public Animator playerAnim;

        //private bool playerInput;
       // private CanvasGroup groupDialogue;


        //[Header("跟隨")]
        //public GameObject ghostFollow;
        //public List<Vector3> positionList;
        //public int distance = 5;

        private void Start()
        {
            playerAnim = GetComponent<Animator>();
            //groupDialogue = GameObject.Find("畫布對話系統").GetComponent<CanvasGroup>();
        }

        private void Update()
        {
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");
           // if (groupDialogue.alpha > 0)
            //{
               // playerInput = false;
            //}
            //else 
           // {
               // playerInput = true; 
           // }

            
                transform.Translate(Vector3.forward * Time.deltaTime * speedBackAndForward * v);
                transform.Rotate(Vector3.up * Time.deltaTime * speedTurn * h);
            
               
           



            if (Mathf.Abs(v) > 0.2f)
            {
                playerAnim.SetFloat("Speed_f", 1);
                DirstSplatter.SetActive(true);

            }
            else
            {
                playerAnim.SetFloat("Speed_f", 0);
                DirstSplatter.SetActive(false);

            }

            //positionList.Add(transform.position);
            //if (positionList.Count > distance)
            //{
            // positionList.RemoveAt(0);
            // ghostFollow.transform.position = positionList[0];
            // }

        }
    }
}

