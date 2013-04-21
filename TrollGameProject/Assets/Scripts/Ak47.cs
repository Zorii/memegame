using UnityEngine;
using System.Collections;

public class Ak47 : MonoBehaviour {

	public Transform FirePoint;
	public int FusilMagazine;
	public GameObject BulletPrefab;
    public int Ammo = 20;
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
	if(FusilMagazine > 0) {
	  Ammo = 20;
	  FusilMagazine = FusilMagazine -1;
	  }
	}
}