using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIscripts : MonoBehaviour
{

    public string TextBody;
    UnityEngine.UI.Text hudText;
    // Start is called before the first frame update
    void Start()
    {
        //TextBody = "Repair the Teleporter...";
        TextBody = "butthole teeeest";
        hudText.text = TextBody;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
