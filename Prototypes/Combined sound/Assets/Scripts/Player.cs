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
}
