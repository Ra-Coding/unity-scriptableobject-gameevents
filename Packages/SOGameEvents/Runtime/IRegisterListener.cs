using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RaCoding.GameEvents
{
    public delegate void OnEnableGameEventListener();
    public delegate void OnDisableGameEventListener();

    public interface IRegisterListener
    {
        OnEnableGameEventListener onEnableGameEventListener { get; set; }
        OnDisableGameEventListener onDisableGameEventListener { get; set; }
    }
}
