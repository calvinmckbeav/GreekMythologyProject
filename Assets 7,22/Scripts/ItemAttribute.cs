using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemAttribute : MonoBehaviour
{
    public string textDescription;
    public KeyCode interactKey;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Item";
    }

    public abstract void Interact();





}
