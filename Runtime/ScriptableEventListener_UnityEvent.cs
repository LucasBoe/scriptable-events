using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScriptableEventListener_UnityEvent : ScriptableEventListener_Base
{
    UnityEvent unityEvent;
    protected override void OnGotCalled() => unityEvent?.Invoke();
}
