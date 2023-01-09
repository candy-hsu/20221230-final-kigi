
using UnityEngine;
using UnityEngine.Events;

namespace Uzai
{
    /// <summary>
    /// 互動系統：偵測玩家是否進入並且執行互動行為
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;
        [SerializeField, Header("對話結束後的事件")]
        private UnityEvent onDialogueFinish;

        [SerializeField, Header("啟動道具")]
        private GameObject propActive;
        [SerializeField, Header("啟動後的對話資料")]
        private DialogueData dataDialogueActive;

        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        [SerializeField, Header("啟動後對話結束的事件")]
        private UnityEvent onDialogueFinishAfterActive;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("畫布對話系統").GetComponent<DialogueSystem>();
        }

        
        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameTarget))
            {
                print(other.name);

                
                if (propActive == null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StarDialogue(dataDialogue, onDialogueFinish);
                }
                else
                {
                    dialogueSystem.StarDialogue(dataDialogueActive, onDialogueFinishAfterActive);
                }

            }

        }
        

        
        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }

    }
}