using UnityEngine;
using Valve.VR.InteractionSystem;

namespace KID
{
    /// <summary>
    /// 互動系統
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        private Interactable interactable;

        private void Awake()
        {
            interactable = GetComponent<Interactable>();
        }

        private void Update()
        {
            SaveToInventory();
        }

        /// <summary>
        /// 將物件儲存至道具欄
        /// </summary>
        private void SaveToInventory()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (interactable.attachedToHand == null) return;

                interactable.attachedToHand.DetachObject(gameObject);
            }
        }
    }
}
