using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructableBox : ItemAttribute
{
    public GameObject exploded;

    public void Destruct()
    {
        GameObject broken = Instantiate(exploded, transform.position, transform.rotation);

        Destroy(gameObject);
    }

    public override void Interact()
    {
        Destruct();
    }
}
