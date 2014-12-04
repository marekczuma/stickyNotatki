using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ContainerScript : MonoBehaviour {
	private List<GameObject> notesObject = new List<GameObject>();
	// Use this for initialization
	void Start () {
		
	}
	public void ShowList()
	{
		if(notesObject.Count > 0)
		{
			foreach(var element in notesObject)
			{
				Destroy(element.gameObject);
			}
		}
		foreach(var element in NotesBase.stickyNotes)
		{
			notesObject.Add(element);
		}
		foreach(var element in notesObject)
		{
			Vector2 tmpPos = element.transform.position;
			tmpPos.y -=10;
			Instantiate(element,tmpPos, Quaternion.identity);
			//element = this.gameObject
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
