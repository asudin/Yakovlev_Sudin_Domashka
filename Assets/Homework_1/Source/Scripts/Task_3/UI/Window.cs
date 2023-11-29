using System;
using UnityEngine;
using DG.Tweening;

namespace BallsPattern
{
    [RequireComponent(typeof(Canvas))]
    [RequireComponent(typeof(CanvasGroup))]
    public abstract class Window : MonoBehaviour
    {
        [Header("Canvas Fields")]
        [SerializeField] protected Canvas _setCanvas;
        [SerializeField] protected CanvasGroup _setCanvasGroup;

        private void Reset()
        {
            _setCanvas = GetComponent<Canvas>();
            _setCanvasGroup = GetComponent<CanvasGroup>();
        }

        public void Show(bool state, float animationTime = 0)
        {
            _setCanvasGroup.alpha = Convert.ToInt32(!state);

            if (animationTime > 0)
            {
                _setCanvasGroup.DOFade(Convert.ToInt32(state), animationTime).SetUpdate(UpdateType.Normal, true);
            }
            else
            {
                _setCanvasGroup.alpha = Convert.ToInt32(state);
            }
        }
    }
}