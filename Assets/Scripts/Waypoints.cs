using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Waypoints : MonoBehaviour
{
    public Transform Itan;
    public float stopDistance;
    public NavMeshAgent nav;
    public Vector3 Player;
    float ofset = 1f;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        stopDistance = 1;
        nav.GetComponent<NavMeshAgent>();
        nav.updatePosition = true;
        nav.updateRotation = true;
        nav.stoppingDistance = stopDistance;
        
              
    }

    // Update is called once per frame
    void Update()
    {
        Player = new Vector3(Itan.position.x + ofset, Itan.position.y, Itan.position.z + ofset);
        nav.SetDestination(Player);

    }

}

