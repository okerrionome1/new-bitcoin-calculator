namespace New_Bitcoin_Calculator
{
    partial class btcCalculator
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
            this.currentBtc = new System.Windows.Forms.Label();
            this.predictedBtc = new System.Windows.Forms.Label();
            this.AmoiuntInvested = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtPredicted = new System.Windows.Forms.TextBox();
            this.txtInvested = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentBtc
            // 
            this.currentBtc.AutoSize = true;
            this.currentBtc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBtc.Location = new System.Drawing.Point(47, 53);
            this.currentBtc.Name = "currentBtc";
            this.currentBtc.Size = new System.Drawing.Size(284, 34);
            this.currentBtc.TabIndex = 0;
            this.currentBtc.Text = "Current BTC Price";
            // 
            // predictedBtc
            // 
            this.predictedBtc.AutoSize = true;
            this.predictedBtc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictedBtc.Location = new System.Drawing.Point(47, 135);
            this.predictedBtc.Name = "predictedBtc";
            this.predictedBtc.Size = new System.Drawing.Size(321, 34);
            this.predictedBtc.TabIndex = 1;
            this.predictedBtc.Text = "Predicted BTC Value";
            // 
            // AmoiuntInvested
            // 
            this.AmoiuntInvested.AutoSize = true;
            this.AmoiuntInvested.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmoiuntInvested.Location = new System.Drawing.Point(47, 224);
            this.AmoiuntInvested.Name = "AmoiuntInvested";
            this.AmoiuntInvested.Size = new System.Drawing.Size(369, 34);
            this.AmoiuntInvested.TabIndex = 2;
            this.AmoiuntInvested.Text = "Amount Invested in USD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 34);
            this.label4.TabIndex = 3;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrent.Location = new System.Drawing.Point(438, 52);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(333, 39);
            this.txtCurrent.TabIndex = 4;
            // 
            // txtPredicted
            // 
            this.txtPredicted.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPredicted.Location = new System.Drawing.Point(438, 134);
            this.txtPredicted.Name = "txtPredicted";
            this.txtPredicted.Size = new System.Drawing.Size(333, 39);
            this.txtPredicted.TabIndex = 5;
            // 
            // txtInvested
            // 
            this.txtInvested.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvested.Location = new System.Drawing.Point(438, 223);
            this.txtInvested.Name = "txtInvested";
            this.txtInvested.Size = new System.Drawing.Size(333, 39);
            this.txtInvested.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(53, 360);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(199, 60);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(562, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(199, 60);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btcCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInvested);
            this.Controls.Add(this.txtPredicted);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AmoiuntInvested);
            this.Controls.Add(this.predictedBtc);
            this.Controls.Add(this.currentBtc);
            this.Name = "btcCalculator";
            this.Text = "BTC CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentBtc;
        private System.Windows.Forms.Label predictedBtc;
        private System.Windows.Forms.Label AmoiuntInvested;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtPredicted;
        private System.Windows.Forms.TextBox txtInvested;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}

