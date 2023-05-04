using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent = null;

    private Animator anim;
    private Ray ray;
    private RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if(Physics.Raycast(ray,out hit))
            { 
                _agent.SetDestination(hit.point);
                anim.SetBool("Run", true);
                anim.SetBool("Attack", false);
            }
            else
            {
                anim.SetBool("Run", false);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            anim.SetBool("Run", false);
            anim.SetBool("Attack", true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Run", false);
        }
    }
}
