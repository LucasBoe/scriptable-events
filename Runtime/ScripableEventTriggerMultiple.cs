using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripableEventTriggerMultiple : MonoBehaviour
{
    [SerializeField] ScriptableEvent[] scriptableEvents;
    public void TriggerFirst() => TryTriggerByIndex(0);
    public void TriggerSecond() => TryTriggerByIndex(1);
    public void TriggerThird() => TryTriggerByIndex(2);
    public void TriggerFourth() => TryTriggerByIndex(3);
    public void TriggerFifth() => TryTriggerByIndex(4);
    public void TriggerSixth() => TryTriggerByIndex(5);
    public void TriggerSeventh() => TryTriggerByIndex(6);
    public void TriggerEighth() => TryTriggerByIndex(7);
    public void TriggerNinth() => TryTriggerByIndex(8);
    public void TriggerTenth() => TryTriggerByIndex(9);
    private void TryTriggerByIndex(int index)
    {
        if (scriptableEvents.Length <= index)
            return;

        scriptableEvents[index]?.Invoke();
    }
}