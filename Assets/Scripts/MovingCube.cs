using UnityEngine;
using System.Collections;

public class MovingCube : MonoBehaviour 
{
	public float m_Speed = 0.1f;
    
	private Vector3 translation_vector = Vector3.forward;

    private Vector3 start_pos;

    private Camera main_camera;

    private bool loop_back = false;

	public void ToggleJump()
	{
        if (transform.position.y <= 1f) {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
        }
		
	}

    public void Start()
    {
        start_pos = transform.position;
        main_camera = Camera.main;
    }

    void Update() 
	{

        if (loop_back) {
            //Loop back to start
            transform.position = start_pos;
            loop_back = false;
        }
        transform.Translate(translation_vector * Time.deltaTime * m_Speed);
	}

    void OnBecameInvisible()
    {
        //out of camera view
        loop_back = true;
    }

    void OnBecameVisible()
    {
        loop_back = false;
    }
}
