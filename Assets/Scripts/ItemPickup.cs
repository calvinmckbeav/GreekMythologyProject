using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public GameObject player;
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickUp()
    {
        Debug.Log("pickup called");
        if(gameObject.tag == "Item")
        {
            SwordSwing.swordEquipped = true;
            Destroy(gameObject, 0.2f);
        }
            
    }
}
