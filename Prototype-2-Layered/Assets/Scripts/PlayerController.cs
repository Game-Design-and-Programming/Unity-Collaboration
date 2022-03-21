using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float xRange;

    public GameObject projectilePrefab;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Player"));
        offset = transform.position - projectilePrefab.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Player Movement.
         */
        var horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        /*
         * Fling Food
         */
        if (Input.GetKey(KeyCode.Space))
        {
            // Launch projectile.
            Debug.Log("Fling");
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
