using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class Rail : MonoBehaviour
{

    private Transform[] nodes;

    // Use this for initialization
    void Start()
    {
        nodes = GetComponentsInChildren<Transform>();
    }

    public Vector3 LinearPosition(int seg, float ratio)
    {
        Vector3 p1 = nodes[seg].position;
        Vector3 p2 = nodes[seg + 1].position;
        Debug.Log(Vector3.Lerp(p1, p2, ratio).ToString());
        return Vector3.Lerp(p1, p2, ratio);
    }

    private void OnDrawGizmos()
    {
        for (int i = 1; i < nodes.Length - 1; i++)
        {
            Handles.DrawDottedLine(nodes[i].position, nodes[i + 1].position, 3f);
        }

    }


}
