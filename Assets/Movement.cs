using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    void Start()
    {
        transform.DOMoveX(625f, 5f)
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.InOutSine);

        transform.DOMoveY(50f, .2f)
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.InOutSine);
    }
}
