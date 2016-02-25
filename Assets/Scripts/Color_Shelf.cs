using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Color_Shelf : MonoBehaviour {
	
	public GameObject[] Color_Buttons;
	ArrayList ButtonList;

	//Melamin Holz-Dekor // Melamine wood-laminate
	/*0*/public bool _0_A9_Ahorn; // Maple done
	/*1*/public bool _1_W1_Eiche_hell; // Oak light done
	/*2*/public bool _2_B8_Buche; // Beech done
	/*3*/public bool _3_L8_Birnbaum; // Pear done
	/*4*/public bool _4_WM_Kirschbaum_Romana; // Cherry romana done
	/*5*/public bool _5_B6_Buche_gedampft; // Beech cushioned done
	/*6*/public bool _6_C2_Kirschbaum; // Cherry done
	/*7*/public bool _7_YN_Esche_Cappuccino; // Ash cappuccino done
	/*8*/public bool _8_C7_Nussbaum; // Walnut done
	/*9*/public bool _9_LD_Eiche_Mokka; // Oak Mokka done

	//Melamin Uni-Dekor // Melamine uni-laminate
	/*10*/public bool _10_W3_Perlweiss; // Perl white
	/*11*/public bool _11_A1_Lichtgrau; // Light grey
	/*12*/public bool _12_V9_Vulkangrau; // Vulcan grey
	/*13*/public bool _13_B5_Sandgrau; // Sand grey
	/*14*/public bool _14_DV_Oliv; // Oliv
	/*15*/public bool _15_W6_Rubinrot; // Ruby Red
	/*16*/public bool _16_I4_Metallgrau; // Metal grey
	/*17*/public bool _17_A0_Tiefschwarz; // Dark black
	/*18*/public bool _18_Pastellorange;
	/*19*/public bool _19_Samtgelb;
	/*20*/public bool _20_Taubenblau;
	/*21*/public bool _21_D0_Alusilber; // Alusilver
	
	//Echtholz Furnier // Real wood veneer
	/*22*/public bool _22_G0_Weisser_Ahorn; // White maple
	/*23*/public bool _23_I9_Eiche_hell; // Oak light
	/*24*/public bool _24_I5_Nussbaum; // Walnut
	/*25*/public bool _25_TM_Mooreiche; // Bog Oak
	/*26*/public bool _26_H6_Buche; // Beech
	/*27*/public bool _27_H1_Birnbaum; // Pear
	/*28*/public bool _28_H0_Esche_tiefschwarz; // Ash deep black

	//Vollkernplatte 13mm // Compact top 13mm
//	/*--*/public bool I8_Weiss; // White
//	/*--*/public bool I3_Lichtgrau; // Light grey
//	/*--*/public bool I7_Grau; // Grey

	//MDF glatt // MDF smooth
	/*29*/public bool _29_DQ_Metallgrau; // Metal grey
	/*30*/public bool _30_DT_Alusilber; // Alusilver
	/*31*/public bool _31_E3_Graphitschwarz; // Graphite black
	/*32*/public bool _32_J2_Reinweiss; // Pure white
	/*33*/public bool _33_CZ_Bordeaux_Rot; // Bordeaux red
	/*34*/public bool _34_CW_Citrus_Grun; // Citrus Green
	/*35*/public bool _35_CY_Indigo_Blau; // Indigo Blue

	//Metall glatt // Metal smooth
//	public bool D0_Alusilber; // Alusilver
//	public bool E3_Graphitschwarz; // Graphite black
//	public bool I4_Metallgrau; // Metal grey
	/*36*/public bool _36_E2_Tiefschwarz_Feinstruktur; // Dark black textured

	//Glas lackiert // Painted glass
//	/*--*/public bool DT_Alusilber; // Alusilver
	/*37*/public bool _37_GQ_Metallgrau; // Metal grey
	/*38*/public bool _38_GC_Reinweiss; // Pure white
	/*39*/public bool _39_GN_Graphitschwarz; // Graphite black
	/*40*/public bool _40_GL_Bordeaux_Rot; // Bordeaux red
	/*41*/public bool _41_GM_Indigo_Blau; // Indigo Blue
	/*42*/public bool _42_GK_Citrus_Grun; // Citrus Green

	//Stoff Lucia (YB) // Fabric Lucia (YB)
	/*43*/public bool _43_BA_Oyster_YB107;
	/*44*/public bool _44_BB_Rum_YB086;
	/*45*/public bool _45_BR_Jamaica_YB027;
	/*46*/public bool _46_BC_Slip_YB094;
	/*47*/public bool _47_BD_Paseo_YB019;
	/*48*/public bool _48_BG_Lobster_YB087;
	/*49*/public bool _49_BI_Tobago_YB030;
	/*50*/public bool _50_BH_Calypso_YB106;
	/*51*/public bool _51_BE_Havanna_YB009;
	/*52*/public bool _52_BF_Solano_YB088;
	/*53*/public bool _53_BT_Taboo_YB045;
	/*54*/public bool _54_BJ_Apple_YB096;
	/*55*/public bool _55_BK_Costa_YB026;
	/*56*/public bool _56_BL_Steel_YB095;
	/*57*/public bool _57_CH_Magdalena_CUZ21;
	/*58*/public bool _58_Oxford_CUZ09;
	/*59*/public bool _59_CB_Bryanstone_CUZ53;

	//Metall glatt // Feinstruktur
	/*60*/public bool _60_Fresh_Yellow; // Fresh Yellow
	/*61*/public bool _61_Fresh_Orange; // Fresh Orange
	/*62*/public bool _62_Fresh_Red; // Fresh Red
	/*63*/public bool _63_Fresh_Blue; // Fresh Blue
	/*64*/public bool _64_Fresh_Green; // Fresh Green
	/*65*/public bool _65_Reinweiss; // Pure white
	/*66*/public bool _66_Silber_Feinstruktur; // Silver textured
	/*67*/public bool _67_Graphitgrau; // Graphite grey
	/*68*/public bool _68_Alusilber_glatt;// Alusilver smooth
	/*69*/public bool _69_Schwarz_metallic_glatt; // Black metallic smooth
	/*70*/public bool _70_K5_Chrom_glanzend; // Chrome glossy
	/*71*/public bool _71_E1_Anthrazit_metallic; // Anthrazit metallic
	/*72*/public bool _72_E2_Tiefschwarz_Feinstruktur; // Dark black textured
	/*73*/public bool _73_DT_GJ_Silber; // Silver
	/*74*/public bool _74_Delphingrau; // Dolphin grey
	/*75*/public bool _75_Zebrano_dunkel; // Zebrano dark laminate
	/*76*/public bool _76_Wenge; // Wenge laminate
	/*77*/public bool _77_Alu_eloxiert; // Anodised aluminium
	
	// Use this for initialization
	void Start () {

		ButtonList = new ArrayList();

		if(_0_A9_Ahorn == true){

			ButtonList.Add(Color_Buttons.GetValue(0));
		}

		if(_1_W1_Eiche_hell == true){
			
			ButtonList.Add(Color_Buttons.GetValue(1));
		}
		
		if(_2_B8_Buche== true){
			
			ButtonList.Add(Color_Buttons.GetValue(2));
		}
		
		if(_3_L8_Birnbaum == true){
			
			ButtonList.Add(Color_Buttons.GetValue(3));
		}
		
		if(_4_WM_Kirschbaum_Romana == true){
			
			ButtonList.Add(Color_Buttons.GetValue(4));
		}
		
		if(_5_B6_Buche_gedampft == true){
			
			ButtonList.Add(Color_Buttons.GetValue(5));
		}
		
		if(_6_C2_Kirschbaum == true){
			
			ButtonList.Add(Color_Buttons.GetValue(6));
		}
		
		if(_7_YN_Esche_Cappuccino == true){
			
			ButtonList.Add(Color_Buttons.GetValue(7));
		}
		
		if(_8_C7_Nussbaum == true){
			
			ButtonList.Add(Color_Buttons.GetValue(8));
		}
		if(_9_LD_Eiche_Mokka == true){
			
			ButtonList.Add(Color_Buttons.GetValue(9));
		}
		
		if(_10_W3_Perlweiss == true){
			
			ButtonList.Add(Color_Buttons.GetValue(10));
		}
		if(_11_A1_Lichtgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(11));
		}
		if(_12_V9_Vulkangrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(12));
		}
		if(_13_B5_Sandgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(13));
		}
		if(_14_DV_Oliv == true){
			
			ButtonList.Add(Color_Buttons.GetValue(14));
		}
		if(_15_W6_Rubinrot == true){
			
			ButtonList.Add(Color_Buttons.GetValue(15));
		}
		if(_16_I4_Metallgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(16));
		}
		if(_17_A0_Tiefschwarz == true){
			
			ButtonList.Add(Color_Buttons.GetValue(17));
		}
		if(_18_Pastellorange == true){
			
			ButtonList.Add(Color_Buttons.GetValue(18));
		}
		if(_19_Samtgelb == true){
			
			ButtonList.Add(Color_Buttons.GetValue(19));
		}
		if(_20_Taubenblau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(20));
		}
		if(_21_D0_Alusilber == true){
			
			ButtonList.Add(Color_Buttons.GetValue(21));
		}
		if(_22_G0_Weisser_Ahorn == true){
			
			ButtonList.Add(Color_Buttons.GetValue(22));
		}
		if(_23_I9_Eiche_hell == true){
			
			ButtonList.Add(Color_Buttons.GetValue(23));
		}
		if(_24_I5_Nussbaum == true){
			
			ButtonList.Add(Color_Buttons.GetValue(24));
		}
		if(_25_TM_Mooreiche == true){
			
			ButtonList.Add(Color_Buttons.GetValue(25));
		}
		if(_26_H6_Buche == true){
			
			ButtonList.Add(Color_Buttons.GetValue(26));
		}
		if(_27_H1_Birnbaum == true){
			
			ButtonList.Add(Color_Buttons.GetValue(27));
		}
		if(_28_H0_Esche_tiefschwarz == true){
			
			ButtonList.Add(Color_Buttons.GetValue(28));
		}
		if(_29_DQ_Metallgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(29));
		}
		if(_30_DT_Alusilber == true){
			
			ButtonList.Add(Color_Buttons.GetValue(30));
		}
		if(_31_E3_Graphitschwarz == true){
			
			ButtonList.Add(Color_Buttons.GetValue(31));
		}
		if(_32_J2_Reinweiss == true){
			
			ButtonList.Add(Color_Buttons.GetValue(32));
		}
		if(_33_CZ_Bordeaux_Rot == true){
			
			ButtonList.Add(Color_Buttons.GetValue(33));
		}
		if(_34_CW_Citrus_Grun == true){
			
			ButtonList.Add(Color_Buttons.GetValue(34));
		}
		if(_35_CY_Indigo_Blau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(35));
		}
		if(_36_E2_Tiefschwarz_Feinstruktur == true){
			
			ButtonList.Add(Color_Buttons.GetValue(36));
		}
		if(_37_GQ_Metallgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(37));
		}
		if(_38_GC_Reinweiss == true){
			
			ButtonList.Add(Color_Buttons.GetValue(38));
		}
		if(_39_GN_Graphitschwarz == true){
			
			ButtonList.Add(Color_Buttons.GetValue(39));
		}
		if(_40_GL_Bordeaux_Rot == true){
			
			ButtonList.Add(Color_Buttons.GetValue(40));
		}
		if(_41_GM_Indigo_Blau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(41));
		}
		if(_42_GK_Citrus_Grun == true){
			
			ButtonList.Add(Color_Buttons.GetValue(42));
		}
		if(_43_BA_Oyster_YB107 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(43));
		}
		if(_44_BB_Rum_YB086 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(44));
		}
		if(_45_BR_Jamaica_YB027 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(45));
		}
		if(_46_BC_Slip_YB094 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(46));
		}
		if(_47_BD_Paseo_YB019 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(47));
		}
		if(_48_BG_Lobster_YB087 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(48));
		}
		if(_49_BI_Tobago_YB030 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(49));
		}
		if(_50_BH_Calypso_YB106== true){
			
			ButtonList.Add(Color_Buttons.GetValue(50));
		}
		if(_51_BE_Havanna_YB009 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(51));
		}
		if(_52_BF_Solano_YB088 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(52));
		}
		if(_53_BT_Taboo_YB045 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(53));
		}
		if(_54_BJ_Apple_YB096 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(54));
		}
		if(_55_BK_Costa_YB026 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(55));
		}
		if(_56_BL_Steel_YB095 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(56));
		}
		if(_57_CH_Magdalena_CUZ21 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(57));
		}
		if(_58_Oxford_CUZ09 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(58));
		}
		if(_59_CB_Bryanstone_CUZ53 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(59));
		}
		if(_60_Fresh_Yellow == true){
			
			ButtonList.Add(Color_Buttons.GetValue(60));
		}
		if(_61_Fresh_Orange == true){
			
			ButtonList.Add(Color_Buttons.GetValue(61));
		}
		if(_62_Fresh_Red == true){
			
			ButtonList.Add(Color_Buttons.GetValue(62));
		}
		if(_63_Fresh_Blue == true){
			
			ButtonList.Add(Color_Buttons.GetValue(63));
		}
		if(_64_Fresh_Green == true){
			
			ButtonList.Add(Color_Buttons.GetValue(64));
		}
		if(_65_Reinweiss == true){
			
			ButtonList.Add(Color_Buttons.GetValue(65));
		}
		if(_66_Silber_Feinstruktur == true){
			
			ButtonList.Add(Color_Buttons.GetValue(66));
		}
		if(_67_Graphitgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(67));
		}
		if(_68_Alusilber_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(68));
		}
		if(_69_Schwarz_metallic_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(69));
		}		
		if(_70_K5_Chrom_glanzend == true){
			
			ButtonList.Add(Color_Buttons.GetValue(70));
		}
		if(_71_E1_Anthrazit_metallic == true){
			
			ButtonList.Add(Color_Buttons.GetValue(71));
		}
		if(_72_E2_Tiefschwarz_Feinstruktur == true){
			
			ButtonList.Add(Color_Buttons.GetValue(72));
		}
		if(_73_DT_GJ_Silber == true){
			
			ButtonList.Add(Color_Buttons.GetValue(73));
		}
		if(_74_Delphingrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(74));
		}
		if(_75_Zebrano_dunkel == true){
			
			ButtonList.Add(Color_Buttons.GetValue(75));
		}
		if(_76_Wenge == true){
			
			ButtonList.Add(Color_Buttons.GetValue(76));
		}
		if(_77_Alu_eloxiert == true){
			
			ButtonList.Add(Color_Buttons.GetValue(77));
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
