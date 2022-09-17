using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static Timecord.Utils.StringMethods;
using Timecord.Properties;
using Timecord.Utils;
using static Timecord.Utils.TableRow;

namespace Timecord.Forms {
	public partial class InputPanel : UserControl {

		public bool IsRecording = false;
		public bool IsRunning = false;

		private DateTime? StartDate;
		private DateTime? BreakStartDate;
		private int BreakTime;

		public event EventHandler SendData;
		public event EventHandler UserStoryChanged;
		public event EventHandler ParticipientChanged;

		public List<TableRow> Rows = new List<TableRow>();

		public InputPanel() {
			InitializeComponent();
		}

		public void Reset() {
			ccbUserStory.Reset();
			bSelectColorUserStory.BackColor = Color.White;
			ccbParticipant.Reset();
			tbWorking.Text = "";
			tbEstimatedTime.Text = "00:00";
			tProgress.Text = "0 %";
			sProgress.Value = 0;
		}

		protected virtual void OnSendData(object sender, EventArgs e) {
			EventHandler handler = SendData;
			handler?.Invoke(this, e);
		}

		protected virtual void OnUserStoryChanged(object sender, EventArgs e) {
			EventHandler handler = UserStoryChanged;
			handler?.Invoke(this, e);
		}

		protected virtual void OnParticipientsChanged(object sender, EventArgs e) {
			EventHandler handler = ParticipientChanged;
			handler?.Invoke(this, e);
		}

		private void bSelectColorUserStory_Click(object sender, EventArgs e) {
			DialogResult result = cdUserStory.ShowDialog();
			if(result == DialogResult.OK) {
				bSelectColorUserStory.BackColor = cdUserStory.Color;
			}
		}

		private void bAddUserStory_Click(object sender, EventArgs e) {
			if(ccbUserStory.Items.Contains(ccbUserStory.Text))
				return;
			ccbUserStory.AddItem(ccbUserStory.Text, bSelectColorUserStory.BackColor);
			OnUserStoryChanged(this, new EventArgs());
		}

		private void bRemoveUserStory_Click(object sender, EventArgs e) {
			ccbUserStory.RemoveItem(ccbUserStory.Text);
			ccbUserStory.RemoveItem(ccbUserStory.Text);
			OnUserStoryChanged(this, new EventArgs());
		}

		private void ccbUserStory_SelectedIndexChanged(object sender, EventArgs e) {
			bSelectColorUserStory.BackColor = (Color) ccbUserStory.Colors.ElementAt(ccbUserStory.SelectedIndex);
		}

		private void bAddParticipant_Click(object sender, EventArgs e) {
			if(ccbParticipant.Items.Contains(ccbParticipant.Text))
				return;
			ccbParticipant.AddItem(ccbParticipant.Text, Color.Empty);
			OnParticipientsChanged(this, new EventArgs());
		}

		private void bRemoveParticipant_Click(object sender, EventArgs e) {
			ccbParticipant.RemoveItem(ccbParticipant.Text);
			OnParticipientsChanged(this, new EventArgs());
		}

		string tbWorkingTextBeforeChange;
		private void tbWorking_TextChanged(object sender, EventArgs e) {

			string oldText = tbWorking.Text;
			string newText = oldText.Replace(Environment.NewLine, "");
			int oldSelectinStart = tbWorking.SelectionStart;
			if(tbWorking.Text.Length != newText.Length) {
				tbWorking.Text = newText;
				tbWorking.SelectionStart = oldSelectinStart - (oldText.Length - newText.Length);
			}

			bool continueProcess = true;
			int i = 1;
			int j = 0;
			List<string> lines = new List<string>();
			while(continueProcess) {
				var index = tbWorking.GetFirstCharIndexFromLine(i);
				if(index != -1) {
					lines.Add(tbWorking.Text.Substring(j, index - j));
					j = index;
					i++;
				} else {
					lines.Add(tbWorking.Text.Substring(j, tbWorking.Text.Length - j));
					continueProcess = false;
				}
			}
			oldSelectinStart = tbWorking.SelectionStart;
			if(lines.Count > 3) {
				tbWorking.Text = tbWorkingTextBeforeChange;
				tbWorking.SelectionStart = oldSelectinStart - 1;
			}

			tbWorkingTextBeforeChange = tbWorking.Text;
		}

		string tbEstimitedTimeTextBeforeChange = "00:00";
		private void tbEstimitedTime_TextChanged(object sender, EventArgs e) {
			tbEstimatedTime.MaxLength = 5;

			if(!ValidatedTimeString(tbEstimatedTime.Text)) {
				tbEstimatedTime.Text = tbEstimitedTimeTextBeforeChange;
			}

			tbEstimitedTimeTextBeforeChange = tbEstimatedTime.Text;
		}

		private bool ValidatedTimeString(string text) {
			string[] numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
			if(text.Length != tbEstimatedTime.MaxLength)
				return false;
			if(!EqualsOneOf(text[0].ToString(), numbers))
				return false;
			if(!EqualsOneOf(text[1].ToString(), numbers))
				return false;
			if(!text[2].Equals(':'))
				return false;
			if(!EqualsOneOf(text[3].ToString(), numbers))
				return false;
			if(!EqualsOneOf(text[4].ToString(), numbers))
				return false;
			return true;
		}

