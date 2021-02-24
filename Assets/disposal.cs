using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
using System.Collections;

public class disposal : MonoBehaviour
{
    public Image congrats;
    public Image dialogbox;

    public GameObject next;
    public GameObject trashcan;
    public GameObject trashcan1;
    public GameObject biocan;
    public GameObject biocan1;
    public GameObject main;

    public Text Dname;
    public Text Dtext;
    public int _count = 1;

    public void dispo(){
        if(_count == 1){
            trashcan.SetActive(true);
            biocan.SetActive(true);
            next.SetActive(false);
            trashcan1.SetActive(false);
            biocan1.SetActive(false);

            
            Dtext.text = "Now that we’re done with the syringe, we must dispose of it properly. Which bin does it belong in?";
            Dname.text = "Quiz Time";
        }
        else if(_count == 2){
            trashcan.SetActive(false);
            biocan.SetActive(false);
            next.SetActive(false);
            trashcan1.SetActive(false);
            biocan1.SetActive(false);

            congrats.gameObject.SetActive(true);
            dialogbox.gameObject.SetActive(false);
            main.SetActive(true);
            Dtext.text = "";
            Dname.text = "";

        }
    }

    public void SC(){
        Dtext.text = "<b>Correct!</b> Syringes have <b>needles</b>, which must be disposed of in a sharps disposal container. This is to reduce needle sticks and cuts from loose needles!";
        Dname.text = "Quiz Time";

        _count = 2;

        trashcan.SetActive(false);
        biocan.SetActive(false);
        next.SetActive(true);
        trashcan1.SetActive(false);
        biocan1.SetActive(true);    

    }

    public void FC(){
        Dtext.text = "<b>Incorrect!</b> Needles must be disposed separately from household trash. <b>Try again!</b>";
        Dname.text = "Quiz Time";

        _count = 1;

        trashcan.SetActive(false);
        biocan.SetActive(true);
        next.SetActive(true);
        trashcan1.SetActive(true);
        biocan1.SetActive(false);   
        
    }


}
