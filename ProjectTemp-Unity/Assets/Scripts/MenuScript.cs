/****
* Created by: Runran Li
* Date Created: July 6, 2022
*
* Last Edited by:
* Last Edited:
*
* Description: Manages the UI elements for the menu scenes
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //libraries for UI components
using TMPro; //libraries for TextMeshPro components

public class MenuScript : MonoBehaviour
{
    [Header("Text Boxes")]
    public TMP_Text titleTextbox; //textbox for the title
    public TMP_Text creditsTextbox; //textbox for the credits
    public TMP_Text copyrightTextbox; //textbox for the copyright
    public TMP_Text mesageTextbox; //textbox for end message

    // Start is called before the first frame update
    void Start()
    {
        //set the value for textboxes
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnGameStart()
    {
        Debug.Log("Game Started");
    }//end OnGameStart()

    public void OnGameExit()
    {
        Debug.Log("Exited Game");
    }//end OnGameExit()

}