		private void bHourPlus_Click(object sender, EventArgs e) {
			int hour = int.Parse(tbEstimatedTime.Text.Split(':')[0]) + (Control.ModifierKeys == Keys.Shift ? 5 : 1);
			if(hour > 99)
				hour = 99;
			string hourS = hour < 10 ? "0" + hour : "" + hour;
			tbEstimatedTime.Text = hourS + ":" + tbEstimatedTime.Text.Split(':')[1];
		}

		private void bHourMinus_Click(object sender, EventArgs e) {
			int hour = int.Parse(tbEstimatedTime.Text.Split(':')[0]) - (Control.ModifierKeys == Keys.Shift ? 5 : 1);
			if(hour < 0)
				hour = 0;
			string hourS = hour < 10 ? "0" + hour : "" + hour;
			tbEstimatedTime.Text = hourS + ":" + tbEstimatedTime.Text.Split(':')[1];
		}

		private void bMinutePlus_Click(object sender, EventArgs e) {
			int min = int.Parse(tbEstimatedTime.Text.Split(':')[1]) + (Control.ModifierKeys == Keys.Shift ? 10 : 1);
			if(min > 59)
				min = 59;
			string minS = min < 10 ? "0" + min : "" + min;
			tbEstimatedTime.Text = tbEstimatedTime.Text.Split(':')[0] + ":" + minS;
		}

		private void bMinuteMinus_Click(object sender, EventArgs e) {
			int min = int.Parse(tbEstimatedTime.Text.Split(':')[1]) - (Control.ModifierKeys == Keys.Shift ? 10 : 1);
			if(min < 0)
				min = 0;
			string minS = min < 10 ? "0" + min : "" + min;
			tbEstimatedTime.Text = tbEstimatedTime.Text.Split(':')[0] + ":" + minS;
		}

		int sProgressValueBeforeChange;
		private void sProgress_ValueChanged(object sender, EventArgs e) {
			if(sProgressValueBeforeChange == sProgress.Value)
				return;
			tProgress.Text = sProgress.Value.ToString() + " %";
			sProgressValueBeforeChange = sProgress.Value;
		}

		string tProgressTextBeforeChange = "0 %";
		int tProgressSSB = 0;
		private void tProgress_TextChanged(object sender, EventArgs e) {
			if(tProgressTextBeforeChange.Equals(tProgress.Text))
				return;
			if(!tProgress.Text.EndsWith(" %")) {
				tProgress.Text = tProgressTextBeforeChange;
				return;
			}
			try {
				string text = tProgress.Text;
				int value = int.Parse(text.Substring(0, text.LastIndexOf(" %")));

				if(0 <= value && value <= 100) {
					sProgress.Value = value;
				} else {
					tProgress.Text = tProgressTextBeforeChange;
					tProgress.SelectionStart = text.LastIndexOf(" %") - 1;
				}
			} catch(Exception) {
				if(tProgress.Text.Length == 2)
					return;
				tProgress.Text = tProgressTextBeforeChange;
			}
			tProgressTextBeforeChange = tProgress.Text;
			tProgressSSB = tbWorking.SelectionStart;
		}

		private void tProgress_LostFocus(object sender, EventArgs e) {
			if(tProgress.Text.Length <= 2)
				tProgress.Text = sProgress.Value.ToString() + " %";
		}

		private void tProgress_SelectionController(object sender, EventArgs e) {
			if(tProgress.SelectionStart > tProgress.Text.Length - 2)
				tProgress.SelectionStart = tProgress.Text.LastIndexOf(" %");
		}

		private void bRecord_Click(object sender, EventArgs e) {
			bRecord.BackgroundImage = Resources.Stop_disabled;
			bRecord.Enabled = false;
			Pause();
			Rows.Add(
				new TableRow(
					ccbUserStory.Text,
					ccbParticipant.Text,
					tbWorking.Text,
					(int.Parse(tbEstimatedTime.Text.Substring(0, 2)) * 60 + int.Parse(tbEstimatedTime.Text.Substring(3, 2))) * 60000,
					sProgress.Value,
					(DateTime) StartDate,
					DateTime.Now,
					BreakTime
				)
			);
			OnSendData(this, new EventArgs());
			BreakTime = 0;
			StartDate = null;
		}

		private void bStartPause_Click(object sender, EventArgs e) {
			if(this.IsRunning) {
				Pause();
			} else {
				Start();
			}
		}

		private void Pause() {
			this.IsRunning = false;
			bStartPause.BackgroundImage = Resources.play_enabled;
			BreakStartDate = DateTime.Now;
		}

		private void Start() {
			bRecord.Enabled = true;
			bRecord.BackgroundImage = Resources.Stop_enabled;
			if(StartDate == null)
				StartDate = DateTime.Now;
			this.IsRunning = true;
			bStartPause.BackgroundImage = Resources.pause_enabled;
			if(BreakStartDate != null)
				BreakTime += (int) DateTime.Now.Subtract((DateTime) BreakStartDate).TotalMilliseconds;
		}
	}
}
