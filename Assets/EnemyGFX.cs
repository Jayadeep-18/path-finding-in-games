using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    // Start is called before the first frame update
    public AIPath aipath;

    // Update is called once per frame
    void Update()
    {
        if(aipath.desiredVelocity.x>=0.01f)
        {
            transform.localScale = new Vector3(-4f, 4f, 4f);
        }else if(aipath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(4f, 4f, 4f);
        }
    }
}
