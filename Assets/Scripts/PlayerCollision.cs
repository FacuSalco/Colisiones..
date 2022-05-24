using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(0, 0.5f, 0);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "DeathWall")
        {
            //Destroy(gameObject);
            transform.position  = new Vector3(0, 0.5f, 0);
        }

        
    }
}
