﻿using UnityEngine;
using UnityEngine.EventSystems;

namespace Test
{
    public class UISlot : MonoBehaviour, IDropHandler
    {
        public void OnDrop(PointerEventData eventData)
        {
            var otherItemTransform = eventData.pointerDrag.transform;
            otherItemTransform.SetParent(transform);
            otherItemTransform.localPosition = Vector3.zero;     
        }
    }
}

