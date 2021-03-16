using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
using System.Collections;

/*used on injection vial 2; */
public class vial : MonoBehaviour
{
    public Image handv;
    public Image handv1;
    public Image handv2;

    public GameObject next;
    public GameObject redarrow;
    public GameObject rarrow;
    public GameObject loadnext;

    public Text Dname;
    public Text Dtext;
    public int _count = 1;

    public void vialhand(){
        _count=_count+1;
        if(_count == 2){
            next.SetActive(true);
            redarrow.SetActive(false);

            handv.gameObject.SetActive(false);
            handv1.gameObject.SetActive(true);

            Dtext.text = "Perfect! Now that the needle is inside the vial, we can fill the syringe.";
            Dname.text = "Dr. Diana";
        }
        else if(_count == 3){
            next.SetActive(false);
            rarrow.SetActive(true);

            Dtext.text = "Drag the plunger up to fill the syringe with insulin.";
            Dname.text = "Dr. Diana";
        }
        
        else if(_count == 4){
            loadnext.SetActive(true);
            rarrow.SetActive(false);

            handv1.gameObject.SetActive(false);
            handv2.gameObject.SetActive(true);

            Dtext.text = "Nice! Now that we’ve filled the syringe with insulin, we are ready to inject.";
            Dname.text = "Dr. Diana";
        }
    }
}
