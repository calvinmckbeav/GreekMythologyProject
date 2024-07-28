using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    public static bool swordEquipped;
    public GameObject sword;
    // Start is called before the first frame update
    void Start()
    {
        swordEquipped = false;
        sword.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(swordEquipped)
        {
            sword.SetActive(true);
            if(Input.GetButtonDown("Fire1"))
            {
                sword.GetComponent<Animator>().SetTrigger("SwingSword");
            }
        }

    }
}
