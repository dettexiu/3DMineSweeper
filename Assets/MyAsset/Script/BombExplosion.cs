using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//外部からExplotion()が呼ばれると、爆発エフェクトを表示して自壊する
public class BombExplosion : MonoBehaviour {

	public GameObject explotion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Explotion(){
		//爆発エフェクトを発生させる
		Instantiate (explotion, transform.position, transform.rotation);
		//自身は消滅する
		Destroy (gameObject);
	}
}
