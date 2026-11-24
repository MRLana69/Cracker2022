using System.Collections.Generic;
using UnityEngine;

/// <summary>A small, original endless-runner scaffold using Beijing-themed colors.
/// It intentionally does not depend on recovered game code, network services or proprietary managers.</summary>
public sealed class BeijingRunnerGame : MonoBehaviour
{
    const float LaneGap = 2.25f;
    const float SpawnZ = 64f;
    const float PlayerZ = 0f;
    const float StartSpeed = 13f;
    const float MaxSpeed = 27f;
    const float Acceleration = 0.16f;

    sealed class Piece { public Transform transform; public int lane; public bool coin; public bool jumpOnly; public bool slideOnly; }
    readonly List<Piece> pieces = new List<Piece>();
    Transform runner;
    Camera gameCamera;
    Material runnerMat, obstacleMat, coinMat, railMat, groundMat, trainMat, goldMat;
    int lane = 1, coins, score;
    float speed, elapsed, spawnTimer, jumpTimer, slideTimer, laneX;
    bool gameOver;
    Vector2 touchStart;
    bool trackingTouch;
    GUIStyle titleStyle, hudStyle, helpStyle, centerStyle;

    void Start()
    {
        speed = StartSpeed;
        runnerMat = MakeMaterial(new Color(.88f,.23f,.15f));
        obstacleMat = MakeMaterial(new Color(.12f,.20f,.29f));
        coinMat = MakeMaterial(new Color(1f,.72f,.08f));
        railMat = MakeMaterial(new Color(.32f,.62f,.69f));
        groundMat = MakeMaterial(new Color(.72f,.80f,.78f));
        trainMat = MakeMaterial(new Color(.72f,.18f,.13f));
        goldMat = MakeMaterial(new Color(.97f,.78f,.39f));
        BuildWorld();
        CreateRunner();
        CreateCamera();
    }

    Material MakeMaterial(Color color)
    {
        Shader shader = Shader.Find("Standard");
        if (shader == null) shader = Shader.Find("Diffuse");
        Material m = new Material(shader); m.color = color; return m;
    }

