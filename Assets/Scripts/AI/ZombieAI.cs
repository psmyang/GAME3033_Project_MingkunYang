using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;

    public float walkSpeed = 1;

    public Transform target;

    public float attackDistance = 3;
    public bool isAttacking = false;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        agent.speed = walkSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        SetAttackAnimationBool();

        if(agent.remainingDistance <= attackDistance)
        {
            isAttacking = true;
        }
        else
        {
            isAttacking = false;
        }
    }

    private void SetAttackAnimationBool()
    {
        animator.SetBool("attack", isAttacking);
    }
}
