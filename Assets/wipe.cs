using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*used on injection wipe; */
public class wipe : MonoBehaviour
{
    public Image wipeup;
    public Image wipedown;
    public Image wipedone;

    public Text Dname;
    public Text Dtext;
    public int _count=1;
    private int i = 0;

    public GameObject frontarrow;
    

    public void wipeClick(){
        if(i < 5){
            if(_count == 1){
                wipeup.gameObject.SetActive(false);
                wipedown.gameObject.SetActive(true);
                Dtext.text = "Tap tap tap!";
                Dname.text = "Dr. Diana";
                _count = 0;
                i +=1;

            }
            else if(_count == 0){
                wipeup.gameObject.SetActive(true);
                wipedown.gameObject.SetActive(false);

                Dtext.text = "Tap tap tap!";
                Dname.text = "Dr. Diana"; 
                _count = 1;
                i+=1;
            }
        }
        else if(i == 5){
            wipeup.gameObject.SetActive(false);
            wipedown.gameObject.SetActive(false);
            wipedone.gameObject.SetActive(true);
            frontarrow.SetActive(true);
            Dtext.text = "All clean! Thank you!";
            Dname.text = "Dr. Diana"; 
        }
        
    }

}
