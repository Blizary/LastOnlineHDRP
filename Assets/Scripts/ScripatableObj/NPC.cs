﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewNPC", menuName = "ScriptableObj/ NPC", order = 4)]
public class NPC : ScriptableObject
{
    public Sprite npcImage;
    public string npcName;
    [TextArea]
    public string tooltipInfo;

    [Header("Rp Settings")]
    public Sprite playerIcon;
    public Sprite affiliationIcon;
    public string rpName;
    public string eyeColour;
    public string height;
    public string affiliation;
    public string rpClass;
    [TextArea] public string description;

}
