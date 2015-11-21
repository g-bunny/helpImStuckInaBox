Shader "Unlit/NewUnlitShader"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "experiment" {}
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }
		LOD 100

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				UNITY_FOG_COORDS(1)
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}
			float F(float x, float p, float w){
				return(smoothstep(0., p, x) - smoothstep(p,w,x));
			}
			fixed4 frag (v2f i) : SV_Target
			{
				// sample the texture
				fixed4 col = tex2D(_MainTex, i.uv);
//				// apply fog
//				UNITY_APPLY_FOG(i.fogCoord, col);				
//				return col;
				float pct = F(input.texcoord., abs(0.5),1.);
				return fixed4(pct,pct,pct,1.0);
			}
			ENDCG
		}
	}
}
