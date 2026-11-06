namespace EDPLab2SOpenFile
{
    partial class FrmOpenFile
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
            lvShowText = new ListView();
            btnOpen = new Button();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.Location = new Point(186, 44);
            lvShowText.MultiSelect = false;
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(413, 168);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            // 
            // btnOpen
            // 
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Location = new Point(240, 239);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(135, 48);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(414, 239);
            button1.Name = "button1";
            button1.Size = new Size(135, 48);
            button1.TabIndex = 2;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmOpenFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnOpen);
            Controls.Add(lvShowText);
            Name = "FrmOpenFile";
            Text = "FrmOpenFile";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvShowText;
        private Button btnOpen;
        private OpenFileDialog openFileDialog1;
        private Button button1;
    }
}
