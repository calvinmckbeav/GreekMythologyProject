using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Text itemInfo;
    public Text dialogueText;
    public Slider healthSlider;
    public Image reticle;


    private bool inDialogue;

    private Talkable talker;


    void Start()
    {
        itemInfo.gameObject.SetActive(false);
        dialogueText.gameObject.SetActive(false);

        inDialogue = false;
    }

    private void Update()
    {
        if (!inDialogue)
        {
            ItemDetect();
        }
        else
        {
            DialogueSequence();
        }
    }

    void ItemDetect()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.TryGetComponent(out ItemAttribute item))
            {
                itemInfo.text = item.textDescription;
                itemInfo.gameObject.SetActive(true);

                if (Input.GetKeyDown(item.interactKey))
                {
                    item.Interact();
                }
            }

            else
            {
                itemInfo.gameObject.SetActive(false);
            }
        }

    }

    public void DialogueON(Talkable talker)
    {
        this.talker = talker;

        MouseLook.active = false;
        PlayerController.active = false;

        inDialogue = true;
        dialogueText.text = talker.GetDialogue();

        itemInfo.gameObject.SetActive(false);
        dialogueText.gameObject.SetActive(true);
        healthSlider.gameObject.SetActive(false);
        reticle.gameObject.SetActive(false);
    }

    public void DialogueOFF()
    {
        MouseLook.active = true;
        PlayerController.active = true;

        inDialogue = false;

        dialogueText.gameObject.SetActive(false);
        healthSlider.gameObject.SetActive(true);
        reticle.gameObject.SetActive(true);
    }

    void DialogueSequence()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            dialogueText.text = talker.GetDialogue();
        }
    }


}
