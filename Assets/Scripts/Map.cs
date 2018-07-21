using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
	public GameObject[][] wallsVertical;
	public GameObject[][] wallsHorizontal;
	public GameObject wallInstance;
	private int width;
	private int height;
	// Use this for initialization
	void Start () {
		this.width = 8;
		this.height = 8;

		this.wallsVertical = new GameObject[height][];
		for (int z = 0; z < this.wallsVertical.Length; z++) {
			this.wallsVertical[z] = new GameObject[width];
			for (int x = 0; x < this.wallsVertical[z].Length; x++) {
				if (z != 0) {
					this.wallsVertical[z][x] = Instantiate (wallInstance, new Vector3 (x * 10 + x, 0, z * 10 + z), new Quaternion (0, 0, 0, 0));
					Door a = this.wallsVertical[z][x].GetComponentInChildren<Door> ();
					if (x != 0 && x != this.wallsVertical[z].Length - 1) {
						a.destroy ();
					}
				}

			}
		}
		this.wallsHorizontal = new GameObject[height][];
		for (int z = 0; z < this.wallsHorizontal.Length; z++) {
			this.wallsHorizontal[z] = new GameObject[width];
			for (int x = 0; x < this.wallsHorizontal[z].Length; x++) {
				if (x != this.wallsHorizontal[z].Length - 1) {
					this.wallsHorizontal[z][x] = Instantiate (wallInstance, new Vector3 (x * 10 + x + 1, 0, z * 10 + z), new Quaternion (0, 0, 0, 0));
					this.wallsHorizontal[z][x].transform.rotation = Quaternion.Euler (0, 270f, 0);
					if (z != 0 && z != this.wallsHorizontal.Length - 1) {
						Door a = this.wallsHorizontal[z][x].GetComponentInChildren<Door> ();
						a.destroy ();
					}
				};
			}
		}
	}

	// Update is called once per frame
	void Update () {

	}
}