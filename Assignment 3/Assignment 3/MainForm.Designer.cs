namespace Assignment_3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxFuelInput = new System.Windows.Forms.GroupBox();
            this.btnCalcFuel = new System.Windows.Forms.Button();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblFuelAmount = new System.Windows.Forms.Label();
            this.txtFuelAmount = new System.Windows.Forms.TextBox();
            this.lblPrevReading = new System.Windows.Forms.Label();
            this.txtPrevReading = new System.Windows.Forms.TextBox();
            this.lblCurrentReading = new System.Windows.Forms.Label();
            this.txtCurrReading = new System.Windows.Forms.TextBox();
            this.gbxFuelResult = new System.Windows.Forms.GroupBox();
            this.lblcostPerKm = new System.Windows.Forms.Label();
            this.lblLitPerSweMil = new System.Windows.Forms.Label();
            this.lblLitPerMile = new System.Windows.Forms.Label();
            this.lblCostperKmText = new System.Windows.Forms.Label();
            this.lblLiterPerSwMilText = new System.Windows.Forms.Label();
            this.lblLiterPerMileText = new System.Windows.Forms.Label();
            this.lblLiterPerKmText = new System.Windows.Forms.Label();
            this.lblLitPerKm = new System.Windows.Forms.Label();
            this.lblkmPerLit = new System.Windows.Forms.Label();
            this.lblKmPerLiterText = new System.Windows.Forms.Label();
            this.gbxBMIInput = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.rbtnUsUnits = new System.Windows.Forms.RadioButton();
            this.rbtnMetricUnits = new System.Windows.Forms.RadioButton();
            this.btnCalcBMI = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblNameText = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbxResultBmi = new System.Windows.Forms.GroupBox();
            this.lblNormalBmi = new System.Windows.Forms.Label();
            this.lblWeightCategory = new System.Windows.Forms.Label();
            this.lblYourBmi = new System.Windows.Forms.Label();
            this.lblWeightCategoryText = new System.Windows.Forms.Label();
            this.lblYourBmiText = new System.Windows.Forms.Label();
            this.gbxBmr = new System.Windows.Forms.GroupBox();
            this.lblBmrResult = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnCalcBmr = new System.Windows.Forms.Button();
            this.gbxActivityLevel = new System.Windows.Forms.GroupBox();
            this.rbtnGroup3 = new System.Windows.Forms.RadioButton();
            this.rbtnGroup4 = new System.Windows.Forms.RadioButton();
            this.rbtnGroup2 = new System.Windows.Forms.RadioButton();
            this.rbtnGroup0 = new System.Windows.Forms.RadioButton();
            this.rbtnGroup1 = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAgeText = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.gbxFuelInput.SuspendLayout();
            this.gbxFuelResult.SuspendLayout();
            this.gbxBMIInput.SuspendLayout();
            this.gbxResultBmi.SuspendLayout();
            this.gbxBmr.SuspendLayout();
            this.gbxActivityLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFuelInput
            // 
            this.gbxFuelInput.Controls.Add(this.btnCalcFuel);
            this.gbxFuelInput.Controls.Add(this.lblUnitPrice);
            this.gbxFuelInput.Controls.Add(this.txtUnitPrice);
            this.gbxFuelInput.Controls.Add(this.lblFuelAmount);
            this.gbxFuelInput.Controls.Add(this.txtFuelAmount);
            this.gbxFuelInput.Controls.Add(this.lblPrevReading);
            this.gbxFuelInput.Controls.Add(this.txtPrevReading);
            this.gbxFuelInput.Controls.Add(this.lblCurrentReading);
            this.gbxFuelInput.Controls.Add(this.txtCurrReading);
            this.gbxFuelInput.Location = new System.Drawing.Point(43, 12);
            this.gbxFuelInput.Name = "gbxFuelInput";
            this.gbxFuelInput.Size = new System.Drawing.Size(469, 191);
            this.gbxFuelInput.TabIndex = 0;
            this.gbxFuelInput.TabStop = false;
            this.gbxFuelInput.Text = "Fuel";
            // 
            // btnCalcFuel
            // 
            this.btnCalcFuel.Location = new System.Drawing.Point(187, 149);
            this.btnCalcFuel.Name = "btnCalcFuel";
            this.btnCalcFuel.Size = new System.Drawing.Size(100, 30);
            this.btnCalcFuel.TabIndex = 8;
            this.btnCalcFuel.Text = "Calculate";
            this.btnCalcFuel.UseVisualStyleBackColor = true;
            this.btnCalcFuel.Click += new System.EventHandler(this.BtnCalcFuel_Click);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(10, 126);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(92, 17);
            this.lblUnitPrice.TabIndex = 7;
            this.lblUnitPrice.Text = "Price per liter";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(342, 126);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(62, 22);
            this.txtUnitPrice.TabIndex = 6;
            // 
            // lblFuelAmount
            // 
            this.lblFuelAmount.AutoSize = true;
            this.lblFuelAmount.Location = new System.Drawing.Point(10, 92);
            this.lblFuelAmount.Name = "lblFuelAmount";
            this.lblFuelAmount.Size = new System.Drawing.Size(240, 17);
            this.lblFuelAmount.TabIndex = 5;
            this.lblFuelAmount.Text = "Current amount of fuel tanked (liters)";
            // 
            // txtFuelAmount
            // 
            this.txtFuelAmount.Location = new System.Drawing.Point(342, 92);
            this.txtFuelAmount.Name = "txtFuelAmount";
            this.txtFuelAmount.Size = new System.Drawing.Size(62, 22);
            this.txtFuelAmount.TabIndex = 4;
            // 
            // lblPrevReading
            // 
            this.lblPrevReading.AutoSize = true;
            this.lblPrevReading.Location = new System.Drawing.Point(10, 57);
            this.lblPrevReading.Name = "lblPrevReading";
            this.lblPrevReading.Size = new System.Drawing.Size(211, 17);
            this.lblPrevReading.TabIndex = 3;
            this.lblPrevReading.Text = "Previous odometer reading (km)";
            // 
            // txtPrevReading
            // 
            this.txtPrevReading.Location = new System.Drawing.Point(251, 57);
            this.txtPrevReading.Name = "txtPrevReading";
            this.txtPrevReading.Size = new System.Drawing.Size(153, 22);
            this.txtPrevReading.TabIndex = 2;
            // 
            // lblCurrentReading
            // 
            this.lblCurrentReading.AutoSize = true;
            this.lblCurrentReading.Location = new System.Drawing.Point(10, 29);
            this.lblCurrentReading.Name = "lblCurrentReading";
            this.lblCurrentReading.Size = new System.Drawing.Size(203, 17);
            this.lblCurrentReading.TabIndex = 1;
            this.lblCurrentReading.Text = "Current odometer reading (km)";
            // 
            // txtCurrReading
            // 
            this.txtCurrReading.Location = new System.Drawing.Point(251, 24);
            this.txtCurrReading.Name = "txtCurrReading";
            this.txtCurrReading.Size = new System.Drawing.Size(153, 22);
            this.txtCurrReading.TabIndex = 0;
            // 
            // gbxFuelResult
            // 
            this.gbxFuelResult.Controls.Add(this.lblcostPerKm);
            this.gbxFuelResult.Controls.Add(this.lblLitPerSweMil);
            this.gbxFuelResult.Controls.Add(this.lblLitPerMile);
            this.gbxFuelResult.Controls.Add(this.lblCostperKmText);
            this.gbxFuelResult.Controls.Add(this.lblLiterPerSwMilText);
            this.gbxFuelResult.Controls.Add(this.lblLiterPerMileText);
            this.gbxFuelResult.Controls.Add(this.lblLiterPerKmText);
            this.gbxFuelResult.Controls.Add(this.lblLitPerKm);
            this.gbxFuelResult.Controls.Add(this.lblkmPerLit);
            this.gbxFuelResult.Controls.Add(this.lblKmPerLiterText);
            this.gbxFuelResult.Location = new System.Drawing.Point(43, 209);
            this.gbxFuelResult.Name = "gbxFuelResult";
            this.gbxFuelResult.Size = new System.Drawing.Size(469, 168);
            this.gbxFuelResult.TabIndex = 1;
            this.gbxFuelResult.TabStop = false;
            this.gbxFuelResult.Text = "Results";
            // 
            // lblcostPerKm
            // 
            this.lblcostPerKm.AutoSize = true;
            this.lblcostPerKm.Location = new System.Drawing.Point(312, 136);
            this.lblcostPerKm.Name = "lblcostPerKm";
            this.lblcostPerKm.Size = new System.Drawing.Size(56, 17);
            this.lblcostPerKm.TabIndex = 12;
            this.lblcostPerKm.Text = "cost/km";
            // 
            // lblLitPerSweMil
            // 
            this.lblLitPerSweMil.AutoSize = true;
            this.lblLitPerSweMil.Location = new System.Drawing.Point(312, 108);
            this.lblLitPerSweMil.Name = "lblLitPerSweMil";
            this.lblLitPerSweMil.Size = new System.Drawing.Size(62, 17);
            this.lblLitPerSweMil.TabIndex = 11;
            this.lblLitPerSweMil.Text = "l/Swe mil";
            // 
            // lblLitPerMile
            // 
            this.lblLitPerMile.AutoSize = true;
            this.lblLitPerMile.Location = new System.Drawing.Point(312, 80);
            this.lblLitPerMile.Name = "lblLitPerMile";
            this.lblLitPerMile.Size = new System.Drawing.Size(40, 17);
            this.lblLitPerMile.TabIndex = 10;
            this.lblLitPerMile.Text = "l/mile";
            // 
            // lblCostperKmText
            // 
            this.lblCostperKmText.AutoSize = true;
            this.lblCostperKmText.Location = new System.Drawing.Point(10, 136);
            this.lblCostperKmText.Name = "lblCostperKmText";
            this.lblCostperKmText.Size = new System.Drawing.Size(122, 17);
            this.lblCostperKmText.TabIndex = 9;
            this.lblCostperKmText.Text = "Cost per kilometer";
            // 
            // lblLiterPerSwMilText
            // 
            this.lblLiterPerSwMilText.AutoSize = true;
            this.lblLiterPerSwMilText.Location = new System.Drawing.Point(10, 108);
            this.lblLiterPerSwMilText.Name = "lblLiterPerSwMilText";
            this.lblLiterPerSwMilText.Size = new System.Drawing.Size(187, 17);
            this.lblLiterPerSwMilText.TabIndex = 8;
            this.lblLiterPerSwMilText.Text = "Fuel consumption (l/Swe mil)";
            // 
            // lblLiterPerMileText
            // 
            this.lblLiterPerMileText.AutoSize = true;
            this.lblLiterPerMileText.Location = new System.Drawing.Point(10, 80);
            this.lblLiterPerMileText.Name = "lblLiterPerMileText";
            this.lblLiterPerMileText.Size = new System.Drawing.Size(165, 17);
            this.lblLiterPerMileText.TabIndex = 7;
            this.lblLiterPerMileText.Text = "Fuel consumption (l/mile)";
            // 
            // lblLiterPerKmText
            // 
            this.lblLiterPerKmText.AutoSize = true;
            this.lblLiterPerKmText.Location = new System.Drawing.Point(10, 55);
            this.lblLiterPerKmText.Name = "lblLiterPerKmText";
            this.lblLiterPerKmText.Size = new System.Drawing.Size(158, 17);
            this.lblLiterPerKmText.TabIndex = 6;
            this.lblLiterPerKmText.Text = "Fuel consumption (l/km)";
            // 
            // lblLitPerKm
            // 
            this.lblLitPerKm.AutoSize = true;
            this.lblLitPerKm.Location = new System.Drawing.Point(312, 55);
            this.lblLitPerKm.Name = "lblLitPerKm";
            this.lblLitPerKm.Size = new System.Drawing.Size(33, 17);
            this.lblLitPerKm.TabIndex = 5;
            this.lblLitPerKm.Text = "l/km";
            // 
            // lblkmPerLit
            // 
            this.lblkmPerLit.AutoSize = true;
            this.lblkmPerLit.Location = new System.Drawing.Point(312, 29);
            this.lblkmPerLit.Name = "lblkmPerLit";
            this.lblkmPerLit.Size = new System.Drawing.Size(33, 17);
            this.lblkmPerLit.TabIndex = 4;
            this.lblkmPerLit.Text = "km/l";
            // 
            // lblKmPerLiterText
            // 
            this.lblKmPerLiterText.AutoSize = true;
            this.lblKmPerLiterText.Location = new System.Drawing.Point(10, 29);
            this.lblKmPerLiterText.Name = "lblKmPerLiterText";
            this.lblKmPerLiterText.Size = new System.Drawing.Size(158, 17);
            this.lblKmPerLiterText.TabIndex = 3;
            this.lblKmPerLiterText.Text = "Fuel consumption (km/l)";
            // 
            // gbxBMIInput
            // 
            this.gbxBMIInput.Controls.Add(this.txtWeight);
            this.gbxBMIInput.Controls.Add(this.txtHeight);
            this.gbxBMIInput.Controls.Add(this.rbtnUsUnits);
            this.gbxBMIInput.Controls.Add(this.rbtnMetricUnits);
            this.gbxBMIInput.Controls.Add(this.btnCalcBMI);
            this.gbxBMIInput.Controls.Add(this.lblWeight);
            this.gbxBMIInput.Controls.Add(this.lblHeight);
            this.gbxBMIInput.Controls.Add(this.lblNameText);
            this.gbxBMIInput.Controls.Add(this.txtName);
            this.gbxBMIInput.Location = new System.Drawing.Point(536, 17);
            this.gbxBMIInput.Name = "gbxBMIInput";
            this.gbxBMIInput.Size = new System.Drawing.Size(448, 186);
            this.gbxBMIInput.TabIndex = 2;
            this.gbxBMIInput.TabStop = false;
            this.gbxBMIInput.Text = "BMI";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(146, 87);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(62, 22);
            this.txtWeight.TabIndex = 8;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(146, 52);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(62, 22);
            this.txtHeight.TabIndex = 7;
            // 
            // rbtnUsUnits
            // 
            this.rbtnUsUnits.AutoSize = true;
            this.rbtnUsUnits.Location = new System.Drawing.Point(264, 96);
            this.rbtnUsUnits.Name = "rbtnUsUnits";
            this.rbtnUsUnits.Size = new System.Drawing.Size(141, 21);
            this.rbtnUsUnits.TabIndex = 6;
            this.rbtnUsUnits.TabStop = true;
            this.rbtnUsUnits.Text = "US units (inch, lb)";
            this.rbtnUsUnits.UseVisualStyleBackColor = true;
            this.rbtnUsUnits.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // rbtnMetricUnits
            // 
            this.rbtnMetricUnits.AutoSize = true;
            this.rbtnMetricUnits.Location = new System.Drawing.Point(264, 69);
            this.rbtnMetricUnits.Name = "rbtnMetricUnits";
            this.rbtnMetricUnits.Size = new System.Drawing.Size(156, 21);
            this.rbtnMetricUnits.TabIndex = 5;
            this.rbtnMetricUnits.TabStop = true;
            this.rbtnMetricUnits.Text = "Metric units (cm, kg)";
            this.rbtnMetricUnits.UseVisualStyleBackColor = true;
            this.rbtnMetricUnits.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // btnCalcBMI
            // 
            this.btnCalcBMI.Location = new System.Drawing.Point(188, 144);
            this.btnCalcBMI.Name = "btnCalcBMI";
            this.btnCalcBMI.Size = new System.Drawing.Size(100, 30);
            this.btnCalcBMI.TabIndex = 4;
            this.btnCalcBMI.Text = "Calculate";
            this.btnCalcBMI.UseVisualStyleBackColor = true;
            this.btnCalcBMI.Click += new System.EventHandler(this.BtnCalcBmi_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(18, 87);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(81, 17);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight (kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(18, 55);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(81, 17);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height (cm)";
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Location = new System.Drawing.Point(18, 24);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(77, 17);
            this.lblNameText.TabIndex = 1;
            this.lblNameText.Text = "Your name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 22);
            this.txtName.TabIndex = 0;
            // 
            // gbxResultBmi
            // 
            this.gbxResultBmi.Controls.Add(this.lblNormalBmi);
            this.gbxResultBmi.Controls.Add(this.lblWeightCategory);
            this.gbxResultBmi.Controls.Add(this.lblYourBmi);
            this.gbxResultBmi.Controls.Add(this.lblWeightCategoryText);
            this.gbxResultBmi.Controls.Add(this.lblYourBmiText);
            this.gbxResultBmi.Location = new System.Drawing.Point(536, 209);
            this.gbxResultBmi.Name = "gbxResultBmi";
            this.gbxResultBmi.Size = new System.Drawing.Size(448, 168);
            this.gbxResultBmi.TabIndex = 3;
            this.gbxResultBmi.TabStop = false;
            this.gbxResultBmi.Text = "Results for NoName";
            this.gbxResultBmi.Enter += new System.EventHandler(this.gpxName_Enter);
            // 
            // lblNormalBmi
            // 
            this.lblNormalBmi.AutoSize = true;
            this.lblNormalBmi.Location = new System.Drawing.Point(192, 91);
            this.lblNormalBmi.Name = "lblNormalBmi";
            this.lblNormalBmi.Size = new System.Drawing.Size(243, 17);
            this.lblNormalBmi.TabIndex = 7;
            this.lblNormalBmi.Text = "Normal BMI is between18.5 and 24.9.";
            // 
            // lblWeightCategory
            // 
            this.lblWeightCategory.AutoSize = true;
            this.lblWeightCategory.Location = new System.Drawing.Point(261, 55);
            this.lblWeightCategory.Name = "lblWeightCategory";
            this.lblWeightCategory.Size = new System.Drawing.Size(111, 17);
            this.lblWeightCategory.TabIndex = 6;
            this.lblWeightCategory.Text = "Weight category";
            // 
            // lblYourBmi
            // 
            this.lblYourBmi.AutoSize = true;
            this.lblYourBmi.Location = new System.Drawing.Point(257, 29);
            this.lblYourBmi.Name = "lblYourBmi";
            this.lblYourBmi.Size = new System.Drawing.Size(65, 17);
            this.lblYourBmi.TabIndex = 5;
            this.lblYourBmi.Text = "Your BMI";
            // 
            // lblWeightCategoryText
            // 
            this.lblWeightCategoryText.AutoSize = true;
            this.lblWeightCategoryText.Location = new System.Drawing.Point(18, 55);
            this.lblWeightCategoryText.Name = "lblWeightCategoryText";
            this.lblWeightCategoryText.Size = new System.Drawing.Size(113, 17);
            this.lblWeightCategoryText.TabIndex = 4;
            this.lblWeightCategoryText.Text = "Weight Category";
            // 
            // lblYourBmiText
            // 
            this.lblYourBmiText.AutoSize = true;
            this.lblYourBmiText.Location = new System.Drawing.Point(18, 29);
            this.lblYourBmiText.Name = "lblYourBmiText";
            this.lblYourBmiText.Size = new System.Drawing.Size(65, 17);
            this.lblYourBmiText.TabIndex = 3;
            this.lblYourBmiText.Text = "Your BMI";
            // 
            // gbxBmr
            // 
            this.gbxBmr.Controls.Add(this.lblBmrResult);
            this.gbxBmr.Controls.Add(this.lblText);
            this.gbxBmr.Controls.Add(this.btnCalcBmr);
            this.gbxBmr.Controls.Add(this.gbxActivityLevel);
            this.gbxBmr.Controls.Add(this.txtAge);
            this.gbxBmr.Controls.Add(this.lblAgeText);
            this.gbxBmr.Controls.Add(this.rbtnMale);
            this.gbxBmr.Controls.Add(this.rbtnFemale);
            this.gbxBmr.Location = new System.Drawing.Point(46, 393);
            this.gbxBmr.Name = "gbxBmr";
            this.gbxBmr.Size = new System.Drawing.Size(938, 296);
            this.gbxBmr.TabIndex = 4;
            this.gbxBmr.TabStop = false;
            this.gbxBmr.Text = "BMR";
            // 
            // lblBmrResult
            // 
            this.lblBmrResult.BackColor = System.Drawing.SystemColors.Window;
            this.lblBmrResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBmrResult.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmrResult.Location = new System.Drawing.Point(471, 24);
            this.lblBmrResult.Name = "lblBmrResult";
            this.lblBmrResult.Size = new System.Drawing.Size(454, 256);
            this.lblBmrResult.TabIndex = 11;
            this.lblBmrResult.Text = "Result";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(76, 47);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(286, 17);
            this.lblText.TabIndex = 10;
            this.lblText.Text = "Please give name, height and weight above.";
            // 
            // btnCalcBmr
            // 
            this.btnCalcBmr.Location = new System.Drawing.Point(184, 250);
            this.btnCalcBmr.Name = "btnCalcBmr";
            this.btnCalcBmr.Size = new System.Drawing.Size(100, 30);
            this.btnCalcBmr.TabIndex = 9;
            this.btnCalcBmr.Text = "Calculate";
            this.btnCalcBmr.UseVisualStyleBackColor = true;
            this.btnCalcBmr.Click += new System.EventHandler(this.BtnCalcBmr_Click);
            // 
            // gbxActivityLevel
            // 
            this.gbxActivityLevel.Controls.Add(this.rbtnGroup3);
            this.gbxActivityLevel.Controls.Add(this.rbtnGroup4);
            this.gbxActivityLevel.Controls.Add(this.rbtnGroup2);
            this.gbxActivityLevel.Controls.Add(this.rbtnGroup0);
            this.gbxActivityLevel.Controls.Add(this.rbtnGroup1);
            this.gbxActivityLevel.Location = new System.Drawing.Point(28, 83);
            this.gbxActivityLevel.Name = "gbxActivityLevel";
            this.gbxActivityLevel.Size = new System.Drawing.Size(394, 159);
            this.gbxActivityLevel.TabIndex = 4;
            this.gbxActivityLevel.TabStop = false;
            this.gbxActivityLevel.Text = "Activity level per week";
            // 
            // rbtnGroup3
            // 
            this.rbtnGroup3.AutoSize = true;
            this.rbtnGroup3.Location = new System.Drawing.Point(35, 98);
            this.rbtnGroup3.Name = "rbtnGroup3";
            this.rbtnGroup3.Size = new System.Drawing.Size(297, 21);
            this.rbtnGroup3.TabIndex = 6;
            this.rbtnGroup3.TabStop = true;
            this.rbtnGroup3.Text = "Very active (excercise 6 to 7 times a week)";
            this.rbtnGroup3.UseVisualStyleBackColor = true;
            this.rbtnGroup3.CheckedChanged += new System.EventHandler(this.ActivityLevel_CheckedChanged);
            // 
            // rbtnGroup4
            // 
            this.rbtnGroup4.AutoSize = true;
            this.rbtnGroup4.Location = new System.Drawing.Point(35, 125);
            this.rbtnGroup4.Name = "rbtnGroup4";
            this.rbtnGroup4.Size = new System.Drawing.Size(307, 21);
            this.rbtnGroup4.TabIndex = 7;
            this.rbtnGroup4.TabStop = true;
            this.rbtnGroup4.Text = "Extra active ( hard excercise or physical job)";
            this.rbtnGroup4.UseVisualStyleBackColor = true;
            this.rbtnGroup4.CheckedChanged += new System.EventHandler(this.ActivityLevel_CheckedChanged);
            // 
            // rbtnGroup2
            // 
            this.rbtnGroup2.AutoSize = true;
            this.rbtnGroup2.Location = new System.Drawing.Point(35, 75);
            this.rbtnGroup2.Name = "rbtnGroup2";
            this.rbtnGroup2.Size = new System.Drawing.Size(338, 21);
            this.rbtnGroup2.TabIndex = 5;
            this.rbtnGroup2.TabStop = true;
            this.rbtnGroup2.Text = "Moderately active (excercise 4 to 5 times a week)";
            this.rbtnGroup2.UseVisualStyleBackColor = true;
            this.rbtnGroup2.CheckedChanged += new System.EventHandler(this.ActivityLevel_CheckedChanged);
            // 
            // rbtnGroup0
            // 
            this.rbtnGroup0.AutoSize = true;
            this.rbtnGroup0.Location = new System.Drawing.Point(35, 21);
            this.rbtnGroup0.Name = "rbtnGroup0";
            this.rbtnGroup0.Size = new System.Drawing.Size(233, 21);
            this.rbtnGroup0.TabIndex = 0;
            this.rbtnGroup0.TabStop = true;
            this.rbtnGroup0.Text = "Sedentary (little or no excercise)";
            this.rbtnGroup0.UseVisualStyleBackColor = true;
            this.rbtnGroup0.CheckedChanged += new System.EventHandler(this.ActivityLevel_CheckedChanged);
            // 
            // rbtnGroup1
            // 
            this.rbtnGroup1.AutoSize = true;
            this.rbtnGroup1.Location = new System.Drawing.Point(35, 48);
            this.rbtnGroup1.Name = "rbtnGroup1";
            this.rbtnGroup1.Size = new System.Drawing.Size(309, 21);
            this.rbtnGroup1.TabIndex = 1;
            this.rbtnGroup1.TabStop = true;
            this.rbtnGroup1.Text = "Lightly active (excercise 1 to 3 times a week)";
            this.rbtnGroup1.UseVisualStyleBackColor = true;
            this.rbtnGroup1.CheckedChanged += new System.EventHandler(this.ActivityLevel_CheckedChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(288, 22);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(55, 22);
            this.txtAge.TabIndex = 3;
            // 
            // lblAgeText
            // 
            this.lblAgeText.AutoSize = true;
            this.lblAgeText.Location = new System.Drawing.Point(249, 23);
            this.lblAgeText.Name = "lblAgeText";
            this.lblAgeText.Size = new System.Drawing.Size(33, 17);
            this.lblAgeText.TabIndex = 2;
            this.lblAgeText.Text = "Age";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(160, 22);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(59, 21);
            this.rbtnMale.TabIndex = 1;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(74, 22);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(75, 21);
            this.rbtnFemale.TabIndex = 0;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            this.rbtnFemale.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 701);
            this.Controls.Add(this.gbxBmr);
            this.Controls.Add(this.gbxResultBmi);
            this.Controls.Add(this.gbxBMIInput);
            this.Controls.Add(this.gbxFuelResult);
            this.Controls.Add(this.gbxFuelInput);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universal calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxFuelInput.ResumeLayout(false);
            this.gbxFuelInput.PerformLayout();
            this.gbxFuelResult.ResumeLayout(false);
            this.gbxFuelResult.PerformLayout();
            this.gbxBMIInput.ResumeLayout(false);
            this.gbxBMIInput.PerformLayout();
            this.gbxResultBmi.ResumeLayout(false);
            this.gbxResultBmi.PerformLayout();
            this.gbxBmr.ResumeLayout(false);
            this.gbxBmr.PerformLayout();
            this.gbxActivityLevel.ResumeLayout(false);
            this.gbxActivityLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFuelInput;
        private System.Windows.Forms.Label lblCurrentReading;
        private System.Windows.Forms.TextBox txtCurrReading;
        private System.Windows.Forms.GroupBox gbxFuelResult;
        private System.Windows.Forms.GroupBox gbxBMIInput;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbxResultBmi;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblFuelAmount;
        private System.Windows.Forms.TextBox txtFuelAmount;
        private System.Windows.Forms.Label lblPrevReading;
        private System.Windows.Forms.TextBox txtPrevReading;
        private System.Windows.Forms.Button btnCalcFuel;
        private System.Windows.Forms.Label lblKmPerLiterText;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblkmPerLit;
        private System.Windows.Forms.Label lblcostPerKm;
        private System.Windows.Forms.Label lblLitPerSweMil;
        private System.Windows.Forms.Label lblLitPerMile;
        private System.Windows.Forms.Label lblCostperKmText;
        private System.Windows.Forms.Label lblLiterPerSwMilText;
        private System.Windows.Forms.Label lblLiterPerMileText;
        private System.Windows.Forms.Label lblLiterPerKmText;
        private System.Windows.Forms.Label lblLitPerKm;
        private System.Windows.Forms.RadioButton rbtnUsUnits;
        private System.Windows.Forms.RadioButton rbtnMetricUnits;
        private System.Windows.Forms.Button btnCalcBMI;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblYourBmi;
        private System.Windows.Forms.Label lblWeightCategoryText;
        private System.Windows.Forms.Label lblYourBmiText;
        private System.Windows.Forms.Label lblWeightCategory;
        private System.Windows.Forms.Label lblNormalBmi;
        private System.Windows.Forms.GroupBox gbxBmr;
        private System.Windows.Forms.Button btnCalcBmr;
        private System.Windows.Forms.GroupBox gbxActivityLevel;
        private System.Windows.Forms.RadioButton rbtnGroup3;
        private System.Windows.Forms.RadioButton rbtnGroup4;
        private System.Windows.Forms.RadioButton rbtnGroup2;
        private System.Windows.Forms.RadioButton rbtnGroup0;
        private System.Windows.Forms.RadioButton rbtnGroup1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAgeText;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblBmrResult;
    }
}

