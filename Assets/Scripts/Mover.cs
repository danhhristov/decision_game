using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public Rail rail;

    private int currentSeg;
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
        transition += Time.deltaTime * 2;
        if (transition > 1)
        {
            transition = 0;
            currentSeg++;
        }
        else if (transition < 0)
        {
            transition = 1;
            currentSeg--;
        }

        transform.position = rail.LinearPosition(currentSeg, transition);
    }
}
