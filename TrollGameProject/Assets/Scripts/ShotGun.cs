using UnityEngine;
using System.Collections;

public class ShotGun : MonoBehaviour {

	public Transform FirePoint;
	public int FusilMagazine;
	public GameObject BulletPrefab;
    public int Ammo = 6;
	public GameObject Stickman;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    /// <summary>
    /// Launch four bullets.
    /// </summary>
	public void LaunchBullet() {
	 if(Ammo > 0){
     Ammo = Ammo-1;
	 //instantiate the 3 bullet of shotgun
	 GameObject BulletInstantiate1 = (GameObject)GameObject.Instantiate(BulletPrefab,FirePoint.position,Quaternion.Euler(0,0,0));
	 GameObject BulletInstantiate2 = (GameObject)GameObject.Instantiate(BulletPrefab,FirePoint.position,Quaternion.Euler(0,0,0));
	 GameObject BulletInstantiate3 = (GameObject)GameObject.Instantiate(BulletPrefab,FirePoint.position,Quaternion.Euler(0,0,0));
     //Apply physics 
	 BulletInstantiate1.rigidbody.AddForce(new Vector3(0,0,0));
     BulletInstantiate2.rigidbody.AddForce(new Vector3(0,0,0));
	 BulletInstantiate3.rigidbody.AddForce(new Vector3(0,0,0));

	}
  }
    /// <summary>
	/// Reload the pistol and decrease a magazine.
	/// </summary>
	public void Reload() {
	if(FusilMagazine > 0) {
	  Ammo = 60;
	  FusilMagazine = FusilMagazine -1;
	  }
	}
}