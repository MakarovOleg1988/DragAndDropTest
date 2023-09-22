using UnityEngine;
using UnityEngine.EventSystems;

namespace Test
{
    public class UIItem : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
    {
        private RectTransform _rectTransformItem;
        private Canvas _mainCanvas;
        private CanvasGroup _canvasGroupItem;

        private void Start()
        {
            _rectTransformItem = GetComponent<RectTransform>();
            _mainCanvas = GetComponentInParent<Canvas>();
            _canvasGroupItem = GetComponent<CanvasGroup>();
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            var slotTransform = _rectTransformItem.parent;
            slotTransform.SetAsLastSibling();

            _canvasGroupItem.blocksRaycasts = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            _rectTransformItem.anchoredPosition += eventData.delta/_mainCanvas.scaleFactor;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            transform.localPosition = Vector3.zero;

            _canvasGroupItem.blocksRaycasts = true;
        }
    }
}

