 #region Headers

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#endregion


///<summary>
/// 
///		Binds the Mindwave values with the puzzle game.
///		The pattern to play the game is :
///			- Get meditation over "MeditationToInitgame"
///			- Hold meditation over "MinMeditation" during "MeditationPhaseDuration"
///			- After that phase, focus, and get attention over "RequiredAttention"
///			- Hold attention during "FocusPhaseDuration"
///			- Flip start!
///			- Memorise back images and match.
///			- By matching same images, scores increses.
///			
///		Note that this script use coroutines for each phase timers and callbacks triggering.
///
///</summary>
[AddComponentMenu("Scripts/Game/Mindblast Trigger")]
public class MindblastTrigger : MonoBehaviour
{
    public int image;     //to store number of previous image on which player clicked
    public int score;
    public int[] u = new int[16];   //this array is used to permanently hide upper images
    public int i;
    public GameObject[] gameobject = new GameObject[16];
    public Text scoreText;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.name == "upperimage1")
                {
                    if (image == 11)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l1"));  //destroys the back image
                        GameObject.FindGameObjectWithTag("i1").gameObject.GetComponent<Renderer>().enabled = false; //hides upper image
                        u[0] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l11"));
                        GameObject.FindGameObjectWithTag("i11").gameObject.GetComponent<Renderer>().enabled = false;
                        u[10] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 1;
                    }
                }
                else if (hit.transform.name == "upperimage11")
                {

                    if (image == 1)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l1"));
                        GameObject.FindGameObjectWithTag("i1").gameObject.GetComponent<Renderer>().enabled = false;
                        u[0] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l11"));
                        GameObject.FindGameObjectWithTag("i11").gameObject.GetComponent<Renderer>().enabled = false;
                        u[10] = 1;
                        score += 1;

                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 11;
                    }
                }
                else if (hit.transform.name == "upperimage2")
                {

                    if (image == 9)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l2"));
                        GameObject.FindGameObjectWithTag("i2").gameObject.GetComponent<Renderer>().enabled = false;
                        u[1] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l9"));
                        GameObject.FindGameObjectWithTag("i9").gameObject.GetComponent<Renderer>().enabled = false;
                        u[8] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 2;
                    }
                }
                else if (hit.transform.name == "upperimage9")
                {

                    if (image == 2)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l2"));
                        GameObject.FindGameObjectWithTag("i2").gameObject.GetComponent<Renderer>().enabled = false;
                        u[1] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l9"));
                        GameObject.FindGameObjectWithTag("i9").gameObject.GetComponent<Renderer>().enabled = false;
                        u[8] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 9;
                    }
                }
                else if (hit.transform.name == "upperimage3")
                {

                    if (image == 15)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l3"));
                        GameObject.FindGameObjectWithTag("i3").gameObject.GetComponent<Renderer>().enabled = false;
                        u[2] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l15"));
                        GameObject.FindGameObjectWithTag("i15").gameObject.GetComponent<Renderer>().enabled = false;
                        u[14] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 3;
                    }
                }
                else if (hit.transform.name == "upperimage15")
                {

                    if (image == 3)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l3"));
                        GameObject.FindGameObjectWithTag("i3").gameObject.GetComponent<Renderer>().enabled = false;
                        u[2] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l15"));
                        GameObject.FindGameObjectWithTag("i15").gameObject.GetComponent<Renderer>().enabled = false;
                        u[14] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 15;
                    }

                }
                else if (hit.transform.name == "upperimage4")
                {

                    if (image == 10)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l4"));
                        GameObject.FindGameObjectWithTag("i4").gameObject.GetComponent<Renderer>().enabled = false;
                        u[3] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l10"));
                        GameObject.FindGameObjectWithTag("i10").gameObject.GetComponent<Renderer>().enabled = false;
                        u[9] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 4;
                    }
                }
                else if (hit.transform.name == "upperimage10")
                {

                    if (image == 4)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l4"));
                        GameObject.FindGameObjectWithTag("i4").gameObject.GetComponent<Renderer>().enabled = false;
                        u[3] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l10"));
                        GameObject.FindGameObjectWithTag("i10").gameObject.GetComponent<Renderer>().enabled = false;
                        u[9] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 10;
                    }
                }
                else if (hit.transform.name == "upperimage5")
                {

                    if (image == 12)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l5"));
                        GameObject.FindGameObjectWithTag("i5").gameObject.GetComponent<Renderer>().enabled = false;
                        u[4] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l12"));
                        GameObject.FindGameObjectWithTag("i12").gameObject.GetComponent<Renderer>().enabled = false;
                        u[11] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 5;
                    }
                }
                else if (hit.transform.name == "upperimage12")
                {

                    if (image == 5)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l5"));
                        GameObject.FindGameObjectWithTag("i5").gameObject.GetComponent<Renderer>().enabled = false;
                        u[4] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l12"));
                        GameObject.FindGameObjectWithTag("i12").gameObject.GetComponent<Renderer>().enabled = false;
                        u[11] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 12;
                    }
                }
                else if (hit.transform.name == "upperimage6")
                {

                    if (image == 13)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l6"));
                        GameObject.FindGameObjectWithTag("i6").gameObject.GetComponent<Renderer>().enabled = false;
                        u[5] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l13"));
                        GameObject.FindGameObjectWithTag("i13").gameObject.GetComponent<Renderer>().enabled = false;
                        u[12] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 6;
                    }
                }
                else if (hit.transform.name == "upperimage13")
                {

                    if (image == 6)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l6"));
                        GameObject.FindGameObjectWithTag("i6").gameObject.GetComponent<Renderer>().enabled = false;
                        u[5] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l13"));
                        GameObject.FindGameObjectWithTag("i13").gameObject.GetComponent<Renderer>().enabled = false;
                        u[12] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 13;
                    }
                }
                else if (hit.transform.name == "upperimage7")
                {

                    if (image == 16)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l7"));
                        GameObject.FindGameObjectWithTag("i7").gameObject.GetComponent<Renderer>().enabled = false;
                        u[6] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l16"));
                        GameObject.FindGameObjectWithTag("i16").gameObject.GetComponent<Renderer>().enabled = false;
                        u[15] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 7;
                    }
                }
                else if (hit.transform.name == "upperimage16")
                {

                    if (image == 7)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l7"));
                        GameObject.FindGameObjectWithTag("i7").gameObject.GetComponent<Renderer>().enabled = false;
                        u[6] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l16"));
                        GameObject.FindGameObjectWithTag("i16").gameObject.GetComponent<Renderer>().enabled = false;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        u[15] = 1;
                        print(score);
                    }
                    else
                    {
                        image = 16;
                    }
                }
                else if (hit.transform.name == "upperimage8")
                {

                    if (image == 14)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l8"));
                        GameObject.FindGameObjectWithTag("i8").gameObject.GetComponent<Renderer>().enabled = false;
                        u[7] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l14"));
                        GameObject.FindGameObjectWithTag("i14").gameObject.GetComponent<Renderer>().enabled = false;
                        u[13] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 8;
                    }
                }
                else if (hit.transform.name == "upperimage14")
                {

                    if (image == 8)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("l8"));
                        GameObject.FindGameObjectWithTag("i8").gameObject.GetComponent<Renderer>().enabled = false;
                        u[7] = 1;
                        Destroy(GameObject.FindGameObjectWithTag("l14"));
                        GameObject.FindGameObjectWithTag("i14").gameObject.GetComponent<Renderer>().enabled = false;
                        u[13] = 1;
                        score += 1;
                        scoreText.text = "Score: " + score.ToString();
                        print(score);
                    }
                    else
                    {
                        image = 14;
                    }
                }
            }
        }
    }


    /// <summary>
    /// Names the different phases of the bomb.
    /// </summary>
    public enum Phase
    {
        None,
        Meditation,
        Focus
    }

    #region Attributes

    // Settings

    [Header("Settings")]

    [SerializeField, Range(0.0f, 100.0f)]
    [Tooltip("If the meditation goes down this value, game does'nt start")]
    private float m_MinMeditation = 30.0f;

    [SerializeField, Range(0.0f, 100.0f)]
    [Tooltip("If the meditation goes over this value, start the \"Meditation phase\"")]
    private float m_MeditationToStartGame = 60.0f;

    [SerializeField, Range(0.0f, 30.0f)]
    [Tooltip("You must hold meditation value over MinMeditation during this value (in seconds)")]
    private float m_MeditationPhaseDuration = 5.0f;

    [SerializeField, Range(0.0f, 100.0f)]
    [Tooltip("If the player is in \"Meditation phase\", it must hold its attention over this value to initialize \"Focus phase\"")]
    private float m_RequiredAttention = 60.0f;

    [SerializeField, Range(0.0f, 30.0f)]
    [Tooltip("The player has to hold its attention over RequiredAttention during this value (in seconds)")]
    private float m_FocusPhaseDuration = 1.0f;


    // Flow

    // The current timer coroutine
    private Coroutine m_Routine = null;

    // The current blast phase
    private Phase m_CurrentPhase = Phase.None;



    #endregion


    #region Engine Methods

    private void Awake()
    {

    }

    private void Start()
    {
        MindwaveManager.Instance.Controller.OnUpdateMindwaveData += OnUpdateMindwaveData;
        image = 0;
        score = 0;
        i = 0;
        scoreText.text = "Score: " + score.ToString();
        gameobject[0] = GameObject.FindGameObjectWithTag("i1");
        gameobject[1] = GameObject.FindGameObjectWithTag("i2");
        gameobject[2] = GameObject.FindGameObjectWithTag("i3");
        gameobject[3] = GameObject.FindGameObjectWithTag("i4");
        gameobject[4] = GameObject.FindGameObjectWithTag("i5");
        gameobject[5] = GameObject.FindGameObjectWithTag("i6");
        gameobject[6] = GameObject.FindGameObjectWithTag("i7");
        gameobject[7] = GameObject.FindGameObjectWithTag("i8");
        gameobject[8] = GameObject.FindGameObjectWithTag("i9");
        gameobject[9] = GameObject.FindGameObjectWithTag("i10");
        gameobject[10] = GameObject.FindGameObjectWithTag("i11");
       gameobject[11] = GameObject.FindGameObjectWithTag("i12");
        gameobject[12] = GameObject.FindGameObjectWithTag("i13");
        gameobject[13] = GameObject.FindGameObjectWithTag("i14");
        gameobject[14] = GameObject.FindGameObjectWithTag("i15");
        gameobject[15] = GameObject.FindGameObjectWithTag("i16");
        u[0] = 0;
        u[1] = 0;
        u[2] = 0;
        u[3] = 0;
        u[4] = 0;
        u[5] = 0;
        u[6] = 0;
        u[7] = 0;
        u[8] = 0;
        u[9] = 0;
        u[10] = 0;
        u[11] = 0;
        u[12] = 0;
        u[13] = 0;
        u[14] = 0;
        u[15] = 0;
        // TESTING
        // You can use the "BrainwaveTester" component to test the MindblastTrigger behavior.
        // If you do so, comment the previous line, and uncomment this following one.
        //GetComponentInChildren<BrainwaveTester>().OnUpdateMindwaveData += OnUpdateMindwaveData;
    }

    #endregion


    #region Public Methods

    /// <summary>
    /// Called when the MindwaveController sends new values.
    /// </summary>
    public void OnUpdateMindwaveData(MindwaveDataModel _Data)
    {
        // (Start the game depending on the meditation value)


        // If the player is not in a specific phase
        if (m_CurrentPhase == Phase.None)
        {
            // If its meditation is sufficient
            if (_Data.eSense.meditation >= m_MeditationToStartGame)
            {
                // Start Meditation phase
                //print("done");
                Load();
            }
        }

        // If the player is in Meditation phase
        else if (m_CurrentPhase == Phase.Meditation)
        {
            // If its meditation is too low
            if (_Data.eSense.meditation <= m_MinMeditation)
            {
                // Cancels the meditation phase
                CancelMeditationPhase();
            }
        }

        // If the player is in focus phase
        else if (m_CurrentPhase == Phase.Focus)
        {
            // If the attention is sufficient
            if (_Data.eSense.attention >= m_RequiredAttention)
            {
               
               // m_MinMeditation = 1000.0f; 
                StartCoroutine(Trigger());

            }
        }
    }


    #endregion


    #region Protected Methods
    #endregion


    #region Private Methods



    /// <summary>
    /// Enters in meditation phase, and start the loading blast trigger timer.
    /// </summary>
    private void Load()
    {
        m_CurrentPhase = Phase.Meditation;

        CancelRoutine();
        m_Routine = StartCoroutine(EnterMeditationPhase(m_MeditationPhaseDuration, m_FocusPhaseDuration));
    }

    /// <summary>
    /// Coroutine: started when the player enters in Meditation phase.
    /// </summary>
    private IEnumerator EnterMeditationPhase(float _MeditationPhaseDuration, float _FocusPhaseDuration)
    {
        OnEnterMeditationPhase();
        m_CurrentPhase = Phase.Meditation;
        yield return new WaitForSeconds(_MeditationPhaseDuration);
        OnExitMeditationPhase();

        // If the meditation phase hasn't been cancelled, start focus phase.
        m_Routine = StartCoroutine(EnterFocusPhase(_FocusPhaseDuration));
    }

    /// <summary>
    /// Coroutine: started when the player enters in focus phase.
    /// </summary>
    private IEnumerator EnterFocusPhase(float _FocusPhaseDuration)
    {

        m_CurrentPhase = Phase.Focus;
        yield return new WaitForSeconds(_FocusPhaseDuration);

        CancelRoutine();
    }

    /// <summary>
    /// Called when player enters in meditation phase.
    /// </summary>
    private void OnEnterMeditationPhase()
    {
        Debug.Log("Enter meditation phase");
    }

    // Called when the meditation phase is cancelled (meditation becomes too low)
    private void OnCancelMeditationPhase()
    {
        Debug.Log("Cancel meditation phase");
    }

    /// <summary>
    /// Called when player exits the meditation phase (all is fine, the focus phase should begin)
    /// </summary>
    private void OnExitMeditationPhase()
    {
        Debug.Log("Exit meditation phase");
    }

    /// <summary>
    /// Cancels the current coroutine, and set it to null.
    /// </summary>
    private void CancelRoutine()
    {
        if (m_Routine != null)
        {
            StopCoroutine(m_Routine);
            m_Routine = null;
        }
    }

    /// <summary>
    /// Cancels the meditation phase (reset mindblast)
    /// </summary>
    private void CancelMeditationPhase()
    {
        CancelRoutine();
        m_CurrentPhase = Phase.None;
        OnCancelMeditationPhase();
    }
   
    private IEnumerator Trigger()
    {

        CancelRoutine();
        m_CurrentPhase = Phase.None;


        gameobject[i].gameObject.GetComponent<Renderer>().enabled = false;
      
            yield return new WaitForSeconds(5.0f);
        
            
            if (u[i] == 0)
            {
            gameobject[i].gameObject.GetComponent<Renderer>().enabled = true;
                
            }
        i++;
        if (i == 16)
            {
                i = 0;
             
            }
           
    
        }

        //    //GameObject c2 = GameObject.FindGameObjectWithTag("c2");
        //    //c2.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
        #endregion

    }