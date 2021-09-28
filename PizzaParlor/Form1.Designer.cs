
namespace PizzaParlor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.slicesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(282, 106);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(230, 29);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(279, 311);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(101, 24);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Your Total:";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(268, 211);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 30);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // slicesLabel
            // 
            this.slicesLabel.AutoSize = true;
            this.slicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slicesLabel.Location = new System.Drawing.Point(120, 109);
            this.slicesLabel.Name = "slicesLabel";
            this.slicesLabel.Size = new System.Drawing.Size(95, 24);
            this.slicesLabel.TabIndex = 3;
            this.slicesLabel.Text = "# of Slices";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 377);
            this.Controls.Add(this.slicesLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza Parlor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label slicesLabel;
    }
}

