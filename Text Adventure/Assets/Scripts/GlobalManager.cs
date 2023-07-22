using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class GlobalManager : MonoBehaviour
{
    [HideInInspector] public ScenarioManager scenarioManager;

    [SerializeField]
    TMP_Text mainTxt;
    
    [SerializeField]
    Button btn1;
    
    [SerializeField]
    Button btn2;

    void Start()
    {
        scenarioManager = GetComponent<ScenarioManager>();
        
    }

    void Update()
    {
        DisplayTextAndChoices();
    }

    public void DisplayTextAndChoices()
    {
        mainTxt.text = scenarioManager.currentScenario.storyText;
        btn1.GetComponentInChildren<TMP_Text>().text = scenarioManager.currentScenario.choice1;
        btn2.GetComponentInChildren<TMP_Text>().text = scenarioManager.currentScenario.choice2;

    }

    public void Button1Clicked()
    {
        scenarioManager.currentScenario = scenarioManager.currentScenario.branch1;
    }

    public void Button2Clicked()
    {
        scenarioManager.currentScenario = scenarioManager.currentScenario.branch2;
    }

}

/* To do: 
 * Varje scenario ska kunna bestämma om spelaren får 1-4 val. Beroende på detta kommer UIn spawna in rätt antal knappar. */
