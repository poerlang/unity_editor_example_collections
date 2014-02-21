using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor (typeof(MainCam))]
public class MainCamEditor : PropertyEditor {
	private SerializedProperty p0;
	private SerializedProperty p1;
	private SerializedProperty p2;
	protected override void Initialize(){
		p0 = serializedObject.FindProperty("p0");
		p1 = serializedObject.FindProperty("p1");
		p2 = serializedObject.FindProperty("p2");
	}
	public override void OnInspectorGUI (){
		BeginEdit ();
			BeginSection ("h4");
				PropertyField ("h5", p0);
				Comment ("SomeThing to say");
				MinMaxPropertySliderFields ("h6", p1, p2, 0f, 100f);
			EndSection ();
		EndEdit ();
	}
}

