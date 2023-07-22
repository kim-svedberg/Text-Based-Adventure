using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "TextAdventure/BaseScenario")]
public class BaseScenario : ScriptableObject
{
    [TextArea]
    public string storyText;
    public string choice1;
    public BaseScenario? branch1;
    public string choice2;
    public BaseScenario? branch2;
}
