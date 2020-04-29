using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateObjectiveText : MonoBehaviour
{
    public Text updater;
    public void setUpdater(string newText)
    {
        updater.text = newText;
    }
}