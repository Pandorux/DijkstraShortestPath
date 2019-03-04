using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [Tooltip("What nodes is this node connected to")]
    public Node[] neighbors;



    private void OnDrawGizmos()
    {
        foreach (Node n in neighbors)
        {
            Gizmos.DrawLine(transform.position, n.transform.position);
        }
    }

}
