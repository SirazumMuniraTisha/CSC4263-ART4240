using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    public int curhealth;
    public int maxhealth = 5;
    void Start()
    {
        curhealth = 0;

    }

    void Update()
    {
        if (curhealth >= maxhealth)
            curhealth = maxhealth;

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Tcell")
        {
            curhealth += 1;

            Destroy(other.gameObject);
        }
    }
}
