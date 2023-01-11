
using TMPro;
using UnityEngine;




namespace Uzai
{
    /// <summary>
    /// 計分
    /// </summary>
    public class ScoreCode : MonoBehaviour
    {
      

        public static int Score;
       
        [SerializeField, Header("碰到會計分的名稱")]
        private string nameTarget;

        public TextMeshProUGUI ShowScore;
        [SerializeField]
        private GameObject scoreGroup;
        [SerializeField]
        private GameObject pass;

        private void Start()
        {
            scoreGroup.SetActive(true);
            pass.SetActive(false);
        }

        void Update()

        {


            ShowScore.text = Score.ToString();

            if (ScoreCode.Score >= 10)
            {
                scoreGroup.SetActive(false);
                pass.SetActive(true);
            }

        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name.Contains(nameTarget))
            {
                ScoreCode.Score += 1;
                print(Score);

            }
        }





    }
}