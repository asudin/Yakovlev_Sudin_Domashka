using Assets.Homework_2.Source.Scripts.StateMachine.State.Configs;
using UnityEngine;

namespace Assets.Homework_2.Source.Scripts
{
    [CreateAssetMenu(fileName = "WorkerConfig", menuName = "Configs/WorkerConfig")]
    public class WorkerConfig : ScriptableObject
    {
        [field: SerializeField] public RunningStateConfig RunningStateConfig { get; private set; }
        [field: SerializeField] public ActionStatesConfig ActionStatesConfig { get; private set; }
    }
}
