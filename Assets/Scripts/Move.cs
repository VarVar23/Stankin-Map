using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    [SerializeField] private Transform[] _doorsPosition;
    [SerializeField] private NavMeshAgent _agent;

    private Dictionary<string, Transform> _doorsNumbersDictionary = new Dictionary<string, Transform>();
    private Transform _finishTransform;
    private Transform _startTransform;

    void Start()
    {
        foreach (var door in _doorsPosition)
        {
            _doorsNumbersDictionary.Add(door.name, door);
        }
    }

    public void GoingToFinishPoint(string startPoint, string finishPoint)
    {
        if (startPoint == null || finishPoint == null)
            return;

        _doorsNumbersDictionary.TryGetValue(startPoint, out _startTransform);
        _agent.enabled = false;
        _agent.transform.position = _startTransform.position;
        _agent.enabled = true;

        _doorsNumbersDictionary.TryGetValue(finishPoint, out _finishTransform);

        _agent.SetDestination(_finishTransform.position);
    }
}
