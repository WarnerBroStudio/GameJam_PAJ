﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
  public GameObject[][] wallsVertical;
  public GameObject[][] wallsHorizontal;
  public GameObject wallInstance;
  public Player[] players;
  private int width = 0;
  private int height = 0;

  void Start () {
    this.width = this.width != 0 ? this.width + 1 : 5;
    this.height = this.height != 0 ? this.height + 1 : 5;

    this.wallsVertical = new GameObject[height][];
    for (int z = 0; z < this.wallsVertical.Length; z++) {
      this.wallsVertical[z] = new GameObject[width];
      for (int x = 0; x < this.wallsVertical[z].Length; x++) {
        if (z != 0) {
          this.wallsVertical[z][x] = Instantiate (wallInstance, new Vector3 (x * 10 + x, 0, z * 10 + z), new Quaternion (0, 0, 0, 0));
          if (x != 0 && x != this.wallsVertical[z].Length - 1) {
            Door door = this.wallsVertical[z][x].GetComponentInChildren<Door> ();
            door.destroy ();
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
            Door door = this.wallsHorizontal[z][x].GetComponentInChildren<Door> ();
            door.destroy ();
          }
        };
      }
    }
    this.wallsVertical[2][1].GetComponentInChildren<Switch> ().toggleState (this.players[0]);
    this.wallsVertical[2][2].GetComponentInChildren<Switch> ().toggleState (this.players[0]);
    this.wallsHorizontal[1][1].GetComponentInChildren<Switch> ().toggleState (this.players[0]);
    this.wallsHorizontal[2][1].GetComponentInChildren<Switch> ().toggleState (this.players[0]);
    // this.onWallChange ();
  }

  public void onWallChange () {
    for (int i = 0; i < this.players.Length; i++) {
      this.players[i].score = 0;
    }
    for (int z = 0; z < this.wallsHorizontal.Length; z++) {
      for (int x = 0; x < this.wallsHorizontal[z].Length; x++) {
        GameObject wall = this.wallsHorizontal[z][x];
        if (wall) {
          Switch switchComponent = wall.GetComponentInChildren<Switch> ();
          if (switchComponent.player) {
            bool full = true;
            if (
              (z + 1 >= this.wallsHorizontal.Length &&
              z + 1 >= this.wallsVertical.Length) ||
              this.wallsHorizontal[z + 1][x].GetComponentInChildren<Switch> ().player != switchComponent.player ||
              this.wallsVertical[z + 1][x + 1].GetComponentInChildren<Switch> ().player != switchComponent.player ||
              this.wallsVertical[z + 1][x].GetComponentInChildren<Switch> ().player != switchComponent.player
            ) {
              full = false;
            }
            if (full) {
              switchComponent.player.score++;
            }
          }
        }
      }
    }
    for (int i = 0; i < this.players.Length; i++) {
      this.players[i].updateScore ();
    }
  }
}