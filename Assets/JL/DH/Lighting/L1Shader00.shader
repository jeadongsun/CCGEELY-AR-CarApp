// Shader created with Shader Forge v1.37 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.37;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:True,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True,fsmp:False;n:type:ShaderForge.SFN_Final,id:4795,x:33869,y:32866,varname:node_4795,prsc:2|emission-1259-OUT,alpha-3299-OUT;n:type:ShaderForge.SFN_Tex2d,id:6074,x:32101,y:32711,ptovrint:False,ptlb:MainTex_1,ptin:_MainTex_1,varname:_MainTex_1,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7ed8dc0bbc2a1424ba1d2b241c6d0d87,ntxv:0,isnm:False|UVIN-2756-OUT;n:type:ShaderForge.SFN_Color,id:797,x:32069,y:32925,ptovrint:True,ptlb:Color,ptin:_TintColor,varname:_TintColor,prsc:2,glob:False,taghide:False,taghdr:True,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Tex2d,id:8082,x:32101,y:32499,ptovrint:False,ptlb:MainTex_2,ptin:_MainTex_2,varname:_MainTex_2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:59095d921b9aa344389cf645d17c5c9c,ntxv:0,isnm:False|UVIN-9922-OUT;n:type:ShaderForge.SFN_Tex2d,id:3369,x:32105,y:33143,ptovrint:False,ptlb:Alpha,ptin:_Alpha,varname:_Alpha,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:4ea3ffbfebce0b048bd3f6c2a34d95a6,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Panner,id:8383,x:31794,y:32682,varname:node_8383,prsc:2,spu:1,spv:0|UVIN-4093-OUT,DIST-5223-OUT;n:type:ShaderForge.SFN_TexCoord,id:5985,x:31150,y:32534,varname:node_5985,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:9575,x:31377,y:32583,varname:node_9575,prsc:2|A-5985-U,B-8953-OUT;n:type:ShaderForge.SFN_Multiply,id:8726,x:31377,y:32717,varname:node_8726,prsc:2|A-5985-V,B-4369-OUT;n:type:ShaderForge.SFN_Append,id:4093,x:31569,y:32641,varname:node_4093,prsc:2|A-9575-OUT,B-8726-OUT;n:type:ShaderForge.SFN_Time,id:123,x:31282,y:33112,varname:node_123,prsc:2;n:type:ShaderForge.SFN_Multiply,id:5223,x:31569,y:32890,varname:node_5223,prsc:2|A-1669-OUT,B-123-T;n:type:ShaderForge.SFN_Panner,id:7941,x:31794,y:32404,varname:node_7941,prsc:2,spu:1,spv:0|UVIN-4093-OUT,DIST-8458-OUT;n:type:ShaderForge.SFN_Multiply,id:8458,x:31581,y:32362,varname:node_8458,prsc:2|A-932-OUT,B-123-T;n:type:ShaderForge.SFN_Tex2d,id:5344,x:32171,y:33352,ptovrint:False,ptlb:L_Tex,ptin:_L_Tex,varname:_L_Tex,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:fffc455550629b64ca1fe62ac0a2a722,ntxv:0,isnm:False|UVIN-3513-UVOUT;n:type:ShaderForge.SFN_Panner,id:3513,x:31985,y:33352,varname:node_3513,prsc:2,spu:1,spv:0|UVIN-8972-UVOUT,DIST-9447-OUT;n:type:ShaderForge.SFN_TexCoord,id:8972,x:31709,y:33228,varname:node_8972,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:6110,x:32903,y:32875,varname:node_6110,prsc:2|A-2920-OUT,B-6841-OUT;n:type:ShaderForge.SFN_Multiply,id:6841,x:32406,y:33323,varname:node_6841,prsc:2|A-5344-R,B-1189-RGB;n:type:ShaderForge.SFN_Color,id:1189,x:32216,y:33564,ptovrint:False,ptlb:L_Color,ptin:_L_Color,varname:_L_Color,prsc:2,glob:False,taghide:False,taghdr:True,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2033954,c2:0.2416657,c3:0.2794118,c4:1;n:type:ShaderForge.SFN_Add,id:4079,x:32384,y:32647,varname:node_4079,prsc:2|A-8082-R,B-6074-R;n:type:ShaderForge.SFN_Tex2d,id:3898,x:31515,y:32004,ptovrint:False,ptlb:RD_Tex,ptin:_RD_Tex,varname:_RD_Tex,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:0e6a805239d71f245a6219504e34170c,ntxv:0,isnm:False|UVIN-7332-UVOUT;n:type:ShaderForge.SFN_Multiply,id:2348,x:31765,y:32114,varname:node_2348,prsc:2|A-3898-R,B-2042-OUT;n:type:ShaderForge.SFN_Slider,id:2042,x:31389,y:32242,ptovrint:False,ptlb:RD,ptin:_RD,varname:_RD,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Panner,id:7332,x:31332,y:32004,varname:node_7332,prsc:2,spu:1,spv:0|UVIN-5094-UVOUT,DIST-295-OUT;n:type:ShaderForge.SFN_TexCoord,id:5094,x:31000,y:31914,varname:node_5094,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:295,x:31139,y:32102,varname:node_295,prsc:2|A-8698-OUT,B-123-T;n:type:ShaderForge.SFN_Add,id:9922,x:31963,y:32285,varname:node_9922,prsc:2|A-2348-OUT,B-7941-UVOUT;n:type:ShaderForge.SFN_Add,id:2756,x:31952,y:32626,varname:node_2756,prsc:2|A-2348-OUT,B-8383-UVOUT;n:type:ShaderForge.SFN_Multiply,id:2920,x:32654,y:32824,varname:node_2920,prsc:2|A-4079-OUT,B-797-RGB,C-797-A,D-3369-R;n:type:ShaderForge.SFN_Multiply,id:9447,x:31800,y:33465,varname:node_9447,prsc:2|A-123-T,B-6660-OUT;n:type:ShaderForge.SFN_Slider,id:6660,x:31238,y:33484,ptovrint:False,ptlb:L_Speed,ptin:_L_Speed,varname:_L_Speed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3589744,max:1;n:type:ShaderForge.SFN_Slider,id:932,x:31220,y:32375,ptovrint:False,ptlb:B_Speed,ptin:_B_Speed,varname:_B_Speed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1538462,max:1;n:type:ShaderForge.SFN_Slider,id:1669,x:31211,y:32921,ptovrint:False,ptlb:A_Speed,ptin:_A_Speed,varname:_A_Speed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:-1,max:1;n:type:ShaderForge.SFN_Slider,id:4369,x:31013,y:32816,ptovrint:False,ptlb:A_V_Repeat,ptin:_A_V_Repeat,varname:_A_V_Repeat,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:3,max:3;n:type:ShaderForge.SFN_Slider,id:8953,x:31013,y:32723,ptovrint:False,ptlb:A_U_Repeat,ptin:_A_U_Repeat,varname:_A_U_Repeat,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Slider,id:8698,x:30729,y:32093,ptovrint:False,ptlb:RD_Speed,ptin:_RD_Speed,varname:_RD_Speed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_TexCoord,id:5821,x:32611,y:33603,varname:node_5821,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_If,id:1243,x:33225,y:33577,varname:node_1243,prsc:2|A-5821-U,B-157-OUT,GT-4388-OUT,EQ-4388-OUT,LT-6408-OUT;n:type:ShaderForge.SFN_Vector1,id:4388,x:32953,y:33723,varname:node_4388,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:6408,x:32900,y:33939,varname:node_6408,prsc:2,v1:0;n:type:ShaderForge.SFN_Slider,id:157,x:32616,y:33801,ptovrint:False,ptlb:IF_B,ptin:_IF_B,varname:_IF_B,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_OneMinus,id:4792,x:32780,y:33471,varname:node_4792,prsc:2|IN-5821-U;n:type:ShaderForge.SFN_Multiply,id:5236,x:32918,y:33075,varname:node_5236,prsc:2|A-4079-OUT,B-3369-R;n:type:ShaderForge.SFN_Add,id:8395,x:33193,y:33097,varname:node_8395,prsc:2|A-5236-OUT,B-5344-R;n:type:ShaderForge.SFN_Multiply,id:3299,x:33569,y:33141,varname:node_3299,prsc:2|A-8395-OUT,B-6838-OUT;n:type:ShaderForge.SFN_Multiply,id:1259,x:33555,y:32968,varname:node_1259,prsc:2|A-6110-OUT,B-6838-OUT;n:type:ShaderForge.SFN_If,id:632,x:33280,y:33980,varname:node_632,prsc:2|A-4792-OUT,B-8669-OUT,GT-4388-OUT,EQ-4388-OUT,LT-6408-OUT;n:type:ShaderForge.SFN_Slider,id:8669,x:32723,y:34159,ptovrint:False,ptlb:IF_A,ptin:_IF_A,varname:_IF_A,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:6838,x:33489,y:33714,varname:node_6838,prsc:2|A-1243-OUT,B-632-OUT;proporder:6074-797-8082-3369-5344-1189-3898-2042-6660-932-1669-4369-8953-8698-157-8669;pass:END;sub:END;*/

