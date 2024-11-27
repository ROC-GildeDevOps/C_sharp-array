namespace C_sharp_array
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
            this.lbl_output = new System.Windows.Forms.Label();
            this.btn_while = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_for = new System.Windows.Forms.Button();
            this.btn_each = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_output
            // 
            this.lbl_output.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_output.Location = new System.Drawing.Point(350, 300);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(100, 23);
            this.lbl_output.TabIndex = 0;
            // 
            // btn_while
            // 
            this.btn_while.Location = new System.Drawing.Point(100, 50);
            this.btn_while.Name = "btn_while";
            this.btn_while.Size = new System.Drawing.Size(100, 50);
            this.btn_while.TabIndex = 1;
            this.btn_while.Text = "While";
            this.btn_while.UseVisualStyleBackColor = true;
            this.btn_while.Click += new System.EventHandler(this.btn_while_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(200, 50);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(100, 50);
            this.btn_clean.TabIndex = 2;
            this.btn_clean.Text = "Clean";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(300, 50);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 50);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_for
            // 
            this.btn_for.Location = new System.Drawing.Point(400, 50);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(100, 50);
            this.btn_for.TabIndex = 4;
            this.btn_for.Text = "For";
            this.btn_for.UseVisualStyleBackColor = true;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // btn_each
            // 
            this.btn_each.Location = new System.Drawing.Point(500, 50);
            this.btn_each.Name = "btn_each";
            this.btn_each.Size = new System.Drawing.Size(100, 50);
            this.btn_each.TabIndex = 5;
            this.btn_each.Text = "ForEach";
            this.btn_each.UseVisualStyleBackColor = true;
            this.btn_each.Click += new System.EventHandler(this.btn_each_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_each);
            this.Controls.Add(this.btn_for);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.btn_while);
            this.Controls.Add(this.lbl_output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_while;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.Button btn_each;
    }
}

