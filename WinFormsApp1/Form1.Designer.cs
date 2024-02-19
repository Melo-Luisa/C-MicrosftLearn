namespace WinFormsApp1
{
    partial class Form1
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
            lblHelloWorld = new Label();
            btnClickThis = new Button();
            SuspendLayout();
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Location = new Point(345, 259);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(45, 20);
            lblHelloWorld.TabIndex = 1;
            lblHelloWorld.Text = "Texto";
            // 
            // btnClickThis
            // 
            btnClickThis.Location = new Point(314, 215);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(94, 29);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "Click This";
            btnClickThis.UseVisualStyleBackColor = true;
            btnClickThis.Click += btnClickThis_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 594);
            Controls.Add(lblHelloWorld);
            Controls.Add(btnClickThis);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lblHelloWorld;
        private Button btnClickThis;
    }
}
