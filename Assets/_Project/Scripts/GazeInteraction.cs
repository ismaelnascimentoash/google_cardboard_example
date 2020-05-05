using UnityEngine;
using UnityEngine.EventSystems;

namespace IsmaelNascimentoAssets
{
    public class GazeInteraction : MonoBehaviour
    {
        #region VARIABLES

        [SerializeField] private float gazeTime = .5f;
        private float timer;
        private bool gazedAt;

        #endregion

        #region MONOBEHAVIOUR_METHODS

        private void Update()
        {
            if (gazedAt)
            {
                timer += Time.deltaTime;

                if (timer >= gazeTime)
                {
                    ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                    timer = 0f;
                }
            }
        }

        #endregion

        #region EVENT_METHODS

        public void PointerEnter()
        {
            gazedAt = true;
            Debug.Log("PointerEnter");
        }

        public void PointerExit()
        {
            gazedAt = false;
            timer = 0;
            Debug.Log("PointerExit");
        }

        public void PointerDown()
        {
            PointerExit();
            Debug.Log("PointerDown");
        }

        #endregion
    }
}