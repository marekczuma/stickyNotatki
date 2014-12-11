using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ButtonAddNoteScript : MonoBehaviour {
	//public GameObject stickyNote;
	public GameObject kanwas;
	public GameObject note;
	public InputField fieldOfText;

	private Vector3 nextNotePosition;
	// Use this for initialization
	void Start () {
		nextNotePosition = this.transform.position;
		nextNotePosition.y -= 110;
	}
	public void AddNote()
	{
		//Instantiate (stickyNote);

		GameObject tmpNote = Instantiate (note, nextNotePosition, Quaternion.identity) as GameObject;
		tmpNote.transform.SetParent (kanwas.transform);
		tmpNote.transform.GetChild (0).GetComponent<Text> ().text = fieldOfText.text ;
		CalculateNextPosition ();
	}
	void CalculateNextPosition()
	{
		nextNotePosition.y -= 160;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
