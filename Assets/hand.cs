using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
using System.Collections;

public class hand : MonoBehaviour
{
    public Image hand1;
    public Image hand2;
    public Image hand3;
    public Image hand4;
    public Image finalhand;
    public GameObject next;
    public GameObject frontarrow;

    public Text Dname;
    public Text Dtext;
    public int _count = 1;

    public void clickHand(){
        _count = _count+1;
        if(_count == 2){
            next.SetActive(true);
            hand1.gameObject.SetActive(false);
            hand2.gameObject.SetActive(true);
            Dtext.text = "Keep tapping until they’re all clean.";
            Dname.text = "Dr. Diana";

        }
        else if(_count == 3){
            hand1.gameObject.SetActive(false);
            hand2.gameObject.SetActive(false);
            hand3.gameObject.SetActive(true);

            Dtext.text = "Keep tapping until they’re all clean.";
            Dname.text = "Dr. Diana"; 
        }
        else if(_count == 4){
            hand1.gameObject.SetActive(false);
            hand2.gameObject.SetActive(false);
            hand3.gameObject.SetActive(false);
            hand4.gameObject.SetActive(true);

            Dtext.text = "Yay! Tap to dry.";
            Dname.text = "Dr. Diana"; 
        }
        else if(_count == 5){
            hand1.gameObject.SetActive(false);
            hand2.gameObject.SetActive(false);
            hand3.gameObject.SetActive(false);
            hand4.gameObject.SetActive(false);
            finalhand.gameObject.SetActive(true);
            next.SetActive(false);
            frontarrow.SetActive(true);

            Dtext.text = "Nice going! Now that your hands are clean, we can safely move onto the injection.";
            Dname.text = "Dr. Diana"; 
        }
    }

}
