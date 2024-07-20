using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventCenter : BaseManager<EventCenter>
{
    private Dictionary<string, UnityAction<object>> eventDic = new Dictionary<string, UnityAction<object>>();
    public void AddListener(string name, UnityAction<object> action)
    {
        if (eventDic.ContainsKey(name))
        {
            eventDic[name] += action;
        }
        else
        {
            eventDic.Add(name,action);
        }
    }

    public void EventTrigger(string name,object o)
    {
        if (eventDic.ContainsKey(name))
        {
            eventDic[name].Invoke(o);
        }
    }

    public void RemoveListener()
    {
        
    }
}
