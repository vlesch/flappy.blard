using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float MoveSpeed = 5;
    public float deadzone = -30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;

        if (transform.position.x < deadzone)
        {
            Debug.Log("pipeDeleted");
            Destroy(gameObject);
        }
    }
}
