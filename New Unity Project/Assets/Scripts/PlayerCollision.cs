using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter (UnityEngine.Collision collisionInfo)
    {
        string objTag = collisionInfo.gameObject.tag;
        if(objTag == "Obsticle")
        {
            Debug.Log(objTag);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
