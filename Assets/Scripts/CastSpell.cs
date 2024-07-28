using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastSpell : MonoBehaviour
{
    public bool deathSpellUnlocked;
    public bool waterSpellUnlocked;
    public bool lightningSpellUnlocked;
    public Image deathImage;   
    public Image waterImage;
    public Image lightningImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(deathSpellUnlocked)
        {
            deathImage.color = Color.white;
        }
        if(waterSpellUnlocked)
        {
            waterImage.color = Color.blue;
        }
        if(lightningSpellUnlocked)
        {
            lightningImage.color = Color.yellow;
        }
    }
}
