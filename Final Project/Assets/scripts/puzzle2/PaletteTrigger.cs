using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaletteTrigger : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // checks if the player is stepping on the trigger
        if (other.gameObject.CompareTag("Player")){
            //  if the player has no paint ( just entered area ) and they step on the trigger
            if (Palette.paintCount <= 0)
            {
                // give them the three tries
                Palette.paintCount = 3;
                // let circle follow the player now
                AreaDetection.startCircle = true;
                // change the circle to red
                AreaDetection.circleColor = 0;
            }
        }
        // player has full paint change all the flowers to their base colors
        if (Palette.paintCount == 3)
        {
            GreenFlower.gBaseColor = ColorScript.yellow;
            PurpleFlower.purpBaseColor = ColorScript.blue;
            OrangeFlower.oBaseColor = ColorScript.yellow;
            PinkFlower.pinkBaseColor = ColorScript.white;
            LBFlower.lbBaseColor = ColorScript.white;
        }
    }
}
