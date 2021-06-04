Shader "yh/Role" {

    Properties
    {
        _MainTex("MainTex (RGB)", 2D) = "white" {}	//��ɫ��ͼ

        _MainTint("Main Color", Color) = (0.5, 0.5, 0.5, 1)
        _MainTintPower("Main Color Power", Float) = 1.2

        _XRayColor("XRay Color", Color) = (1, 1, 1, 1) //(0.435, 0.851, 1, 0.419)    
        _XRayPower("XRay Power", Float) = 0.5

            //͸���Ȳü���ģ��ͷ��֮��ģ�
            _AlphaCutoff("Alpha cutoff", Float) = 0.5

            //�ܻ�������ɫ
            _HitColor("Hit Color", Color) = (0.6,0.6,0.6,1)
            _HitColorWidth("Hit Color Width", Float) = 0.8
            //�Ƿ񱻻�0û�б��� 1�����У�����Ҫ����Ϊ0������������ʱ��1�ɵ��ܻ���ɫ��Ȼ�����0����������ʾ��ɫ��
            _IsHit("Is Hit", Range(0, 1)) = 0

            //�Ƿ񾭼�ģʽ������ģʽ��͸���ü�
            _IsECHO("Is ECHO", Range(0, 1)) = 0

    }

        SubShader
        {
            Tags { "Queue" = "Geometry+200" "RenderType" = "Opaque" }
            Fog { Mode off }
            //LOD 200

            Blend SrcAlpha OneMinusSrcAlpha


            Pass {
                Lighting Off

                Cull Off



                Blend SrcAlpha  OneMinusSrcAlpha

                CGPROGRAM
                    #pragma vertex vert
                    #pragma fragment frag
                    #include "UnityCG.cginc"

                    struct appdata
                    {
                        float4 vertex : POSITION;
                        float3 normal : NORMAL;
                        float2 texcoord : TEXCOORD0;
                    };

                    struct v2f
                    {
                        float4 pos : SV_POSITION;
                        float2 uv : TEXCOORD0;
                        fixed3 color : COLOR;
                    };

                    uniform float4 _MainTex_ST;
                    uniform fixed4 _HitColor;
                    float _HitColorWidth;
                    fixed _AlphaCutoff;
                    float _IsHit;
                    float _MainTintPower;
                    float _IsECHO;


                    v2f vert(appdata_base v) {
                        v2f o;
                        o.pos = UnityObjectToClipPos(v.vertex);

                        if (_IsHit == 1)
                        {
                            float3 viewDir = normalize(ObjSpaceViewDir(v.vertex));
                            float dotProduct = 1 - dot(v.normal, viewDir);
                            o.color = smoothstep(1 - _HitColorWidth, 1.0, dotProduct);
                            o.color *= _HitColor;
                        }

                        if (_IsHit == 0)
                        {
                            o.color = 0;
                        }

                        o.uv = v.texcoord.xy;
                        return o;
                    }

                    uniform sampler2D _MainTex;
                    uniform fixed4 _MainTint;

                    fixed4 frag(v2f i) : COLOR {

                        fixed4 texcol = tex2D(_MainTex, i.uv);
                        texcol *= _MainTint;
                        //texcol *= _MainTintPower * 2;
                        texcol.rgb += i.color;
                        //texcol.a=0;
                                            if (_IsECHO == 0)
                                            {
                                                clip(texcol.a - _AlphaCutoff);
                                            }

                                            return texcol;
                                        }
                                    ENDCG
                                }
        }
}