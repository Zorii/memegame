using UnityEngine;
using System.Collections;

public class RPG : MonoBehaviour {

	public GameObject RocketPrefab;
    public GameObject Rocket;
	public int Ammo = 6;
	public GameObject Stickman;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
	public void LaunchRocket() {
	 if(Ammo > 0){
     Ammo = Ammo-1;
	 GameObject RocketInstantiate = (GameObject)GameObject.Instantiate(RocketPrefab,Rocket.transform.position,Rocket.transform.rotation);
	 RocketInstantiate.rigidbody.AddForce(new Vector3(0,0,0));
	 Rocket.renderer.enabled = false;
	 
	}
  }
    public void Reload() {
	 
	}
}
