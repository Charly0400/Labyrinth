using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

  [RequireComponent(typeof(NavMeshAgent))]
public class NPC_Clicker : MonoBehaviour
{
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        PlusOneInt(out int valor);

        Debug.Log(valor);
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
            {
                Debug.Log(hit.point);
            }
        }
    }

    void PlusOneInt(out int variable)
    {
        variable = 1;
        variable++;
    }
}
