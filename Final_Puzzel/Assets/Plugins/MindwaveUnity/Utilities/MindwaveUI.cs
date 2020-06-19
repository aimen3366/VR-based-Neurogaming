#region Headers

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#endregion


///<summary>
/// 
///		
///
///</summary>
[AddComponentMenu("Scripts/MindwaveUnity/Mindwave UI")]
public class MindwaveUI : MonoBehaviour
{
    public Transform bar;
    public Transform bar1;
    void Start()
    {
        bar = GameObject.FindGameObjectWithTag("bar").gameObject.GetComponent<Renderer>().transform.Find("bar");
        bar1 = GameObject.FindGameObjectWithTag("bar1").gameObject.GetComponent<Renderer>().transform.Find("bar1");
        bar.localScale = new Vector3(.4f, 1f,1f);
        bar1.localScale = new Vector3(.4f, 1f, 1f);  

    }

    #region Attributes

    // Constants & Statics

    private const int LABEL_WIDTH = 200;
		private const int VALUE_MIN_WIDTH = 100;

		// References

		[Header("References")]

		[SerializeField]
		private MindwaveController m_Controller = null;

		[SerializeField]
	//	private MindwaveCalibrator m_Calibrator = null;

		// Flow

		private MindwaveDataModel m_MindwaveData;
		private int m_EEGValue = 0;
		private int m_BlinkStrength = 0;

	#endregion

	
	#region Engine Methods

		private void Awake()
		{
			if(m_Controller == null)
			{
				m_Controller = GetComponent<MindwaveController>();
			}

			BindMindwaveControllerEvents();
		}

		private void OnGUI()
		{
			GUILayout.BeginHorizontal();
			{
				DrawControllerGUI();
				
			}
			//GUILayout.EndHorizontal();
		}

	#endregion

	
	#region Public Methods
		
		public void OnUpdateMindwaveData(MindwaveDataModel _Data)
		{
			m_MindwaveData = _Data;
		}

		public void OnUpdateRawEEG(int _EEGValue)
		{
			m_EEGValue = _EEGValue;
		}

		public void OnUpdateBlink(int _BlinkStrength)
		{
			m_BlinkStrength = _BlinkStrength;
		}

	#endregion

	
	#region Private Methods

		private void BindMindwaveControllerEvents()
		{
			m_Controller.OnUpdateMindwaveData += OnUpdateMindwaveData;
			m_Controller.OnUpdateRawEEG += OnUpdateRawEEG;
			m_Controller.OnUpdateBlink += OnUpdateBlink;
		}

		private void DrawControllerGUI()
		{
			GUILayout.BeginVertical(GUI.skin.box);
			{
				GUILayout.Box("CONTROLLER");
				DrawSpace();

				if (m_Controller.IsConnecting)
				{
					GUILayout.BeginVertical(GUI.skin.box);
					{
						GUILayout.Label("Trying to connect to Mindwave...");
						GUILayout.Label("Timeouts in " + Mathf.CeilToInt(m_Controller.ConnectionTimeoutDelay - m_Controller.TimeoutTimer) + "s");
					}
					GUILayout.EndVertical();
				}

				else if (m_Controller.IsConnected)
				{

					DrawConnectedGUI();
				}

				else
				{
					DrawDisconnectedGUI();
				}
			}
			GUILayout.EndVertical();
		}

		

		private void DrawConnectedGUI()
		{
        bar.localScale = new Vector3(m_MindwaveData.eSense.attention / 100f, 1f, 1f);
        bar1.localScale = new Vector3(m_MindwaveData.eSense.meditation / 100f, 1f, 1f);
        // GUILayout.BeginVertical(GUI.skin.box);
        //	{
        //GUILayout.Box("Signal");
        //DrawData("Status", m_MindwaveData.status);
        //DrawData("Poor signal level", m_MindwaveData.poorSignalLevel);
        //DrawSpace();

        //	GUILayout.Box("Senses");
        //	DrawData("Attention", m_MindwaveData.eSense.attention);
        // print(m_MindwaveData.eSense.attention);

        //  SetSize(m_MindwaveData.eSense.attention/100);
        //  DrawData("Meditation", m_MindwaveData.eSense.meditation);

        //  DrawSpace();

        //GUILayout.Box("Brain Waves");
        //DrawData("Delta", m_MindwaveData.eegPower.delta);
        //DrawData("Theta", m_MindwaveData.eegPower.theta);
        //DrawData("Low Alpha", m_MindwaveData.eegPower.lowAlpha);
        //DrawData("High Alpha", m_MindwaveData.eegPower.highAlpha);
        //DrawData("Low Beta", m_MindwaveData.eegPower.lowBeta);
        //DrawData("High Beta", m_MindwaveData.eegPower.highBeta);
        //DrawData("Low Gamma", m_MindwaveData.eegPower.lowGamma);
        //DrawData("High Gamma", m_MindwaveData.eegPower.highGamma);
        //DrawSpace();

        //GUILayout.Box("Others");
        //	DrawData("Blink strength", m_BlinkStrength);
        //DrawData("Raw EEG", m_EEGValue);
        //     }
       

			if(GUILayout.Button("Disconnect from Mindwave"))
			{
				m_Controller.Disconnect();
			}
		}

		private void DrawData(string _Label, string _Value)
		{
			GUILayout.BeginHorizontal();
			{
				GUILayout.Label(_Label, GUILayout.Width(LABEL_WIDTH));
				GUILayout.Label(_Value, GUILayout.MinWidth(VALUE_MIN_WIDTH));
			}
			GUILayout.EndHorizontal();
		}

		private void DrawData(string _Label, int _Value)
		{
			DrawData(_Label, _Value.ToString());
		}

		private void DrawData(string _Label, float _Value)
		{
			DrawData(_Label, _Value.ToString());
		}

		private void DrawSpace()
		{
			GUILayout.Label("");
		}

		private void DrawDisconnectedGUI()
		{
			GUILayout.Box("Not connected");

			if(m_Controller != null)
			{
				if (GUILayout.Button("Connect to Mindwave"))
				{
					m_Controller.Connect();
				}
			}

			else
			{
				GUILayout.Box("No MindwaveController");
			}
		}

	#endregion

}