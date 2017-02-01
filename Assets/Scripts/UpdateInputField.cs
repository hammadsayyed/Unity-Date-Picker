using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UpdateInputField : MonoBehaviour {

    public InputField mainInputField;
    //https://msdn.microsoft.com/en-us/library/bb762911(v=vs.110).aspx


    public void UpdateField()
    {
        string text = EventSystem.current.currentSelectedGameObject.GetComponent<Button>().GetComponentInChildren<Text>().text;
        Debug.Log(text);
        mainInputField.text = text;
    } 
}
