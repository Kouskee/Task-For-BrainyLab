using UnityEngine;
using UnityEngine.AI;

public class FollowToHero : MonoBehaviour
{
    [SerializeField] private Transform _targetHero;
    [SerializeField] private NavMeshAgent _agent;
    Vector3 posHero;

    void Update()
    {
        Follow();
    }

    void Follow()
    {
        if(_targetHero != null)
            posHero = _targetHero.position;

        transform.LookAt(posHero);
        _agent.SetDestination(posHero);
    }

}
