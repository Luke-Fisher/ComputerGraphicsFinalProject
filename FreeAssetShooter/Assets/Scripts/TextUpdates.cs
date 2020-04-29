
using UnityEngine;
using UnityEngine.UI;

public class TextUpdates : MonoBehaviour
{

   

    public Text updateText;
    // Update is called once per frame

 
    public void fireAnimation(string newText)
    {
        updateText.text = newText;
    }
}
