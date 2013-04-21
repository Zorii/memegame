using UnityEngine;
using System.Collections;

public class Pistola : MonoBehaviour {

	public Transform FirePoint;
	public int PistolMagazine;
	public GameObject BulletPrefab;
    public int Ammo = 15;
	public GameObject Stickman;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
	public void LaunchBullet() {
	 if(Ammo > 0){
     Ammo = Ammo-1;
	 GameObject BulletInstantiate = (GameObject)GameObject.Instantiate(BulletPrefab,FirePoint.position,FirePoint.rotation);
	 BulletInstantiate.rigidbody.AddForce(new Vector3(0,0,0));
	}
  }
	/// <summary>
	/// Reload the pistol and decrease a magazine.
	/// </summary>
    public void Reload() {
	if(PistolMagazine > 0) {
	  Ammo = 15;
	  PistolMagazine = PistolMagazine -1;
	  }
	}
}