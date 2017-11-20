using System.Collections;
using UnityEngine;


public class ColorBlink : MonoBehaviour {  
    
    
    public SpriteRenderer square; //object to blink
    Color32 tempColor = new Color32(255, 20, 20, 0); 
    bool blinkBool = false;

    
void MyFunction() {
    
    if (true) {    //if something happened
    blinkBool = true;
    }
    
}
    
    
    IEnumerator BlinkNow() { 
        
        blinkBool = false;
        Color32 firstColor = square.color;
        
        for (int i = 0; i < 20; i++) {
            square.color = tempColor;
            tempColor = new Color32(255, 20, 20, tempColor.a += 10);
            yield return new WaitForSeconds(0.03f);
        }

        for (int i = 0; i < 19; i++) {
            square.color = tempColor;
            tempColor = new Color32(255, 20, 20, tempColor.a -= 10);
            yield return new WaitForSeconds(0.03f);
        }   
        
        square.color = firstColor;

    }    
    

    
    void Update() {
        
        if (blinkBool) {
            StartCoroutine(BlinkNow());
        }
        
    }
    
    
}
