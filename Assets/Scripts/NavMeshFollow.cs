using UnityEngine;
using UnityEngine.AI;

public class NavMeshFollow : MonoBehaviour
{
    [SerializeField] private NavMeshAgent enemy;
    [SerializeField] private Transform Player;

   
   
    void Update()
    {
        enemy.SetDestination(Player.position);
    }
}
