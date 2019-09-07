using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : SingletonMonoBehaviour<EventManager>
{
    SignalController controller = new SignalController();

    public T CreateOrGetSignal<T>(string signal)
    where T : Signal, new()
    {
        return controller.CreateOrGetSignal<T>(signal);
    }

    public T GetSignal<T>(string signal)
    where T : Signal
    {
        return controller.GetSignal<T>(signal);
    }

    public EmptySignal CreateActionSignal(string signal) => controller.CreateOrGetSignal<EmptySignal>(signal);

    public int AddAction(string signal, Action action)
    {
        var actionSignal = controller.GetSignal<EmptySignal>(signal);
        return actionSignal.Attach(action);
    }

    public void DeleteAction(string signal, int index)
    {
        var actionSignal = controller.GetSignal<EmptySignal>(signal);
        actionSignal.DeAttach(index);
    }
}
