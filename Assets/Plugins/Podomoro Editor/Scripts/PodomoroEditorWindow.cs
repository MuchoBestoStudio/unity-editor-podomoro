using UnityEngine;
using UnityEditor;

namespace MuchoBestoStudio.Podomoro.Editor
{
	public class PodomoroEditorWindow : EditorWindow
	{
		#region Enum

		public enum Tabs
		{
			Timer,
			Settings,
		}

		#endregion

		#region Constants

		public static readonly string[] TABS_LABELS = { "Timer", "Settings" };

		#endregion

		#region Variable

		public Tabs CurrentTab { get; private set; } = Tabs.Timer;

		#endregion

		#region Initialize

		[MenuItem("Window/Podomoro")]
		private static void Initialize()
		{
			GetWindow<PodomoroEditorWindow>(false, "Podomoro", true).Show();
		}

		#endregion

		#region OnGUI

		private void OnGUI()
		{
			DrawTabs();

			if (CurrentTab == Tabs.Timer)
			{
				DrawTimer();
			}
			else
			{
				DrawSettings();
			}
		}

		private void DrawTabs()
		{
			Tabs tab = (Tabs)GUILayout.Toolbar((int)CurrentTab, TABS_LABELS);
			if (tab != CurrentTab)
			{
				ChangeTab(tab);
			}
		}

		private void DrawTimer()
		{
			// ToDo
		}

		private void DrawSettings()
		{
			// ToDo
		}

		#endregion

		#region Tabs

		public void ChangeTab(Tabs tab)
		{
			CurrentTab = tab;

			// ToDo (save settings)
		}

		#endregion
	}
}
