namespace HousePriceAnalyzer
{
    partial class HousePriceAnalyzerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButtonFurnishingstatus = new RadioButton();
            radioButtonPrefarea = new RadioButton();
            radioButtonParking = new RadioButton();
            radioButtonAirconditioning = new RadioButton();
            radioButtonhotwaterheating = new RadioButton();
            radioButtonArea = new RadioButton();
            radioButtonBasement = new RadioButton();
            radioBathrooms = new RadioButton();
            radioGuestRoom = new RadioButton();
            radioButtonStories = new RadioButton();
            radioMainRoad = new RadioButton();
            radioButtonPrice = new RadioButton();
            formsPlotGeneric = new ScottPlot.FormsPlot();
            tabPage3 = new TabPage();
            splitContainer2 = new SplitContainer();
            groupBox2 = new GroupBox();
            radioButtonBfurnishingstatus = new RadioButton();
            radioButtonBprefarea = new RadioButton();
            radioButtonBstories = new RadioButton();
            radioButtonBmainroad = new RadioButton();
            radioButtonBguestroom = new RadioButton();
            radioButtonBbasement = new RadioButton();
            radioButtonBhotwaterheating = new RadioButton();
            radioButtonBairconditioning = new RadioButton();
            radioButtonBparking = new RadioButton();
            radioButtonBarea = new RadioButton();
            radioButtonBbathrooms = new RadioButton();
            radioButtonBbedrooms = new RadioButton();
            formsPlotBivariate = new ScottPlot.FormsPlot();
            tabPage4 = new TabPage();
            labelPredArea = new Label();
            trackBar1 = new TrackBar();
            textBox3 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox12 = new ComboBox();
            comboBox11 = new ComboBox();
            comboBox10 = new ComboBox();
            comboBox9 = new ComboBox();
            comboBox8 = new ComboBox();
            comboBox7 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            textBox2 = new TextBox();
            tabPage6 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 39);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(840, 324);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(797, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(860, 397);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(852, 369);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Data";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            textBox1.Location = new Point(6, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(840, 35);
            textBox1.TabIndex = 1;
            textBox1.Text = "House Pricing Data,Review";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(852, 369);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Descriptives";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(radioButtonPrice);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(formsPlotGeneric);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(846, 363);
            splitContainer1.SplitterDistance = 130;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButtonFurnishingstatus);
            groupBox1.Controls.Add(radioButtonPrefarea);
            groupBox1.Controls.Add(radioButtonParking);
            groupBox1.Controls.Add(radioButtonAirconditioning);
            groupBox1.Controls.Add(radioButtonhotwaterheating);
            groupBox1.Controls.Add(radioButtonArea);
            groupBox1.Controls.Add(radioButtonBasement);
            groupBox1.Controls.Add(radioBathrooms);
            groupBox1.Controls.Add(radioGuestRoom);
            groupBox1.Controls.Add(radioButtonStories);
            groupBox1.Controls.Add(radioMainRoad);
            groupBox1.Location = new Point(4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(123, 356);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Features";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(6, 22);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(51, 19);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "Price";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged_2;
            // 
            // radioButtonFurnishingstatus
            // 
            radioButtonFurnishingstatus.AutoSize = true;
            radioButtonFurnishingstatus.Location = new Point(6, 297);
            radioButtonFurnishingstatus.Name = "radioButtonFurnishingstatus";
            radioButtonFurnishingstatus.Size = new Size(110, 19);
            radioButtonFurnishingstatus.TabIndex = 7;
            radioButtonFurnishingstatus.Text = "furnishingstatus";
            radioButtonFurnishingstatus.UseVisualStyleBackColor = true;
            radioButtonFurnishingstatus.CheckedChanged += radioButtonFurnishingstatus_CheckedChanged;
            // 
            // radioButtonPrefarea
            // 
            radioButtonPrefarea.AutoSize = true;
            radioButtonPrefarea.Location = new Point(6, 272);
            radioButtonPrefarea.Name = "radioButtonPrefarea";
            radioButtonPrefarea.Size = new Size(68, 19);
            radioButtonPrefarea.TabIndex = 6;
            radioButtonPrefarea.Text = "prefarea";
            radioButtonPrefarea.UseVisualStyleBackColor = true;
            radioButtonPrefarea.CheckedChanged += radioButtonPrefarea_CheckedChanged;
            // 
            // radioButtonParking
            // 
            radioButtonParking.AutoSize = true;
            radioButtonParking.Location = new Point(6, 247);
            radioButtonParking.Name = "radioButtonParking";
            radioButtonParking.Size = new Size(65, 19);
            radioButtonParking.TabIndex = 5;
            radioButtonParking.Text = "parking";
            radioButtonParking.UseVisualStyleBackColor = true;
            radioButtonParking.CheckedChanged += radioButtonParking_CheckedChanged;
            // 
            // radioButtonAirconditioning
            // 
            radioButtonAirconditioning.AutoSize = true;
            radioButtonAirconditioning.Location = new Point(6, 222);
            radioButtonAirconditioning.Name = "radioButtonAirconditioning";
            radioButtonAirconditioning.Size = new Size(106, 19);
            radioButtonAirconditioning.TabIndex = 1;
            radioButtonAirconditioning.Text = "airconditioning";
            radioButtonAirconditioning.UseVisualStyleBackColor = true;
            radioButtonAirconditioning.CheckedChanged += radioButtonAirconditioning_CheckedChanged;
            // 
            // radioButtonhotwaterheating
            // 
            radioButtonhotwaterheating.AutoSize = true;
            radioButtonhotwaterheating.Location = new Point(6, 197);
            radioButtonhotwaterheating.Name = "radioButtonhotwaterheating";
            radioButtonhotwaterheating.Size = new Size(112, 19);
            radioButtonhotwaterheating.TabIndex = 2;
            radioButtonhotwaterheating.Text = "hotwaterheating";
            radioButtonhotwaterheating.UseVisualStyleBackColor = true;
            radioButtonhotwaterheating.CheckedChanged += radioButtonhotwaterheating_CheckedChanged;
            // 
            // radioButtonArea
            // 
            radioButtonArea.AutoSize = true;
            radioButtonArea.Location = new Point(6, 47);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.Size = new Size(47, 19);
            radioButtonArea.TabIndex = 1;
            radioButtonArea.Text = "area";
            radioButtonArea.UseVisualStyleBackColor = true;
            radioButtonArea.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButtonBasement
            // 
            radioButtonBasement.AutoSize = true;
            radioButtonBasement.Location = new Point(6, 172);
            radioButtonBasement.Name = "radioButtonBasement";
            radioButtonBasement.Size = new Size(77, 19);
            radioButtonBasement.TabIndex = 4;
            radioButtonBasement.Text = "basement";
            radioButtonBasement.UseVisualStyleBackColor = true;
            radioButtonBasement.CheckedChanged += radioButtonBasement_CheckedChanged;
            // 
            // radioBathrooms
            // 
            radioBathrooms.AutoSize = true;
            radioBathrooms.Location = new Point(6, 72);
            radioBathrooms.Name = "radioBathrooms";
            radioBathrooms.Size = new Size(83, 19);
            radioBathrooms.TabIndex = 2;
            radioBathrooms.Text = "bathrooms";
            radioBathrooms.UseVisualStyleBackColor = true;
            radioBathrooms.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioGuestRoom
            // 
            radioGuestRoom.AutoSize = true;
            radioGuestRoom.Location = new Point(6, 147);
            radioGuestRoom.Name = "radioGuestRoom";
            radioGuestRoom.Size = new Size(83, 19);
            radioGuestRoom.TabIndex = 1;
            radioGuestRoom.Text = "guestroom";
            radioGuestRoom.UseVisualStyleBackColor = true;
            radioGuestRoom.CheckedChanged += radioGuestRoom_CheckedChanged;
            // 
            // radioButtonStories
            // 
            radioButtonStories.AutoSize = true;
            radioButtonStories.Location = new Point(6, 97);
            radioButtonStories.Name = "radioButtonStories";
            radioButtonStories.Size = new Size(59, 19);
            radioButtonStories.TabIndex = 3;
            radioButtonStories.Text = "stories";
            radioButtonStories.UseVisualStyleBackColor = true;
            radioButtonStories.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioMainRoad
            // 
            radioMainRoad.AutoSize = true;
            radioMainRoad.Location = new Point(6, 122);
            radioMainRoad.Name = "radioMainRoad";
            radioMainRoad.Size = new Size(76, 19);
            radioMainRoad.TabIndex = 1;
            radioMainRoad.Text = "mainroad";
            radioMainRoad.UseVisualStyleBackColor = true;
            radioMainRoad.CheckedChanged += radioButton4_CheckedChanged_1;
            // 
            // radioButtonPrice
            // 
            radioButtonPrice.AutoSize = true;
            radioButtonPrice.Location = new Point(19, 85);
            radioButtonPrice.Name = "radioButtonPrice";
            radioButtonPrice.Size = new Size(51, 19);
            radioButtonPrice.TabIndex = 1;
            radioButtonPrice.Text = "price";
            radioButtonPrice.UseVisualStyleBackColor = true;
            radioButtonPrice.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // formsPlotGeneric
            // 
            formsPlotGeneric.Location = new Point(4, 3);
            formsPlotGeneric.Margin = new Padding(4, 3, 4, 3);
            formsPlotGeneric.Name = "formsPlotGeneric";
            formsPlotGeneric.Size = new Size(715, 357);
            formsPlotGeneric.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitContainer2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(852, 369);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Bivariate";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(formsPlotBivariate);
            splitContainer2.Size = new Size(846, 363);
            splitContainer2.SplitterDistance = 150;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonBfurnishingstatus);
            groupBox2.Controls.Add(radioButtonBprefarea);
            groupBox2.Controls.Add(radioButtonBstories);
            groupBox2.Controls.Add(radioButtonBmainroad);
            groupBox2.Controls.Add(radioButtonBguestroom);
            groupBox2.Controls.Add(radioButtonBbasement);
            groupBox2.Controls.Add(radioButtonBhotwaterheating);
            groupBox2.Controls.Add(radioButtonBairconditioning);
            groupBox2.Controls.Add(radioButtonBparking);
            groupBox2.Controls.Add(radioButtonBarea);
            groupBox2.Controls.Add(radioButtonBbathrooms);
            groupBox2.Controls.Add(radioButtonBbedrooms);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(144, 357);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Price - Bivariate Plots";
            // 
            // radioButtonBfurnishingstatus
            // 
            radioButtonBfurnishingstatus.AutoSize = true;
            radioButtonBfurnishingstatus.Location = new Point(6, 297);
            radioButtonBfurnishingstatus.Name = "radioButtonBfurnishingstatus";
            radioButtonBfurnishingstatus.Size = new Size(110, 19);
            radioButtonBfurnishingstatus.TabIndex = 9;
            radioButtonBfurnishingstatus.TabStop = true;
            radioButtonBfurnishingstatus.Text = "furnishingstatus";
            radioButtonBfurnishingstatus.UseVisualStyleBackColor = true;
            radioButtonBfurnishingstatus.CheckedChanged += radioButtonBfurnishingstatus_CheckedChanged;
            // 
            // radioButtonBprefarea
            // 
            radioButtonBprefarea.AutoSize = true;
            radioButtonBprefarea.Location = new Point(6, 272);
            radioButtonBprefarea.Name = "radioButtonBprefarea";
            radioButtonBprefarea.Size = new Size(68, 19);
            radioButtonBprefarea.TabIndex = 8;
            radioButtonBprefarea.Text = "prefarea";
            radioButtonBprefarea.UseVisualStyleBackColor = true;
            radioButtonBprefarea.CheckedChanged += radioButtonBprefarea_CheckedChanged;
            // 
            // radioButtonBstories
            // 
            radioButtonBstories.AutoSize = true;
            radioButtonBstories.Location = new Point(6, 97);
            radioButtonBstories.Name = "radioButtonBstories";
            radioButtonBstories.Size = new Size(60, 19);
            radioButtonBstories.TabIndex = 1;
            radioButtonBstories.Text = "Stories";
            radioButtonBstories.UseVisualStyleBackColor = true;
            radioButtonBstories.CheckedChanged += radioButtonBstories_CheckedChanged;
            // 
            // radioButtonBmainroad
            // 
            radioButtonBmainroad.AutoSize = true;
            radioButtonBmainroad.Location = new Point(6, 122);
            radioButtonBmainroad.Name = "radioButtonBmainroad";
            radioButtonBmainroad.Size = new Size(76, 19);
            radioButtonBmainroad.TabIndex = 2;
            radioButtonBmainroad.Text = "mainroad";
            radioButtonBmainroad.UseVisualStyleBackColor = true;
            radioButtonBmainroad.CheckedChanged += radioButtonBmainroad_CheckedChanged;
            // 
            // radioButtonBguestroom
            // 
            radioButtonBguestroom.AutoSize = true;
            radioButtonBguestroom.Location = new Point(6, 147);
            radioButtonBguestroom.Name = "radioButtonBguestroom";
            radioButtonBguestroom.Size = new Size(83, 19);
            radioButtonBguestroom.TabIndex = 3;
            radioButtonBguestroom.Text = "guestroom";
            radioButtonBguestroom.UseVisualStyleBackColor = true;
            radioButtonBguestroom.CheckedChanged += radioButtonBguestroom_CheckedChanged;
            // 
            // radioButtonBbasement
            // 
            radioButtonBbasement.AutoSize = true;
            radioButtonBbasement.Location = new Point(6, 172);
            radioButtonBbasement.Name = "radioButtonBbasement";
            radioButtonBbasement.Size = new Size(77, 19);
            radioButtonBbasement.TabIndex = 4;
            radioButtonBbasement.Text = "basement";
            radioButtonBbasement.UseVisualStyleBackColor = true;
            radioButtonBbasement.CheckedChanged += radioButtonBbasement_CheckedChanged;
            // 
            // radioButtonBhotwaterheating
            // 
            radioButtonBhotwaterheating.AutoSize = true;
            radioButtonBhotwaterheating.Location = new Point(6, 197);
            radioButtonBhotwaterheating.Name = "radioButtonBhotwaterheating";
            radioButtonBhotwaterheating.Size = new Size(112, 19);
            radioButtonBhotwaterheating.TabIndex = 5;
            radioButtonBhotwaterheating.Text = "hotwaterheating";
            radioButtonBhotwaterheating.UseVisualStyleBackColor = true;
            radioButtonBhotwaterheating.CheckedChanged += radioButtonBhotwaterheating_CheckedChanged_1;
            // 
            // radioButtonBairconditioning
            // 
            radioButtonBairconditioning.AutoSize = true;
            radioButtonBairconditioning.Location = new Point(6, 222);
            radioButtonBairconditioning.Name = "radioButtonBairconditioning";
            radioButtonBairconditioning.Size = new Size(106, 19);
            radioButtonBairconditioning.TabIndex = 6;
            radioButtonBairconditioning.Text = "airconditioning";
            radioButtonBairconditioning.UseVisualStyleBackColor = true;
            radioButtonBairconditioning.CheckedChanged += radioButtonBairconditioning_CheckedChanged;
            // 
            // radioButtonBparking
            // 
            radioButtonBparking.AutoSize = true;
            radioButtonBparking.Location = new Point(6, 247);
            radioButtonBparking.Name = "radioButtonBparking";
            radioButtonBparking.Size = new Size(65, 19);
            radioButtonBparking.TabIndex = 7;
            radioButtonBparking.Text = "parking";
            radioButtonBparking.UseVisualStyleBackColor = true;
            radioButtonBparking.CheckedChanged += radioButtonBparking_CheckedChanged;
            // 
            // radioButtonBarea
            // 
            radioButtonBarea.AutoSize = true;
            radioButtonBarea.Checked = true;
            radioButtonBarea.Location = new Point(6, 22);
            radioButtonBarea.Name = "radioButtonBarea";
            radioButtonBarea.Size = new Size(47, 19);
            radioButtonBarea.TabIndex = 1;
            radioButtonBarea.TabStop = true;
            radioButtonBarea.Text = "area";
            radioButtonBarea.UseVisualStyleBackColor = true;
            radioButtonBarea.CheckedChanged += radioButtonBarea_CheckedChanged;
            // 
            // radioButtonBbathrooms
            // 
            radioButtonBbathrooms.AutoSize = true;
            radioButtonBbathrooms.Location = new Point(6, 72);
            radioButtonBbathrooms.Name = "radioButtonBbathrooms";
            radioButtonBbathrooms.Size = new Size(83, 19);
            radioButtonBbathrooms.TabIndex = 1;
            radioButtonBbathrooms.Text = "bathrooms";
            radioButtonBbathrooms.UseVisualStyleBackColor = true;
            radioButtonBbathrooms.CheckedChanged += radioButtonBbathrooms_CheckedChanged;
            // 
            // radioButtonBbedrooms
            // 
            radioButtonBbedrooms.AutoSize = true;
            radioButtonBbedrooms.Location = new Point(6, 47);
            radioButtonBbedrooms.Name = "radioButtonBbedrooms";
            radioButtonBbedrooms.Size = new Size(79, 19);
            radioButtonBbedrooms.TabIndex = 0;
            radioButtonBbedrooms.Text = "bedrooms";
            radioButtonBbedrooms.UseVisualStyleBackColor = true;
            radioButtonBbedrooms.CheckedChanged += radioButtonBbedrooms_CheckedChanged;
            // 
            // formsPlotBivariate
            // 
            formsPlotBivariate.Location = new Point(4, 3);
            formsPlotBivariate.Margin = new Padding(4, 3, 4, 3);
            formsPlotBivariate.Name = "formsPlotBivariate";
            formsPlotBivariate.Size = new Size(684, 357);
            formsPlotBivariate.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(labelPredArea);
            tabPage4.Controls.Add(trackBar1);
            tabPage4.Controls.Add(textBox3);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(comboBox12);
            tabPage4.Controls.Add(comboBox11);
            tabPage4.Controls.Add(comboBox10);
            tabPage4.Controls.Add(comboBox9);
            tabPage4.Controls.Add(comboBox8);
            tabPage4.Controls.Add(comboBox7);
            tabPage4.Controls.Add(comboBox6);
            tabPage4.Controls.Add(comboBox5);
            tabPage4.Controls.Add(comboBox4);
            tabPage4.Controls.Add(comboBox3);
            tabPage4.Controls.Add(comboBox2);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(textBox2);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(852, 369);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Predictions";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // labelPredArea
            // 
            labelPredArea.AutoSize = true;
            labelPredArea.BackColor = SystemColors.ActiveCaption;
            labelPredArea.Location = new Point(176, 82);
            labelPredArea.Name = "labelPredArea";
            labelPredArea.Size = new Size(0, 15);
            labelPredArea.TabIndex = 28;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = SystemColors.ActiveBorder;
            trackBar1.Location = new Point(85, 70);
            trackBar1.Maximum = 20000;
            trackBar1.Minimum = 500;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(85, 45);
            trackBar1.TabIndex = 27;
            trackBar1.Value = 500;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 0);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(852, 23);
            textBox3.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(279, 292);
            label12.Name = "label12";
            label12.Size = new Size(92, 15);
            label12.TabIndex = 25;
            label12.Text = "furnishingstatus";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(329, 249);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 24;
            label11.Text = "prefarea";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(326, 210);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 23;
            label10.Text = "parking";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(285, 167);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 22;
            label9.Text = "airconditioning";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(279, 124);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 21;
            label8.Text = "hotwaterheating";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(314, 82);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 20;
            label7.Text = "basement";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 293);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 19;
            label6.Text = "guestroom";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 249);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 18;
            label5.Text = "mainroad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 210);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 17;
            label4.Text = "stories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 167);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 16;
            label3.Text = "bathrooms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 124);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 15;
            label2.Text = "bedrooms";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 82);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 14;
            label1.Text = "area";
            // 
            // comboBox12
            // 
            comboBox12.FormattingEnabled = true;
            comboBox12.Items.AddRange(new object[] { "yes", "no" });
            comboBox12.Location = new Point(379, 289);
            comboBox12.Name = "comboBox12";
            comboBox12.Size = new Size(121, 23);
            comboBox12.TabIndex = 13;
            comboBox12.Text = "Yes";
            // 
            // comboBox11
            // 
            comboBox11.FormattingEnabled = true;
            comboBox11.Items.AddRange(new object[] { "yes", "no" });
            comboBox11.Location = new Point(379, 246);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(121, 23);
            comboBox11.TabIndex = 12;
            comboBox11.Text = "Yes";
            // 
            // comboBox10
            // 
            comboBox10.FormattingEnabled = true;
            comboBox10.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            comboBox10.Location = new Point(379, 207);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(121, 23);
            comboBox10.TabIndex = 11;
            comboBox10.Text = "1";
            // 
            // comboBox9
            // 
            comboBox9.FormattingEnabled = true;
            comboBox9.Items.AddRange(new object[] { "yes", "no" });
            comboBox9.Location = new Point(379, 164);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(121, 23);
            comboBox9.TabIndex = 10;
            comboBox9.Text = "Yes";
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "yes", "no" });
            comboBox8.Location = new Point(379, 121);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(121, 23);
            comboBox8.TabIndex = 9;
            comboBox8.Text = "Yes";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "yes", "no" });
            comboBox7.Location = new Point(379, 79);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(121, 23);
            comboBox7.TabIndex = 8;
            comboBox7.Text = "Yes";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "yes", "no" });
            comboBox6.Location = new Point(85, 289);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 7;
            comboBox6.Text = "Yes";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "yes", "no" });
            comboBox5.Location = new Point(85, 246);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 6;
            comboBox5.Text = "Yes";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBox4.Location = new Point(85, 207);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 5;
            comboBox4.Text = "1";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            comboBox3.Location = new Point(85, 164);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 4;
            comboBox3.Text = "1";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            comboBox2.Location = new Point(85, 121);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "1";
            // 
            // button2
            // 
            button2.Location = new Point(564, 289);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 2;
            button2.Text = "Predict Price";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(700, 289);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 23);
            textBox2.TabIndex = 1;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(852, 369);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "About";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "HousePriceAnalyzer";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage6;
        private SplitContainer splitContainer1;
        private RadioButton radioButtonStories;
        private RadioButton radioBathrooms;
        private RadioButton radioButtonArea;
        private RadioButton radioButtonPrice;
        private ScottPlot.FormsPlot formsPlotGeneric;
        private TabPage tabPage3;
        private SplitContainer splitContainer2;
        private RadioButton radioButtonBarea;
        private RadioButton radioButtonBbathrooms;
        private RadioButton radioButtonBbedrooms;
        private ScottPlot.FormsPlot formsPlotBivariate;
        private RadioButton radioMainRoad;
        private TextBox textBox1;
        private RadioButton radioGuestRoom;
        private GroupBox groupBox1;
        private RadioButton radioButtonBasement;
        private RadioButton radioButtonFurnishingstatus;
        private RadioButton radioButtonPrefarea;
        private RadioButton radioButtonParking;
        private RadioButton radioButtonAirconditioning;
        private RadioButton radioButtonhotwaterheating;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButtonBstories;
        private RadioButton radioButtonBmainroad;
        private RadioButton radioButtonBguestroom;
        private RadioButton radioButtonBbasement;
        private RadioButton radioButtonBhotwaterheating;
        private RadioButton radioButtonBairconditioning;
        private RadioButton radioButtonBparking;
        private RadioButton radioButtonBprefarea;
        private RadioButton radioButtonBfurnishingstatus;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox12;
        private ComboBox comboBox11;
        private ComboBox comboBox10;
        private ComboBox comboBox9;
        private ComboBox comboBox8;
        private ComboBox comboBox7;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private TrackBar trackBar1;
        private Label labelPredArea;
        private ComboBox comboBox2;
    }
}
