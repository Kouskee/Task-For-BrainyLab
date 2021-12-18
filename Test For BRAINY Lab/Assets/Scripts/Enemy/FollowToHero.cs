using UnityEngine;
using UnityEngine.AI;

public class FollowToHero : MonoBehaviour
{
    [SerializeField] private Transform _targetHero;
    [SerializeField] private NavMeshAgent _agent;
    Vector3 posHero;
    public bool obstacle;

    void Update()
    {
        Follow();
    }

    void Follow()
    {
        if(_targetHero != null)
            posHero = _targetHero.position;

        transform.LookAt(posHero);
        _agent.isStopped = false;
        if (Vector3.Distance(posHero, this.transform.position) > 10f)
            _agent.SetDestination(posHero);
        else if(obstacle)
        {
            _agent.isStopped = false;
            _agent.SetDestination(posHero);
        }
        else
        {
            _agent.isStopped = true;
        }
    }

}
