using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public Rail rail;

    private int currentSeg = 1;
    private float transition;
    private bool isCompleted;


    // Update is called once per frame
    private void Update()
    {

        if (!rail)
            return;

        if (!isCompleted)
            Play();
    }

    public void Play()
    {
        if (rail.nodes.Length - 2 == currentSeg) {
            return;
        }

        transition += Time.deltaTime * 1/2;
        if (transition > 1)
        {
            Debug.Log("transited" + transition);
            transition = 0;
            currentSeg++;
        }
        
        transform.position = rail.LinearPosition(currentSeg, transition);
    }
}
