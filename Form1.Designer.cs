namespace Stopwatcher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.stopwatchTimer = new System.Windows.Forms.Timer(this.components);
            this.colonFirst = new System.Windows.Forms.Label();
            this.colonSecond = new System.Windows.Forms.Label();
            this.blinkTimer = new System.Windows.Forms.Timer(this.components);
            this.stopwatchPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.flashTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.opacitySetting = new System.Windows.Forms.TrackBar();
            this.opacityValueLabel = new System.Windows.Forms.Label();
            this.smartPauseSetting = new System.Windows.Forms.TrackBar();
            this.smartPauseValueLabel = new System.Windows.Forms.Label();
            this.flashIntervalSetting = new System.Windows.Forms.TrackBar();
            this.flashIntervalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.progressBarTillPause = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputSwName = new System.Windows.Forms.TextBox();
            this.swName = new System.Windows.Forms.Label();
            this.resetToDefault = new System.Windows.Forms.PictureBox();
            this.switchFlashTaskbar = new System.Windows.Forms.PictureBox();
            this.switchAlwaysOnTop = new System.Windows.Forms.PictureBox();
            this.switchSmartPause = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Label();
            this.stopwatchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacitySetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPauseSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashIntervalSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetToDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchFlashTaskbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchAlwaysOnTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchSmartPause)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHours
            // 
            this.lblHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHours.AutoSize = true;
            this.lblHours.BackColor = System.Drawing.Color.Transparent;
            this.lblHours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHours.Font = new System.Drawing.Font("Digital-7", 24F);
            this.lblHours.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHours.Location = new System.Drawing.Point(-1, -2);
            this.lblHours.Margin = new System.Windows.Forms.Padding(0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(42, 39);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "00";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHours.UseCompatibleTextRendering = true;
            this.lblHours.DoubleClick += new System.EventHandler(this.ResetStopwatch);
            this.lblHours.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ToggleStopwatch);
            this.lblHours.MouseEnter += new System.EventHandler(this.OnMouseEnterTime);
            this.lblHours.MouseLeave += new System.EventHandler(this.OnMouseLeaveTime);
            // 
            // lblMinutes
            // 
            this.lblMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.BackColor = System.Drawing.Color.Transparent;
            this.lblMinutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinutes.Font = new System.Drawing.Font("Digital-7", 24F);
            this.lblMinutes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMinutes.Location = new System.Drawing.Point(45, -2);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(42, 39);
            this.lblMinutes.TabIndex = 0;
            this.lblMinutes.Text = "00";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMinutes.UseCompatibleTextRendering = true;
            this.lblMinutes.DoubleClick += new System.EventHandler(this.ResetStopwatch);
            this.lblMinutes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ToggleStopwatch);
            this.lblMinutes.MouseEnter += new System.EventHandler(this.OnMouseEnterTime);
            this.lblMinutes.MouseLeave += new System.EventHandler(this.OnMouseLeaveTime);
            // 
            // lblSeconds
            // 
            this.lblSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lblSeconds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSeconds.Font = new System.Drawing.Font("Digital-7", 24F);
            this.lblSeconds.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSeconds.Location = new System.Drawing.Point(93, -2);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(42, 39);
            this.lblSeconds.TabIndex = 0;
            this.lblSeconds.Text = "00";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSeconds.UseCompatibleTextRendering = true;
            this.lblSeconds.DoubleClick += new System.EventHandler(this.ResetStopwatch);
            this.lblSeconds.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ToggleStopwatch);
            this.lblSeconds.MouseEnter += new System.EventHandler(this.OnMouseEnterTime);
            this.lblSeconds.MouseLeave += new System.EventHandler(this.OnMouseLeaveTime);
            // 
            // stopwatchTimer
            // 
            this.stopwatchTimer.Interval = 1000;
            this.stopwatchTimer.Tick += new System.EventHandler(this.StopwatchTimer_Tick);
            // 
            // colonFirst
            // 
            this.colonFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colonFirst.BackColor = System.Drawing.Color.Transparent;
            this.colonFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colonFirst.Font = new System.Drawing.Font("Digital-7", 24F);
            this.colonFirst.ForeColor = System.Drawing.SystemColors.Control;
            this.colonFirst.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.colonFirst.Location = new System.Drawing.Point(34, 1);
            this.colonFirst.Margin = new System.Windows.Forms.Padding(0);
            this.colonFirst.Name = "colonFirst";
            this.colonFirst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colonFirst.Size = new System.Drawing.Size(16, 35);
            this.colonFirst.TabIndex = 2;
            this.colonFirst.Text = ":";
            this.colonFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colonFirst.UseCompatibleTextRendering = true;
            this.colonFirst.DoubleClick += new System.EventHandler(this.ResetStopwatch);
            this.colonFirst.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ToggleStopwatch);
            this.colonFirst.MouseEnter += new System.EventHandler(this.OnMouseEnterTime);
            this.colonFirst.MouseLeave += new System.EventHandler(this.OnMouseLeaveTime);
            // 
            // colonSecond
            // 
            this.colonSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colonSecond.BackColor = System.Drawing.Color.Transparent;
            this.colonSecond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colonSecond.Font = new System.Drawing.Font("Digital-7", 24F);
            this.colonSecond.ForeColor = System.Drawing.SystemColors.Control;
            this.colonSecond.Location = new System.Drawing.Point(81, 1);
            this.colonSecond.Name = "colonSecond";
            this.colonSecond.Size = new System.Drawing.Size(16, 35);
            this.colonSecond.TabIndex = 2;
            this.colonSecond.Text = ":";
            this.colonSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colonSecond.UseCompatibleTextRendering = true;
            this.colonSecond.DoubleClick += new System.EventHandler(this.ResetStopwatch);
            this.colonSecond.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ToggleStopwatch);
            this.colonSecond.MouseEnter += new System.EventHandler(this.OnMouseEnterTime);
            this.colonSecond.MouseLeave += new System.EventHandler(this.OnMouseLeaveTime);
            // 
            // blinkTimer
            // 
            this.blinkTimer.Interval = 500;
            this.blinkTimer.Tick += new System.EventHandler(this.BlinkTimer_Tick);
            // 
            // stopwatchPanel
            // 
            this.stopwatchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopwatchPanel.Controls.Add(this.colonSecond);
            this.stopwatchPanel.Controls.Add(this.colonFirst);
            this.stopwatchPanel.Controls.Add(this.lblMinutes);
            this.stopwatchPanel.Controls.Add(this.lblHours);
            this.stopwatchPanel.Controls.Add(this.lblSeconds);
            this.stopwatchPanel.Location = new System.Drawing.Point(4, 22);
            this.stopwatchPanel.Name = "stopwatchPanel";
            this.stopwatchPanel.Size = new System.Drawing.Size(133, 33);
            this.stopwatchPanel.TabIndex = 9;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Location = new System.Drawing.Point(118, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(19, 19);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "✖";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // flashTimer
            // 
            this.flashTimer.Interval = 1000;
            this.flashTimer.Tick += new System.EventHandler(this.flashTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label3.Font = new System.Drawing.Font("TT Commons", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(5, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Settings";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // opacitySetting
            // 
            this.opacitySetting.AutoSize = false;
            this.opacitySetting.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.opacitySetting.Location = new System.Drawing.Point(28, 127);
            this.opacitySetting.Maximum = 100;
            this.opacitySetting.Minimum = 10;
            this.opacitySetting.Name = "opacitySetting";
            this.opacitySetting.Size = new System.Drawing.Size(109, 23);
            this.opacitySetting.TabIndex = 0;
            this.opacitySetting.TickStyle = System.Windows.Forms.TickStyle.None;
            this.opacitySetting.Value = 10;
            this.opacitySetting.ValueChanged += new System.EventHandler(this.opacitySetting_ValueChanged);
            // 
            // opacityValueLabel
            // 
            this.opacityValueLabel.AutoSize = true;
            this.opacityValueLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.opacityValueLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.opacityValueLabel.Location = new System.Drawing.Point(6, 131);
            this.opacityValueLabel.Name = "opacityValueLabel";
            this.opacityValueLabel.Size = new System.Drawing.Size(13, 13);
            this.opacityValueLabel.TabIndex = 15;
            this.opacityValueLabel.Text = "0";
            // 
            // smartPauseSetting
            // 
            this.smartPauseSetting.AutoSize = false;
            this.smartPauseSetting.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.smartPauseSetting.Location = new System.Drawing.Point(30, 214);
            this.smartPauseSetting.Maximum = 61;
            this.smartPauseSetting.Minimum = 1;
            this.smartPauseSetting.Name = "smartPauseSetting";
            this.smartPauseSetting.Size = new System.Drawing.Size(109, 23);
            this.smartPauseSetting.TabIndex = 0;
            this.smartPauseSetting.TickStyle = System.Windows.Forms.TickStyle.None;
            this.smartPauseSetting.Value = 1;
            this.smartPauseSetting.ValueChanged += new System.EventHandler(this.smartPauseSetting_ValueChanged);
            // 
            // smartPauseValueLabel
            // 
            this.smartPauseValueLabel.AutoSize = true;
            this.smartPauseValueLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.smartPauseValueLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.smartPauseValueLabel.Location = new System.Drawing.Point(6, 217);
            this.smartPauseValueLabel.Name = "smartPauseValueLabel";
            this.smartPauseValueLabel.Size = new System.Drawing.Size(13, 13);
            this.smartPauseValueLabel.TabIndex = 17;
            this.smartPauseValueLabel.Text = "0";
            // 
            // flashIntervalSetting
            // 
            this.flashIntervalSetting.AutoSize = false;
            this.flashIntervalSetting.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flashIntervalSetting.Location = new System.Drawing.Point(30, 270);
            this.flashIntervalSetting.Maximum = 605;
            this.flashIntervalSetting.Minimum = 5;
            this.flashIntervalSetting.Name = "flashIntervalSetting";
            this.flashIntervalSetting.Size = new System.Drawing.Size(109, 23);
            this.flashIntervalSetting.SmallChange = 5;
            this.flashIntervalSetting.TabIndex = 0;
            this.flashIntervalSetting.TickStyle = System.Windows.Forms.TickStyle.None;
            this.flashIntervalSetting.Value = 5;
            this.flashIntervalSetting.ValueChanged += new System.EventHandler(this.flashInterval_ValueChanged);
            // 
            // flashIntervalLabel
            // 
            this.flashIntervalLabel.AutoSize = true;
            this.flashIntervalLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flashIntervalLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.flashIntervalLabel.Location = new System.Drawing.Point(6, 273);
            this.flashIntervalLabel.Name = "flashIntervalLabel";
            this.flashIntervalLabel.Size = new System.Drawing.Size(13, 13);
            this.flashIntervalLabel.TabIndex = 20;
            this.flashIntervalLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Opacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Help;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Smart Pause";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Help;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(6, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Flash taskbar";
            // 
            // progressBarTillPause
            // 
            this.progressBarTillPause.ForeColor = System.Drawing.SystemColors.Info;
            this.progressBarTillPause.Location = new System.Drawing.Point(-1, 59);
            this.progressBarTillPause.Maximum = 143;
            this.progressBarTillPause.Name = "progressBarTillPause";
            this.progressBarTillPause.Size = new System.Drawing.Size(143, 2);
            this.progressBarTillPause.Step = 1;
            this.progressBarTillPause.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTillPause.TabIndex = 25;
            this.toolTip1.SetToolTip(this.progressBarTillPause, "Time till pause\r\n");
            this.progressBarTillPause.Value = 143;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(9, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "© Made by Farid Niyazov";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Always on top";
            // 
            // inputSwName
            // 
            this.inputSwName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputSwName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSwName.ForeColor = System.Drawing.Color.Yellow;
            this.inputSwName.Location = new System.Drawing.Point(10, 6);
            this.inputSwName.MaxLength = 35;
            this.inputSwName.Name = "inputSwName";
            this.inputSwName.Size = new System.Drawing.Size(82, 13);
            this.inputSwName.TabIndex = 28;
            this.inputSwName.Text = "Rename me!";
            this.inputSwName.Visible = false;
            this.inputSwName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputSwName_KeyUp);
            this.inputSwName.Leave += new System.EventHandler(this.inputSwName_LostFocus);
            this.inputSwName.LostFocus += new System.EventHandler(this.inputSwName_LostFocus);
            // 
            // swName
            // 
            this.swName.AutoEllipsis = true;
            this.swName.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.swName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.swName.Location = new System.Drawing.Point(7, 6);
            this.swName.Name = "swName";
            this.swName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.swName.Size = new System.Drawing.Size(91, 13);
            this.swName.TabIndex = 28;
            this.swName.Text = "Rename me!";
            this.swName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.swName_DoubleClick);
            this.swName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.swName_MouseDown);
            // 
            // resetToDefault
            // 
            this.resetToDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetToDefault.Image = global::Stopwatcher.Properties.Resources.refresh_arrow_white_trans;
            this.resetToDefault.Location = new System.Drawing.Point(108, 71);
            this.resetToDefault.Name = "resetToDefault";
            this.resetToDefault.Size = new System.Drawing.Size(25, 24);
            this.resetToDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.resetToDefault.TabIndex = 29;
            this.resetToDefault.TabStop = false;
            this.resetToDefault.Click += new System.EventHandler(this.resetToDefault_Click);
            // 
            // switchFlashTaskbar
            // 
            this.switchFlashTaskbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchFlashTaskbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchFlashTaskbar.Image = ((System.Drawing.Image)(resources.GetObject("switchFlashTaskbar.Image")));
            this.switchFlashTaskbar.Location = new System.Drawing.Point(102, 250);
            this.switchFlashTaskbar.Name = "switchFlashTaskbar";
            this.switchFlashTaskbar.Size = new System.Drawing.Size(29, 15);
            this.switchFlashTaskbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.switchFlashTaskbar.TabIndex = 27;
            this.switchFlashTaskbar.TabStop = false;
            this.switchFlashTaskbar.Tag = "on";
            this.switchFlashTaskbar.Click += new System.EventHandler(this.switchFlashTaskbar_Click);
            // 
            // switchAlwaysOnTop
            // 
            this.switchAlwaysOnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchAlwaysOnTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchAlwaysOnTop.Image = global::Stopwatcher.Properties.Resources.switch_on;
            this.switchAlwaysOnTop.Location = new System.Drawing.Point(102, 163);
            this.switchAlwaysOnTop.Name = "switchAlwaysOnTop";
            this.switchAlwaysOnTop.Size = new System.Drawing.Size(29, 15);
            this.switchAlwaysOnTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.switchAlwaysOnTop.TabIndex = 26;
            this.switchAlwaysOnTop.TabStop = false;
            this.switchAlwaysOnTop.Tag = "on";
            this.switchAlwaysOnTop.Click += new System.EventHandler(this.switchAlwaysOnTop_Click);
            // 
            // switchSmartPause
            // 
            this.switchSmartPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchSmartPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchSmartPause.Image = ((System.Drawing.Image)(resources.GetObject("switchSmartPause.Image")));
            this.switchSmartPause.Location = new System.Drawing.Point(102, 195);
            this.switchSmartPause.Name = "switchSmartPause";
            this.switchSmartPause.Size = new System.Drawing.Size(29, 15);
            this.switchSmartPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.switchSmartPause.TabIndex = 26;
            this.switchSmartPause.TabStop = false;
            this.switchSmartPause.Tag = "on";
            this.switchSmartPause.Click += new System.EventHandler(this.switchSmartPause_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(96, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(19, 18);
            this.settingsButton.TabIndex = 21;
            this.settingsButton.Click += new System.EventHandler(this.settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(141, 320);
            this.Controls.Add(this.resetToDefault);
            this.Controls.Add(this.inputSwName);
            this.Controls.Add(this.swName);
            this.Controls.Add(this.switchFlashTaskbar);
            this.Controls.Add(this.switchAlwaysOnTop);
            this.Controls.Add(this.switchSmartPause);
            this.Controls.Add(this.progressBarTillPause);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.flashIntervalLabel);
            this.Controls.Add(this.flashIntervalSetting);
            this.Controls.Add(this.smartPauseValueLabel);
            this.Controls.Add(this.smartPauseSetting);
            this.Controls.Add(this.opacityValueLabel);
            this.Controls.Add(this.opacitySetting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.stopwatchPanel);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.stopwatchPanel.ResumeLayout(false);
            this.stopwatchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacitySetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPauseSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashIntervalSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetToDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchFlashTaskbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchAlwaysOnTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchSmartPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Timer stopwatchTimer;
        private System.Windows.Forms.Label colonFirst;
        private System.Windows.Forms.Label colonSecond;
        private System.Windows.Forms.Timer blinkTimer;
        private System.Windows.Forms.Panel stopwatchPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Timer flashTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar opacitySetting;
        private System.Windows.Forms.Label opacityValueLabel;
        private System.Windows.Forms.TrackBar smartPauseSetting;
        private System.Windows.Forms.Label smartPauseValueLabel;
        private System.Windows.Forms.TrackBar flashIntervalSetting;
        private System.Windows.Forms.Label flashIntervalLabel;
        private System.Windows.Forms.Label settingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarTillPause;
        private System.Windows.Forms.PictureBox switchSmartPause;
        private System.Windows.Forms.PictureBox switchFlashTaskbar;
        private System.Windows.Forms.PictureBox switchAlwaysOnTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputSwName;
        private System.Windows.Forms.Label swName;
        private System.Windows.Forms.PictureBox resetToDefault;
    }
}

