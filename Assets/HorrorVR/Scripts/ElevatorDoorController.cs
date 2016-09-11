using UnityEngine;
using System.Collections;

public class ElevatorDoorController : MonoBehaviour {
	public	Transform	elevator;
	public	Transform	hallFrame;

	void Update () {
		if( Input.GetKeyDown( KeyCode.E ) ){
			OpenDoors();
		}

		if( Input.GetKeyDown( KeyCode.R ) ){
			CloseDoors();
		}
	}

	public void OpenDoors()
	{
		elevator.GetComponent<Animation>().clip 	= elevator.GetComponent<Animation>().GetClip( "OpenDoors" );
		hallFrame.GetComponent<Animation>().clip 	= elevator.GetComponent<Animation>().GetClip( "OpenDoors" );
		elevator.GetComponent<Animation>().Play();
		hallFrame.GetComponent<Animation>().Play();
	}

	public void CloseDoors()
	{
		elevator.GetComponent<Animation>().clip 	= elevator.GetComponent<Animation>().GetClip( "CloseDoors" );
		hallFrame.GetComponent<Animation>().clip 	= elevator.GetComponent<Animation>().GetClip( "CloseDoors" );
		elevator.GetComponent<Animation>().Play();
		hallFrame.GetComponent<Animation>().Play();	
	}
}
