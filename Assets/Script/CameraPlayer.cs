using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public GameObject cabeca;
    public GameObject[] posicoes;
    private int indice = 0;
    public float velocidadeMovimento = 2;
    private RaycastHit hit;

    private void FixedUpdate()
    {
        transform.LookAt(cabeca.transform);
        if (!Physics.Linecast(cabeca.transform.position, posicoes[indice].transform.position))
        {
            transform.position = Vector3.Lerp(transform.position, posicoes[indice].transform.position, velocidadeMovimento*Time.deltaTime);
            Debug.DrawLine(cabeca.transform.position, posicoes[indice].transform.position);
                
        }else if(Physics.Linecast(cabeca.transform.position,posicoes[indice].transform.position, out hit)){
            transform.position = Vector3.Lerp(transform.position, hit.point, (velocidadeMovimento * 2) * Time.deltaTime);
            Debug.DrawLine(cabeca.transform.position, hit.point);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && indice <(posicoes.Length-1))
        {
            indice++;
        }else if (Input.GetKey(KeyCode.E) && indice>=(posicoes.Length-1))
        {
            indice = 0;
        }
    }
}
