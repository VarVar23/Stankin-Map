using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SSS : MonoBehaviour
{
    [SerializeField] private Transform[] _doors;
    [SerializeField] private NavMeshAgent _agent;
    public string nameDoors;

    private Dictionary<string, Transform> _doorsDictionary = new Dictionary<string, Transform>();


    void Start()
    {
        foreach(var o in _doors)
        {
            _doorsDictionary.Add(o.name, o);
        }

        Transform pos;

        _doorsDictionary.TryGetValue(nameDoors, out pos);

        _agent.SetDestination(pos.position);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
