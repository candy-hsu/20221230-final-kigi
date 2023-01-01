
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// �������ʵ{���t��
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("�����ʵe")]
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
