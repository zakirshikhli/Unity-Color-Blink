using System.Collections;
using UnityEngine;

public class ColorBlink : MonoBehaviour
{   
    public SpriteRenderer square;
    Color32 tempColor = new Color32(255, 20, 20, 0);
    bool fadeBool = false;


    IEnumerator CellFade()
    {
        if (fadeBool)
        {
            fadeBool = false;

            for (int i = 0; i < 20; i++)
            {
                square.color = tempColor;
                tempColor = new Color32(255, 20, 20, tempColor.a += 10);
                yield return new WaitForSeconds(0.03f);
            }

            for (int i = 0; i < 19; i++)
            {
                square.color = tempColor;
                tempColor = new Color32(255, 20, 20, tempColor.a -= 10);
                yield return new WaitForSeconds(0.03f);
            }
        }

    }    

    private void Update()
    {
        if (fadeBool)
        {
            StartCoroutine(CellFade());
        }
    }
}
