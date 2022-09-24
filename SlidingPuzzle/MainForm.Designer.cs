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
            this.text_instructions = new System.Windows.Forms.RichTextBox();
            this.lbl_instructions = new System.Windows.Forms.Label();
            this.text_difficulty = new System.Windows.Forms.RichTextBox();
            this.lbl_difficulty = new System.Windows.Forms.Label();
            this.panel_MainMenu = new System.Windows.Forms.Panel();
            this.panel_Victory = new System.Windows.Forms.Panel();
            this.button_Victory_Quit = new System.Windows.Forms.Button();
            this.button_Victory_Restart = new System.Windows.Forms.Button();
            this.textBox_Victory = new System.Windows.Forms.RichTextBox();
            this.panel_MainMenu.SuspendLayout();
            this.panel_Victory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(125, 25);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(200, 100);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // cmb_Difficulty
            // 
            this.cmb_Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Difficulty.FormattingEnabled = true;
            this.cmb_Difficulty.Location = new System.Drawing.Point(268, 227);
            this.cmb_Difficulty.Name = "cmb_Difficulty";
            this.cmb_Difficulty.Size = new System.Drawing.Size(136, 39);
            this.cmb_Difficulty.TabIndex = 1;
            this.cmb_Difficulty.Text = "Difficulty";
            // 
            // text_instructions
            // 
            this.text_instructions.Location = new System.Drawing.Point(28, 177);
            this.text_instructions.Name = "text_instructions";
            this.text_instructions.ReadOnly = true;
            this.text_instructions.Size = new System.Drawing.Size(213, 123);
            this.text_instructions.TabIndex = 4;
            this.text_instructions.Text = resources.GetString("text_instructions.Text");
            // 
            // lbl_instructions
            // 
            this.lbl_instructions.AutoSize = true;
            this.lbl_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instructions.Location = new System.Drawing.Point(73, 150);
            this.lbl_instructions.Name = "lbl_instructions";
            this.lbl_instructions.Size = new System.Drawing.Size(104, 24);
            this.lbl_instructions.TabIndex = 5;
            this.lbl_instructions.Text = "Instructions";
            // 
            // text_difficulty
            // 
            this.text_difficulty.Location = new System.Drawing.Point(279, 177);
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
            this.lbl_difficulty.Location = new System.Drawing.Point(285, 150);
            this.lbl_difficulty.Name = "lbl_difficulty";
            this.lbl_difficulty.Size = new System.Drawing.Size(92, 24);
            this.lbl_difficulty.TabIndex = 7;
            this.lbl_difficulty.Text = "Difficulties";
            // 
            // panel_MainMenu
            // 
            this.panel_MainMenu.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel_MainMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_MainMenu.Controls.Add(this.panel_Victory);
            this.panel_MainMenu.Controls.Add(this.btn_Start);
            this.panel_MainMenu.Controls.Add(this.lbl_instructions);
            this.panel_MainMenu.Controls.Add(this.lbl_difficulty);
            this.panel_MainMenu.Controls.Add(this.text_instructions);
            this.panel_MainMenu.Controls.Add(this.text_difficulty);
            this.panel_MainMenu.Controls.Add(this.cmb_Difficulty);
            this.panel_MainMenu.Location = new System.Drawing.Point(26, 35);
            this.panel_MainMenu.Name = "panel_MainMenu";
            this.panel_MainMenu.Size = new System.Drawing.Size(465, 329);
            this.panel_MainMenu.TabIndex = 8;
            // 
            // panel_Victory
            // 
            this.panel_Victory.BackColor = System.Drawing.Color.ForestGreen;
            this.panel_Victory.Controls.Add(this.button_Victory_Quit);
            this.panel_Victory.Controls.Add(this.button_Victory_Restart);
            this.panel_Victory.Controls.Add(this.textBox_Victory);
            this.panel_Victory.Location = new System.Drawing.Point(125, 84);
            this.panel_Victory.Name = "panel_Victory";
            this.panel_Victory.Size = new System.Drawing.Size(200, 191);
            this.panel_Victory.TabIndex = 9;
            // 
            // button_Victory_Quit
            // 
            this.button_Victory_Quit.BackColor = System.Drawing.Color.Red;
            this.button_Victory_Quit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Victory_Quit.Location = new System.Drawing.Point(109, 135);
            this.button_Victory_Quit.Name = "button_Victory_Quit";
            this.button_Victory_Quit.Size = new System.Drawing.Size(75, 23);
            this.button_Victory_Quit.TabIndex = 2;
            this.button_Victory_Quit.Text = "Quit";
            this.button_Victory_Quit.UseVisualStyleBackColor = false;
            this.button_Victory_Quit.Click += new System.EventHandler(this.button_Victory_Quit_Click);
            // 
            // button_Victory_Restart
            // 
            this.button_Victory_Restart.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Victory_Restart.Location = new System.Drawing.Point(15, 135);
            this.button_Victory_Restart.Name = "button_Victory_Restart";
            this.button_Victory_Restart.Size = new System.Drawing.Size(75, 23);
            this.button_Victory_Restart.TabIndex = 1;
            this.button_Victory_Restart.Text = "Play Again";
            this.button_Victory_Restart.UseVisualStyleBackColor = false;
            this.button_Victory_Restart.Click += new System.EventHandler(this.button_Victory_Restart_Click);
            // 
            // textBox_Victory
            // 
            this.textBox_Victory.Location = new System.Drawing.Point(15, 15);
            this.textBox_Victory.Name = "textBox_Victory";
            this.textBox_Victory.Size = new System.Drawing.Size(169, 70);
            this.textBox_Victory.TabIndex = 0;
            this.textBox_Victory.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1036, 844);
            this.Controls.Add(this.panel_MainMenu);
            this.Name = "MainForm";
            this.Text = "Sliding Puzzle";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_MainMenu.ResumeLayout(false);
            this.panel_MainMenu.PerformLayout();
            this.panel_Victory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ComboBox cmb_Difficulty;
        private System.Windows.Forms.RichTextBox text_instructions;
        private System.Windows.Forms.Label lbl_instructions;
        private System.Windows.Forms.RichTextBox text_difficulty;
        private System.Windows.Forms.Label lbl_difficulty;
        private System.Windows.Forms.Panel panel_MainMenu;
        private System.Windows.Forms.Panel panel_Victory;
        private System.Windows.Forms.RichTextBox textBox_Victory;
        private System.Windows.Forms.Button button_Victory_Quit;
        private System.Windows.Forms.Button button_Victory_Restart;
    }
}

