using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PoliciaDINKI1 : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController controller;
    private Animator anim;
    private GameObject jogador;
    private NavMeshAgent navAgent;

    void Start()
    {
        //controller = GetComponent<CharacterController>();
      anim = GetComponent<Animator>();
        Looking();
        jogador = GameObject.FindGameObjectWithTag("Player");
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navAgent.destination = jogador.transform.position;
    }
    private void Looking()
    {
        anim.SetBool("Looking", false);  
        anim.SetBool("Walking", true);
        anim.SetBool("Idle", false);

    }
}
