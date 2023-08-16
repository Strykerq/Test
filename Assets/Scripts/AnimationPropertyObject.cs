using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AnimationPropertyObject
{
    [SerializeField] private WomenAnimator _animationNPC;



    public WomenAnimator AnimationNPC => _animationNPC;
}
