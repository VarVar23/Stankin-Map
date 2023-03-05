using UnityEngine;
using UnityEngine.AI;

public class Test : MonoBehaviour
{
    [SerializeField] private Transform _classRoom;
    [SerializeField] private NavMeshAgent _agent;

    void Update()
    {
        _agent.SetDestination(_classRoom.position);
    }
}
