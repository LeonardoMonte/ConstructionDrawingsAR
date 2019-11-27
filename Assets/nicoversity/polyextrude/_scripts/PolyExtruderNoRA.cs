using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PolyExtruderNoRA : MonoBehaviour
{
      // enum for selecting example data (to be selected via Unity Inspector)

    // set up options (adjusted via Unity Inspector)
    public bool is3D = true;
    public bool enableMovement = false;
    public float extrusionHeight = 60.0f;

    // reference to setup example poly extruder 
    private PolyExtruder polyExtruder;
    private PolyExtruder polyExtruder2;
    private PolyExtruder polyExtruder3;
    private PolyExtruder polyExtruder4;
    private PolyExtruder polyExtruder5;

    private GameObject polyExtruderGO;
    private GameObject polyExtruderGO2;
    private GameObject polyExtruderGO3;
    private GameObject polyExtruderGO4;
    private GameObject polyExtruderGO5;


    void Start()
    {

    	    		polyExtruderGO = new GameObject();
			        polyExtruderGO2 = new GameObject();
			        polyExtruderGO3 = new GameObject();
			        polyExtruderGO4 = new GameObject();
			        polyExtruderGO5 = new GameObject();

			        
			        polyExtruderGO.transform.parent = this.transform;
			        polyExtruderGO2.transform.parent = this.transform;
			        polyExtruderGO3.transform.parent = this.transform;
			        polyExtruderGO4.transform.parent = this.transform;
			        polyExtruderGO5.transform.parent = this.transform;

			        // add PolyExtruder script to newly created GameObject and keep track of its reference
			        polyExtruder = polyExtruderGO.AddComponent<PolyExtruder>();
			        polyExtruder2 = polyExtruderGO2.AddComponent<PolyExtruder>();
			        polyExtruder3 = polyExtruderGO3.AddComponent<PolyExtruder>();
			        polyExtruder4 = polyExtruderGO4.AddComponent<PolyExtruder>();
			        polyExtruder5 = polyExtruderGO5.AddComponent<PolyExtruder>();

			        polyExtruderGO.name = "Polygon1";
			        polyExtruderGO2.name = "Polygon2";
			        polyExtruderGO3.name = "Polygon3";
			        polyExtruderGO4.name = "Polygon4";
			        polyExtruderGO5.name = "Polygon5";


			        polyExtruder.createPrism(polyExtruderGO.name, extrusionHeight, Polygon1, Color.grey, is3D,"1");
			        polyExtruder2.createPrism(polyExtruderGO2.name, extrusionHeight, Polygon2, Color.grey, is3D,"2");
			        polyExtruder3.createPrism(polyExtruderGO3.name, extrusionHeight, Polygon3, Color.grey, is3D,"3");
			        polyExtruder4.createPrism(polyExtruderGO4.name, extrusionHeight, Polygon4, Color.grey, is3D,"4");
			        polyExtruder5.createPrism(polyExtruderGO5.name, extrusionHeight, Polygon5, Color.grey, is3D,"5");


				    //string localPath = "Assets/" + polyExtruderGO.name + ".prefab";

		            //localPath = AssetDatabase.GenerateUniqueAssetPath(localPath);

		            //PrefabUtility.SaveAsPrefabAssetAndConnect(polyExtruderGO, localPath, InteractionMode.UserAction);




				    //Object prefab2 = EditorUtility.CreateEmptyPrefab("Assets/"+polyExtruderGO2.name+".prefab");
				    //EditorUtility.ReplacePrefab(polyExtruderGO2, prefab2, ReplacePrefabOptions.ConnectToPrefab);

				    //Object prefab3 = EditorUtility.CreateEmptyPrefab("Assets/"+polyExtruderGO3.name+".prefab"//);
				    //EditorUtility.ReplacePrefab(polyExtruderGO3, prefab3, ReplacePrefabOptions.ConnectToPrefab)//;

				    //Object prefab4 = EditorUtility.CreateEmptyPrefab("Assets/"+polyExtruderGO4.name+".prefab");
				    //EditorUtility.ReplacePrefab(polyExtruderGO4, prefab4, ReplacePrefabOptions.ConnectToPrefab);

				    //Object prefab5 = EditorUtility.CreateEmptyPrefab("Assets/"+polyExtruderGO5.name+".prefab");
				    //EditorUtility.ReplacePrefab(polyExtruderGO5, prefab5, ReplacePrefabOptions.ConnectToPrefab);

			        //polyExtruderGO.transform.localScale = new Vector3(-1,60,1);
			        //polyExtruderGO2.transform.localScale = new Vector3(-1,60,1);
			        //polyExtruderGO3.transform.localScale = new Vector3(-1,60,1);
			        //polyExtruderGO4.transform.localScale = new Vector3(-1,60,1);
			        //polyExtruderGO5.transform.localScale = new Vector3(-1,60,1);

			        //polyExtruderGO.transform.position = new Vector3(0,0.125f,0);
			        //polyExtruderGO2.transform.position = new Vector3(0,0.125f,0);
			        //polyExtruderGO3.transform.position = new Vector3(0,0.125f,0);
			        //polyExtruderGO4.transform.position = new Vector3(0,0.125f,0);
			        //polyExtruderGO5.transform.position = new Vector3(0,0.125f,0);

			        //polyExtruderGO.transform.Rotate(90,0,0);
			        //polyExtruderGO2.transform.Rotate(90,0,0);
			        //polyExtruderGO3.transform.Rotate(90,0,0);
			        //polyExtruderGO4.transform.Rotate(90,0,0);
			        //polyExtruderGO5.transform.Rotate(90,0,0);



    }

   

    void Update()
    {
        // if movement is selected (via Unity Inspector), oscillate height accordingly
        if(enableMovement)
        {
            polyExtruder.updateHeight((Mathf.Sin(Time.time) + 1.0f) * this.extrusionHeight);
        }
    }


    #region EXAMPLE_DATA

    public static Vector2[] Polygon1 = new Vector2[]
    {
          new Vector2(52, 138),
          new Vector2(50, 140),
          new Vector2(50, 282),
          new Vector2(51, 283),
          new Vector2(59, 283),
          new Vector2(59, 251),
          new Vector2(60, 250),
          new Vector2(60, 249),
          new Vector2(64, 245),
          new Vector2(65, 245),
          new Vector2(66, 244),
          new Vector2(148, 244),
          new Vector2(149, 243),
          new Vector2(198, 243),
          new Vector2(199, 244),
          new Vector2(256, 244),
          new Vector2(256, 236),
          new Vector2(255, 235),
          new Vector2(254, 235),
          new Vector2(253, 234),
          new Vector2(232, 234),
          new Vector2(231, 233),
          new Vector2(225, 233),
          new Vector2(224, 232),
          new Vector2(169, 232),
          new Vector2(168, 233),
          new Vector2(158, 233),
          new Vector2(157, 232),
          new Vector2(102, 232),
          new Vector2(101, 233),
          new Vector2(95,233),
          new Vector2(94, 234),
          new Vector2(64, 234),
          new Vector2(60, 230),
          new Vector2(60, 229),
          new Vector2(59, 228),
          new Vector2(59, 139),
          new Vector2(58, 138),

    };

        public static Vector2[] Polygon2 = new Vector2[]
    {
			new Vector2(664,115),
			new Vector2(662,117),
			new Vector2(662,124),
			new Vector2(661,125),
			new Vector2(661,177),
			new Vector2(662,178),
			new Vector2(662,230),
			new Vector2(658,234),
			new Vector2(578,234),
			new Vector2(577,235),
			new Vector2(569,235),
			new Vector2(568,234),
			new Vector2(562,234),
			new Vector2(561,235),
			new Vector2(516,235),
			new Vector2(514,237),
			new Vector2(514,243),
			new Vector2(515,244),
			new Vector2(515,245),
			new Vector2(587,245),
			new Vector2(588,244),
			new Vector2(611,244),
			new Vector2(612,245),
			new Vector2(613,245),
			new Vector2(617,249),
			new Vector2(617,257),
			new Vector2(616,258),
			new Vector2(616,269),
			new Vector2(617,270),
			new Vector2(617,381),
			new Vector2(618,382),
			new Vector2(618,383),
			new Vector2(619,384),
			new Vector2(619,385),
			new Vector2(620,386),
			new Vector2(621,386),
			new Vector2(622,387),
			new Vector2(668,387),
			new Vector2(668,379),
			new Vector2(667,378),
			new Vector2(658,378),
			new Vector2(657,377),
			new Vector2(644,377),
			new Vector2(643,376),
			new Vector2(637,376),
			new Vector2(636,377),
			new Vector2(631,377),
			new Vector2(627,373),
			new Vector2(627,371),
			new Vector2(626,370),
			new Vector2(626,368),
			new Vector2(627,367),
			new Vector2(627,352),
			new Vector2(626,351),
			new Vector2(626,339),
			new Vector2(627,338),
			new Vector2(627,301),
			new Vector2(633,295),
			new Vector2(643,295),
			new Vector2(644,294),
			new Vector2(654,294),
			new Vector2(655,295),
			new Vector2(665,295),
			new Vector2(666,294),
			new Vector2(678,294),
			new Vector2(678,285),
			new Vector2(677,284),
			new Vector2(631,284),
			new Vector2(628,281),
			new Vector2(628,280),
			new Vector2(627,279),
			new Vector2(627,251),
			new Vector2(633,245),
			new Vector2(648,245),
			new Vector2(649,246),
			new Vector2(669,246),
			new Vector2(670,247),
			new Vector2(684,247),
			new Vector2(685,246),
			new Vector2(718,246),
			new Vector2(719,245),
			new Vector2(724,250),
			new Vector2(724,255),
			new Vector2(723,256),
			new Vector2(723,257),
			new Vector2(722,258),
			new Vector2(722,259),
			new Vector2(721,260),
			new Vector2(721,267),
			new Vector2(722,268),
			new Vector2(722,269),
			new Vector2(723,270),
			new Vector2(723,271),
			new Vector2(724,272),
			new Vector2(724,280),
			new Vector2(725,281),
			new Vector2(725,328),
			new Vector2(724,329),
			new Vector2(724,331),
			new Vector2(723,332),
			new Vector2(723,378),
			new Vector2(722,379),
			new Vector2(722,386),
			new Vector2(723,387),
			new Vector2(723,388),
			new Vector2(724,389),
			new Vector2(724,390),
			new Vector2(725,391),
			new Vector2(725,429),
			new Vector2(721,433),
			new Vector2(569,433),
			new Vector2(568,432),
			new Vector2(538,432),
			new Vector2(537,433),
			new Vector2(263,433),
			new Vector2(259,429),
			new Vector2(259,428),
			new Vector2(258,427),
			new Vector2(258,303),
			new Vector2(257,302),
			new Vector2(251,302),
			new Vector2(249,304),
			new Vector2(249,339),
			new Vector2(248,340),
			new Vector2(248,346),
			new Vector2(249,347),
			new Vector2(249,363),
			new Vector2(248,364),
			new Vector2(248,370),
			new Vector2(247,371),
			new Vector2(247,424),
			new Vector2(248,425),
			new Vector2(248,428),
			new Vector2(244,432),
			new Vector2(128,432),
			new Vector2(127,433),
			new Vector2(64,433),
			new Vector2(60,429),
			new Vector2(60,428),
			new Vector2(59,427),
			new Vector2(59,393),
			new Vector2(58,392),
			new Vector2(52,392),
			new Vector2(50,394),
			new Vector2(50,436),
			new Vector2(51,437),
			new Vector2(51,438),
			new Vector2(52,439),
			new Vector2(52,440),
			new Vector2(53,441),
			new Vector2(54,441),
			new Vector2(55,442),
			new Vector2(730,442),
			new Vector2(731,441),
			new Vector2(732,441),
			new Vector2(733,440),
			new Vector2(733,439),
			new Vector2(734,438),
			new Vector2(734,240),
			new Vector2(733,239),
			new Vector2(733,238),
			new Vector2(732,237),
			new Vector2(731,237),
			new Vector2(730,236),
			new Vector2(729,236),
			new Vector2(728,235),
			new Vector2(677,235),
			new Vector2(673,231),
			new Vector2(673,230),
			new Vector2(672,229),
			new Vector2(672,116),
			new Vector2(671,116),
			new Vector2(670,115),

    };



    public static Vector2[] Polygon3 = new Vector2[]
    {
		new Vector2(515,28),
		new Vector2(514,29),
		new Vector2(513,29),
		new Vector2(512,30),
		new Vector2(511,30),
		new Vector2(510,31),
		new Vector2(510,32),
		new Vector2(509,33),
		new Vector2(509,86),
		new Vector2(508,87),
		new Vector2(508,93),
		new Vector2(509,94),
		new Vector2(509,178),
		new Vector2(510,179),
		new Vector2(510,180),
		new Vector2(519,180),
		new Vector2(519,111),
		new Vector2(518,110),
		new Vector2(518,45),
		new Vector2(519,44),
		new Vector2(519,43),
		new Vector2(523,39),
		new Vector2(524,39),
		new Vector2(525,38),
		new Vector2(552,38),
		new Vector2(553,39),
		new Vector2(580,39),
		new Vector2(581,38),
		new Vector2(582,39),
		new Vector2(592,39),
		new Vector2(593,38),
		new Vector2(656,38),
		new Vector2(657,39),
		new Vector2(669,39),
		new Vector2(669,30),
		new Vector2(668,29),
		new Vector2(667,29),
		new Vector2(666,28),

    };


    public static Vector2[] Polygon4 = new Vector2[]
    {
		new Vector2(284,27),
		new Vector2(283,28),
		new Vector2(282,28),
		new Vector2(280,30),
		new Vector2(280,36),
		new Vector2(282,38),
		new Vector2(357,38),
		new Vector2(358,39),
		new Vector2(359,39),
		new Vector2(363,43),
		new Vector2(363,130),
		new Vector2(364,131),
		new Vector2(364,134),
		new Vector2(365,135),
		new Vector2(365,136),
		new Vector2(366,137),
		new Vector2(386,137),
		new Vector2(387,136),
		new Vector2(388,136),
		new Vector2(389,137),
		new Vector2(391,137),
		new Vector2(394,140),
		new Vector2(394,220),
		new Vector2(393,221),
		new Vector2(393,230),
		new Vector2(390,233),
		new Vector2(366,233),
		new Vector2(365,234),
		new Vector2(361,234),
		new Vector2(360,235),
		new Vector2(319,235),
		new Vector2(317,237),
		new Vector2(317,243),
		new Vector2(318,244),
		new Vector2(400,244),
		new Vector2(401,243),
		new Vector2(402,243),
		new Vector2(403,242),
		new Vector2(403,241),
		new Vector2(404,240),
		new Vector2(404,130),
		new Vector2(403,129),
		new Vector2(403,127),
		new Vector2(401,125),
		new Vector2(400,125),
		new Vector2(399,124),
		new Vector2(379,124),
		new Vector2(374,119),
		new Vector2(374,65),
		new Vector2(375,64),
		new Vector2(375,54),
		new Vector2(374,53),
		new Vector2(374,44),
		new Vector2(380,38),
		new Vector2(410,38),
		new Vector2(411,37),
		new Vector2(449,37),
		new Vector2(449,29),
		new Vector2(448,28),
		new Vector2(447,28),
		new Vector2(446,27),

    };

    public static Vector2[] Polygon5 = new Vector2[]
    {
    	new Vector2(57,27),
		new Vector2(56,28),
		new Vector2(55,28),
		new Vector2(55,29),
		new Vector2(54,30),
		new Vector2(54,36),
		new Vector2(55,37),
		new Vector2(146,37),
		new Vector2(147,36),
		new Vector2(173,36),
		new Vector2(173,28),
		new Vector2(172,27),

    };

    #endregion
}