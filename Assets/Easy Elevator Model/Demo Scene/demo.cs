using UnityEngine;
using System.Collections;

public class demo : MonoBehaviour {
	public	Transform	elevator;
	public	Transform	hallFrame;
	
	void Update () {
		if( Input.GetKeyDown( KeyCode.E ) ){
			elevator.GetComponent<Animation>().clip 	= elevator.GetComponent<Animation>().GetClip( "OpenDoors" );
			hallFrame.GetComponent<Animation>().clip 	= elevator.GetComponent<Animation>().GetClip( "OpenDoors" );
			elevator.GetComponent<Animation>().Play();
			hallFrame.GetComponent<Animation>().Play();
		}
		
		if( Input.GetKeyDown( KeyCode.R ) ){
			elevator.GetComponent<Animation>().clip 	= elevator.GetComponent<Animation>().GetClip( "CloseDoors" );
			hallFrame.GetComponent<Animation>().clip 	= elevator.GetComponent<Animation>().GetClip( "CloseDoors" );
			elevator.GetComponent<Animation>().Play();
			hallFrame.GetComponent<Animation>().Play();
		}
	}
}
