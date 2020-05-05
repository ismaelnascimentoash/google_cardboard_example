using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;

namespace IsmaelNascimentoAssets
{
    [RequireComponent(typeof(CanvasGroup))]
    public class FadeCanvas : MonoBehaviour
    {
        #region VARIABLES

        private CanvasGroup canvasGroup;

        // Actions
        public Action OnCallFadeUpFinish;
        public Action OnCallFadeDownFinish;

        #endregion

        #region MONOBEHAVIOUR_METHODS

        private void Start()
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        #endregion

        #region PUBLIC_METHOD

        public void CallFadeUp(float durationTime)
        {
            StartCoroutine(CallFadeUp_Coroutine(durationTime));
        }

        public void CallFadeDown(float durationTime)
        {
            StartCoroutine(CallFadeDown_Coroutine(durationTime));
        }

        #endregion

        #region COROUTINES

        private IEnumerator CallFadeUp_Coroutine(float durationTime)
        {
            canvasGroup.DOFade(1f, durationTime);
            yield return new WaitForSeconds(durationTime);
            OnCallFadeUpFinish?.Invoke();
        }

        private IEnumerator CallFadeDown_Coroutine(float durationTime)
        {
            canvasGroup.DOFade(0f, durationTime);
            yield return new WaitForSeconds(durationTime);
            OnCallFadeDownFinish?.Invoke();
        }

        #endregion

        #region TEST_METHODS

        [ContextMenu("CallFadeUp_Test")]
        public void CallFadeUp_Test()
        {
            CallFadeUp(1f);
        }

        [ContextMenu("CallFadeDown_Test")]
        public void CallFadeDown_Test()
        {
            CallFadeDown(1f);
        }

        #endregion
    }
}