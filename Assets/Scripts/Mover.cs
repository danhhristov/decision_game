using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public Rail railUp;
    public Rail railDown;
    private Rail currentRail;

    private int currentSeg = 1;
    private float transition;
    private bool isCompleted;

    // Use this for initialization
    void Start()
    {
        currentRail = railUp;
    }


    // Update is called once per frame
    private void Update()
    {

        if (!currentRail)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            if (currentSeg == 1)
            {
                Debug.Log("Changed direction");
                currentRail = railDown;
            }
        }

        if (!isCompleted)
            Play();
    }

    public void Play()
    {

        transition += Time.deltaTime * 1/2;
        if (transition > 1)
        {
            transition = 0;
            currentSeg++;
        }

        if (currentRail.nodes.Length - 1 == currentSeg)
        {
            isCompleted = true;
            return;
        }

        transform.position = currentRail.LinearPosition(currentSeg, transition);
    }
}
