using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class HintScript : DefaultTrackableEventHandler {

    public string objectName = "Object";
    
    public Text hintText;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();

        hintText.enabled = true;
        hintText.text = "Found " + objectName + "!";

        Invoke("HideHint", 3f);
    }

    private void HideHint()
    {
        hintText.enabled = false;
    }

}
