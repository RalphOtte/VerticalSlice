using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour
{
    [SerializeField]
    private CharacterData characterData;

    [SerializeField]
    private Text maxhealthGUI;
    [SerializeField]
    private Text maxmanaGUI;
    [SerializeField]
    private Text healthGUI;
    [SerializeField]
    private Text manaGUI;

    private string maxhealthString;
    private string maxmanaString;
    private string healthString;
    private string manaString;

    void Update()
    {
        maxhealthString = Mathf.Floor(characterData.maxhealth).ToString();
        maxhealthGUI.text = maxhealthString;
        maxmanaString = Mathf.Floor(characterData.maxmana).ToString();
        maxmanaGUI.text = maxmanaString;
        healthString = Mathf.Floor(characterData.health).ToString();
        healthGUI.text = healthString;
        manaString = Mathf.Floor(characterData.mana).ToString();
        manaGUI.text = manaString;
    }

}
