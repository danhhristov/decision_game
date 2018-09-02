using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class Rail : MonoBehaviour
{

    public Transform[] nodes;

    // Use this for initialization
    void Start()
    {
        nodes = GetComponentsInChildren<Transform>();
        Debug.Log(nodes.Length);
    }

    public Vector3 LinearPosition(int seg, float ratio)
    {
        Vector3 p1 = nodes[seg].position;
        Vector3 p2 = nodes[seg + 1].position;
        return Vector3.Lerp(p1, p2, ratio);
    }

    private void OnDrawGizmos()
    {
        for (int i = 1; i < nodes.Length - 2; i++)
        {
            Handles.DrawDottedLine(nodes[i].position, nodes[i + 1].position, 3f);
        }

    }


}
