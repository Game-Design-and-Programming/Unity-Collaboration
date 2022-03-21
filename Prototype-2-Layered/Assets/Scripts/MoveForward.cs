using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    public float limitT;
    public float limitB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);

        if (transform.position.z > limitT)
        {
            // Food -- moving up on screen.
            Destroy(gameObject);
        }
        else if (transform.position.z < limitB)
        {
            // Animal -- moving down on screen.
            Destroy(gameObject);
        }
    }
}
