using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FieldOfViewDINIK1 : MonoBehaviour
{
    public float radius;
    [Range(0, 360)]
    public float angle;
  
    public GameObject playerRef;
    public GameObject mask;

    private CharacterController controller;
    private Animator anim;
    private GameObject jogador;
    private NavMeshAgent navAgent;


    public LayerMask targetMask;
    public LayerMask obstructionMask;

    public bool canSeePlayer;

    public GameObject msg;
    GameOver gameOver;

    public GameObject fundo;
    public GameObject panel;
    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(FOVRoutine());
        anim = GetComponent<Animator>();
        Looking();
        jogador = GameObject.FindGameObjectWithTag("Player");
        navAgent = GetComponent<NavMeshAgent>();
        gameOver = msg.GetComponent<GameOver>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == jogador && mask.activeSelf != true)
        {
            
            Time.timeScale = 0;
            fundo.SetActive(true);
            panel.SetActive(false);
            gameOver.msgMP.text = "Foste apanhado pela policia";
        }
    }
    private void Looking()
    {
        anim.SetBool("Looking", true);
        anim.SetBool("Walking", false);
        anim.SetBool("Idle", false);

    }
    private void Walking()
    {
        anim.SetBool("Looking", false);
        anim.SetBool("Walking", true);
        anim.SetBool("Idle", false);

    }
    void Awake()
    {
        jogador = GameObject.FindGameObjectWithTag("Player");
     }
    private void Idle()
    {
        anim.SetBool("Looking", false);
        anim.SetBool("Walking", false);
        anim.SetBool("Idle", true);

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
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position,radius,targetMask);
        if (rangeChecks.Length != 0)
        {
            Transform target = rangeChecks[0].transform;
            Vector3 directionToTarget = (target.position - transform.position).normalized;
            if (Vector3.Angle(transform.forward,directionToTarget) <angle/2 )
            {
                float distanceToTarget = Vector3.Distance(transform.position,target.position);
                if (!Physics.Raycast(transform.position,directionToTarget, distanceToTarget, obstructionMask)&& mask.activeSelf !=  true)
                {
                    Walking();
                    canSeePlayer = true;
                   
                    navAgent.destination = jogador.transform.position;

                }
                else {
                    Looking();
                    canSeePlayer = false; 
                }
            }
            else {  canSeePlayer = false; Looking(); }

        }else if (canSeePlayer)
        {
            Looking();
            canSeePlayer = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        FieldOfViewCheck();
    }
}
