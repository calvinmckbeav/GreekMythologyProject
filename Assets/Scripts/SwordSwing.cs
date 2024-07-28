using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetButtonDown("Fire1"))
            {
                gameObject.GetComponent<Animator>().SetTrigger("SwingSword");
            }

    }
}
