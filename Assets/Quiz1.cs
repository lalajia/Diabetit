using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Quiz1 : MonoBehaviour {

	public Text BText1; //DText

	public Text BText2; //QText

	public Text SText1; //DName

	public Text SText2; //Quiz

	public int _int = 1;

	public GameObject FChoice;

	public GameObject SChoice;

	public GameObject TChoice;

	public GameObject nextbutton;

	public GameObject layer;
	
	public GameObject dialogbox;

	//public GameObject hand;



public	void talking()
	{

			_int = _int + 1;	
			///////////// quiz //////////////

		if(_int == 2)
			{
				BText1.text = "";
				SText1.text = "";
				
				BText2.text = "How long should you scrub your hands for?";
				SText2.text = "Quiz Time";

				dialogbox.SetActive(true);
				
			}

		else	if(_int == 3)
			{
				BText1.text = "";
				SText1.text = "";
				
				BText2.text = "How long should you scrub your hands for?";
				SText2.text = "Quiz Time";

				nextbutton.SetActive(false);
				FChoice.SetActive(true);
				SChoice.SetActive(true);
				TChoice.SetActive(true);
				layer.SetActive(true);

				dialogbox.SetActive(true);
				
			}

			/// After Choices ///


		else	if(_int == 100)
			{
				BText1.text = "<b>Your turn!</b> Keep tapping on your hands to get rid of the germs!";
				SText1.text = "Dr.Diana";
				
				BText2.text = "";
				SText2.text = "";

				nextbutton.SetActive(false);

				dialogbox.SetActive(false);
			}

			else	if(_int == 101)
			{
				BText1.text = "Keep tapping until they’re all clean.";
				SText1.text = "Dr.Diana";
				
				BText2.text = "";
				SText2.text = "";
				nextbutton.SetActive(false);
				//hand.SetActive(true);
			}


		}



	/// CHOICE TIME ///

	public void FS()
	{
		BText1.text = "That’s too short! Try again.";
		SText1.text = "Quiz Time";
		
		BText2.text = "";
		SText2.text = "";

		_int = 2;

		FChoice.SetActive(false);
		SChoice.SetActive(false);
		TChoice.SetActive(false);
		layer.SetActive(false);
		nextbutton.SetActive(true);

		dialogbox.SetActive(true);

	}

	public void T()
	{


		BText1.text = "You got it! Scrub your hands with soap and water for at least <b>30 seconds</b> to thoroughly clean them.";
		SText1.text = "Quiz Time";
		
		BText2.text = "";
		SText2.text = "";

		_int = 99;

		nextbutton.SetActive(true);
		FChoice.SetActive(false);
		SChoice.SetActive(false);
		TChoice.SetActive(false);
		layer.SetActive(false);

		dialogbox.SetActive(true);
	}

}