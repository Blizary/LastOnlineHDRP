using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FarPersonManager : MonoBehaviour
{
    public string playerName;

    public List<ChatConv> chatbox;
    [SerializeField] private GameObject inventoryOBJ;
    [SerializeField] private GameObject characterOBJ;
    [SerializeField] private string noTargetMessage;
    [SerializeField] private string friendlyTargetMessage;
    [SerializeField] private GameObject warningOBJ;
    [SerializeField] private GameObject targetFrame;
    [SerializeField] private GameObject targetName;
    [SerializeField] private GameObject targetIcon;
    [SerializeField] private GameObject optionsPanel;
    [SerializeField] private GameObject playerAwnser;
    [SerializeField] private GameObject rpPanel;
    [SerializeField] private GameObject tooltipPanel;


    public bool inChat;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /// <summary>
    /// Copies the chats into list to be used during the game
    /// </summary>
    void CopyChats()
    {

    }


    public void AbilityClicked()
    {
        if(player.GetComponent<ThirdPersonMovement>().hasTarget)
        {
            string oldText = warningOBJ.GetComponent<TextMeshProUGUI>().text;
            warningOBJ.GetComponent<TextMeshProUGUI>().text = friendlyTargetMessage;
            warningOBJ.GetComponent<TextMeshProUGUI>().text += "\n";
            warningOBJ.GetComponent<TextMeshProUGUI>().text += oldText;
            warningOBJ.GetComponent<WarningController>().StartTimer();
        }
        else
        {
            string oldText = warningOBJ.GetComponent<TextMeshProUGUI>().text;
            warningOBJ.GetComponent<TextMeshProUGUI>().text = noTargetMessage;
            warningOBJ.GetComponent<TextMeshProUGUI>().text += "\n" ;
            warningOBJ.GetComponent<TextMeshProUGUI>().text += oldText;
            warningOBJ.GetComponent<WarningController>().StartTimer();
        }
    }


    public void UpdateTarget(NPC _newTarget)
    {
        targetIcon.GetComponent<Image>().sprite = _newTarget.npcImage;
        targetName.GetComponent<TextMeshProUGUI>().text = _newTarget.npcName;
        targetFrame.SetActive(true);
        player.GetComponent<ThirdPersonMovement>().hasTarget = true;
    }

    public void NoTarget()
    {
        targetFrame.SetActive(false);
        player.GetComponent<ThirdPersonMovement>().hasTarget = false;
    }

    public void ChatStartButton()
    {
        inChat = true;
        optionsPanel.SetActive(true);
        for (int i = 0; i < optionsPanel.transform.childCount; i++)
        {
            optionsPanel.transform.GetChild(i).gameObject.SetActive(true);
        }
    }


    public void CloseChat()
    {
        inChat = false;
        optionsPanel.SetActive(false);
    }

    public void AddAwnser(char _letter)
    {
        playerAwnser.GetComponent<TextMeshProUGUI>().text += _letter;
        
    }

    public void ClearAwnser()
    {
        playerAwnser.GetComponent<TextMeshProUGUI>().text = "";
    }

    public void OpenRPPanel(NPC _npc)
    {
        rpPanel.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = _npc.rpName;
        rpPanel.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = _npc.eyeColour;
        rpPanel.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = _npc.height;
        rpPanel.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = _npc.affiliation;
        rpPanel.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = _npc.rpClass;
        rpPanel.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text = _npc.description;

        rpPanel.transform.GetChild(0).GetComponent<Image>().sprite = _npc.playerIcon;
        rpPanel.transform.GetChild(1).GetComponent<Image>().sprite = _npc.affiliationIcon;

        rpPanel.SetActive(true);
    }

    public void CloseRPPanel()
    {
        rpPanel.SetActive(false);
    }

    public void ShowToolTip(NPC _npc)
    {
        if(!tooltipPanel.activeInHierarchy || tooltipPanel.transform.GetChild(0).GetComponent< TextMeshProUGUI>().text!= _npc.tooltipInfo)
        {
            tooltipPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = _npc.tooltipInfo;
            tooltipPanel.SetActive(true);

        }
            
    }
    
    public void CloseToolTip()
    {
        if(tooltipPanel.activeInHierarchy)
        {
            tooltipPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "";
            tooltipPanel.SetActive(false);
        }
    }


    public void OpenInventory()
    {
        if(!inventoryOBJ.activeInHierarchy)
        {
            inventoryOBJ.SetActive(true);
        }
        else
        {
            inventoryOBJ.SetActive(false);
        }
        
    }

    public void CloseInventory()
    {
        inventoryOBJ.SetActive(false);
    }


    public void OpenCharacter()
    {
        if(!characterOBJ.activeInHierarchy)
        {
            characterOBJ.SetActive(true);
        }
        else
        {
            characterOBJ.SetActive(false);
        }
        
    }

    public void CloseCharacter()
    {
        characterOBJ.SetActive(false);
    }

   
}
