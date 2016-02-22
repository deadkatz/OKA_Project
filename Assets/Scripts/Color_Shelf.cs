using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Color_Shelf : MonoBehaviour {
	
	public GameObject[] Color_Buttons;
	ArrayList ButtonList;

	//Melamin Holz-Dekor // Melamine wood-laminate
	/*0*/public bool A9_Ahorn; // Maple done
	/*1*/public bool W1_Eiche_hell; // Oak light done
	/*2*/public bool B8_Buche; // Beech done
	/*3*/public bool L8_Birnbaum; // Pear done
	/*4*/public bool WM_Kirschbaum_Romana; // Cherry romana done
	/*5*/public bool B6_Buche_gedämpft; // Beech cushioned done
	/*6*/public bool C2_Kirschbaum; // Cherry done
	/*7*/public bool YN_Esche_Cappuccino; // Ash cappuccino done
	/*8*/public bool C7_Nussbaum; // Walnut done
	/*9*/public bool LD_Eiche_Mokka; // Oak Mokka done

	//Melamin Uni-Dekor // Melamine uni-laminate
	/*10*/public bool W3_Perlweiß; // Perl white
	/*11*/public bool A1_Lichtgrau; // Light grey
	/*12*/public bool W9_Vulkangrau; // Vulcan grey
	/*13*/public bool B5_Sandgrau; // Sand grey
	/*14*/public bool DV_Oliv; // Oliv
	/*15*/public bool W6_Rubinrot; // Ruby Red
	/*16*/public bool I4_Metallgrau; // Metal grey
	/*17*/public bool A0_Tiefschwarz; // Dark black
	/*18*/public bool Pastellorange;
	/*19*/public bool Samtgelb;
	/*20*/public bool Taubenblau;
	/*21*/public bool D0_Alusilber; // Alusilver
	
	//Echtholz Furnier // Real wood veneer
	/*22*/public bool G0_Weißer_Ahorn; // White maple
	/*23*/public bool I9_Eiche_hell; // Oak light
	/*24*/public bool I5_Nussbaum; // Walnut
	/*25*/public bool TM_Mooreiche; // Bog Oak
	/*26*/public bool H6_Buche; // Beech
	/*27*/public bool H1_Birnbaum; // Pear
	/*28*/public bool H0_Esche_tiefschwarz; // Ash deep black

	//Vollkernplatte 13mm // Compact top 13mm
	/*--*/public bool I8_Weiß; // White
	/*--*/public bool I3_Lichtgrau; // Light grey
	/*--*/public bool I7_Grau; // Grey

	//MDF glatt // MDF smooth
	/*29*/public bool DQ_Metallgrau; // Metal grey
	/*30*/public bool DT_Alusilber; // Alusilver
	/*31*/public bool E3_Graphitschwarz; // Graphite black
	/*32*/public bool J2_Reinweiß; // Pure white
	/*33*/public bool CZ_Bordeaux_Rot; // Bordeaux red
	/*34*/public bool CW_Citrus_Grün; // Citrus Green
	/*35*/public bool CY_Indigo_Blau; // Indigo Blue

	//Metall glatt // Metal smooth
//	public bool D0_Alusilber; // Alusilver
//	public bool E3_Graphitschwarz; // Graphite black
	/*--*/public bool K5_Chrom_glänzend; // Chrome glossy
	/*--*/public bool E1_Anthrazit_metallic; // Anthrazit metallic
//	public bool I4_Metallgrau; // Metal grey
	/*36*/public bool E2_Tiefschwarz_Feinstruktur; // Dark black textured

	//Glas lackiert // Painted glass
//	/*--*/public bool DT_Alusilber; // Alusilver
	/*37*/public bool GQ_Metallgrau; // Metal grey
	/*38*/public bool GC_Reinweiß; // Pure white
	/*39*/public bool GN_Graphitschwarz; // Graphite black
	/*40*/public bool GL_Bordeaux_Rot; // Bordeaux red
	/*41*/public bool GM_Indigo_Blau; // Indigo Blue
	/*42*/public bool GK_Citrus_Grün; // Citrus Green

	//Stoff Lucia (YB) // Fabric Lucia (YB)
	/*43*/public bool BA_Oyster_YB107;
	/*44*/public bool BB_Rum_YB086;
	/*45*/public bool BR_Jamaica_YB027;
	/*46*/public bool BC_Slip_YB094;
	/*47*/public bool BD_Paseo_YB019;
	/*48*/public bool BG_Lobster_YB087;
	/*49*/public bool BI_Tobago_YB030;
	/*50*/public bool BH_Calypso_YB106;
	/*51*/public bool BE_Havanna_YB009;
	/*52*/public bool BF_Solano_YB088;
	/*53*/public bool BT_Taboo_YB045;
	/*54*/public bool BJ_Apple_YB096;
	/*55*/public bool BK_Costa_YB026;
	/*56*/public bool BL_Steel_YB095;
	/*57*/public bool CH_Magdalena_CUZ21;
	/*58*/public bool Oxford_CUZ09;
	/*59*/public bool CB_Bryanstone_CUZ53;

	//Metall glatt // Feinstruktur
	/*60*/public bool Fresh_Yellow; // Fresh Yellow
	/*61*/public bool Fresh_Orange; // Fresh Orange
	/*62*/public bool Fresh_Red; // Fresh Red
	/*63*/public bool Fresh_Blue; // Fresh Blue
	/*64*/public bool Fresh_Green; // Fresh Green
	/*65*/public bool Reinweiß; // Pure white
	/*66*/public bool Silber_Feinstruktur; // Silver textured
	/*67*/public bool Graphitgrau; // Graphite grey
	/*68*/public bool Alusilber_glatt;// Alusilver smooth
	/*69*/public bool Schwarz_metallic_glatt; // Black metallic smooth
	
	// Use this for initialization
	void Start () {

		ButtonList = new ArrayList();

		if(A9_Ahorn == true){

			ButtonList.Add(Color_Buttons.GetValue(0));
		}

		if(W1_Eiche_hell == true){
			
			ButtonList.Add(Color_Buttons.GetValue(1));
		}
		
		if(B8_Buche== true){
			
			ButtonList.Add(Color_Buttons.GetValue(2));
		}
		
		if(L8_Birnbaum == true){
			
			ButtonList.Add(Color_Buttons.GetValue(3));
		}
		
		if(WM_Kirschbaum_Romana == true){
			
			ButtonList.Add(Color_Buttons.GetValue(4));
		}
		
		if(B6_Buche_gedämpft == true){
			
			ButtonList.Add(Color_Buttons.GetValue(5));
		}
		
		if(C2_Kirschbaum == true){
			
			ButtonList.Add(Color_Buttons.GetValue(6));
		}
		
		if(YN_Esche_Cappuccino == true){
			
			ButtonList.Add(Color_Buttons.GetValue(7));
		}
		
		if(C7_Nussbaum == true){
			
			ButtonList.Add(Color_Buttons.GetValue(8));
		}
		if(LD_Eiche_Mokka == true){
			
			ButtonList.Add(Color_Buttons.GetValue(9));
		}
		
		if(W3_Perlweiß == true){
			
			ButtonList.Add(Color_Buttons.GetValue(10));
		}
		if(A1_Lichtgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(11));
		}
		if(W9_Vulkangrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(12));
		}
		if(B5_Sandgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(13));
		}
		if(DV_Oliv == true){
			
			ButtonList.Add(Color_Buttons.GetValue(14));
		}
		if(W6_Rubinrot == true){
			
			ButtonList.Add(Color_Buttons.GetValue(15));
		}
		if(I4_Metallgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(16));
		}
		if(A0_Tiefschwarz == true){
			
			ButtonList.Add(Color_Buttons.GetValue(17));
		}
		if(Pastellorange == true){
			
			ButtonList.Add(Color_Buttons.GetValue(18));
		}
		if(Samtgelb == true){
			
			ButtonList.Add(Color_Buttons.GetValue(19));
		}
		if(Taubenblau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(20));
		}
		if(D0_Alusilber == true){
			
			ButtonList.Add(Color_Buttons.GetValue(21));
		}
		if(G0_Weißer_Ahorn == true){
			
			ButtonList.Add(Color_Buttons.GetValue(22));
		}
		if(I9_Eiche_hell == true){
			
			ButtonList.Add(Color_Buttons.GetValue(23));
		}
		if(I5_Nussbaum == true){
			
			ButtonList.Add(Color_Buttons.GetValue(24));
		}
		if(TM_Mooreiche == true){
			
			ButtonList.Add(Color_Buttons.GetValue(25));
		}
		if(H6_Buche == true){
			
			ButtonList.Add(Color_Buttons.GetValue(26));
		}
		if(H1_Birnbaum == true){
			
			ButtonList.Add(Color_Buttons.GetValue(27));
		}
		if(H0_Esche_tiefschwarz == true){
			
			ButtonList.Add(Color_Buttons.GetValue(28));
		}
		if(DQ_Metallgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(29));
		}
		if(DT_Alusilber == true){
			
			ButtonList.Add(Color_Buttons.GetValue(30));
		}
		if(E3_Graphitschwarz == true){
			
			ButtonList.Add(Color_Buttons.GetValue(31));
		}
		if(J2_Reinweiß == true){
			
			ButtonList.Add(Color_Buttons.GetValue(32));
		}
		if(CZ_Bordeaux_Rot == true){
			
			ButtonList.Add(Color_Buttons.GetValue(33));
		}
		if(CW_Citrus_Grün == true){
			
			ButtonList.Add(Color_Buttons.GetValue(34));
		}
		if(CY_Indigo_Blau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(35));
		}
		if(E2_Tiefschwarz_Feinstruktur == true){
			
			ButtonList.Add(Color_Buttons.GetValue(36));
		}
		if(GQ_Metallgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(37));
		}
		if(GC_Reinweiß == true){
			
			ButtonList.Add(Color_Buttons.GetValue(38));
		}
		if(GN_Graphitschwarz == true){
			
			ButtonList.Add(Color_Buttons.GetValue(39));
		}
		if(GL_Bordeaux_Rot == true){
			
			ButtonList.Add(Color_Buttons.GetValue(40));
		}
		if(GM_Indigo_Blau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(41));
		}
		if(GK_Citrus_Grün == true){
			
			ButtonList.Add(Color_Buttons.GetValue(42));
		}
		if(BA_Oyster_YB107 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(43));
		}
		if(BB_Rum_YB086 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(44));
		}
		if(BR_Jamaica_YB027 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(45));
		}
		if(BC_Slip_YB094 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(46));
		}
		if(BD_Paseo_YB019 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(47));
		}
		if(BG_Lobster_YB087 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(48));
		}
		if(BI_Tobago_YB030 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(49));
		}
		if(BH_Calypso_YB106== true){
			
			ButtonList.Add(Color_Buttons.GetValue(50));
		}
		if(BE_Havanna_YB009 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(51));
		}
		if(BF_Solano_YB088 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(52));
		}
		if(BT_Taboo_YB045 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(53));
		}
		if(BJ_Apple_YB096 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(54));
		}
		if(BK_Costa_YB026 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(55));
		}
		if(BL_Steel_YB095 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(56));
		}
		if(CH_Magdalena_CUZ21 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(57));
		}
		if(Oxford_CUZ09 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(58));
		}
		if(CB_Bryanstone_CUZ53 == true){
			
			ButtonList.Add(Color_Buttons.GetValue(59));
		}
		if(Fresh_Yellow == true){
			
			ButtonList.Add(Color_Buttons.GetValue(60));
		}
		if(Fresh_Orange == true){
			
			ButtonList.Add(Color_Buttons.GetValue(61));
		}
		if(Fresh_Red == true){
			
			ButtonList.Add(Color_Buttons.GetValue(62));
		}
		if(Fresh_Blue == true){
			
			ButtonList.Add(Color_Buttons.GetValue(63));
		}
		if(Fresh_Green == true){
			
			ButtonList.Add(Color_Buttons.GetValue(64));
		}
		if(Reinweiß == true){
			
			ButtonList.Add(Color_Buttons.GetValue(65));
		}
		if(Silber_Feinstruktur == true){
			
			ButtonList.Add(Color_Buttons.GetValue(66));
		}
		if(Graphitgrau == true){
			
			ButtonList.Add(Color_Buttons.GetValue(67));
		}
		if(Alusilber_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(68));
		}
		if(Schwarz_metallic_glatt == true){
			
			ButtonList.Add(Color_Buttons.GetValue(69));
		}

		Debug.Log (ButtonList.Count);
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
