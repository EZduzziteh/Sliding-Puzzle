namespace SlidingPuzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_Start = new System.Windows.Forms.Button();
            this.cmb_Difficulty = new System.Windows.Forms.ComboBox();
            this.lbl_victory = new System.Windows.Forms.Label();
            this.text_instructions = new System.Windows.Forms.RichTextBox();
            this.lbl_instructions = new System.Windows.Forms.Label();
            this.text_difficulty = new System.Windows.Forms.RichTextBox();
            this.lbl_difficulty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(208, 62);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(200, 100);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // cmb_Difficulty
            // 
            this.cmb_Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Difficulty.FormattingEnabled = true;
            this.cmb_Difficulty.Location = new System.Drawing.Point(241, 179);
            this.cmb_Difficulty.Name = "cmb_Difficulty";
            this.cmb_Difficulty.Size = new System.Drawing.Size(136, 39);
            this.cmb_Difficulty.TabIndex = 1;
            this.cmb_Difficulty.Text = "Difficulty";
            // 
            // lbl_victory
            // 
            this.lbl_victory.AutoSize = true;
            this.lbl_victory.Location = new System.Drawing.Point(393, 303);
            this.lbl_victory.Name = "lbl_victory";
            this.lbl_victory.Size = new System.Drawing.Size(0, 13);
            this.lbl_victory.TabIndex = 2;
            // 
            // text_instructions
            // 
            this.text_instructions.Location = new System.Drawing.Point(37, 281);
            this.text_instructions.Name = "text_instructions";
            this.text_instructions.ReadOnly = true;
            this.text_instructions.Size = new System.Drawing.Size(381, 73);
            this.text_instructions.TabIndex = 4;
            this.text_instructions.Text = resources.GetString("text_instructions.Text");
            // 
            // lbl_instructions
            // 
            this.lbl_instructions.AutoSize = true;
            this.lbl_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instructions.Location = new System.Drawing.Point(166, 254);
            this.lbl_instructions.Name = "lbl_instructions";
            this.lbl_instructions.Size = new System.Drawing.Size(104, 24);
            this.lbl_instructions.TabIndex = 5;
            this.lbl_instructions.Text = "Instructions";
            // 
            // text_difficulty
            // 
            this.text_difficulty.Location = new System.Drawing.Point(447, 281);
            this.text_difficulty.Name = "text_difficulty";
            this.text_difficulty.ReadOnly = true;
            this.text_difficulty.Size = new System.Drawing.Size(110, 44);
            this.text_difficulty.TabIndex = 6;
            this.text_difficulty.Text = "Easy -  4x4 grid Medium - 5x5 grid Hard - 6x6 grid";
            // 
            // lbl_difficulty
            // 
            this.lbl_difficulty.AutoSize = true;
            this.lbl_difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_difficulty.Location = new System.Drawing.Point(453, 254);
            this.lbl_difficulty.Name = "lbl_difficulty";
            this.lbl_difficulty.Size = new System.Drawing.Size(92, 24);
            this.lbl_difficulty.TabIndex = 7;
            this.lbl_difficulty.Text = "Difficulties";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.lbl_difficulty);
            this.Controls.Add(this.text_difficulty);
            this.Controls.Add(this.lbl_instructions);
            this.Controls.Add(this.text_instructions);
            this.Controls.Add(this.lbl_victory);
            this.Controls.Add(this.cmb_Difficulty);
            this.Controls.Add(this.btn_Start);
            this.Name = "MainForm";
            this.Text = "Sliding Puzzle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ComboBox cmb_Difficulty;
        private System.Windows.Forms.Label lbl_victory;
        private System.Windows.Forms.RichTextBox text_instructions;
        private System.Windows.Forms.Label lbl_instructions;
        private System.Windows.Forms.RichTextBox text_difficulty;
        private System.Windows.Forms.Label lbl_difficulty;
    }
}

