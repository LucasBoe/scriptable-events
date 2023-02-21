using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ScriptableEventListener_Base : MonoBehaviour
{
    [SerializeField] ScriptableEvent scriptableEvent;

    protected virtual void OnEnable() => scriptableEvent.AddListener(OnGotCalled);
    protected virtual void OnDisable() => scriptableEvent.RemoveListener(OnGotCalled);
    protected abstract void OnGotCalled();
}