using System.Collections;
using UnityEngine;


public class ColorBlink : MonoBehaviour {  
    
    
    public SpriteRenderer square; //object to blink
    Color32 tempColor = new Color32(255, 20, 20, 0); 
    bool blinkBool = false;
    float blinkSpeed = 0.03f // less is faster
    
void MyFunction() {
    
    if (true) {    //if something happened
    blinkBool = true;
    }
    
}
    
    
    IEnumerator BlinkNow() { 
        
        blinkBool = false; // prevent loop more than once
        Color32 firstColor = square.color; // to restore first color
        // to red
        for (int i = 0; i < 20; i++) {
            square.color = tempColor;
            tempColor = new Color32(255, 20, 20, tempColor.a += 10);
            yield return new WaitForSeconds(blinkSpeed);
        }
        // back to transparence
        for (int i = 0; i < 19; i++) { // not 20 to prevent exception chance
            square.color = tempColor;
            tempColor = new Color32(255, 20, 20, tempColor.a -= 10);
            yield return new WaitForSeconds(blinkSpeed);
        }  
        //restore first color
        square.color = firstColor;
    }   

    
    void Update() {        
        if (blinkBool) {
            StartCoroutine(BlinkNow());
        }        
    }    
    
}
