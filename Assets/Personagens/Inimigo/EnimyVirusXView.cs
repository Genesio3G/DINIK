using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnimyVirusXView : MonoBehaviour
{

    public float radius;
    [Range(0, 360)]
    public float angle;

    public GameObject playerRef;


    private CharacterController controller;
    private Animator anim;
    private GameObject jogador;
   
    private NavMeshAgent navAgent;


    public LayerMask targetMask;
    public LayerMask obstructionMask;

    public bool canSeePlayer;
    // Start is called before the first frame update
    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(FOVRoutine());
        anim = GetComponent<Animator>();
        Looking();
        jogador = GameObject.FindGameObjectWithTag("Player");
        navAgent = GetComponent<NavMeshAgent>();
    }
    private IEnumerator FOVRoutine()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {
            yield return wait;
            FieldOfViewCheck();
        }

    }
    private void FieldOfViewCheck()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, targetMask);
        if (rangeChecks.Length != 0)
        {
            Transform target = rangeChecks[0].transform;
            Vector3 directionToTarget = (target.position - transform.position).normalized;
            if (Vector3.Angle(transform.forward, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);
                if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, obstructionMask))
                {
                    Walking();
                    canSeePlayer = true;

                    navAgent.destination = jogador.transform.position;

                }
                else
                {
                    Looking();
                    canSeePlayer = false;
                }
            }
            else { canSeePlayer = false; Looking(); }

        }
        else if (canSeePlayer)
        {
            Looking();
            canSeePlayer = false;
        }
    }
    private void Looking()
    {
        anim.SetBool("looking", true);
        anim.SetBool("walking", false);
      

    }
    private void Walking()
    {
        anim.SetBool("looking", false);
        anim.SetBool("walking", true);
        

    }
  
    // Update is called once per frame
    void Update()
    {
        FieldOfViewCheck();
    }
}
