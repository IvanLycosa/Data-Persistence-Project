using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UserInput : MonoBehaviour
{
    public GameObject inputField;
    public string theName;
    [SerializeField] private TextMeshProUGUI playerName;    

    public void InputName()
    {
        //theName = inputField.GetComponent<Text>().text;
        playerName.SetText("Hello");
        Debug.Log(inputField.GetComponent<Text>().text);
    }

    
}
