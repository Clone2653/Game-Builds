using System;
using UnityEngine;
using UnityEngine.UI;

public class uiCHaracterCreator : Monobehavior {

//get the GUI elements
public UnityEngine.UI.Slider Hair;
public UnityEngine.UI.Slider Face;
public UnityEngine.UI.Slider Torso;
public UnityEngine.UI.Slider Legs;
public EnityEngine.UI.TextField Name;

//the username string
public static string Username = "Insert Name";

//The integers for the creationApply
public static int hairInt;
public static int faceInt;
public static int torsoInt;
public static int legsInt;

//gets the playing and the minifig model
public GameObject Minifig;
public GameObject Player;

//gets the hair models
public GameObject Hair_02_black;
public GameObject Hair_02_brown;
public GameObject Hair_05_yellow;

//gets the torso/leg textures
public Texture2D Torso1;
public Texture2D Torso2;
public Texture2D Torso3;
public Texture2D Torso4;


void Start() {

//Sets the integers
hairInt = (int)Hair.value;
faceInt = (int)Face.value;
torsoInt = (int)Torso.value;
legsInt = (int)Legs.value;

}

}
