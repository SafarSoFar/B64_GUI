namespace B64_GUI_
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            encButton = new Button();
            decButton = new Button();
            clearButton = new Button();
            dragList = new ListBox();
            SuspendLayout();
            // 
            // encButton
            // 
            encButton.Location = new Point(483, 32);
            encButton.Name = "encButton";
            encButton.Size = new Size(139, 102);
            encButton.TabIndex = 1;
            encButton.Text = "Encrypt";
            encButton.UseVisualStyleBackColor = true;
            encButton.Click += encButton_Click;
            // 
            // decButton
            // 
            decButton.Location = new Point(483, 158);
            decButton.Name = "decButton";
            decButton.Size = new Size(139, 102);
            decButton.TabIndex = 2;
            decButton.Text = "Decrypt";
            decButton.UseVisualStyleBackColor = true;
            decButton.Click += decButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 287);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(610, 43);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear the box";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // dragList
            // 
            dragList.AllowDrop = true;
            dragList.FormattingEnabled = true;
            dragList.Location = new Point(12, 32);
            dragList.Name = "dragList";
            dragList.Size = new Size(426, 244);
            dragList.TabIndex = 4;
            dragList.DragDrop += dragList_DragDrop;
            dragList.DragEnter += dragList_DragEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 342);
            Controls.Add(dragList);
            Controls.Add(clearButton);
            Controls.Add(decButton);
            Controls.Add(encButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Base64 Application";
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button encButton;
        private Button decButton;
        private Button clearButton;
        private ListBox dragList;
    }
}
