using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaletteTrigger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // checks if the player is stepping on the trigger
        if (other.gameObject.CompareTag("Player")){
            //  if the player has no paint ( just entered area ) and they step on the trigger
            if (Palette.paintRefill <= 0)
            {
                // give them the three tries
                Palette.paintCount = 3;
            }
        }
        // player has full paint change all the flowers to their base colors
        if (Palette.paintCount == 3)
        {
            ColorScript.changeColor(Flower1.flower1, ColorScript.yellow);
            Flower1.f1BaseColor = ColorScript.yellow;

            ColorScript.changeColor(Flower2.flower2, ColorScript.blue);
            Flower2.f2BaseColor = ColorScript.blue;

            ColorScript.changeColor(Flower3.flower3, ColorScript.yellow);
            Flower3.f3BaseColor = ColorScript.yellow;

            ColorScript.changeColor(Flower4.flower4, Color.white);
            Flower4.f4BaseColor = Color.white;

        }
    }
}