    void BuildWorld()
    {
        GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane);
        floor.name = "Beijing track surface"; floor.transform.position = new Vector3(0,-.08f,75f);
        floor.transform.localScale = new Vector3(1.05f,1f,16f); floor.GetComponent<Renderer>().material = groundMat;
        Destroy(floor.GetComponent<Collider>());
        for (int l=0;l<3;l++)
        {
            float x=(l-1)*LaneGap;
            GameObject line=GameObject.CreatePrimitive(PrimitiveType.Cube); line.name="Lane guide";
            line.transform.position=new Vector3(x,-.005f,75f); line.transform.localScale=new Vector3(.055f,.025f,145f);
            line.GetComponent<Renderer>().material=railMat; Destroy(line.GetComponent<Collider>());
        }
        for(int side=-1;side<=1;side+=2)
        {
            GameObject rail=GameObject.CreatePrimitive(PrimitiveType.Cube); rail.name="Track rail";
            rail.transform.position=new Vector3(side*4.15f,.12f,75f); rail.transform.localScale=new Vector3(.22f,.25f,150f);
            rail.GetComponent<Renderer>().material=goldMat; Destroy(rail.GetComponent<Collider>());
            for(int i=0;i<9;i++)
            {
                GameObject post=GameObject.CreatePrimitive(PrimitiveType.Cube); post.name="Beijing red-gold platform post";
                post.transform.position=new Vector3(side*6.6f,1.35f,8f+i*17f);
                post.transform.localScale=new Vector3(.38f,2.7f,.38f); post.GetComponent<Renderer>().material=trainMat; Destroy(post.GetComponent<Collider>());
                GameObject cap=GameObject.CreatePrimitive(PrimitiveType.Cube); cap.name="Platform post cap";
                cap.transform.position=new Vector3(side*6.6f,2.8f,8f+i*17f); cap.transform.localScale=new Vector3(.58f,.18f,.58f); cap.GetComponent<Renderer>().material=goldMat; Destroy(cap.GetComponent<Collider>());
            }
        }
        // A few stationary train-like forms add scale and a Beijing-red accent to the corridor.
        for(int i=0;i<4;i++)
        {
            GameObject train=GameObject.CreatePrimitive(PrimitiveType.Cube); train.name="Beijing train carriage silhouette";
            train.transform.position=new Vector3((i%2==0?-1:1)*8.1f,1.3f,24f+i*34f);
            train.transform.localScale=new Vector3(2.2f,2.6f,16f); train.GetComponent<Renderer>().material=trainMat; Destroy(train.GetComponent<Collider>());
        }
        RenderSettings.ambientLight = new Color(.63f,.68f,.70f);
        RenderSettings.fog = true; RenderSettings.fogColor = new Color(.69f,.76f,.78f); RenderSettings.fogDensity=.004f;
    }

    void CreateRunner()
    {
        runner=GameObject.CreatePrimitive(PrimitiveType.Capsule).transform;
        runner.name="Runner (placeholder model)"; runner.position=new Vector3(0,1f,PlayerZ);
        runner.GetComponent<Renderer>().material=runnerMat; Destroy(runner.GetComponent<Collider>());
        GameObject torso=GameObject.CreatePrimitive(PrimitiveType.Cube); torso.name="Runner jacket accent"; torso.transform.SetParent(runner,false);
        torso.transform.localPosition=new Vector3(0,.16f,0); torso.transform.localScale=new Vector3(.72f,.48f,.62f);
        torso.GetComponent<Renderer>().material=goldMat; Destroy(torso.GetComponent<Collider>());
    }

    void CreateCamera()
    {
        gameCamera=Camera.main;
        if(gameCamera==null){GameObject c=new GameObject("Main Camera"); c.tag="MainCamera"; gameCamera=c.AddComponent<Camera>(); c.AddComponent<AudioListener>();}
        gameCamera.fieldOfView=62f; gameCamera.nearClipPlane=.1f; gameCamera.farClipPlane=240f;
    }

    void Update()
    {
        if(gameOver){ReadRestart(); return;}
        elapsed+=Time.deltaTime; speed=Mathf.Min(MaxSpeed,StartSpeed+elapsed*Acceleration);
        ReadControls();
        laneX=Mathf.Lerp(laneX,(lane-1)*LaneGap,1f-Mathf.Exp(-13f*Time.deltaTime));
        if(jumpTimer>0)jumpTimer-=Time.deltaTime;
        if(slideTimer>0)slideTimer-=Time.deltaTime;
        float jumpHeight=jumpTimer>0?Mathf.Sin((1f-jumpTimer/.72f)*Mathf.PI)*1.7f:0f;
        runner.position=new Vector3(laneX,1f+jumpHeight,PlayerZ);
        runner.localScale=new Vector3(1f,slideTimer>0?.55f:1f,1f);
        spawnTimer-=Time.deltaTime;
        if(spawnTimer<=0){SpawnWave();spawnTimer=Mathf.Max(.72f,1.55f-(speed-StartSpeed)*.025f);}
        MovePieces();
        score=Mathf.FloorToInt(elapsed*speed)+coins*25;
        UpdateCamera();
    }

    void ReadControls()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.A)) lane=Mathf.Max(0,lane-1);
        if(Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.D)) lane=Mathf.Min(2,lane+1);
        if(Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.Space)) Jump();
        if(Input.GetKeyDown(KeyCode.DownArrow)||Input.GetKeyDown(KeyCode.S)) Slide();
        if(Input.touchCount>0)
        {
            Touch t=Input.GetTouch(0);
            if(t.phase==TouchPhase.Began){touchStart=t.position;trackingTouch=true;}
            else if(trackingTouch&&(t.phase==TouchPhase.Ended||t.phase==TouchPhase.Canceled))
            {
                Vector2 d=t.position-touchStart; trackingTouch=false;
                if(d.magnitude>45f){if(Mathf.Abs(d.x)>Mathf.Abs(d.y)){if(d.x<0)lane=Mathf.Max(0,lane-1);else lane=Mathf.Min(2,lane+1);}else{if(d.y>0)Jump();else Slide();}}
            }
        }
    }

    void Jump(){if(jumpTimer<=0f)jumpTimer=.72f; slideTimer=0f;}
    void Slide(){slideTimer=.82f; jumpTimer=0f;}

    void SpawnWave()
    {
        int blocked=Random.Range(0,3);
        int second=Random.Range(0,3); while(second==blocked)second=Random.Range(0,3);
        SpawnPiece(blocked,SpawnZ,false,Random.value<.5f,Random.value<.5f);
        // Leave one path open; place coins in that route and an optional second hazard.
        if(Random.value<.72f) SpawnPiece(second,SpawnZ+Random.Range(-1f,2f),false,Random.value<.35f,Random.value<.35f);
        int safe=3-blocked-second;
        for(int i=0;i<6;i++) SpawnPiece(safe,SpawnZ+3f+i*1.7f,true,false,false);
    }

    void SpawnPiece(int laneIndex,float z,bool isCoin,bool jumpOnly,bool slideOnly)
    {
        GameObject go;
        if(isCoin){go=GameObject.CreatePrimitive(PrimitiveType.Cylinder);go.name="Beijing gold coin";go.transform.localScale=new Vector3(.72f,.12f,.72f);go.transform.rotation=Quaternion.Euler(90f,0,0);go.GetComponent<Renderer>().material=coinMat;Destroy(go.GetComponent<Collider>());}
        else{go=GameObject.CreatePrimitive(PrimitiveType.Cube);go.name=jumpOnly?"Low barrier (jump)":slideOnly?"Overhead gate (slide)":"Track obstacle";go.transform.localScale=jumpOnly?new Vector3(1.45f,.62f,1.1f):slideOnly?new Vector3(1.5f,2.2f,1.1f):new Vector3(1.45f,1.7f,1.2f);go.GetComponent<Renderer>().material=obstacleMat;}
        go.transform.position=new Vector3((laneIndex-1)*LaneGap,isCoin?1.15f:(jumpOnly?.35f:go.transform.localScale.y*.5f),z);
        pieces.Add(new Piece{transform=go.transform,lane=laneIndex,coin=isCoin,jumpOnly=jumpOnly,slideOnly=slideOnly});
    }

    void MovePieces()
    {
        for(int i=pieces.Count-1;i>=0;i--)
        {
            Piece p=pieces[i]; if(p.transform==null){pieces.RemoveAt(i);continue;}
            p.transform.position+=Vector3.back*(speed*Time.deltaTime);
            if(p.transform.position.z < -3f){Destroy(p.transform.gameObject);pieces.RemoveAt(i);continue;}
            if(p.lane!=lane||Mathf.Abs(p.transform.position.z-PlayerZ)>1.15f)continue;
            if(p.coin){coins++;Destroy(p.transform.gameObject);pieces.RemoveAt(i);continue;}
            bool jumping=jumpTimer>0&&runner.position.y>1.25f;
            bool sliding=slideTimer>0;
            bool avoided=(p.jumpOnly&&jumping)||(p.slideOnly&&sliding);
            if(!avoided){gameOver=true;break;}
        }
    }

    void UpdateCamera()
    {
        if(gameCamera==null)return;
        Vector3 pos=runner.position+new Vector3(0,5.5f,-9.5f);
        gameCamera.transform.position=Vector3.Lerp(gameCamera.transform.position,pos,1f-Mathf.Exp(-5f*Time.deltaTime));
        gameCamera.transform.rotation=Quaternion.Slerp(gameCamera.transform.rotation,Quaternion.LookRotation(new Vector3(0,1.1f,18f)-gameCamera.transform.position),1f-Mathf.Exp(-5f*Time.deltaTime));
    }

    void ReadRestart(){if(Input.GetKeyDown(KeyCode.R)||Input.GetKeyDown(KeyCode.Space))Restart();if(Input.touchCount>0&&Input.GetTouch(0).phase==TouchPhase.Began)Restart();}
    void Restart(){foreach(Piece p in pieces)if(p.transform!=null)Destroy(p.transform.gameObject);pieces.Clear();lane=1;laneX=0;coins=0;score=0;elapsed=0;spawnTimer=.5f;jumpTimer=0;slideTimer=0;gameOver=false;speed=StartSpeed;}

    void OnGUI()
    {
        if(titleStyle==null){titleStyle=new GUIStyle(GUI.skin.label){fontSize=24,fontStyle=FontStyle.Bold,normal={textColor=Color.white}};hudStyle=new GUIStyle(GUI.skin.label){fontSize=18,fontStyle=FontStyle.Bold,normal={textColor=Color.white}};helpStyle=new GUIStyle(GUI.skin.label){fontSize=15,wordWrap=true,normal={textColor=Color.white}};centerStyle=new GUIStyle(GUI.skin.label){fontSize=25,fontStyle=FontStyle.Bold,alignment=TextAnchor.MiddleCenter,normal={textColor=Color.white}};}
        GUI.Box(new Rect(12,12,250,112),GUIContent.none);GUI.Label(new Rect(24,18,230,34),"BEIJING RUN",titleStyle);GUI.Label(new Rect(24,53,230,26),"Score  "+score+"     Coins  "+coins,hudStyle);GUI.Label(new Rect(24,82,230,24),"Speed  "+speed.ToString("0.0"),helpStyle);
        GUI.Label(new Rect(12,Screen.height-68,Screen.width-24,56),"Swipe / arrows: move lanes   |   Up / swipe up: jump   |   Down / swipe down: slide",helpStyle);
        if(gameOver){GUI.Box(new Rect(Screen.width*.2f,Screen.height*.36f,Screen.width*.6f,Screen.height*.25f),GUIContent.none);GUI.Label(new Rect(Screen.width*.2f,Screen.height*.39f,Screen.width*.6f,55),"RUN OVER",centerStyle);GUI.Label(new Rect(Screen.width*.2f,Screen.height*.49f,Screen.width*.6f,45),"Score "+score+"   •   tap or press R to retry",centerStyle);}
    }
}
