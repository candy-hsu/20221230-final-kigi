
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// 門的互動程式系統
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("門的動畫")]
        private Animator doorAim;

        private void Start()
        {
            doorAim = GetComponent<Animator>();
            int ReapeatTime = Random.Range(1, 5);
            InvokeRepeating("DoorReapeat", 2, ReapeatTime);
        }

        private void DoorReapeat()
        {
            doorAim.Play("dooronoff", 1);
        }
    }

}
