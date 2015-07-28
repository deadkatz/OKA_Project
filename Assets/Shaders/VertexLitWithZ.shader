Shader "Transparent/VertexLit with Z" {
    Properties {
        _Color ("Main Color", Color) = (1,1,1,1)
        _MainTex ("Base (RGB) Trans (A)", 2D) = "white" {}
    }
 
    SubShader {
        Tags {"RenderType"="Transparent" "Queue"="Transparent"}
        Pass {
            Cull Front
            Cull Back
            ColorMask 0
        }
        // Render into depth buffer only
        Pass {
            ColorMask 0
            AlphaTest Greater [_Cutoff]
            SetTexture [_MainTex] {
                combine texture * primary, texture
            }
        }
        // Render normally
        Pass {
            ZWrite Off
            Blend SrcAlpha OneMinusSrcAlpha
            ColorMask RGB
            Material {
                Diffuse [_Color]
                Ambient [_Color]
            }
            Lighting On
            SetTexture [_MainTex] {
                Combine texture * primary DOUBLE, texture * primary
            }
        }
    }
}