using System;
using UnityEngine;

namespace Assets.Homework_2.Source.Scripts.StateMachine.State.Configs
{
    [Serializable]
    public class ActionStatesConfig
    {
        [field: SerializeField, Range(0, 10)] public float ActionTime { get; private set; }
    }
}
