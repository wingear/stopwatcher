using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Stopwatcher
{
    public partial class Form1 : Form
    {
        int stopwatchElapsedTime = 0;
        bool isActive;
        bool isTransparent = false;
        bool isPaused = false;

        int mouseLastPosX;
        int mouseLastPosY;
        int idleTime = 0; // Текущее кол-во секунд неактивности
        int secondsInPause = 0; // Количество секунд на паузе
        int baseHeight = 61;
        int saveInterval; // Промежуток времени в секундах перед сохранением
        Guid id = Guid.NewGuid();
        private List<Label> labels;

        int config_pauseIdleTime = 3 * 60; // 3 минуты
        int config_saveInterval = 5 * 60; // 5 минут
        int config_flashInterval = 10; // seconds
        bool config_flashTaskbarEnabled = true;
        double config_opacity = 0.7;

        private int flashIntervalStep = 5;

        // Keyboard listening
        KeyboardListener KListener = new KeyboardListener();
        CustomFont customFont = new CustomFont();

        string fileName;

        public Form1()
        {
            InitializeComponent();

            lblSeconds.MouseWheel += OnMouseWheel;
            lblMinutes.MouseWheel += OnMouseWheel;
            lblHours.MouseWheel += OnMouseWheel;
            labels = new List<Label>() { lblHours, lblMinutes, lblSeconds, colonFirst, colonSecond };

            customFont.IncludeFont(Properties.Resources.digital_7_mono, labels);
            
            fileName = "Stopwatcher elapsed time - " + Text + " " + id.ToString() + ".txt";
            // Пытался поменять иконку 
            //BitmapSource icon = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(Properties.Resources.switch_on.GetHicon(), Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            //this.Icon = Icon.FromHandle(Properties.Resources.switch_on.GetHicon());
            //System.Windows.Interop.Imaging.
            /*using (var stream = File.OpenRead("power.ico"))
            {
                this.Icon = new Icon(stream);
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ActiveControl = null;

            ResetTime();

            Height = baseHeight;

            mouseLastPosX = MousePosition.X;
            mouseLastPosY = MousePosition.Y;

            opacitySetting.Value = (int)(config_opacity * 100);
            smartPauseSetting.Value = config_pauseIdleTime / 60;
            flashIntervalSetting.Value = config_flashInterval;
            saveInterval = config_saveInterval;
            TopMostWindow.TopMostToggle(true, Handle);
            KListener.KeyDown += new RawKeyEventHandler(KListener_KeyDown);

            toolTip1.SetToolTip(label2, "Time to activate Smart Pause");
            toolTip1.SetToolTip(label4, "Time until the taskbar flashes during a pause");
            toolTip1.SetToolTip(lblMinutes, "Scroll to adjust");
            toolTip1.SetToolTip(lblHours, "Scroll to adjust");
            toolTip1.SetToolTip(lblSeconds, "Scroll to adjust");
            toolTip1.SetToolTip(swName, "Double click to edit");
            toolTip1.SetToolTip(resetToDefault, "Reset settings to default");
        }

        private void KListener_KeyDown(object sender, RawKeyEventArgs args)
        {
            idleTime = 0;
        }

        private bool IsCursorInWindow()
        {
            int cursorX = MousePosition.X;
            int cursorY = MousePosition.Y;

            int windowX = Location.X;
            int windowY = Location.Y;

            if (cursorX >= windowX &&
                cursorX <= windowX + Width &&
                cursorY >= windowY &&
                cursorY <= windowY + Height)
            {
                return true;
            }

            return false;
        }

        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            if (isActive) return;

            Label label = (Label)sender;
            string labelName = label.Name;
            int secondsToChange = 1;

            if (labelName == lblMinutes.Name)
            {
                secondsToChange = 60;
            }

            if (labelName == lblHours.Name)
            {
                secondsToChange = 60 * 60;
            }

            int direction = e.Delta / 120;
            int newElapsedTime = stopwatchElapsedTime + direction * secondsToChange;

            if (newElapsedTime >= 0)
            {
                stopwatchElapsedTime = newElapsedTime;
                DrawTime();
            }
        }

        private void ToggleColor()
        {
            Color color = SystemColors.ControlDarkDark;

            if (isTransparent)
            {
                color = SystemColors.Control;
            }

            foreach (Label label in labels)
            {
                label.ForeColor = color;
            }

            isTransparent = !isTransparent;
        }

        private void SetLabelColor(Color color)
        {
            foreach (Label label in labels)
            {
                label.ForeColor = color;
            }
        }

        private void StartStopwatch()
        {
            isActive = true;
            stopwatchTimer.Enabled = true;
            blinkTimer.Enabled = false;
            flashTimer.Enabled = false;
            SetLabelColor(SystemColors.Control);
            DrawTime();
        }

        private void PauseStopwatch()
        {
            isActive = false;
            isPaused = true;
            stopwatchTimer.Enabled = false;
            blinkTimer.Enabled = true;
            flashTimer.Enabled = true;
            DrawTime();
            WriteToFile();
        }

        private void ResetStopwatch(object sender, EventArgs e)
        {
            isActive = false;
            stopwatchTimer.Enabled = false;
            blinkTimer.Enabled = false;
            flashTimer.Enabled = false;
            SetLabelColor(SystemColors.Control);
            ResetTime();
        }

        private void ResetTime()
        {
            stopwatchElapsedTime = 0;
            DrawTime();
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            ToggleColor();
        }

        private void StopwatchTimer_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                stopwatchElapsedTime++;
                AutoSave();
                SmartPause();
            }

            DrawTime();

            if (!IsCursorInWindow())
            {
                OnMouseLeave(e);
            }
        }

        private void WriteToFile()
        {
            TimeSpan elapsedTime = TimeSpan.FromSeconds(stopwatchElapsedTime);

            DateTime localDate = DateTime.Now;
            var culture = new CultureInfo("ru-RU");
            string datetime = localDate.ToString(culture);
            TextWriter txt = new StreamWriter(fileName);
            txt.Write("[" + datetime + "] " + elapsedTime.ToString());
            txt.Close();
        }

        private void AutoSave()
        {
            saveInterval--;
            if (saveInterval <= 0)
            {
                WriteToFile();
                saveInterval = config_saveInterval;
            }
        }

        private void flashTimer_Tick(object sender, EventArgs e)
        {
            if (config_flashInterval == 0 || !config_flashTaskbarEnabled)
            {
                return;
            }

            secondsInPause++;

            if (isPaused && secondsInPause >= config_flashInterval && secondsInPause <= config_flashInterval + 10)
            {
                FlashWindow.Flash(this, 3);
                secondsInPause = 0;
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Opacity = 1;
            closeButton.Enabled = true;
            settingsButton.Enabled = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (ClientRectangle.Contains(PointToClient(Control.MousePosition)))
                return;
            else
            {
                base.OnMouseLeave(e);
                Opacity = config_opacity;
                closeButton.Enabled = false;
                settingsButton.Enabled = false;
            }
        }

        private void OnMouseEnterTime(object sender, EventArgs e)
        {
            stopwatchPanel.BackColor = Color.FromArgb(90, 90, 90);
        }

        private void OnMouseLeaveTime(object sender, EventArgs e)
        {
            stopwatchPanel.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void SmartPause()
        {
            if (config_pauseIdleTime == 0)
            {
                return;
            }

            if (mouseLastPosX == MousePosition.X && mouseLastPosY == MousePosition.Y)
            {
                idleTime++;
            }
            else
            {
                idleTime = 0;
            }

            if (idleTime >= config_pauseIdleTime)
            {
                progressBarTillPause.Value = progressBarTillPause.Maximum;
                stopwatchElapsedTime -= idleTime;
                if (stopwatchElapsedTime < 0)
                {
                    stopwatchElapsedTime = 0;
                }
                PauseStopwatch();
                idleTime = 0;
            }
            else
            {
                progressBarTillPause.Value = idleTime * progressBarTillPause.Maximum / config_pauseIdleTime;
            }

            mouseLastPosX = MousePosition.X;
            mouseLastPosY = MousePosition.Y;
        }

        private void DrawTime()
        {
            TimeSpan elapsedTime = TimeSpan.FromSeconds(stopwatchElapsedTime);

            lblHours.Text = string.Format("{0:00}", (int)elapsedTime.TotalHours);
            lblMinutes.Text = string.Format("{0:00}", elapsedTime.Minutes);
            lblSeconds.Text = string.Format("{0:00}", elapsedTime.Seconds);
        }

        private void ToggleStopwatch(object sender, MouseEventArgs e)
        {
            if (isActive)
            {
                PauseStopwatch();
            }
            else
            {
                StartStopwatch();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(@fileName);
            Close();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            if (Height != baseHeight)
            {
                Height = baseHeight;
            }
            else
            {
                Height = 320;
            }
        }

        private void flashInterval_ValueChanged(object sender, EventArgs e)
        {
            int FIValue = flashIntervalSetting.Value;

            if (FIValue % flashIntervalStep != 0)
            {
                FIValue = (FIValue / flashIntervalStep) * flashIntervalStep;
            }


            if (FIValue > 59)
            {
                TimeSpan elapsedTime = TimeSpan.FromSeconds(FIValue);
                flashIntervalLabel.Text = string.Format("{0:00}:{1:00}", elapsedTime.Minutes, elapsedTime.Seconds);
            }
            else
            {
                flashIntervalLabel.Text = FIValue.ToString() + " s";
            }


            config_flashInterval = FIValue;
        }

        private void opacitySetting_ValueChanged(object sender, EventArgs e)
        {
            config_opacity = Opacity = (double)opacitySetting.Value / 100;
            opacityValueLabel.Text = opacitySetting.Value.ToString() + "%";
        }

        private void smartPauseSetting_ValueChanged(object sender, EventArgs e)
        {
            int SPValue = smartPauseSetting.Value;
            smartPauseValueLabel.Text = SPValue.ToString() + " m";
            config_pauseIdleTime = SPValue * 60;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            DragWindow.InitDragging(sender, e, Handle);
        }

        private bool toggleSwitch(PictureBox pictureBox)
        {
            Image switch_on = Properties.Resources.switch_on;
            Image switch_off = Properties.Resources.switch_off;
            Image targetPicture;
            string tag = "on";
            bool switchChecked = true;

            if ((string)pictureBox.Tag == "on")
            {
                targetPicture = switch_off;
                tag = "off";
                switchChecked = false;
            }
            else
            {
                targetPicture = switch_on;
            }
            pictureBox.Image = targetPicture;
            pictureBox.Tag = tag;

            return switchChecked;
        }
        private void switchSmartPause_Click(object sender, EventArgs e)
        {
            bool switchChecked = toggleSwitch(switchSmartPause);
            if (switchChecked)
            {
                smartPauseSetting.Enabled = true;
                config_pauseIdleTime = smartPauseSetting.Value * 60;
            }
            else
            {
                smartPauseSetting.Enabled = false;
                progressBarTillPause.Enabled = false;
                progressBarTillPause.Value = 0;
                config_pauseIdleTime = 0;
            }
        }

        private void switchFlashTaskbar_Click(object sender, EventArgs e)
        {
            bool switchChecked = toggleSwitch(switchFlashTaskbar);
            if (switchChecked)
            {
                flashIntervalSetting.Enabled = true;
                config_flashTaskbarEnabled = true;
            }
            else
            {
                flashIntervalSetting.Enabled = false;
                config_flashTaskbarEnabled = false;
            }
        }

        private void switchAlwaysOnTop_Click(object sender, EventArgs e)
        {
            bool switchChecked = toggleSwitch(switchAlwaysOnTop);
            TopMostWindow.TopMostToggle(switchChecked, Handle);
        }

        private void swName_DoubleClick(object sender, EventArgs e)
        {
            swName.Visible = false;
            inputSwName.Visible = true;
            inputSwName.SelectAll();
            inputSwName.Focus();
        }

        private void inputSwName_LostFocus(object sender, EventArgs e)
        {
            swName.Visible = true;
            inputSwName.Visible = false;
            renameTitle();
        }

        private void renameTitle()
        {
            if (swName.Text == "Rename me!" || swName.Text == "")
            {
                Text = "Stopwatcher";
            }
            else
            {
                Text = swName.Text + " - Stopwatcher";
            }
        }

        private void inputSwName_KeyUp(object sender, KeyEventArgs e)
        {
            swName.Text = inputSwName.Text;
        }

        private void swName_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DragWindow.InitDragging(sender, e, Handle);
            }
        }

        private void resetToDefault_Click(object sender, EventArgs e)
        {
            opacitySetting.Value = 70;

            switchAlwaysOnTop.Tag = "off";
            switchAlwaysOnTop_Click(sender, e);

            switchSmartPause.Tag = "off";
            switchSmartPause_Click(sender, e);
            smartPauseSetting.Value = 3;

            switchFlashTaskbar.Tag = "off";
            switchFlashTaskbar_Click(sender, e);
            flashIntervalSetting.Value = 10;
        }
    }
}