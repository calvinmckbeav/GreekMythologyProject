using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talkable : ItemAttribute
{
    public string[] dialogueStrings;
    public Vector2Int firstAndLastLine;

    int currentLine = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (textDescription.Equals(""))
        {
            textDescription = "Talkable [Press P to talk]";
        }

        interactKey = KeyCode.P;
    }

    public string GetDialogue()
    {

        currentLine++;
        if (currentLine > firstAndLastLine.y + 1)
        {

            currentLine = firstAndLastLine.x;
            Camera.main.GetComponent<PlayerUI>().DialogueOFF();
            return "";
        }
        return dialogueStrings[currentLine - 1];
    }

    public override void Interact()
    {
        PlayerUI playerUI = FindObjectOfType<PlayerUI>();
        playerUI.DialogueON(this);
        
    }
}
