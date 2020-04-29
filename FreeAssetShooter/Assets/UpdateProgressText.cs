using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateProgressText : MonoBehaviour
{
    public Text progress;
    public void setProgress(string newText)
    {
        progress.text = newText;
    }
}