Shader "Shader Forge/L1Shader" {
    Properties {
        _MainTex_1 ("MainTex_1", 2D) = "white" {}
        [HDR]_TintColor ("Color", Color) = (0.5,0.5,0.5,1)
        _MainTex_2 ("MainTex_2", 2D) = "white" {}
        _Alpha ("Alpha", 2D) = "white" {}
        _L_Tex ("L_Tex", 2D) = "white" {}
        [HDR]_L_Color ("L_Color", Color) = (0.2033954,0.2416657,0.2794118,1)
        _RD_Tex ("RD_Tex", 2D) = "white" {}
        _RD ("RD", Range(0, 1)) = 0
        _L_Speed ("L_Speed", Range(0, 1)) = 0.3589744
        _B_Speed ("B_Speed", Range(0, 1)) = 0.1538462
        _A_Speed ("A_Speed", Range(-1, 1)) = -1
        _A_V_Repeat ("A_V_Repeat", Range(0, 3)) = 3
        _A_U_Repeat ("A_U_Repeat", Range(0, 1)) = 1
        _RD_Speed ("RD_Speed", Range(0, 1)) = 1
        _IF_B ("IF_B", Range(0, 1)) = 0
        _IF_A ("IF_A", Range(0, 1)) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _MainTex_1; uniform float4 _MainTex_1_ST;
            uniform float4 _TintColor;
            uniform sampler2D _MainTex_2; uniform float4 _MainTex_2_ST;
            uniform sampler2D _Alpha; uniform float4 _Alpha_ST;
            uniform sampler2D _L_Tex; uniform float4 _L_Tex_ST;
            uniform float4 _L_Color;
            uniform sampler2D _RD_Tex; uniform float4 _RD_Tex_ST;
            uniform float _RD;
            uniform float _L_Speed;
            uniform float _B_Speed;
            uniform float _A_Speed;
            uniform float _A_V_Repeat;
            uniform float _A_U_Repeat;
            uniform float _RD_Speed;
            uniform float _IF_B;
            uniform float _IF_A;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float4 node_123 = _Time + _TimeEditor;
                float2 node_7332 = (i.uv0+(_RD_Speed*node_123.g)*float2(1,0));
                float4 _RD_Tex_var = tex2D(_RD_Tex,TRANSFORM_TEX(node_7332, _RD_Tex));
                float node_2348 = (_RD_Tex_var.r*_RD);
                float2 node_4093 = float2((i.uv0.r*_A_U_Repeat),(i.uv0.g*_A_V_Repeat));
                float2 node_9922 = (node_2348+(node_4093+(_B_Speed*node_123.g)*float2(1,0)));
                float4 _MainTex_2_var = tex2D(_MainTex_2,TRANSFORM_TEX(node_9922, _MainTex_2));
                float2 node_2756 = (node_2348+(node_4093+(_A_Speed*node_123.g)*float2(1,0)));
                float4 _MainTex_1_var = tex2D(_MainTex_1,TRANSFORM_TEX(node_2756, _MainTex_1));
                float node_4079 = (_MainTex_2_var.r+_MainTex_1_var.r);
                float4 _Alpha_var = tex2D(_Alpha,TRANSFORM_TEX(i.uv0, _Alpha));
                float2 node_3513 = (i.uv0+(node_123.g*_L_Speed)*float2(1,0));
                float4 _L_Tex_var = tex2D(_L_Tex,TRANSFORM_TEX(node_3513, _L_Tex));
                float node_1243_if_leA = step(i.uv0.r,_IF_B);
                float node_1243_if_leB = step(_IF_B,i.uv0.r);
                float node_6408 = 0.0;
                float node_4388 = 1.0;
                float node_632_if_leA = step((1.0 - i.uv0.r),_IF_A);
                float node_632_if_leB = step(_IF_A,(1.0 - i.uv0.r));
                float node_6838 = (lerp((node_1243_if_leA*node_6408)+(node_1243_if_leB*node_4388),node_4388,node_1243_if_leA*node_1243_if_leB)*lerp((node_632_if_leA*node_6408)+(node_632_if_leB*node_4388),node_4388,node_632_if_leA*node_632_if_leB));
                float3 emissive = (((node_4079*_TintColor.rgb*_TintColor.a*_Alpha_var.r)+(_L_Tex_var.r*_L_Color.rgb))*node_6838);
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,(((node_4079*_Alpha_var.r)+_L_Tex_var.r)*node_6838));
                UNITY_APPLY_FOG_COLOR(i.fogCoord, finalRGBA, fixed4(0,0,0,1));
                return finalRGBA;
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
