using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class NotesBase : MonoBehaviour {
	public GameObject stickyNoteTemplate = null;
	static public List<GameObject> stickyNotes = new List<GameObject>();
	public Canvas kanwas = null;
	public InputField inputF;
	private Text tekst = null; 
	
	// Use this for initialization
	void Start () {
		tekst = stickyNoteTemplate.GetComponent<Text>();
		tekst.text = "Nowa nooootka";
	}
	public void deleteSticky()
	{
		Destroy(stickyNotes[0].gameObject);
	}
	public void addNote()
	{
		/*
		zGameObject g = (GameObject)Instantiate(_enemy, pos, Quaternion.identity);
		PathFinding2Script n = g.GetComponent<PathFinding2Script>();
		MonsterScript _tmpMonster = g.GetComponent<MonsterScript>();
		n.stations = Stations; */
		Vector2 tmpPos = new Vector2();
		if(stickyNotes.Count == 0)
		{
			tmpPos = this.gameObject.transform.position;
			tmpPos.y -= 10;
		}else
		{
			tmpPos = stickyNotes[stickyNotes.Count - 1 ].transform.position;
			tmpPos.y -= 50;
		}
		GameObject tmp = stickyNoteTemplate;

		tmp.transform.position = tmpPos;

		//tekst.text = inputF.text.text;

		stickyNotes.Add(tmp);
		Instantiate(stickyNotes[stickyNotes.Count - 1 ], tmpPos, Quaternion.identity);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
