using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Color_Shelf : MonoBehaviour {
	
	public GameObject[] Color_Buttons;
	ArrayList ButtonList;

	//Melamine
	
	/*0*/public bool _0_A0_Tiefschwarz;
	/*1*/public bool _1_A1_Lichtgrau;
	/*2*/public bool _2_D0_Alusilber;
	/*3*/public bool _3_I4_Metallgrau;
	/*4*/public bool _4_W9_Vulkangrau;
	/*5*/public bool _5_B5_Sandgrau;
	/*6*/public bool _6_A9_Ahorn_Dekor;
	/*7*/public bool _7_B8_Buche_Dekor;
	/*8*/public bool _8_I6_Buche_gedämpft_Dekor;
	/*9*/public bool _9_C2_Kirschbaum_Dekor;
	/*10*/public bool _10_WM_Kirschbaum_Romana_Dekor;
	/*11*/public bool _11_YN_Esche_Cappuccino_Dekor;
	/*12*/public bool _12_L8_Birnbaum_Dekor;
	/*13*/public bool _13_C7_Nußbaum_Dekor;
	/*14*/public bool _14_W1_Eiche_hellgebeizt_Dekor;
	/*15*/public bool _15_LD_Eiche_Mokka_Dekor;
	/*16*/public bool _16_W3_Perlweiß;
	/*17*/public bool _17_W6_Rubinrot;
	/*18*/public bool _18_DV_Oliv;
			
			//Shutter
	/*19*/public bool _19_A1_Lichtgrau;
	/*20*/public bool _20_A9_Ahorn_Dekor;
	/*21*/public bool _21_B8_Buche_Dekor;
	/*22*/public bool _22_D0_Alusilber;
	/*23*/public bool _23_I4_Metallgrau;
	/*24*/public bool _24_B5_Sandgrau;
	/*25*/public bool _25_W3_Perlweiß;
			
			//P2 (compact plate 13mm)
			///*0*/I8_Weiß
			///*0*/I7_Grau
			///*0*/I3_Lichtgrau
			
			//P3
			
	/*26*/public bool _26_H6_Buche_Furnier;
	/*27*/public bool _27_G2_Buche_Furnier_Umleimer_Furnier_Multiplex;
	/*28*/public bool _28_G0_Weißer_Ahorn_Furnier;
			
			//P4
			
	/*29*/public bool _29_H1_Birnbaum_Furnier;
	/*30*/public bool _30_TM_Mooreiche;
	/*31*/public bool _31_I5_Nussbaum_Furnier;
	/*32*/public bool _32_I9_Eiche_hell_gebeizt;
	/*33*/public bool _33_H0_Esche_tiefschwarz_gebeizt;
			
			//MDF Painted
	/*34*/public bool _34_J2_Reinweiß_glatt;
	/*35*/public bool _35_CY_Indigo_Blau_glatt;
	/*36*/public bool _36_CW_Citrus_Grün_glatt;
	/*37*/public bool _37_CZ_Bordeaux_Rot_glatt;
	/*38*/public bool _38_DQ_Metallgrau_glatt;
	/*39*/public bool _39_E3_Graphitschwarz_glatt;
	/*40*/public bool _40_DT_Silber_glatt;
			
			//Metal
	/*41*/public bool _41_D0_Alusilber_glatt;
	/*42*/public bool _42_I4_Metallgrau_glatt;
	/*43*/public bool _43_E3_Graphitschwarz_glatt;
	/*44*/public bool _44_J2_Reinweiß_glatt;
	/*45*/public bool _45_E1_Anthrazit_Metallic;
	/*46*/public bool _46_E2_Tiefschwarz_Feinstruktur;
	/*47*/public bool _47_K5_Chrom_glänzend;
	/*48*/public bool _48_CC_Chrom_in_Chrom_glänzend;
	/*49*/public bool _49_C8_Alu_eloxiert;
			
			//Stoff Lucia
	/*50*/public bool _50_BJ_Apple;
	/*51*/public bool _51_BH_Calypso;
	/*52*/public bool _52_BK_Costa;
	/*53*/public bool _53_BE_Havanna;
	/*54*/public bool _54_BR_Jamaica;
	/*55*/public bool _55_BG_Lobster;
	/*56*/public bool _56_BA_Oyster;
	/*57*/public bool _57_BD_Paseo;
	/*58*/public bool _58_BB_Rum;
	/*59*/public bool _59_BC_Slip;
	/*60*/public bool _60_BF_Solano;
	/*61*/public bool _61_BL_Steel;
	/*62*/public bool _62_BT_Taboo;
	/*63*/public bool _63_BI_Tobago;
	/*64*/public bool _64_CH_Magdalena;
	/*65*/public bool _65_CB_Bryanstone;
	/*66*/public bool _66_CQ_Oxford;
			
			

	
	// Use this for initialization
	void Start () {

		ButtonList = new ArrayList();

		if(_0_A0_Tiefschwarz == true){

			ButtonList.Add(Color_Buttons.GetValue(0));
		}

		if(_1_A1_Lichtgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(1));
		}
		
		if(_2_D0_Alusilber== true){
			
			ButtonList.Add(Color_Buttons.GetValue(2));
		}
		
		if(_3_I4_Metallgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(3));
		}
		
		if(_4_W9_Vulkangrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(4));
		}
		
		if(_5_B5_Sandgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(5));
		}
		
		if(_6_A9_Ahorn_Dekor == true){
			
			ButtonList.Add(Color_Buttons.GetValue(6));
		}
		
		if(_7_B8_Buche_Dekor == true){
			
			ButtonList.Add(Color_Buttons.GetValue(7));
		}
		
		if(_8_I6_Buche_gedämpft_Dekor == true){
			
			ButtonList.Add(Color_Buttons.GetValue(8));
		}
		if(_9_C2_Kirschbaum_Dekor == true){
			
			ButtonList.Add(Color_Buttons.GetValue(9));
		}
		
		if(_10_WM_Kirschbaum_Romana_Dekor == true){
			
			ButtonList.Add(Color_Buttons.GetValue(10));
		}
		if(_11_YN_Esche_Cappuccino_Dekor == true){
			
			ButtonList.Add(Color_Buttons.GetValue(11));
		}
		if(_12_L8_Birnbaum_Dekor == true){
			
			ButtonList.Add(Color_Buttons.GetValue(12));
		}
		if(_13_C7_Nußbaum_Dekor == true){
			
			ButtonList.Add(Color_Buttons.GetValue(13));
		}
		if(_14_W1_Eiche_hellgebeizt_Dekor == true){
			
			ButtonList.Add(Color_Buttons.GetValue(14));
		}
		if(_15_LD_Eiche_Mokka_Dekor == true){
			
			ButtonList.Add(Color_Buttons.GetValue(15));
		}
		if(_16_W3_Perlweiß == true){
			
			ButtonList.Add(Color_Buttons.GetValue(16));
		}
		if(_17_W6_Rubinrot == true){
			
			ButtonList.Add(Color_Buttons.GetValue(17));
		}
		if(_18_DV_Oliv == true){
			
			ButtonList.Add(Color_Buttons.GetValue(18));
		}
		if(_19_A1_Lichtgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(19));
		}
		if(_20_A9_Ahorn_Dekor == true){
			
			ButtonList.Add(Color_Buttons.GetValue(20));
		}
		if(_21_B8_Buche_Dekor == true){
			
			ButtonList.Add(Color_Buttons.GetValue(21));
		}
		if(_22_D0_Alusilber == true){
			
			ButtonList.Add(Color_Buttons.GetValue(22));
		}
		if(_23_I4_Metallgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(23));
		}
		if(_24_B5_Sandgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(24));
		}
		if(_25_W3_Perlweiß == true){
			
			ButtonList.Add(Color_Buttons.GetValue(25));
		}
		if(_26_H6_Buche_Furnier == true){
			
			ButtonList.Add(Color_Buttons.GetValue(26));
		}
		if(_27_G2_Buche_Furnier_Umleimer_Furnier_Multiplex == true){
			
			ButtonList.Add(Color_Buttons.GetValue(27));
		}
		if(_28_G0_Weißer_Ahorn_Furnier == true){
			
			ButtonList.Add(Color_Buttons.GetValue(28));
		}
		if(_29_H1_Birnbaum_Furnier == true){
			
			ButtonList.Add(Color_Buttons.GetValue(29));
		}
		if(_30_TM_Mooreiche == true){
			
			ButtonList.Add(Color_Buttons.GetValue(30));
		}
		if(_31_I5_Nussbaum_Furnier == true){
			
			ButtonList.Add(Color_Buttons.GetValue(31));
		}
		if(_32_I9_Eiche_hell_gebeizt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(32));
		}
		if(_33_H0_Esche_tiefschwarz_gebeizt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(33));
		}
		if(_34_J2_Reinweiß_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(34));
		}
		if(_35_CY_Indigo_Blau_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(35));
		}
		if(_36_CW_Citrus_Grün_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(36));
		}
		if(_37_CZ_Bordeaux_Rot_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(37));
		}
		if(_38_DQ_Metallgrau_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(38));
		}
		if(_39_E3_Graphitschwarz_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(39));
		}
		if(_40_DT_Silber_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(40));
		}
		if(_41_D0_Alusilber_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(41));
		}
		if(_42_I4_Metallgrau_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(42));
		}
		if(_43_E3_Graphitschwarz_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(43));
		}
		if(_44_J2_Reinweiß_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(44));
		}
		if(_45_E1_Anthrazit_Metallic == true){
			
			ButtonList.Add(Color_Buttons.GetValue(45));
		}
		if(_46_E2_Tiefschwarz_Feinstruktur == true){
			
			ButtonList.Add(Color_Buttons.GetValue(46));
		}
		if(_47_K5_Chrom_glänzend == true){
			
			ButtonList.Add(Color_Buttons.GetValue(47));
		}
		if(_48_CC_Chrom_in_Chrom_glänzend == true){
			
			ButtonList.Add(Color_Buttons.GetValue(48));
		}
		if(_49_C8_Alu_eloxiert == true){
			
			ButtonList.Add(Color_Buttons.GetValue(49));
		}
		if(_50_BJ_Apple== true){
			
			ButtonList.Add(Color_Buttons.GetValue(50));
		}
		if(_51_BH_Calypso == true){
			
			ButtonList.Add(Color_Buttons.GetValue(51));
		}
		if(_52_BK_Costa == true){
			
			ButtonList.Add(Color_Buttons.GetValue(52));
		}
		if(_53_BE_Havanna == true){
			
			ButtonList.Add(Color_Buttons.GetValue(53));
		}
		if(_54_BR_Jamaica == true){
			
			ButtonList.Add(Color_Buttons.GetValue(54));
		}
		if(_55_BG_Lobster == true){
			
			ButtonList.Add(Color_Buttons.GetValue(55));
		}
		if(_56_BA_Oyster == true){
			
			ButtonList.Add(Color_Buttons.GetValue(56));
		}
		if(_57_BD_Paseo == true){
			
			ButtonList.Add(Color_Buttons.GetValue(57));
		}
		if(_58_BB_Rum == true){
			
			ButtonList.Add(Color_Buttons.GetValue(58));
		}
		if(_59_BC_Slip == true){
			
			ButtonList.Add(Color_Buttons.GetValue(59));
		}
		if(_60_BF_Solano == true){
			
			ButtonList.Add(Color_Buttons.GetValue(60));
		}
		if(_61_BL_Steel == true){
			
			ButtonList.Add(Color_Buttons.GetValue(61));
		}
		if(_62_BT_Taboo == true){
			
			ButtonList.Add(Color_Buttons.GetValue(62));
		}
		if(_63_BI_Tobago == true){
			
			ButtonList.Add(Color_Buttons.GetValue(63));
		}
		if(_64_CH_Magdalena == true){
			
			ButtonList.Add(Color_Buttons.GetValue(64));
		}
		if(_65_CB_Bryanstone == true){
			
			ButtonList.Add(Color_Buttons.GetValue(65));
		}
		if(_66_CQ_Oxford == true){
			
			ButtonList.Add(Color_Buttons.GetValue(66));
		}

//		Debug.Log (ButtonList.Count);
		AddObjects();
	}

	private void AddObjects(){

		float ArrayWidth;
		int ButtonWidth = 90;
		int NewArraySize;

		NewArraySize = ButtonList.Count;
		
		GameObject[] temp = new GameObject[NewArraySize];
		ButtonList.CopyTo(temp, 0);
//		ButtonList = temp;

	
		ArrayWidth = temp.Length * ButtonWidth;

		transform.GetComponent<RectTransform> ().sizeDelta = new Vector2 (100, ArrayWidth);
	
		for (int x=0; x < ButtonList.Count; x++) {
		
			GameObject go = Instantiate (temp [x], new Vector3 (0, x * ButtonWidth - ((ArrayWidth / 2) - 45), 0), Quaternion.Euler (0, 0, 0)) as GameObject;
			go.transform.SetParent (this.transform, false);
			go.transform.localScale += new Vector3 ((55 / 100), (55 / 100), (55 / 100));
		
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
