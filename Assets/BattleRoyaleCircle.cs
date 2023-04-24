using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleRoyaleCircle : MonoBehaviour
{
    public float shrinkSpeed = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x > 1) 
        {
            transform.localScale -= new Vector3(shrinkSpeed, shrinkSpeed, 0);
        }
    }
}
