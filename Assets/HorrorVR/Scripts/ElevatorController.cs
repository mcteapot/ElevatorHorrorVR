using UnityEngine;
using System.Collections;

public enum Floors {
	FloorTravel00, FloorArive00, FloorStart00, FloorTravel01, FloorArive01, FloorStart01, FloorTravel02, FloorArive02, FloorStart02
};
public class ElevatorController : MonoBehaviour {



		
	public Floors _floor;
	public Floors Floor
	{
		get { return _floor; }
		set {
			Debug.Log("FLOOOOOOOR SET");
			switch (value)
			{
				case Floors.FloorStart00:
					if(!ElevatorTraveling) {
						StartCoroutine("TravelFloor00");
						_floor = Floors.FloorTravel00; 
						
					}
				break;
				default:
					if(!ElevatorTraveling) {
						_floor = value; 

					}
				break;

			}

		}



	}

	public bool ElevatorTraveling;

	public AudioClip audioDoorClose;
	AudioSource audio;



	// Use this for initialization
	void Start () {
		ElevatorTraveling = false;
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Transform[] buttons;

	public ElevatorDoorController elevatorDoorController;


	private IEnumerator TravelFloor00() {
		//close doors
		Debug.Log("Doors Closing");
		ElevatorTraveling = true;
		elevatorDoorController.CloseDoors();
		audio.PlayOneShot(audioDoorClose, 1.0F);

		yield return new WaitForSeconds(5.0f);
		// Do Stuff
		yield return new WaitForSeconds(1.0f);
		// open doors
		Debug.Log("Doors Open");
		elevatorDoorController.OpenDoors();
		yield return new WaitForSeconds(5.0f);
		// 
		print("WaitAndPrint " + Time.time);
		Floor = Floors.FloorArive00;
		ElevatorTraveling = false;
	}
		


}
