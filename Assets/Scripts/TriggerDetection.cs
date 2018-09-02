using System.Collections;
using UnityEngine;

public class TriggerDetection : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + " has colided with" + collision.gameObject.name);
    }
}
