using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleWalk : MonoBehaviour
{
    public Transform[] walkPoints;
    public float walk_speed = 1f;
    public bool isIdle;

    private int walk_Index;

    private UnityEngine.AI.NavMeshAgent navAgent;
    private Animator anim;


    void Awake()
    {
        anim = GetComponent<Animator>();
        navAgent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
    }

    void Start()
    {
        if(isIdle) {
            anim.Play("Idle");
        } else {
            anim.Play("Walk");
        }
    }

    void Update()
    {
        if (!isIdle) {
            ChooseWalkPoint();
        }   
    }

    void ChooseWalkPoint() {
        if (navAgent.remainingDistance <= 0.1f) {
            navAgent.SetDestination (walkPoints [walk_Index].position);

            if (walk_Index == walkPoints.Length - 1 ) {
                walk_Index = 0;
            } else {
                walk_Index++;
            }
        }
    }
}
